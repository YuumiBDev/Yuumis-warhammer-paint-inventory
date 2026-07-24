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
