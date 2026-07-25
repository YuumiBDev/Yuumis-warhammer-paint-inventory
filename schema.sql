-- ============================================================
-- Warhammer Paint Inventory — full database schema (consolidated)
-- Run once in the Supabase SQL editor (Dashboard -> SQL Editor -> New query)
-- on a fresh Supabase project. Idempotent: safe to run more than once.
--
-- This single file combines what used to be 6 separate migration files:
-- master paint list, owned/wishlist/category-settings schema, rack
-- settings, and 3rd-party paint equivalents (Vallejo/AK/Army Painter/P3).
-- ============================================================

-- ============================================================
-- PART 1: MASTER PAINT LIST (337 Citadel paints)
-- ============================================================

-- ============================================================
-- Warhammer Paint Inventory — master paint list backup
-- Run once in the Supabase SQL editor (Dashboard → SQL Editor → New query).
-- Idempotent: safe to run more than once.
--
-- This is a REFERENCE / BACKUP copy of the master paint list, not something
-- the app reads from — the app's source of truth stays the hardcoded list in
-- Models/PaintDatabase.cs (per your call to keep it there). This table exists
-- purely so the full name+type list also exists in the database in case
-- something happens to the code.
--
-- Generated directly from Models/PaintDatabase.cs (337 rows) — not retyped —
-- so it's guaranteed to match the app's actual data exactly.
-- ============================================================

create table if not exists public.warhammer_paint_master (
  paint_id bigint generated always as identity primary key,
  name     text not null,
  type     text not null,
  unique (name)
);

alter table public.warhammer_paint_master enable row level security;

grant select, insert, update, delete on public.warhammer_paint_master to anon;

drop policy if exists "anon read paint_master"   on public.warhammer_paint_master;
drop policy if exists "anon insert paint_master" on public.warhammer_paint_master;

create policy "anon read paint_master"
  on public.warhammer_paint_master for select
  to anon using (true);

create policy "anon insert paint_master"
  on public.warhammer_paint_master for insert
  to anon with check (true);

insert into public.warhammer_paint_master (name, type) values
  ('Abaddon Black', 'Base'),
  ('Averland Sunset', 'Base'),
  ('Balthasar Gold', 'Base'),
  ('Barak-Nar Burgundy', 'Base'),
  ('Bugman''s Glow', 'Base'),
  ('Caledor Sky', 'Base'),
  ('Caliban Green', 'Base'),
  ('Castellan Green', 'Base'),
  ('Catachan Flesh', 'Base'),
  ('Celestra Grey', 'Base'),
  ('Corax White', 'Base'),
  ('Corvus Black', 'Base'),
  ('Daemonette Hide', 'Base'),
  ('Death Guard Green', 'Base'),
  ('Death Korps Drab', 'Base'),
  ('Deathworld Forest', 'Base'),
  ('Dryad Bark', 'Base'),
  ('Gal Vorbak Red', 'Base'),
  ('Grey Knights Steel', 'Base'),
  ('Grey Seer', 'Base'),
  ('Hobgrot Hide', 'Base'),
  ('Incubi Darkness', 'Base'),
  ('Ionrach Skin', 'Base'),
  ('Iron Hands Steel', 'Base'),
  ('Iron Warriors', 'Base'),
  ('Jokaero Orange', 'Base'),
  ('Kantor Blue', 'Base'),
  ('Khorne Red', 'Base'),
  ('Leadbelcher', 'Base'),
  ('Lupercal Green', 'Base'),
  ('Macragge Blue', 'Base'),
  ('Mechanicus Standard Grey', 'Base'),
  ('Mephiston Red', 'Base'),
  ('Morghast Bone', 'Base'),
  ('Mournfang Brown', 'Base'),
  ('Naggaroth Night', 'Base'),
  ('Night Lords Blue', 'Base'),
  ('Nocturne Green', 'Base'),
  ('Orruk Flesh', 'Base'),
  ('Phoenician Purple', 'Base'),
  ('Rakarth Flesh', 'Base'),
  ('Ratskin Flesh', 'Base'),
  ('Retributor Armour', 'Base'),
  ('Rhinox Hide', 'Base'),
  ('Runelord Brass', 'Base'),
  ('Screamer Pink', 'Base'),
  ('Screaming Bell', 'Base'),
  ('Steel Legion Drab', 'Base'),
  ('Stegadon Scale Green', 'Base'),
  ('The Fang', 'Base'),
  ('Thondia Brown', 'Base'),
  ('Thousand Sons Blue', 'Base'),
  ('Waaagh! Flesh', 'Base'),
  ('Warplock Bronze', 'Base'),
  ('Wraithbone', 'Base'),
  ('XV-88', 'Base'),
  ('Zandri Dust', 'Base'),
  ('Administratum Grey', 'Layer'),
  ('Ahriman Blue', 'Layer'),
  ('Alaitoc Blue', 'Layer'),
  ('Altdorf Guard Blue', 'Layer'),
  ('Auric Armour Gold', 'Layer'),
  ('Baharroth Blue', 'Layer'),
  ('Balor Brown', 'Layer'),
  ('Baneblade Brown', 'Layer'),
  ('Bestigor Flesh', 'Layer'),
  ('Bloodreaver Flesh', 'Layer'),
  ('Blue Horror', 'Layer'),
  ('Brass Scorpion', 'Layer'),
  ('Cadian Fleshtone', 'Layer'),
  ('Calgar Blue', 'Layer'),
  ('Canoptek Alloy', 'Layer'),
  ('Castellax Bronze', 'Layer'),
  ('Dark Reaper', 'Layer'),
  ('Dawnstone', 'Layer'),
  ('Deathclaw Brown', 'Layer'),
  ('Dechala Lilac', 'Layer'),
  ('Deepkin Flesh', 'Layer'),
  ('Doombull Brown', 'Layer'),
  ('Dorn Yellow', 'Layer'),
  ('Elysian Green', 'Layer'),
  ('Emperor''s Children', 'Layer'),
  ('Eshin Grey', 'Layer'),
  ('Evil Sunz Scarlet', 'Layer'),
  ('Fenrisian Grey', 'Layer'),
  ('Fire Dragon Bright', 'Layer'),
  ('Flash Gitz Yellow', 'Layer'),
  ('Flayed One Flesh', 'Layer'),
  ('Fulgrim Pink', 'Layer'),
  ('Fulgurite Copper', 'Layer'),
  ('Gauss Blaster Green', 'Layer'),
  ('Gehenna''s Gold', 'Layer'),
  ('Genestealer Purple', 'Layer'),
  ('Gorthor Brown', 'Layer'),
  ('Hashut Copper', 'Layer'),
  ('Hoeth Blue', 'Layer'),
  ('Ironbreaker', 'Layer'),
  ('Kabalite Green', 'Layer'),
  ('Kakophoni Purple', 'Layer'),
  ('Karak Stone', 'Layer'),
  ('Kislev Flesh', 'Layer'),
  ('Knight-Questor Flesh', 'Layer'),
  ('Krieg Khaki', 'Layer'),
  ('Liberator Gold', 'Layer'),
  ('Loren Forest', 'Layer'),
  ('Lothern Blue', 'Layer'),
  ('Lugganath Orange', 'Layer'),
  ('Moot Green', 'Layer'),
  ('Nurgling Green', 'Layer'),
  ('Ogryn Camo', 'Layer'),
  ('Pallid Wych Flesh', 'Layer'),
  ('Phalanx Yellow', 'Layer'),
  ('Pink Horror', 'Layer'),
  ('Runefang Steel', 'Layer'),
  ('Russ Grey', 'Layer'),
  ('Screaming Skull', 'Layer'),
  ('Skarsnik Green', 'Layer'),
  ('Skavenblight Dinge', 'Layer'),
  ('Skrag Brown', 'Layer'),
  ('Skullcrusher Brass', 'Layer'),
  ('Slaanesh Grey', 'Layer'),
  ('Sotek Green', 'Layer'),
  ('Sons of Horus Green', 'Layer'),
  ('Squig Orange', 'Layer'),
  ('Stormhost Silver', 'Layer'),
  ('Stormvermin Fur', 'Layer'),
  ('Straken Green', 'Layer'),
  ('Sybarite Green', 'Layer'),
  ('Sycorax Bronze', 'Layer'),
  ('Tallarn Sand', 'Layer'),
  ('Tau Light Ochre', 'Layer'),
  ('Teclis Blue', 'Layer'),
  ('Temple Guard Blue', 'Layer'),
  ('Thunderhawk Blue', 'Layer'),
  ('Troll Slayer Orange', 'Layer'),
  ('Tuskgor Fur', 'Layer'),
  ('Ulthuan Grey', 'Layer'),
  ('Ungor Flesh', 'Layer'),
  ('Ushabti Bone', 'Layer'),
  ('Vulkan Green', 'Layer'),
  ('Warboss Green', 'Layer'),
  ('Warpfiend Grey', 'Layer'),
  ('Warpstone Glow', 'Layer'),
  ('Wazdakka Red', 'Layer'),
  ('White Scar', 'Layer'),
  ('Wild Rider Red', 'Layer'),
  ('Word Bearers Red', 'Layer'),
  ('Xereus Purple', 'Layer'),
  ('Yriel Yellow', 'Layer'),
  ('Zamesi Desert', 'Layer'),
  ('Aeldari Emerald', 'Contrast'),
  ('Aethermatic Blue', 'Contrast'),
  ('Aggaros Dunes', 'Contrast'),
  ('Akhelian Green', 'Contrast'),
  ('Apothecary White', 'Contrast'),
  ('Asurmen Blue', 'Contrast'),
  ('Bad Moon Yellow', 'Contrast'),
  ('Baal Red', 'Contrast'),
  ('Basilicanum Grey', 'Contrast'),
  ('Black Legion', 'Contrast'),
  ('Black Templar', 'Contrast'),
  ('Blood Angels Red', 'Contrast'),
  ('Briar Queen Chill', 'Contrast'),
  ('Celestium Blue', 'Contrast'),
  ('Creed Camo', 'Contrast'),
  ('Cygor Brown', 'Contrast'),
  ('Dark Angels Green', 'Contrast'),
  ('Darkoath Flesh', 'Contrast'),
  ('Doomfire Magenta', 'Contrast'),
  ('Dreadful Visage', 'Contrast'),
  ('Flesh Tearers Red', 'Contrast'),
  ('Frostheart', 'Contrast'),
  ('Fyreslayer Flesh', 'Contrast'),
  ('Garaghak''s Sewer', 'Contrast'),
  ('Gore-Grunta Fur', 'Contrast'),
  ('Gryph-Charger Grey', 'Contrast'),
  ('Gryph-Hound Orange', 'Contrast'),
  ('Guilliman Flesh', 'Contrast'),
  ('Gutrippa Flesh', 'Contrast'),
  ('Hexwraith Flame', 'Contrast'),
  ('Imperial Fist', 'Contrast'),
  ('Ironjawz Yellow', 'Contrast'),
  ('Iyanden Yellow', 'Contrast'),
  ('Karandras Green', 'Contrast'),
  ('Kroxigor Scales', 'Contrast'),
  ('Leviathan Purple', 'Contrast'),
  ('Leviadon Blue', 'Contrast'),
  ('Luxion Purple', 'Contrast'),
  ('Magmadroth Flame', 'Contrast'),
  ('Magos Purple', 'Contrast'),
  ('Mantis Warriors Green', 'Contrast'),
  ('Militarum Green', 'Contrast'),
  ('Nazdreg Yellow', 'Contrast'),
  ('Nighthaunt Gloom', 'Contrast'),
  ('Ork Flesh', 'Contrast'),
  ('Plaguebearer Flesh', 'Contrast'),
  ('Pylar Glacier', 'Contrast'),
  ('Ratling Grime', 'Contrast'),
  ('Shyish Purple', 'Contrast'),
  ('Sigvald Burgundy', 'Contrast'),
  ('Skeleton Horde', 'Contrast'),
  ('Snakebite Leather', 'Contrast'),
  ('Space Wolves Grey', 'Contrast'),
  ('Stormfiend', 'Contrast'),
  ('Striking Scorpion Green', 'Contrast'),
  ('Talassar Blue', 'Contrast'),
  ('Terradon Turquoise', 'Contrast'),
  ('Ultramarines Blue', 'Contrast'),
  ('Volupus Pink', 'Contrast'),
  ('Warp Lightning', 'Contrast'),
  ('Wyldwood', 'Contrast'),
  ('Astorath Red', 'Dry'),
  ('Changeling Pink', 'Dry'),
  ('Chronus Blue', 'Dry'),
  ('Eldar Flesh', 'Dry'),
  ('Etherium Blue', 'Dry'),
  ('Golden Griffon', 'Dry'),
  ('Golgfag Brown', 'Dry'),
  ('Hellion Green', 'Dry'),
  ('Hexos Palesun', 'Dry'),
  ('Imrik Blue', 'Dry'),
  ('Kindleflame', 'Dry'),
  ('Longbeard Grey', 'Dry'),
  ('Lucius Lilac', 'Dry'),
  ('Necron Compound', 'Dry'),
  ('Niblet Green', 'Dry'),
  ('Praxeti White', 'Dry'),
  ('Ryza Rust', 'Dry'),
  ('Sigmarite', 'Dry'),
  ('Skink Blue', 'Dry'),
  ('Stormfang', 'Dry'),
  ('Sylvaneth Bark', 'Dry'),
  ('Terminatus Stone', 'Dry'),
  ('Tyrant Skull', 'Dry'),
  ('Underhive Ash', 'Dry'),
  ('Verminlord Hide', 'Dry'),
  ('Wrack White', 'Dry'),
  ('Dry: Dawnstone', 'Dry'),
  ('Dry: Hoeth Blue', 'Dry'),
  ('Dry: Nurgling Green', 'Dry'),
  ('''Ardcoat', 'Technical'),
  ('Agrellan Badland', 'Technical'),
  ('Agrellan Earth', 'Technical'),
  ('Armageddon Dust', 'Technical'),
  ('Astrogranite', 'Technical'),
  ('Blood for the Blood God', 'Technical'),
  ('Contrast Medium', 'Technical'),
  ('Lahmian Medium', 'Technical'),
  ('Martian Ironcrust', 'Technical'),
  ('Martian Ironearth', 'Technical'),
  ('Mordant Earth', 'Technical'),
  ('Nihilakh Oxide', 'Technical'),
  ('Nurgle''s Rot', 'Technical'),
  ('Soulstone Blue', 'Technical'),
  ('Spiritstone Red', 'Technical'),
  ('Stirland Mud', 'Technical'),
  ('Stormshield', 'Technical'),
  ('Tesseract Glow', 'Technical'),
  ('Typhus Corrosion', 'Technical'),
  ('Valhallan Blizzard', 'Technical'),
  ('Waystone Green', 'Technical'),
  ('Agrax Earthshade', 'Shade'),
  ('Athonian Camoshade', 'Shade'),
  ('Berserker Bloodshade', 'Shade'),
  ('Biel-Tan Green', 'Shade'),
  ('Carroburg Crimson', 'Shade'),
  ('Casandora Yellow', 'Shade'),
  ('Coelia Greenshade', 'Shade'),
  ('Drakenhof Nightshade', 'Shade'),
  ('Druchii Violet', 'Shade'),
  ('Fuegan Orange', 'Shade'),
  ('Kroak Green', 'Shade'),
  ('Mortarion Grime', 'Shade'),
  ('Nuln Oil', 'Shade'),
  ('Poxwalker', 'Shade'),
  ('Reikland Fleshshade', 'Shade'),
  ('Seraphim Sepia', 'Shade'),
  ('Soulblight Grey', 'Shade'),
  ('Targor Rageshade', 'Shade'),
  ('Tyran Blue', 'Shade'),
  ('Air: Abaddon Black', 'Air'),
  ('Air: Administratum Grey', 'Air'),
  ('Air: Air Caste Thinner', 'Air'),
  ('Air: Angron Red Clear', 'Air'),
  ('Air: Averland Sunset', 'Air'),
  ('Air: Balthasar Gold', 'Air'),
  ('Air: Baneblade Brown', 'Air'),
  ('Air: Caliban Green', 'Air'),
  ('Air: Calth Blue Clear', 'Air'),
  ('Air: Castellan Green', 'Air'),
  ('Air: Corvus Black', 'Air'),
  ('Air: Dawnstone', 'Air'),
  ('Air: Deathworld Forest', 'Air'),
  ('Air: Eidolon Purple Clear', 'Air'),
  ('Air: Elysian Green', 'Air'),
  ('Air: Evil Sunz Scarlet', 'Air'),
  ('Air: Fenrisian Grey', 'Air'),
  ('Air: Flash Gitz Yellow', 'Air'),
  ('Air: Grey Knights Steel', 'Air'),
  ('Air: Kantor Blue', 'Air'),
  ('Air: Khorne Red', 'Air'),
  ('Air: Kislev Flesh', 'Air'),
  ('Air: Leadbelcher', 'Air'),
  ('Air: Lothern Blue', 'Air'),
  ('Air: Macragge Blue', 'Air'),
  ('Air: Mechanicus Standard Grey', 'Air'),
  ('Air: Mephiston Red', 'Air'),
  ('Air: Moot Green', 'Air'),
  ('Air: Mortarion Green Clear', 'Air'),
  ('Air: Mournfang Brown', 'Air'),
  ('Air: Night Lords Blue', 'Air'),
  ('Air: Ogryn Camo', 'Air'),
  ('Air: Phalanx Yellow', 'Air'),
  ('Air: Phoenician Purple', 'Air'),
  ('Air: Runefang Steel', 'Air'),
  ('Air: Russ Grey', 'Air'),
  ('Air: Temple Guard Blue', 'Air'),
  ('Air: Thallax Gold', 'Air'),
  ('Air: The Fang', 'Air'),
  ('Air: Troll Slayer Orange', 'Air'),
  ('Air: Typhon Ash', 'Air'),
  ('Air: Ulthuan Grey', 'Air'),
  ('Air: Ushabti Bone', 'Air'),
  ('Air: White Scar', 'Air'),
  ('Air: Zandri Dust', 'Air'),
  ('Spray: Chaos Black', 'Spray'),
  ('Spray: Death Guard Green', 'Spray'),
  ('Spray: Grey Seer', 'Spray'),
  ('Spray: Leadbelcher', 'Spray'),
  ('Spray: Macragge Blue', 'Spray'),
  ('Spray: Mechanicus Standard Grey', 'Spray'),
  ('Spray: Mephiston Red', 'Spray'),
  ('Spray: Munitorum Varnish', 'Spray'),
  ('Spray: Retributor Armour', 'Spray'),
  ('Spray: White Scar', 'Spray'),
  ('Spray: Wraithbone', 'Spray'),
  ('Spray: Zandri Dust', 'Spray')
on conflict (name) do nothing;

-- ============================================================
-- PART 2: OWNED / WISHLIST / CATEGORY SETTINGS
-- ============================================================

-- ============================================================
-- Warhammer Paint Inventory — owned / wishlist / category settings
-- Run in the Supabase SQL editor. Requires warhammer_paint_master to
-- already exist and be populated (master_paint_list_backup.sql).
-- Idempotent: safe to run more than once.
--
-- This is the final-state schema (paint_id-keyed throughout) for a fresh
-- Supabase project — there's no legacy name-keyed table to migrate from.
-- ============================================================

-- 1. OWNED PAINTS ----------------------------------------------
-- A row means you own it (quantity >= 1). Extras = quantity - 1.
-- Un-owning a paint = deleting its row.
create table if not exists public.warhammer_owned_paints (
  paint_id bigint primary key references public.warhammer_paint_master(paint_id),
  quantity int not null default 1
);

do $$
begin
  if not exists (
    select 1 from pg_constraint where conname = 'warhammer_owned_paints_quantity_min'
  ) then
    alter table public.warhammer_owned_paints
      add constraint warhammer_owned_paints_quantity_min check (quantity >= 1);
  end if;
end $$;

alter table public.warhammer_owned_paints enable row level security;

grant select, insert, update, delete on public.warhammer_owned_paints to anon;

drop policy if exists "anon read owned"   on public.warhammer_owned_paints;
drop policy if exists "anon insert owned" on public.warhammer_owned_paints;
drop policy if exists "anon update owned" on public.warhammer_owned_paints;
drop policy if exists "anon delete owned" on public.warhammer_owned_paints;

create policy "anon read owned"   on public.warhammer_owned_paints for select to anon using (true);
create policy "anon insert owned" on public.warhammer_owned_paints for insert to anon with check (true);
create policy "anon update owned" on public.warhammer_owned_paints for update to anon using (true) with check (true);
create policy "anon delete owned" on public.warhammer_owned_paints for delete to anon using (true);


-- 2. WISHLIST -----------------------------------------------------
-- One row per wishlisted paint.
create table if not exists public.warhammer_wishlist_paints (
  paint_id bigint primary key references public.warhammer_paint_master(paint_id)
);

alter table public.warhammer_wishlist_paints enable row level security;

grant select, insert, delete on public.warhammer_wishlist_paints to anon;

drop policy if exists "anon read wishlist"   on public.warhammer_wishlist_paints;
drop policy if exists "anon insert wishlist" on public.warhammer_wishlist_paints;
drop policy if exists "anon delete wishlist" on public.warhammer_wishlist_paints;

create policy "anon read wishlist"   on public.warhammer_wishlist_paints for select to anon using (true);
create policy "anon insert wishlist" on public.warhammer_wishlist_paints for insert to anon with check (true);
create policy "anon delete wishlist" on public.warhammer_wishlist_paints for delete to anon using (true);


-- 3. CATEGORY SETTINGS ---------------------------------------------
-- One row per paint category: whether it's shown, and its fill/display order.
-- sort_order drives the packing planner (fill order) as well as on-screen order.
create table if not exists public.warhammer_category_settings (
  category   text primary key,          -- Base | Layer | Contrast | Dry | Technical | Shade | Air | Spray
  enabled    boolean not null default true,
  sort_order int     not null
);

alter table public.warhammer_category_settings enable row level security;

grant select, insert, update on public.warhammer_category_settings to anon;

drop policy if exists "anon read category_settings"   on public.warhammer_category_settings;
drop policy if exists "anon insert category_settings" on public.warhammer_category_settings;
drop policy if exists "anon update category_settings" on public.warhammer_category_settings;

create policy "anon read category_settings"   on public.warhammer_category_settings for select to anon using (true);
create policy "anon insert category_settings" on public.warhammer_category_settings for insert to anon with check (true);
create policy "anon update category_settings" on public.warhammer_category_settings for update to anon using (true) with check (true);

insert into public.warhammer_category_settings (category, enabled, sort_order) values
  ('Base',      true, 1),
  ('Layer',     true, 2),
  ('Contrast',  true, 3),
  ('Dry',       true, 4),
  ('Technical', true, 5),
  ('Shade',     true, 6),
  ('Air',       true, 7),
  ('Spray',     true, 8)
on conflict (category) do nothing;

-- ============================================================
-- PART 3: RACK LAYOUT SETTINGS
-- ============================================================

-- ============================================================
-- Warhammer Paint Inventory — migration: configurable rack settings
-- Run once in the Supabase SQL editor (Dashboard → SQL Editor → New query).
-- Idempotent: safe to run more than once.
-- ============================================================

-- Single-row settings table: whether you use racks at all, rack rows/columns,
-- and how many racks you own.
create table if not exists public.warhammer_rack_settings (
  id               int primary key default 1,
  has_racks        boolean not null default true,
  rows_per_rack    int not null default 12,
  columns_per_rack int not null default 6,
  racks_owned      int,
  constraint warhammer_rack_settings_singleton check (id = 1)
);

alter table public.warhammer_rack_settings
  add column if not exists has_racks boolean not null default true;

alter table public.warhammer_rack_settings enable row level security;

grant select, insert, update on public.warhammer_rack_settings to anon;

drop policy if exists "anon read rack_settings"   on public.warhammer_rack_settings;
drop policy if exists "anon insert rack_settings" on public.warhammer_rack_settings;
drop policy if exists "anon update rack_settings" on public.warhammer_rack_settings;

create policy "anon read rack_settings"
  on public.warhammer_rack_settings for select
  to anon using (true);

create policy "anon insert rack_settings"
  on public.warhammer_rack_settings for insert
  to anon with check (true);

create policy "anon update rack_settings"
  on public.warhammer_rack_settings for update
  to anon using (true) with check (true);

-- Seed the single row with the app's previous hardcoded defaults (has racks, 12x6, racks_owned unset).
insert into public.warhammer_rack_settings (id, has_racks, rows_per_rack, columns_per_rack, racks_owned)
values (1, true, 12, 6, null)
on conflict (id) do nothing;

-- ============================================================
-- PART 4: 3RD-PARTY PAINT EQUIVALENTS (Vallejo, AK Interactive)
-- ============================================================

-- ============================================================
-- Warhammer Paint Inventory — 3rd-party paint equivalents
-- Run in the Supabase SQL editor. Requires warhammer_paint_master to
-- already exist and be populated (master_paint_list_backup.sql).
--
-- IMPORTANT — this is NOT an official or scientifically exact match list.
-- It's assembled from community-published conversion charts (colour-distance
-- matching, not physical side-by-side comparison in most cases), and is
-- known to be incomplete. Treat it as a starting point, not ground truth.
-- The app lets you add/remove entries yourself to correct or extend it.
--
-- Coverage as shipped in THIS file:
--   Vallejo (Model Color / Model Air, mixed) — 252 pairs, reasonably solid
--   AK Interactive — 5 pairs only (couldn't reliably scrape a full chart —
--     their published chart is a scanned/image PDF, not extractable as text)
--   Army Painter — 0 pairs here (same problem at the time this was written)
--     — see add_army_painter_equivalents.sql for 48 pairs added afterward
--     from a source that was readable as text.
-- ============================================================

create table if not exists public.warhammer_paint_equivalents (
  id              bigint generated always as identity primary key,
  paint_id        bigint not null references public.warhammer_paint_master(paint_id),
  brand           text not null,
  equivalent_name text not null,
  unique (paint_id, brand, equivalent_name)
);

alter table public.warhammer_paint_equivalents enable row level security;

grant select, insert, update, delete on public.warhammer_paint_equivalents to anon;

drop policy if exists "anon read paint_equivalents"   on public.warhammer_paint_equivalents;
drop policy if exists "anon insert paint_equivalents" on public.warhammer_paint_equivalents;
drop policy if exists "anon delete paint_equivalents" on public.warhammer_paint_equivalents;

create policy "anon read paint_equivalents"
  on public.warhammer_paint_equivalents for select
  to anon using (true);

create policy "anon insert paint_equivalents"
  on public.warhammer_paint_equivalents for insert
  to anon with check (true);

create policy "anon delete paint_equivalents"
  on public.warhammer_paint_equivalents for delete
  to anon using (true);


-- ── Vallejo (252 pairs) ──────────────────────────────────────
insert into public.warhammer_paint_equivalents (paint_id, brand, equivalent_name)
select m.paint_id, 'Vallejo', v.equivalent_name
from (values
  ('Emperor''s Children', 'Sunset Red'),
  ('Cadian Fleshtone', 'Brown Rose'),
  ('Bestigor Flesh', 'Beige Red'),
  ('Troll Slayer Orange', 'German Orange'),
  ('Screaming Skull', 'German Yellow'),
  ('Stegadon Scale Green', 'Oxford Blue'),
  ('Temple Guard Blue', 'Blue Green'),
  ('Alaitoc Blue', 'Royal Blue'),
  ('Xereus Purple', 'Royal Purple'),
  ('Genestealer Purple', 'Blue Violet'),
  ('Screamer Pink', 'Violet Red'),
  ('Rhinox Hide', 'Burnt Cadmium Red'),
  ('Flayed One Flesh', 'Basic Skintone'),
  ('Mechanicus Standard Grey', 'Luftwaffe Uniform WW2'),
  ('Wild Rider Red', 'Scarlet'),
  ('Bugman''s Glow', 'Red Leather'),
  ('Karak Stone', 'Iraqi Sand'),
  ('Baneblade Brown', 'German Cam. Beige WW2'),
  ('Rhinox Hide', 'German Cam. Black Brown'),
  ('Death Guard Green', 'Luftwaffe Cam. Green'),
  ('Baneblade Brown', 'German Cam. Orange Ochre'),
  ('Stormvermin Fur', 'German Cam. Pale Brown'),
  ('Tuskgor Fur', 'German Cam. Medium Brown'),
  ('Moot Green', 'Lime Green'),
  ('Squig Orange', 'Amaranth Red'),
  ('Skavenblight Dinge', 'German Field Grey WW2'),
  ('Skarsnik Green', 'German Cam. Bright Green'),
  ('Lugganath Orange', 'Salmon Rose'),
  ('Eshin Grey', 'London Grey'),
  ('Krieg Khaki', 'Pale Sand'),
  ('Kabalite Green', 'Emerald'),
  ('Calgar Blue', 'Ultramarine'),
  ('Ahriman Blue', 'Light Turquoise'),
  ('Hoeth Blue', 'Andrea Blue'),
  ('Baneblade Brown', 'Cork Brown'),
  ('Lothern Blue', 'Deep Sky Blue'),
  ('Kislev Flesh', 'Sunny Skintone'),
  ('Bugman''s Glow', 'Mahogany Brown'),
  ('Kislev Flesh', 'Dark Sand'),
  ('Warpstone Glow', 'Medium Olive'),
  ('Troll Slayer Orange', 'Bright Orange'),
  ('Ratskin Flesh', 'Ochre Brown'),
  ('Elysian Green', 'Golden Olive'),
  ('Screaming Skull', 'Ice Yellow'),
  ('Bestigor Flesh', 'Medium Fleshtone'),
  ('Abaddon Black', 'Glossy Black'),
  ('Dryad Bark', 'Black Grey'),
  ('Eshin Grey', 'Grey Green'),
  ('Dark Reaper', 'Dark Blue Grey'),
  ('Dark Reaper', 'Dark Sea Green'),
  ('Eshin Grey', 'Basalt Grey'),
  ('Slaanesh Grey', 'Medium Sea Grey'),
  ('Skavenblight Dinge', 'Leather Brown'),
  ('Skavenblight Dinge', 'Chocolate Brown'),
  ('Steel Legion Drab', 'US Field Drab'),
  ('Baneblade Brown', 'Tan Earth'),
  ('Gorthor Brown', 'Beige Brown'),
  ('Baneblade Brown', 'Brown Sand'),
  ('Tallarn Sand', 'Gold Brown'),
  ('Baneblade Brown', 'Green Brown'),
  ('Baneblade Brown', 'Khaki Grey'),
  ('Zandri Dust', 'Yellow Green'),
  ('Zandri Dust', 'Middlestone'),
  ('Ulthuan Grey', 'Silver Grey'),
  ('Administratum Grey', 'Stone Grey'),
  ('Gauss Blaster Green', 'Pastel Green'),
  ('Dark Reaper', 'Brown Violet'),
  ('Dark Reaper', 'Olive Grey'),
  ('Dark Reaper', 'USA Olive Drab'),
  ('Waaagh! Flesh', 'Reflective Green'),
  ('Skarsnik Green', 'Intermediate Green'),
  ('Dryad Bark', 'Yellow Olive'),
  ('Dawnstone', 'US Dark Green'),
  ('Dark Reaper', 'Cam. Olive Green'),
  ('Thunderhawk Blue', 'Gunship Green'),
  ('Dark Reaper', 'German Cam. Extra Dark Green'),
  ('Dark Reaper', 'Bronce Green'),
  ('Mechanicus Standard Grey', 'Dark Sea Blue'),
  ('Kantor Blue', 'Dark Prussian Blue'),
  ('The Fang', 'French Mirage Blue'),
  ('Hoeth Blue', 'Azure'),
  ('The Fang', 'Intermediate Blue'),
  ('The Fang', 'Dark Blue Grey'),
  ('Celestra Grey', 'Blue Grey Pale'),
  ('Celestra Grey', 'Pale Blue'),
  ('Ulthuan Grey', 'Pale Grey Blue'),
  ('Squig Orange', 'Carmine Red'),
  ('Wild Rider Red', 'Vermillion'),
  ('Jokaero Orange', 'Orange Red'),
  ('Fire Dragon Bright', 'Light Orange'),
  ('Karak Stone', 'Tan Yellow'),
  ('Karak Stone', 'Yellow Ochre'),
  ('Baneblade Brown', 'Green Ochre'),
  ('Yriel Yellow', 'Deep Yellow'),
  ('Ushabti Bone', 'Sand Yellow'),
  ('Flayed One Flesh', 'Beige'),
  ('Dark Reaper', 'German Uniform'),
  ('Steel Legion Drab', 'English Uniform'),
  ('Loren Forest', 'Uniform Green'),
  ('Zandri Dust', 'Japan Uniform WW2'),
  ('Dawnstone', 'Russian Uniform WW2'),
  ('Macragge Blue', 'Blue'),
  ('Tuskgor Fur', 'Red'),
  ('Kislev Flesh', 'Dark Flesh'),
  ('Cadian Fleshtone', 'Light Brown'),
  ('Alaitoc Blue', 'Dark Blue'),
  ('Bugman''s Glow', 'Saddle Brown'),
  ('Gorthor Brown', 'Burnt Umber'),
  ('Sybarite Green', 'Light Green'),
  ('Russ Grey', 'Grey Blue'),
  ('Deathclaw Brown', 'Old Rose'),
  ('Pink Horror', 'Magenta'),
  ('Squig Orange', 'Dark Red'),
  ('Flayed One Flesh', 'Golden Yellow'),
  ('Flash Gitz Yellow', 'Light Yellow'),
  ('Dryad Bark', 'Black'),
  ('Dorn Yellow', 'Lemon Yellow'),
  ('Yriel Yellow', 'Flat Yellow'),
  ('Flash Gitz Yellow', 'Yellow Green'),
  ('Kislev Flesh', 'Flat Flesh'),
  ('Troll Slayer Orange', 'Clear Orange'),
  ('Tuskgor Fur', 'Flat Red'),
  ('Emperor''s Children', 'Pink'),
  ('Pink Horror', 'Purple'),
  ('Xereus Purple', 'Violet'),
  ('Blue Horror', 'Sky Blue'),
  ('Caledor Sky', 'Flat Blue'),
  ('Caledor Sky', 'Medium Blue'),
  ('Thunderhawk Blue', 'Field Blue'),
  ('Stegadon Scale Green', 'Prussian Blue'),
  ('Ahriman Blue', 'Turquoise'),
  ('Straken Green', 'Olive Green'),
  ('Waaagh! Flesh', 'Flat Green'),
  ('Kabalite Green', 'Park Green Flat'),
  ('Warboss Green', 'Deep Green'),
  ('Gauss Blaster Green', 'Grey Grey'),
  ('Temple Guard Blue', 'Light Green Blue'),
  ('Celestra Grey', 'Light Sea Grey'),
  ('Sybarite Green', 'Green Sky'),
  ('Dark Reaper', 'Military Green'),
  ('Screaming Skull', 'Buff'),
  ('Zandri Dust', 'Desert Yellow'),
  ('Zandri Dust', 'Dark Yellow'),
  ('Dark Reaper', 'German Cam. Dark Green'),
  ('Incubi Darkness', 'Black Green'),
  ('Ratskin Flesh', 'Orange Brown'),
  ('Tuskgor Fur', 'Cavalry Brown'),
  ('Steel Legion Drab', 'Flat Earth'),
  ('Gorthor Brown', 'Flat Brown'),
  ('Rhinox Hide', 'Hull Red'),
  ('Pallid Wych Flesh', 'Deck Tan'),
  ('Administratum Grey', 'Medium Grey'),
  ('Celestra Grey', 'Sky Grey'),
  ('Administratum Grey', 'Light Grey'),
  ('Dawnstone', 'Dark Sea Grey'),
  ('The Fang', 'Neutral Grey'),
  ('Incubi Darkness', 'Dark Grey'),
  ('Incubi Darkness', 'German Grey'),
  ('Aeldari Emerald', 'Snake Green'),
  ('Akhelian Green', 'Caribbean Turquoise'),
  ('Abaddon Black', 'Black (Model Air)'),
  ('Agrax Earthshade', 'Umber (Wash)'),
  ('Apothecary White', 'Templar White'),
  ('Balor Brown', 'Dark Green'),
  ('Baneblade Brown', 'Mummy White'),
  ('Bestigor Flesh', 'Skin Tone'),
  ('Black Templar', 'Black Lotus'),
  ('Blood Angels Red', 'Plasma Red'),
  ('Bloodreaver Flesh', 'Carmine Red'),
  ('Blue Horror', 'Wolf Grey'),
  ('Brass Scorpion', 'Bronze'),
  ('Bugman''s Glow', 'Athena Skin'),
  ('Caledor Sky', 'Dark Blue'),
  ('Calgar Blue', 'Elfic Blue'),
  ('Caliban Green', 'Pale Green'),
  ('Castellan Green', 'Black Green RLM70'),
  ('Celestium Blue', 'Omega Blue'),
  ('Corvus Black', 'Black (Model Air)'),
  ('Cygor Brown', 'Muddy Ground'),
  ('Daemonette Hide', 'Blue Violet'),
  ('Dark Angels Green', 'Lizard Green'),
  ('Deathworld Forest', 'Russian Green 4B0'),
  ('Dechala Lilac', 'Lustful Purple'),
  ('Doomfire Magenta', 'Cardinal Purple'),
  ('Doombull Brown', 'Nato Brown'),
  ('Dorn Yellow', 'Toxic Yellow'),
  ('Dreadful Visage', 'Wicked Purple'),
  ('Druchii Violet', 'Violet (Wash)'),
  ('Elysian Green', 'Camouflage Green'),
  ('Evil Sunz Scarlet', 'Red RLM23'),
  ('Fire Dragon Bright', 'Orange Rust'),
  ('Flesh Tearers Red', 'Velvet Red'),
  ('Fulgrim Pink', 'Pink'),
  ('Fyreslayer Flesh', 'Tanned Skin'),
  ('Gauss Blaster Green', 'Ghost Green'),
  ('Gore-Grunta Fur', 'Copper Brown'),
  ('Gryph-Charger Grey', 'Starship Steel'),
  ('Gryph-Hound Orange', 'Martian Orange'),
  ('Guilliman Flesh', 'Dwarf Skin'),
  ('Iron Hands Steel', 'Chrome (Metallic)'),
  ('Iyanden Yellow', 'Nuclear Yellow'),
  ('Kabalite Green', 'Scurvy Green'),
  ('Kantor Blue', 'Sunrise Blue'),
  ('Karak Stone', 'Light Brown'),
  ('Kislev Flesh', 'Beige Red'),
  ('Leviathan Purple', 'Vampiric Purple'),
  ('Lothern Blue', 'Electric Blue'),
  ('Macragge Blue', 'French Blue'),
  ('Luxion Purple', 'Gloomy Violet'),
  ('Magmadroth Flame', 'Phoenix Orange'),
  ('Mantis Warriors Green', 'Orc Skin'),
  ('Magos Purple', 'Twilight Rose'),
  ('Mephiston Red', 'Mahogany'),
  ('Moot Green', 'Light Green'),
  ('Militarum Green', 'Plaque Green'),
  ('Mournfang Brown', 'Gorgon Brown'),
  ('Nighthaunt Gloom', 'Space Grey'),
  ('Night Lords Blue', 'Deep Sky'),
  ('Nuln Oil', 'Black (Wash)'),
  ('Ogryn Camo', 'Stone Grey'),
  ('Pallid Wych Flesh', 'Off-White'),
  ('Ork Flesh', 'Forest Green'),
  ('Plaguebearer Flesh', 'Rotten Flesh'),
  ('Rakarth Flesh', 'Heavy Warmgrey'),
  ('Reikland Fleshshade', 'Flesh (Wash)'),
  ('Ratling Grime', 'Greasy Black'),
  ('Retributor Armour', 'Gold (Metallic)'),
  ('Rhinox Hide', 'Dark Brown RLM61'),
  ('Russ Grey', 'Oxford Blue'),
  ('Screamer Pink', 'Magenta'),
  ('Screaming Skull', 'Bonewhite'),
  ('Seraphim Sepia', 'Sepia (Wash)'),
  ('Sigvald Burgundy', 'Deep Purple'),
  ('Skeleton Horde', 'Bag of Bones'),
  ('Skrag Brown', 'Light Rust'),
  ('Snakebite Leather', 'Wasteland Brown'),
  ('Sotek Green', 'Park Green Flat'),
  ('Steel Legion Drab', 'Dark Earth'),
  ('Sybarite Green', 'Foul Green'),
  ('Tallarn Sand', 'Hemp'),
  ('Tau Light Ochre', 'Beige Red'),
  ('The Fang', 'Field Blue'),
  ('Troll Slayer Orange', 'Orange'),
  ('Ultramarines Blue', 'Storm Blue'),
  ('Warboss Green', 'Sick Green'),
  ('Warp Lightning', 'Troll Green'),
  ('Warpstone Glow', 'Light Green'),
  ('White Scar', 'White (Model Air)'),
  ('Xereus Purple', 'Blue Violet'),
  ('Wyldwood', 'Willow Bark'),
  ('XV-88', 'USAF Brown'),
  ('Zandri Dust', 'Concrete')
) as v(citadel_name, equivalent_name)
join public.warhammer_paint_master m on m.name = v.citadel_name
on conflict (paint_id, brand, equivalent_name) do nothing;


-- ── AK Interactive (5 pairs — very minimal, see note above) ──
insert into public.warhammer_paint_equivalents (paint_id, brand, equivalent_name)
select m.paint_id, 'AK Interactive', v.equivalent_name
from (values
  ('Rhinox Hide', 'Grim Brown'),
  ('Khorne Red', 'Carmine'),
  ('Averland Sunset', 'Golden Brown'),
  ('Waaagh! Flesh', 'Black Green'),
  ('Kantor Blue', 'Dark Prussian Blue')
) as v(citadel_name, equivalent_name)
join public.warhammer_paint_master m on m.name = v.citadel_name
on conflict (paint_id, brand, equivalent_name) do nothing;

-- Army Painter: no rows in this file — see add_army_painter_equivalents.sql,
-- run separately, for 48 pairs added once a readable source was found.

-- ============================================================
-- PART 5: MORE EQUIVALENTS (Army Painter)
-- ============================================================

-- ============================================================
-- Warhammer Paint Inventory — add Army Painter equivalents
-- Run in the Supabase SQL editor. Requires warhammer_paint_equivalents
-- to already exist (create_paint_equivalents.sql).
--
-- Sourced from the DakkaDakka paint range compatibility wiki table
-- (community-maintained, itself compiled from several older paint-shop
-- reference sites — see its own References section). 48 pairs, matched
-- via the Army Painter "(WPxxxx)" product code as an anchor to avoid
-- misreading which table column was which (an earlier source I tried
-- turned out to have old-Citadel-name data mislabeled as Army Painter —
-- this one was double-checked against the actual master paint list
-- with zero unmatched names).
--
-- Idempotent: uses the same (paint_id, brand, equivalent_name) unique
-- constraint as the original seed, so safe to re-run.
-- ============================================================

insert into public.warhammer_paint_equivalents (paint_id, brand, equivalent_name)
select m.paint_id, 'Army Painter', v.equivalent_name
from (values
  ('White Scar', 'Matt White (WP1102)'),
  ('Flash Gitz Yellow', 'Demonic Yelow (WP1107)'),
  ('Tallarn Sand', 'Desert Yellow (WP1121)'),
  ('Fire Dragon Bright', 'Prison Jumpsuit (WP1211 Zombiecide)'),
  ('Troll Slayer Orange', 'Mythical Orange (WP1442)'),
  ('Mephiston Red', 'Vampire Red (WP1460)'),
  ('Evil Sunz Scarlet', 'Pure Red (WP1104)'),
  ('Wild Rider Red', 'Mars Red (WP1436)'),
  ('Wazdakka Red', 'Dragon Red (WP1105)'),
  ('Khorne Red', 'Chaotic Red (WP1142)'),
  ('Xereus Purple', 'Alien Purple (WP1128)'),
  ('Kantor Blue', 'Deep Blue (WP1116)'),
  ('Altdorf Guard Blue', 'Ultramarine Blue (WP1115)'),
  ('Lothern Blue', 'Voidshield Blue (WP1452)'),
  ('Teclis Blue', 'Electric Blue (WP1113)'),
  ('Sotek Green', 'Hydra Turquoise (WP1141)'),
  ('Caliban Green', 'Angel Green (WP1112)'),
  ('Warboss Green', 'Goblin Green (WP1109)'),
  ('Loren Forest', 'Army Green (WP1110)'),
  ('Deathworld Forest', 'Venom Wyrm (WP1461)'),
  ('Ushabti Bone', 'Skeleton Bone (WP1125)'),
  ('Ratskin Flesh', 'Barbarian Flesh (WP1126)'),
  ('Bugman''s Glow', 'Tanned Flesh (WP1127)'),
  ('Steel Legion Drab', 'Leather Brown (WP1123)'),
  ('The Fang', 'Wolf Grey (WP1119)'),
  ('Administratum Grey', 'Ash Grey (WP1117)'),
  ('Dawnstone', 'Uniform Grey (WP1118)'),
  ('Abaddon Black', 'Matt Black (WP1101)'),
  ('Runefang Steel', 'Shining Silver (WP1129)'),
  ('Ironbreaker', 'Plate Mail Metal (WP1130)'),
  ('Leadbelcher', 'Machinegun Metal (WP1221)'),
  ('Auric Armour Gold', 'Bright Gold (WP1231)'),
  ('Gehenna''s Gold', 'Greedy Gold (WP1132)'),
  ('Hashut Copper', 'Weapon Bronze (WP1133)'),
  ('Rakarth Flesh', 'Drake Tooth (WP1417)'),
  ('Drakenhof Nightshade', 'Blue Tone Ink (WP1139)'),
  ('Carroburg Crimson', 'Red Tone Ink (WP1138)'),
  ('Nuln Oil', 'Dark Tone Ink (WP1136)'),
  ('Agrax Earthshade', 'Strong Tone Wash (WP1135)'),
  ('Seraphim Sepia', 'Soft Tone Ink (WP1134)'),
  ('Druchii Violet', 'Purple Tone Ink (WP1140)'),
  ('Reikland Fleshshade', 'Flesh Wash (WP1143)'),
  ('Biel-Tan Green', 'Green Tone Wash (WP1137)'),
  ('Baharroth Blue', 'Toxic Mist (WP1437)'),
  ('Dechala Lilac', 'Oozing Purple (WP1445)'),
  ('Krieg Khaki', 'Necrotic Flesh (WP1108)'),
  ('Blue Horror', 'Gorgon Hide (WP1428)'),
  ('Lugganath Orange', 'Centaur Skin (WP1408)')
) as v(citadel_name, equivalent_name)
join public.warhammer_paint_master m on m.name = v.citadel_name
on conflict (paint_id, brand, equivalent_name) do nothing;

-- ============================================================
-- PART 6: MORE EQUIVALENTS (P3 Formula + extra Vallejo/Army Painter)
-- ============================================================

-- ============================================================
-- Warhammer Paint Inventory — add P3 Formula brand + more
-- Vallejo / Army Painter equivalents
-- Run in the Supabase SQL editor. Requires warhammer_paint_equivalents
-- to already exist (create_paint_equivalents.sql).
--
-- Sourced from redgrimm.github.io/paint-conversion/ (community colour-
-- distance conversion chart covering Vallejo Game, Vallejo Model, P3
-- Formula (Privateer Press), and Army Painter). All 104 Citadel paint
-- names cross-checked against warhammer_paint_master; 2 could not be
-- matched and were dropped rather than guessed:
--   - "Ceramite White" — not a real/current Citadel product in our list
--   - "Death Guard Armor" — no match in warhammer_paint_master (closest
--     is "Death Guard Green", a clearly different name — skipped rather
--     than risk a wrong mapping)
-- 4 name mismatches were corrected against the master list before
-- insert: Bugmans Glow -> Bugman's Glow, Death World Forest ->
-- Deathworld Forest, Emperors Children -> Emperor's Children,
-- Evil Suns Scarlet -> Evil Sunz Scarlet.
--
-- P3 Formula is a new brand (not previously tracked) — add it to the
-- Brands array in Pages/Equivalents.razor after running this.
--
-- Idempotent: uses the same (paint_id, brand, equivalent_name) unique
-- constraint as prior seeds, so safe to re-run. Vallejo/Army Painter
-- rows that duplicate existing entries are silently skipped.
-- ============================================================

-- ── Vallejo (204 pairs: Game + Model per paint) ─────────────
insert into public.warhammer_paint_equivalents (paint_id, brand, equivalent_name)
select m.paint_id, 'Vallejo', v.equivalent_name
from (values
('White Scar', 'Dead White'),
('White Scar', 'White'),
('Averland Sunset', 'Gold Yellow'),
('Averland Sunset', 'Golden Yellow'),
('Yriel Yellow', 'Sun Yellow'),
('Yriel Yellow', 'Deep Yellow'),
('Flash Gitz Yellow', 'Moon Yellow'),
('Flash Gitz Yellow', 'Lemon Yellow'),
('Jokaero Orange', 'Hot Orange'),
('Jokaero Orange', 'Scarlet'),
('Troll Slayer Orange', 'Orange Fire'),
('Troll Slayer Orange', 'Bright Orange'),
('Fire Dragon Bright', 'Bronze Fleshtone'),
('Fire Dragon Bright', 'Light Orange'),
('Mephiston Red', 'Gory Red'),
('Mephiston Red', 'Flat Red'),
('Evil Sunz Scarlet', 'Bloody Red'),
('Evil Sunz Scarlet', 'Carmine Red'),
('Wild Rider Red', 'Hot Orange'),
('Wild Rider Red', 'Scarlet'),
('Khorne Red', 'Terracota'),
('Khorne Red', 'Hull Red'),
('Wazdakka Red', 'Gory Red'),
('Wazdakka Red', 'German Cam. Medium Brown'),
('Squig Orange', 'Tan'),
('Squig Orange', 'Dark Red'),
('Screamer Pink', 'Warlord Purple'),
('Screamer Pink', 'Violet Red'),
('Pink Horror', 'Warlord Purple'),
('Pink Horror', 'Magenta'),
('Emperor''s Children', 'Tan'),
('Emperor''s Children', 'Sunset Red'),
('Naggaroth Night', 'Hexed Lichen'),
('Naggaroth Night', 'Violet'),
('Xereus Purple', 'Heavy Violet'),
('Xereus Purple', 'Royal Purple'),
('Genestealer Purple', 'Sombre Grey'),
('Genestealer Purple', 'Blue Violet'),
('Daemonette Hide', 'Sombre Grey'),
('Daemonette Hide', 'Azure'),
('Warpfiend Grey', 'Cold Grey'),
('Warpfiend Grey', 'Grey Green'),
('Slaanesh Grey', 'Stonewall Grey'),
('Slaanesh Grey', 'Medium Sea Grey'),
('Kantor Blue', 'Royal Purple'),
('Kantor Blue', 'Dark Prussian Blue'),
('Alaitoc Blue', 'Sombre Grey'),
('Alaitoc Blue', 'Royal Blue'),
('Hoeth Blue', 'Electric Blue'),
('Hoeth Blue', 'Azure'),
('Macragge Blue', 'Magic Blue'),
('Macragge Blue', 'Blue'),
('Altdorf Guard Blue', 'Magic Blue'),
('Altdorf Guard Blue', 'Royal Blue'),
('Calgar Blue', 'Sombre Grey'),
('Calgar Blue', 'Ultramarine'),
('Caledor Sky', 'Sombre Grey'),
('Caledor Sky', 'Flat Blue'),
('Teclis Blue', 'Electric Blue'),
('Teclis Blue', 'Azure'),
('Lothern Blue', 'Electric Blue'),
('Lothern Blue', 'Deep Sky Blue'),
('Thousand Sons Blue', 'Wolf Grey'),
('Thousand Sons Blue', 'Deep Sky Blue'),
('Ahriman Blue', 'Steel Grey'),
('Ahriman Blue', 'Turquoise'),
('The Fang', 'Turquoise'),
('The Fang', 'French Mirage Blue'),
('Russ Grey', 'Steel Grey'),
('Russ Grey', 'Grey Blue'),
('Fenrisian Grey', 'Wolf Grey'),
('Fenrisian Grey', 'Pastel Blue'),
('Stegadon Scale Green', 'Heavy Blue'),
('Stegadon Scale Green', 'Oxford Blue'),
('Sotek Green', 'Turquoise'),
('Sotek Green', 'Field Blue'),
('Temple Guard Blue', 'Foul Green'),
('Temple Guard Blue', 'Blue Green'),
('Thunderhawk Blue', 'Turquoise'),
('Thunderhawk Blue', 'Field Blue'),
('Incubi Darkness', 'Scurvy Green'),
('Incubi Darkness', 'Black Green'),
('Kabalite Green', 'Foul Green'),
('Kabalite Green', 'Park Green Flat'),
('Sybarite Green', 'Foul Green'),
('Sybarite Green', 'Light Green'),
('Caliban Green', 'Dark Green'),
('Caliban Green', 'Yellow Olive'),
('Warpstone Glow', 'Goblin Green'),
('Warpstone Glow', 'Medium Olive'),
('Moot Green', 'Scorpion Green'),
('Moot Green', 'Lime Green'),
('Waaagh! Flesh', 'Mutation Green'),
('Waaagh! Flesh', 'Flat Green'),
('Warboss Green', 'Goblin Green'),
('Warboss Green', 'Park Green Flat'),
('Skarsnik Green', 'Foul Green'),
('Skarsnik Green', 'Intermediate Green'),
('Castellan Green', 'Heavy Green'),
('Castellan Green', 'Reflective Green'),
('Deathworld Forest', 'Camoflage Green'),
('Deathworld Forest', 'Luftwaffe Cam. Green'),
('Loren Forest', 'Camoflage Green'),
('Loren Forest', 'Uniform Green'),
('Straken Green', 'Camoflage Green'),
('Straken Green', 'Olive Green'),
('Nurgling Green', 'Heavy Khaki'),
('Nurgling Green', 'Middlestone'),
('Elysian Green', 'Heavy Khaki'),
('Elysian Green', 'Golden Olive'),
('Ogryn Camo', 'Dead Flesh'),
('Ogryn Camo', 'Middlestone'),
('Zandri Dust', 'Heavy Khaki'),
('Zandri Dust', 'Dark Yellow'),
('Ushabti Bone', 'Pale Yellow'),
('Ushabti Bone', 'Sand Yellow'),
('Screaming Skull', 'Elfic Flesh'),
('Screaming Skull', 'Buff'),
('Flayed One Flesh', 'Bone White'),
('Flayed One Flesh', 'Beige'),
('Steel Legion Drab', 'Heavy Brown'),
('Steel Legion Drab', 'English Uniform'),
('Tallarn Sand', 'Heavy Gold Brown'),
('Tallarn Sand', 'Gold Brown'),
('Karak Stone', 'Dead Flesh'),
('Karak Stone', 'Iraqi Sand'),
('Bugman''s Glow', 'Tan'),
('Bugman''s Glow', 'Saddle Brown'),
('Cadian Fleshtone', 'Dwarf Skin'),
('Cadian Fleshtone', 'Light Brown'),
('Kislev Flesh', 'Bone White'),
('Kislev Flesh', 'Flat Flesh'),
('Ratskin Flesh', 'Heavy Skintone'),
('Ratskin Flesh', 'Orange Brown'),
('Bestigor Flesh', 'Bronze Fleshtone'),
('Bestigor Flesh', 'Beige Red'),
('Ungor Flesh', 'Bone White'),
('Ungor Flesh', 'Dark Flesh'),
('Mournfang Brown', 'Terracota'),
('Mournfang Brown', 'Hull Red'),
('Skrag Brown', 'Parasite Brown'),
('Skrag Brown', 'Flat Earth'),
('Deathclaw Brown', 'Dwarf Skin'),
('Deathclaw Brown', 'Orange Brown'),
('XV-88', 'Leather Brown'),
('XV-88', 'English Uniform'),
('Tau Light Ochre', 'Heavy Ochre'),
('Tau Light Ochre', 'Ochre Brown'),
('Balor Brown', 'Leather Brown'),
('Balor Brown', 'Flat Earth'),
('Zamesi Desert', 'Plague Brown'),
('Zamesi Desert', 'Dark Flesh'),
('Rhinox Hide', 'Dark Fleshtone'),
('Rhinox Hide', 'German Cam. Black Brown'),
('Doombull Brown', 'Terracota'),
('Doombull Brown', 'Hull Red'),
('Tuskgor Fur', 'Heavy Red'),
('Tuskgor Fur', 'Cavalry Brown'),
('Dryad Bark', 'Charred Brown'),
('Dryad Bark', 'Leather Brown'),
('Gorthor Brown', 'Heavy Sienna'),
('Gorthor Brown', 'Burnt Umber'),
('Baneblade Brown', 'Khaki'),
('Baneblade Brown', 'Tan Earth'),
('Mechanicus Standard Grey', 'Cold Grey'),
('Mechanicus Standard Grey', 'USA Olive Drab'),
('Dawnstone', 'Khaki'),
('Dawnstone', 'Dark Sea Grey'),
('Administratum Grey', 'Heavy Blue Grey'),
('Administratum Grey', 'Blue Grey Pale'),
('Celestra Grey', 'Heavy Blue Grey'),
('Celestra Grey', 'Light Sea Grey'),
('Ulthuan Grey', 'Verdigris'),
('Ulthuan Grey', 'Silver Grey'),
('Rakarth Flesh', 'Heavy Blue Grey'),
('Rakarth Flesh', 'Stone Grey'),
('Pallid Wych Flesh', 'Elfic Flesh'),
('Pallid Wych Flesh', 'Silver Grey'),
('Abaddon Black', 'Black'),
('Abaddon Black', 'Glossy Black'),
('Eshin Grey', 'Cold Grey'),
('Eshin Grey', 'Grey Green'),
('Skavenblight Dinge', 'Beasty Brown'),
('Skavenblight Dinge', 'Leather Brown'),
('Stormvermin Fur', 'Khaki'),
('Stormvermin Fur', 'German Cam. Pale Brown'),
('Dark Reaper', 'Cayman Green'),
('Dark Reaper', 'USA Olive Drab'),
('Baharroth Blue', 'Heavy Blue Grey'),
('Baharroth Blue', 'Pale Blue'),
('Blue Horror', 'Ghost Grey'),
('Blue Horror', 'Pale Grey Blue'),
('Dechala Lilac', 'Wolf Grey'),
('Dechala Lilac', 'Blue Grey Pale'),
('Dorn Yellow', 'Moon Yellow'),
('Dorn Yellow', 'Lemon Yellow'),
('Fulgrim Pink', 'Pale Flesh'),
('Fulgrim Pink', 'Sky Grey'),
('Gauss Blaster Green', 'Verdigris'),
('Gauss Blaster Green', 'Grey Grey'),
('Krieg Khaki', 'Dead Flesh'),
('Krieg Khaki', 'Pale Sand'),
('Lugganath Orange', 'Rosy Flesh'),
('Lugganath Orange', 'Salmon Rose')
) as v(citadel_name, equivalent_name)
join public.warhammer_paint_master m on m.name = v.citadel_name
on conflict (paint_id, brand, equivalent_name) do nothing;


-- ── P3 Formula (102 pairs, new brand) ───────────────────────
insert into public.warhammer_paint_equivalents (paint_id, brand, equivalent_name)
select m.paint_id, 'P3 Formula', v.equivalent_name
from (values
('White Scar', 'Morrow White'),
('Averland Sunset', 'Heartfire'),
('Yriel Yellow', 'Sulfuric Yellow'),
('Flash Gitz Yellow', 'Cygnus Yellow'),
('Jokaero Orange', 'Khador Red Base'),
('Troll Slayer Orange', 'Khardic Flesh'),
('Fire Dragon Bright', 'Khador Red Highlight'),
('Mephiston Red', 'Skorne Red'),
('Evil Sunz Scarlet', 'Skorne Red'),
('Wild Rider Red', 'Khador Red Base'),
('Khorne Red', 'Sanguine Base'),
('Wazdakka Red', 'Sanguine Base'),
('Squig Orange', 'Bloodstone'),
('Screamer Pink', 'Murderous Magenta'),
('Pink Horror', 'Murderous Magenta'),
('Emperor''s Children', 'Murderous Magenta'),
('Naggaroth Night', 'Exile Blue'),
('Xereus Purple', 'Beaten Purple'),
('Genestealer Purple', 'Cygnar Base Blue'),
('Daemonette Hide', 'Greatcoat Grey'),
('Warpfiend Grey', 'Greatcoat Grey'),
('Slaanesh Grey', 'Ironhull Grey'),
('Kantor Blue', 'Exile Blue'),
('Alaitoc Blue', 'Cygnar Base Blue'),
('Hoeth Blue', 'Cygnar Blue Highlight'),
('Macragge Blue', 'Exile Blue'),
('Altdorf Guard Blue', 'Cygnar Base Blue'),
('Calgar Blue', 'Cygnar Blue Highlight'),
('Caledor Sky', 'Cygnar Blue Highlight'),
('Teclis Blue', 'Cygnar Blue Highlight'),
('Lothern Blue', 'Ironhull Grey'),
('Thousand Sons Blue', 'Meredius Blue'),
('Ahriman Blue', 'Trollblood Base'),
('The Fang', 'Trollblood Base'),
('Russ Grey', 'Greatcoat Grey'),
('Fenrisian Grey', 'Ironhull Grey'),
('Stegadon Scale Green', 'Exile Blue'),
('Sotek Green', 'Coal Black'),
('Temple Guard Blue', 'Meredius Blue'),
('Thunderhawk Blue', 'Coal Black'),
('Incubi Darkness', 'Coal Black'),
('Kabalite Green', 'Gnarls Green'),
('Sybarite Green', 'Iosan Green'),
('Caliban Green', 'Cryx Bane Base'),
('Warpstone Glow', 'Gnarls Green'),
('Moot Green', 'Iosan Green'),
('Waaagh! Flesh', 'Gnarls Green'),
('Warboss Green', 'Gnarls Green'),
('Skarsnik Green', 'Traitor Green'),
('Castellan Green', 'Cryx Bane Base'),
('Deathworld Forest', 'Battledress Green'),
('Loren Forest', 'Ordic Olive'),
('Straken Green', 'Ordic Olive'),
('Nurgling Green', 'Traitor Green'),
('Elysian Green', 'Ordic Olive'),
('Ogryn Camo', 'Wurm Green'),
('Zandri Dust', 'Rucksack Tan'),
('Ushabti Bone', 'Hammerfall Khaki'),
('Screaming Skull', 'Jack Bone'),
('Flayed One Flesh', 'Jack Bone'),
('Steel Legion Drab', 'Thornwood Green'),
('Tallarn Sand', 'Gun Corps Brown'),
('Karak Stone', 'Beast Hide'),
('Bugman''s Glow', 'Idrian Flesh'),
('Cadian Fleshtone', 'Khardic Flesh'),
('Kislev Flesh', 'Midlund Flesh'),
('Ratskin Flesh', 'Idrian Flesh'),
('Bestigor Flesh', 'Khardic Flesh'),
('Ungor Flesh', 'Heartfire'),
('Mournfang Brown', 'Sanguine Base'),
('Skrag Brown', 'Bloodstone'),
('Deathclaw Brown', 'Khardic Flesh'),
('XV-88', 'Idrian Flesh'),
('Tau Light Ochre', 'Bloodtracker Brown'),
('Balor Brown', 'Bootstrap Leather'),
('Zamesi Desert', 'Moldy Ochre'),
('Rhinox Hide', 'Battlefield Brown'),
('Doombull Brown', 'Sanguine Base'),
('Tuskgor Fur', 'Skorne Red'),
('Dryad Bark', 'Battlefield Brown'),
('Gorthor Brown', 'Thornwood Green'),
('Baneblade Brown', 'Cryx Bane Highlight'),
('Mechanicus Standard Grey', 'Greatcoat Grey'),
('Dawnstone', 'Bastion Grey'),
('Administratum Grey', 'Ironhull Grey'),
('Celestra Grey', 'Ironhull Grey'),
('Ulthuan Grey', 'Underbelly Blue'),
('Rakarth Flesh', 'Trollblood Highlight'),
('Pallid Wych Flesh', 'Jack Bone'),
('Abaddon Black', 'Thamar Black'),
('Eshin Grey', 'Greatcoat Grey'),
('Skavenblight Dinge', 'Cryx Bane Base'),
('Stormvermin Fur', 'Bastion Grey'),
('Dark Reaper', 'Greatcoat Grey'),
('Baharroth Blue', 'Arcane Blue'),
('Blue Horror', 'Underbelly Blue'),
('Dechala Lilac', 'Ironhull Grey'),
('Dorn Yellow', 'Cygnus Yellow'),
('Fulgrim Pink', 'Carnal Pink'),
('Gauss Blaster Green', 'Arcane Blue'),
('Krieg Khaki', 'Hammerfall Khaki'),
('Lugganath Orange', 'Midlund Flesh')
) as v(citadel_name, equivalent_name)
join public.warhammer_paint_master m on m.name = v.citadel_name
on conflict (paint_id, brand, equivalent_name) do nothing;


-- ── Army Painter (102 pairs, supplements the existing 48) ───
insert into public.warhammer_paint_equivalents (paint_id, brand, equivalent_name)
select m.paint_id, 'Army Painter', v.equivalent_name
from (values
('White Scar', 'Matt White'),
('Averland Sunset', 'Phoenix Flames'),
('Yriel Yellow', 'Daemonic Yellow'),
('Flash Gitz Yellow', 'Babe Blonde'),
('Jokaero Orange', 'Mythical Orange'),
('Troll Slayer Orange', 'Fire Lizard'),
('Fire Dragon Bright', 'Barbarian Flesh'),
('Mephiston Red', 'Dragon Red'),
('Evil Sunz Scarlet', 'Pure Red'),
('Wild Rider Red', 'Pure Red'),
('Khorne Red', 'Chaotic Red'),
('Wazdakka Red', 'Dragon Red'),
('Squig Orange', 'Mars Red'),
('Screamer Pink', 'Vampire Red'),
('Pink Horror', 'Wasteland Soil'),
('Emperor''s Children', 'Orc Blood'),
('Naggaroth Night', 'Deep Blue'),
('Xereus Purple', 'Alien Purple'),
('Genestealer Purple', 'Dungeon Grey'),
('Daemonette Hide', 'Dungeon Grey'),
('Warpfiend Grey', 'Dungeon Grey'),
('Slaanesh Grey', 'Ash Grey'),
('Kantor Blue', 'Deep Blue'),
('Alaitoc Blue', 'Griffon Blue'),
('Hoeth Blue', 'Crystal Blue'),
('Macragge Blue', 'Ultramarine Blue'),
('Altdorf Guard Blue', 'Ultramarine Blue'),
('Calgar Blue', 'Viking Blue'),
('Caledor Sky', 'Viking Blue'),
('Teclis Blue', 'Crystal Blue'),
('Lothern Blue', 'Voidshield Blue'),
('Thousand Sons Blue', 'Voidshield Blue'),
('Ahriman Blue', 'Hydra Turquoise'),
('The Fang', 'Uniform Grey'),
('Russ Grey', 'Wolf Grey'),
('Fenrisian Grey', 'Ice Storm'),
('Stegadon Scale Green', 'Dark Sky'),
('Sotek Green', 'Wizards Orb'),
('Temple Guard Blue', 'Elemental Bolt'),
('Thunderhawk Blue', 'Uniform Grey'),
('Incubi Darkness', 'Necromance Cloak'),
('Kabalite Green', 'Elemental Bolt'),
('Sybarite Green', 'Goblin Green'),
('Caliban Green', 'Angel Green'),
('Warpstone Glow', 'Mouldy Clothes'),
('Moot Green', 'Jungle Green'),
('Waaagh! Flesh', 'Greenskin'),
('Warboss Green', 'Mouldy Clothes'),
('Skarsnik Green', 'Goblin Green'),
('Castellan Green', 'Elf Green'),
('Deathworld Forest', 'Army Green'),
('Loren Forest', 'Army Green'),
('Straken Green', 'Commando Green'),
('Nurgling Green', 'Scaly Hide'),
('Elysian Green', 'Witch Brew'),
('Ogryn Camo', 'Jungle Green'),
('Zandri Dust', 'Witch Brew'),
('Ushabti Bone', 'Necrotic Flesh'),
('Screaming Skull', 'Skeleton Bone'),
('Flayed One Flesh', 'Corpse Pale'),
('Steel Legion Drab', 'Venom Wyrm'),
('Tallarn Sand', 'Sulphide Ochre'),
('Karak Stone', 'Kobold Skin'),
('Bugman''s Glow', 'Werewolf Fur'),
('Cadian Fleshtone', 'Tanned Flesh'),
('Kislev Flesh', 'Kobold Skin'),
('Ratskin Flesh', 'Tanned Flesh'),
('Bestigor Flesh', 'Troll Claws'),
('Ungor Flesh', 'Kobold Skin'),
('Mournfang Brown', 'Chaotic Red'),
('Skrag Brown', 'Monster Brown'),
('Deathclaw Brown', 'Tanned Flesh'),
('XV-88', 'Leather Brown'),
('Tau Light Ochre', 'Fire Lizard'),
('Balor Brown', 'Monster Brown'),
('Zamesi Desert', 'Phoenix Flames'),
('Rhinox Hide', 'Dirt Spatter'),
('Doombull Brown', 'Chaotic Red'),
('Tuskgor Fur', 'Vampire Red'),
('Dryad Bark', 'Necromance Cloak'),
('Gorthor Brown', 'Dark Stone'),
('Baneblade Brown', 'Filthy Cape'),
('Mechanicus Standard Grey', 'Hardened Carapace'),
('Dawnstone', 'Field Grey'),
('Administratum Grey', 'Ash Grey'),
('Celestra Grey', 'Ash Grey'),
('Ulthuan Grey', 'Spaceship Exterior'),
('Rakarth Flesh', 'Ash Grey'),
('Pallid Wych Flesh', 'Drake Tooth'),
('Abaddon Black', 'Matt Black'),
('Eshin Grey', 'Dark Stone'),
('Skavenblight Dinge', 'Hardened Carapace'),
('Stormvermin Fur', 'Cultist Robe'),
('Dark Reaper', 'Necromance Cloak'),
('Baharroth Blue', 'Toxic Mist'),
('Blue Horror', 'Gorgon Hide'),
('Dechala Lilac', 'Oozing Purple'),
('Dorn Yellow', 'Babe Blonde'),
('Fulgrim Pink', 'Spaceship Exterior'),
('Gauss Blaster Green', 'Kraken Skin'),
('Krieg Khaki', 'Necrotic Flesh'),
('Lugganath Orange', 'Centaur Skin')
) as v(citadel_name, equivalent_name)
join public.warhammer_paint_master m on m.name = v.citadel_name
on conflict (paint_id, brand, equivalent_name) do nothing;

-- ============================================================
-- PART 7: APP-LEVEL SETTINGS
-- ============================================================

-- Single-row settings table for misc app-wide options. Currently just the
-- optional "Home" link shown in the sidebar (null/empty hides it).
create table if not exists public.warhammer_app_settings (
  id            int primary key default 1,
  home_link_url text,
  constraint warhammer_app_settings_singleton check (id = 1)
);

alter table public.warhammer_app_settings enable row level security;

grant select, insert, update on public.warhammer_app_settings to anon;

drop policy if exists "anon read app_settings"   on public.warhammer_app_settings;
drop policy if exists "anon insert app_settings" on public.warhammer_app_settings;
drop policy if exists "anon update app_settings" on public.warhammer_app_settings;

create policy "anon read app_settings"
  on public.warhammer_app_settings for select
  to anon using (true);

create policy "anon insert app_settings"
  on public.warhammer_app_settings for insert
  to anon with check (true);

create policy "anon update app_settings"
  on public.warhammer_app_settings for update
  to anon using (true) with check (true);

-- Seed the single row (unset by default).
insert into public.warhammer_app_settings (id, home_link_url)
values (1, null)
on conflict (id) do nothing;
