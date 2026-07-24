-- ============================================================
-- Warhammer Paint Inventory — migration: configurable rack settings
-- Run once in the Supabase SQL editor (Dashboard → SQL Editor → New query).
-- Idempotent: safe to run more than once.
-- ============================================================

-- Single-row settings table: rack rows/columns, and how many racks you own.
create table if not exists public.warhammer_rack_settings (
  id               int primary key default 1,
  rows_per_rack    int not null default 12,
  columns_per_rack int not null default 6,
  racks_owned      int,
  constraint warhammer_rack_settings_singleton check (id = 1)
);

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

-- Seed the single row with the app's previous hardcoded defaults (12x6, racks_owned unset).
insert into public.warhammer_rack_settings (id, rows_per_rack, columns_per_rack, racks_owned)
values (1, 12, 6, null)
on conflict (id) do nothing;
