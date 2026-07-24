namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static FactionGuide BuildRocksWallsBuildingsGuide() => new("Rocks, Walls & Buildings",
    [
        new("Guide", "A comprehensive Citadel paint guide for painting rocks, walls, and buildings across Warhammer 40K factions. The Agrax Earthshade + Dawnstone + Administratum Grey combo is the backbone of nearly every stone recipe. Disclaimer: all paint names, product names, and faction names are trademarks of Games Workshop Ltd. This guide is an unofficial compilation for personal hobby use only.", [], IsScheme: true),

        new("Classic Grey Stone", null,
        [
            new("Recipe",
            [
                new("Base", "Mechanicus Standard Grey"),
                new("Shade", "Nuln Oil"),
                new("Drybrush", "Dawnstone"),
                new("Drybrush", "Administratum Grey"),
                new("Final drybrush", "Underhive Ash"),
            ]),
        ]),

        new("Dark Grimdark Stone", null,
        [
            new("Recipe",
            [
                new("Base", "Corvus Black"),
                new("Drybrush", "Mechanicus Standard Grey"),
                new("Shade", "Nuln Oil"),
                new("Drybrush", "Dawnstone"),
                new("Edge", "Administratum Grey"),
            ]),
        ]),

        new("Sandy Desert Stone", null,
        [
            new("Recipe",
            [
                new("Base", "Zandri Dust"),
                new("Shade", "Agrax Earthshade"),
                new("Layer", "Ushabti Bone"),
                new("Highlight", "Screaming Skull"),
                new("Final drybrush", "Tyrant Skull"),
            ]),
        ]),

        new("Quick Contrast Method", null,
        [
            new("Recipe",
            [
                new("Base", "Grey Seer"),
                new("Contrast", "Basilicanum Grey"),
                new("Drybrush", "Dawnstone"),
                new("Final", "Underhive Ash"),
            ]),
        ]),

        new("Rockcrete Walls", null,
        [
            new("Recipe",
            [
                new("Base", "Mechanicus Standard Grey"),
                new("Shade", "Nuln Oil"),
                new("Drybrush", "Dawnstone"),
                new("Drybrush", "Administratum Grey"),
                new("Edge", "Longbeard Grey"),
            ]),
        ]),

        new("Marble / Sandstone Cathedral Walls", null,
        [
            new("Recipe",
            [
                new("Base", "Wraithbone", "or Pallid Wych Flesh"),
                new("Shade", "Seraphim Sepia"),
                new("Layer", "Ushabti Bone"),
                new("Highlight", "Screaming Skull"),
                new("Final drybrush", "Terminatus Stone"),
            ]),
        ]),

        new("Arched Gothic Stonework (Dark Marble)", null,
        [
            new("Recipe",
            [
                new("Base", "Abaddon Black"),
                new("Drybrush", "Mechanicus Standard Grey"),
                new("Shade", "Nuln Oil"),
                new("Drybrush", "Dawnstone"),
                new("Edge", "Administratum Grey"),
                new("Gold trim", "Retributor Armour", "→ Reikland Fleshshade → Auric Armour Gold"),
            ]),
        ]),

        new("Chaos Fortifications", null,
        [
            new("Recipe",
            [
                new("Base", "Corvus Black"),
                new("Drybrush", "Skavenblight Dinge"),
                new("Shade", "Nuln Oil"),
                new("Drybrush", "Stormvermin Fur"),
                new("Edge highlight", "Eshin Grey"),
            ]),
        ]),

        new("Corrupted Brass & Stone (Chaos Bastions)", null,
        [
            new("Recipe",
            [
                new("Stone: Base", "Corvus Black", "→ Eshin Grey drybrush"),
                new("Metal: Base", "Warplock Bronze"),
                new("Shade", "Agrax Earthshade"),
                new("Layer", "Hashut Copper"),
                new("Verdigris", "Nihilakh Oxide"),
            ]),
        ]),

        new("Nurgle / Death Guard — Rotting, Diseased Walls", null,
        [
            new("Recipe",
            [
                new("Base", "Death Guard Green"),
                new("Shade", "Agrax Earthshade"),
                new("Shade", "Athonian Camoshade"),
                new("Layer", "Nurgling Green", "raised edges"),
                new("Technical", "Typhus Corrosion", "cracks & rot"),
                new("Technical", "Nurgle's Rot", "slime pools"),
                new("Bonus", "Plaguebearer Flesh", "pale stone areas"),
            ]),
        ]),

        new("Khorne — Blood-Stained Dark Stone", null,
        [
            new("Recipe",
            [
                new("Base", "Abaddon Black"),
                new("Drybrush", "Skavenblight Dinge"),
                new("Shade", "Nuln Oil"),
                new("Edge", "Eshin Grey"),
                new("Rune grooves", "Khorne Red", "→ Evil Sunz Scarlet"),
                new("Gore", "Blood for the Blood God"),
                new("Brass trim", "Warplock Bronze", "→ Hashut Copper"),
            ]),
        ]),

        new("Tzeentch / Thousand Sons — Arcane Sorcerous Stone", null,
        [
            new("Recipe",
            [
                new("Base", "Mechanicus Standard Grey"),
                new("Shade", "Drakenhof Nightshade", "blue tint"),
                new("Drybrush", "Administratum Grey"),
                new("Glowing runes", "Ahriman Blue", "→ Baharroth Blue"),
                new("Technical", "Tesseract Glow", "OSL on rune cracks"),
                new("Gold trim", "Retributor Armour", "→ Auric Armour Gold"),
            ]),
        ]),

        new("Rusty Scrap Metal Walls", null,
        [
            new("Recipe",
            [
                new("Base", "Leadbelcher"),
                new("Shade", "Nuln Oil", "+ Agrax Earthshade"),
                new("Technical", "Typhus Corrosion"),
                new("Drybrush", "Ryza Rust"),
                new("Highlight", "Ironbreaker"),
            ]),
        ]),

        new("Ork Rocky Ground", null,
        [
            new("Recipe",
            [
                new("Base", "Rhinox Hide"),
                new("Layer", "Mournfang Brown"),
                new("Shade", "Agrax Earthshade"),
                new("Drybrush", "Skrag Brown"),
                new("Drybrush", "Karak Stone"),
                new("Final", "Tau Light Ochre"),
            ]),
        ]),

        new("Dark Necrodermis Rock", null,
        [
            new("Recipe",
            [
                new("Base", "Corvus Black"),
                new("Drybrush", "Eshin Grey"),
                new("Drybrush", "Administratum Grey"),
                new("Shade", "Nuln Oil"),
                new("Highlight", "Underhive Ash"),
                new("Metal panels", "Leadbelcher", "→ Nuln Oil → Ironbreaker"),
                new("Verdigris", "Nihilakh Oxide"),
            ]),
        ]),

        new("Glowing Tomb Walls (Gauss Energy)", null,
        [
            new("Recipe",
            [
                new("Base", "Corvus Black"),
                new("Drybrush", "Eshin Grey"),
                new("Drybrush", "Administratum Grey"),
                new("Shade", "Nuln Oil"),
                new("Highlight", "Underhive Ash"),
                new("Metal panels", "Leadbelcher", "→ Nuln Oil → Ironbreaker"),
                new("Verdigris", "Nihilakh Oxide"),
                new("Glow recesses", "Gauss Blaster Green"),
                new("Glow edge", "Moot Green"),
                new("OSL", "Tesseract Glow"),
            ]),
        ]),

        new("Standard T'au Panels", null,
        [
            new("Recipe",
            [
                new("Base", "Grey Seer"),
                new("Wash recesses", "Basilicanum Grey"),
                new("Layer", "Administratum Grey"),
                new("Highlight", "Ulthuan Grey"),
                new("Edge", "White Scar"),
                new("Panel lines", "Drakenhof Nightshade", "thin"),
            ]),
        ]),

        new("T'au Desert Fortifications", null,
        [
            new("Recipe",
            [
                new("Base", "Wraithbone"),
                new("Contrast", "Aggaros Dunes"),
                new("Layer", "Karak Stone"),
                new("Highlight", "Screaming Skull"),
            ]),
        ]),

        new("Standard Wraithbone", null,
        [
            new("Recipe",
            [
                new("Base", "Wraithbone"),
                new("Shade", "Seraphim Sepia"),
                new("Layer", "Screaming Skull"),
                new("Highlight", "Ulthuan Grey"),
                new("Edge", "White Scar"),
                new("Gem accents", "Aeldari Emerald", "+ Soulstone Blue"),
            ]),
        ]),

        new("Craftworld Ruins (Darker Tone)", null,
        [
            new("Recipe",
            [
                new("Base", "Rakarth Flesh"),
                new("Shade", "Agrax Earthshade"),
                new("Layer", "Karak Stone", "→ Screaming Skull"),
                new("Final", "Terminatus Stone"),
            ]),
        ]),

        new("Drukhari — Dark Jagged Spires & Webway Architecture", null,
        [
            new("Recipe",
            [
                new("Base", "Abaddon Black"),
                new("Layer", "Incubi Darkness", "panels"),
                new("Shade", "Nuln Oil"),
                new("Edge", "Kabalite Green"),
                new("Sharp edge", "Sybarite Green"),
                new("Bone spires", "Rakarth Flesh", "→ Ushabti Bone → Screaming Skull"),
            ]),
        ]),

        new("Tyranids — Bio-Organic Terrain & Living Structures", null,
        [
            new("Recipe",
            [
                new("Base", "Rakarth Flesh", "or Morghast Bone"),
                new("Shade", "Agrax Earthshade"),
                new("Layer", "Ushabti Bone"),
                new("Highlight", "Screaming Skull"),
                new("Chitin structures", "Rhinox Hide", "→ Dryad Bark → Gorthor Brown"),
                new("Bio-slime", "Nurgle's Rot"),
                new("Alien glow", "Aeldari Emerald", "or Warp Lightning (recesses)"),
            ]),
        ]),

        new("Space Wolves — Nordic Ice & Frozen Stone", null,
        [
            new("Recipe",
            [
                new("Base", "The Fang"),
                new("Shade", "Nuln Oil"),
                new("Drybrush", "Russ Grey"),
                new("Drybrush", "Administratum Grey"),
                new("Highlight", "Fenrisian Grey"),
                new("Snow/ice", "Valhallan Blizzard"),
                new("Ice cracks", "Pylar Glacier"),
            ]),
        ]),

        new("Dark Angels — Verdant Jungle Stone & Fortress Monasteries", null,
        [
            new("Recipe",
            [
                new("Stone base", "Mechanicus Standard Grey"),
                new("Shade", "Nuln Oil"),
                new("Drybrush", "Dawnstone", "→ Administratum Grey"),
                new("Moss/lichen", "Militarum Green", "in cracks"),
                new("Dark trim", "Caliban Green", "→ Dark Angels Green"),
            ]),
        ]),

        new("Genestealer Cults / Hive Cities — Industrial Underhive", null,
        [
            new("Recipe",
            [
                new("Base", "Mechanicus Standard Grey"),
                new("Shade", "Nuln Oil"),
                new("Technical", "Astrogranite", "textured concrete"),
                new("Drybrush", "Dawnstone"),
                new("Rust streaks", "Typhus Corrosion", "→ Ryza Rust"),
                new("Grime wash", "Agrax Earthshade"),
            ]),
        ]),

        new("Key Dry Paints for Rocks & Stone (Any Faction)", null,
        [
            new("Recipe",
            [
                new("Sandy/pale stone final highlight", "Terminatus Stone"),
                new("Bone & desert stone highlight", "Tyrant Skull"),
                new("Dark grey stone final drybrush", "Underhive Ash"),
                new("Mid-tone grey stone highlight", "Longbeard Grey"),
                new("Extreme white stone highlight", "Praxeti White"),
                new("Rust streaks on metal or corroded stone", "Ryza Rust"),
            ]),
        ]),
    ], Category: GuideCategory.General, Sources:
    [
        new("Official", [
            new("Warhammer Community — Painting Hub", "Official painting guides and hobby articles", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            new("Warhammer Community — Contrast Paints Guide", "Official guide to Contrast paint techniques", "https://www.warhammer-community.com/en-gb/articles/contrast-paints/"),
            new("Citadel Colour App", "Official app with paint recipes and tutorials", "https://www.games-workshop.com/en-GB/Citadel-Colour-App"),
            new("GW Citadel Paint Range", "Official Citadel paint store range", "https://www.games-workshop.com/en-GB/Paint"),
        ]),
        new("Community", [
            new("Warhammer TV YouTube", "Official video painting tutorials", "https://www.youtube.com/@WarhammerTV"),
            new("Midwinter Minis YouTube", "Video walkthroughs and painting guides", "https://www.youtube.com/@MidwinterMinis"),
            new("Zorpazorp YouTube", "Contrast paint and speed painting tutorials", "https://www.youtube.com/@Zorpazorp"),
            new("Painting Sanctuary YouTube", "In-depth painting tutorials", "https://www.youtube.com/@paintingsanctuary"),
            new("The Honest Wargamer YouTube", "Hobby and painting content", "https://www.youtube.com/@TheHonestWargamer"),
        ]),
    ]);
}
