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
