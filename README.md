# Warhammer Paint Inventory

A personal web app to track your Warhammer 40K / Age of Sigmar paint collection. Built with Blazor WebAssembly, hosted on Cloudflare Pages, and synced across devices via Supabase.

This is a standalone fork with no login wall or third-party auth service baked in — it's yours to deploy, point at your own Supabase project, and optionally lock down however you like.

---

## Features

- View all 337 Citadel paints (Base, Layer, Contrast, Dry, Technical, Shade, Air, Spray) with rack location
- Mark paints as owned / not owned, with a quantity stepper for extras
- Explicit wish list — flag specific paints you want, or bulk-add everything you don't own
- Filter by category, search by name
- Visual rack grid view (Sprays are cans, not pots — excluded from rack packing)
- Configurable rack layout (rows/columns per rack, how many racks you own) — Settings page
- Settings page — toggle paint types on/off and reorder them; disabling a type frees its rack slots and repacks the rest
- CSV export (owned, wish list, full list) and CSV import for owned paints
- Stats dashboard with progress by category
- Multi-device sync — changes on phone appear on PC and desktop app
- Community paint-equivalents lookup (Vallejo, Army Painter, AK Interactive, P3 Formula)

---

## Quick Start

1. **Create a Supabase project** (free tier) — [supabase.com](https://supabase.com).
2. **Run the SQL files** at the repo root, in the SQL Editor, **in this order**:
   1. `master_paint_list_backup.sql` — creates and seeds the 337-paint master list.
   2. `schema_owned_wishlist_categories.sql` — creates owned/wishlist/category-settings tables.
   3. `migration_rack_settings.sql` — creates the rack-layout settings table.
   4. `create_paint_equivalents.sql` — creates the equivalents table + seed data (Vallejo, AK Interactive).
   5. *(optional)* `add_army_painter_equivalents.sql`, then `add_p3_and_more_equivalents.sql` — more brands.
3. **Grab your Supabase URL and anon key**: Project Settings → API.
4. **Create a Cloudflare Pages project** — connect this repo, or deploy via the included GitHub Actions workflow (see Deployment below).
5. **Set two environment variables** on the Cloudflare Pages project (Settings → Environment variables):
   - `SUPABASE_URL` — your project URL, e.g. `https://your-project-ref.supabase.co`
   - `SUPABASE_ANON_KEY` — the anon/public key from step 3
6. Push to `main` — the GitHub Actions workflow builds and deploys automatically.

That's it — no auth setup required. The site is open to anyone with the URL; data access is governed entirely by Supabase Row Level Security (the SQL files above grant the `anon` role read/write on your tables). See **Adding a Login Wall** below if you want to restrict access.

---

## Architecture

```
GitHub Repo
    │
    └── GitHub Actions (on push to main)
            │
            └── dotnet publish → Cloudflare Pages (static site)
                                        │
                                  Browser runs
                                  Blazor WASM
                                        │
                          Cloudflare Pages Function
                          (functions/rest/v1/[[path]].js —
                           proxies to Supabase with the anon key)
                                        │
                                   Supabase DB
                    (warhammer_paint_master, warhammer_owned_paints,
                    warhammer_wishlist_paints, warhammer_category_settings,
                    warhammer_rack_settings, warhammer_paint_equivalents)
                                        │
                          Also used by desktop apps
                          (Console + WPF GUI)
```

The browser never talks to Supabase directly — it calls `/rest/v1/*` on its own origin, and a Cloudflare Pages Function forwards that to Supabase with the anon key attached server-side. This keeps the key out of client-side JS bundles, though for a Blazor WASM app that's a modest benefit at best (RLS is what actually protects your data either way).

---

## Tech Stack

| Layer | Technology |
|---|---|
| Frontend | Blazor WebAssembly (.NET 8) |
| Hosting | Cloudflare Pages (free) |
| Database | Supabase PostgreSQL (free tier) |
| CI/CD | GitHub Actions |
| Desktop apps | .NET 8 Console + .NET 10 WPF |

---

## Project Structure

```
WarhamerPaintInventoryWeb/
├── Models/
│   ├── Paint.cs              # Paint model (paint_id, category colours, display name)
│   ├── PaintDatabase.cs      # Hardcoded fallback list + rack-packing logic
│   ├── CategorySetting.cs    # Per-category enabled/order state
│   └── RackSettings.cs       # Rack rows/columns/racks-owned
├── Services/
│   └── InventoryManager.cs   # Supabase REST calls: master list, owned, wishlist, settings, CSV
├── Pages/
│   ├── Home.razor            # Dashboard — stats + category breakdown
│   ├── AllPaints.razor       # Full list with search, filter, owned toggle, quantity, wishlist
│   ├── ByRack.razor          # Visual rack grid (click to toggle owned)
│   ├── WishList.razor        # Explicit wish list, grouped by category
│   ├── Guides.razor          # Faction/unit paint-scheme guides
│   ├── Equivalents.razor     # 3rd-party paint equivalents lookup
│   └── Settings.razor        # Category on/off + reorder, rack layout, CSV export/import
├── Layout/
│   ├── MainLayout.razor      # Sidebar + main content layout
│   └── NavMenu.razor         # Navigation links
├── wwwroot/
│   └── css/app.css           # Dark Warhammer theme
├── functions/
│   └── rest/v1/[[path]].js   # Cloudflare Pages Function — Supabase REST proxy
└── .github/workflows/
    └── deploy.yml            # GitHub Actions build + Cloudflare deploy
```

---

## Supabase Database

Six tables, all namespaced with a `warhammer_` prefix:

| Table | Purpose |
|---|---|
| `warhammer_paint_master` | Source of truth for the paint list — `paint_id`, `name`, `type`. The app loads from here at startup. |
| `warhammer_owned_paints` | Which paints you own — `paint_id` (FK to master), `quantity`. |
| `warhammer_wishlist_paints` | Which paints you want — `paint_id` (FK to master). |
| `warhammer_category_settings` | Per-category `enabled` + `sort_order`, drives the Settings page and rack packing. |
| `warhammer_rack_settings` | Single-row: rack rows/columns, and how many racks you own. |
| `warhammer_paint_equivalents` | Community-sourced 3rd-party brand equivalents, editable in-app. |

`paint_id` is the real key everywhere — owned/wishlist rows reference it via foreign key, not the paint name.

Rack location (`RackNumber`/`Row`/`Column`) is never stored — it's computed client-side from the rack layout and enabled/ordered categories each time (the "packing planner"), so changing rack size or reordering a category in Settings repacks everything live. Sprays are cans, not pots, and are excluded from packing entirely.

If `warhammer_paint_master` is ever unreachable at app startup, the app falls back to the hardcoded list in `PaintDatabase.cs` with negative sentinel IDs — the UI still shows paints, but owned/wishlist changes can't be saved in that degraded state (there's no real `paint_id` to save against).

All RLS policies in the SQL files grant to the `anon` role (see "Adding a Login Wall" below for why).

---

## Rack Layout

Configurable from the Settings page:
- **Rows per rack** / **Columns per rack** — default 12×6 (72 slots per rack), matching a common Citadel paint rack.
- **Racks I own** — optional. If set, the Dashboard shows capacity against that many racks and flags when you've gone over. If left unset, it just shows however many racks your current paint count needs.

Changing any of these repacks every paint's rack/row/column live.

---

## Deployment

### GitHub Actions (`deploy.yml`)

Triggers on every push to `main`:
1. Checks out the repo
2. Installs .NET 8
3. Runs `dotnet publish -c Release -o release`
4. Deploys `release/wwwroot` to Cloudflare Pages via Wrangler

### Cloudflare Pages Project

Create a Pages project (Workers & Pages → Create → Pages) named to match `--project-name` in `.github/workflows/deploy.yml`, or edit that flag to match whatever you name it. This project does **not** use Cloudflare's native Git-connected build (the .NET SDK isn't available in Cloudflare's build image) — deployment is entirely driven by the GitHub Actions workflow.

### Required GitHub Secrets

Add under your repo's **Settings → Secrets and variables → Actions**:

| Secret | Where to find it |
|---|---|
| `CLOUDFLARE_API_TOKEN` | Cloudflare → My Profile → API Tokens |
| `CLOUDFLARE_ACCOUNT_ID` | Cloudflare → Workers & Pages (right sidebar) |

### Required Cloudflare Pages Environment Variables

Add under your Pages project's **Settings → Environment variables** (Production, and Preview if you use it):

| Variable | Where to find it |
|---|---|
| `SUPABASE_URL` | Supabase → Project Settings → API → Project URL |
| `SUPABASE_ANON_KEY` | Supabase → Project Settings → API → anon/public key |

These are read by `functions/rest/v1/[[path]].js` at request time — no rebuild needed if you change them, just a new request.

---

## Adding a Login Wall

This fork ships **without** any login — the deployed URL is reachable by anyone who has it, and every request uses the Supabase `anon` role. That's fine for a private link only you know, but if you want an actual gate, the simplest zero-code option is **Cloudflare Access**:

1. Cloudflare Zero Trust → Access → Applications → Add application → Self-hosted
2. Application domain: your `*.pages.dev` domain (or custom domain)
3. Policy: Allow → Emails → your email address (or however you want to scope it)

Anyone visiting the URL will be asked to verify their email with a one-time code before they ever reach the app. This sits in front of everything, including the `/rest/v1/*` proxy, so it doesn't require any app code changes.

If you want per-user data instead of a single shared inventory, that's a bigger change — you'd need real Supabase Auth (sign-up/login) and RLS policies scoped to `auth.uid()`, plus updating the Pages Function to forward the user's session token instead of the anon key. Not included here.

---

## Desktop Apps

Both the console app (`WarhamerPaintInventory`) and GUI app (`WarhamerPaintInventoryGUI`) sync with the same Supabase database. They call Supabase directly (not through the Cloudflare Function), so they need their own `SUPABASE_URL`/anon key configuration — check each app's config before running.

**On startup:** loads local `inventory.json` first (works offline), then fetches latest owned status from Supabase and updates the local file.

**On toggle:** saves to local file immediately, then syncs to Supabase in the background.

`IsWishListed` (GUI only) is stored locally and is not synced to Supabase.

### Building Desktop Apps

```bash
# Console
cd WarhamerPaintInventory
dotnet publish -c Release -r win-x64 --self-contained false

# GUI
cd WarhamerPaintInventoryGUI
dotnet publish -c Release -r win-x64 --self-contained false
```

---

## Paint Layout

- Rack size is configurable (Settings page — see "Rack Layout" above); defaults to **12 rows × 6 columns = 72 slots** per rack.
- Fill order: top-to-bottom, left-to-right, Rack 1 first, in the category order set on the Settings page.
- Sprays never take a rack slot (cans, not pots).
- With all 8 categories enabled, 325 paints need a slot (337 total minus 12 Sprays). At the 12×6 default that's more than 4 racks (288 slots) — check whether that matches your physical shelving, set "Racks I own" in Settings to see if you're over capacity, or disable/reorder categories to fit within fewer racks.
