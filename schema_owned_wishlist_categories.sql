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
