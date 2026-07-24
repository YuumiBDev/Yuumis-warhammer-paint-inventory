namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static GeneralGuide RocksWallsBuildingsGuide() => new("Rocks, Walls & Buildings",
    [
        new(BlockKind.Text, Text: "A comprehensive Citadel paint guide for painting rocks, walls, and buildings across Warhammer 40K factions. The Agrax Earthshade + Dawnstone + Administratum Grey combo is the backbone of nearly every stone recipe."),

        new(BlockKind.H1, Text: "General Stone / Ruins (Universal)"),

        new(BlockKind.H2, Text: "Classic Grey Stone"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Mechanicus Standard Grey", "Base"],
            ["Shade", "Nuln Oil", "Shade"],
            ["Drybrush", "Dawnstone", "Layer"],
            ["Drybrush", "Administratum Grey", "Layer"],
            ["Final drybrush", "Underhive Ash", "Dry"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Painting Hub", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Citadel Colour App", "https://www.games-workshop.com/en-GB/Citadel-Colour-App"),
            ("Warhammer TV YouTube", "https://www.youtube.com/@WarhammerTV"),
        ]),

        new(BlockKind.H2, Text: "Dark Grimdark Stone"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Corvus Black", "Base"],
            ["Drybrush", "Mechanicus Standard Grey", "Base"],
            ["Shade", "Nuln Oil", "Shade"],
            ["Drybrush", "Dawnstone", "Layer"],
            ["Edge", "Administratum Grey", "Layer"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Painting Hub", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Midwinter Minis YouTube", "https://www.youtube.com/@MidwinterMinis"),
        ]),

        new(BlockKind.H2, Text: "Sandy Desert Stone"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Zandri Dust", "Base"],
            ["Shade", "Agrax Earthshade", "Shade"],
            ["Layer", "Ushabti Bone", "Layer"],
            ["Highlight", "Screaming Skull", "Layer"],
            ["Final drybrush", "Tyrant Skull", "Dry"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Painting Hub", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Citadel Colour App", "https://www.games-workshop.com/en-GB/Citadel-Colour-App"),
            ("Warhammer TV YouTube", "https://www.youtube.com/@WarhammerTV"),
        ]),

        new(BlockKind.H2, Text: "Quick Contrast Method"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Grey Seer", "Base"],
            ["Contrast", "Basilicanum Grey", "Contrast"],
            ["Drybrush", "Dawnstone", "Layer"],
            ["Final", "Underhive Ash", "Dry"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Contrast Paints Guide", "https://www.warhammer-community.com/en-gb/articles/contrast-paints/"),
            ("Warhammer TV YouTube", "https://www.youtube.com/@WarhammerTV"),
            ("Zorpazorp YouTube", "https://www.youtube.com/@Zorpazorp"),
        ]),

        new(BlockKind.H1, Text: "Imperium — Space Marines, Astra Militarum, Fortresses"),

        new(BlockKind.H2, Text: "Rockcrete Walls"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Mechanicus Standard Grey", "Base"],
            ["Shade", "Nuln Oil", "Shade"],
            ["Drybrush", "Dawnstone", "Layer"],
            ["Drybrush", "Administratum Grey", "Layer"],
            ["Edge", "Longbeard Grey", "Dry"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Sector Imperialis guides", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Warhammer TV YouTube", "https://www.youtube.com/@WarhammerTV"),
            ("Citadel Colour App", "https://www.games-workshop.com/en-GB/Citadel-Colour-App"),
        ]),

        new(BlockKind.H2, Text: "Marble / Sandstone Cathedral Walls"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Wraithbone or Pallid Wych Flesh", "Base/Layer"],
            ["Shade", "Seraphim Sepia", "Shade"],
            ["Layer", "Ushabti Bone", "Layer"],
            ["Highlight", "Screaming Skull", "Layer"],
            ["Final drybrush", "Terminatus Stone", "Dry"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Painting Hub", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Painting Sanctuary YouTube", "https://www.youtube.com/@paintingsanctuary"),
        ]),

        new(BlockKind.H2, Text: "Arched Gothic Stonework (Dark Marble)"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Abaddon Black", "Base"],
            ["Drybrush", "Mechanicus Standard Grey", "Base"],
            ["Shade", "Nuln Oil", "Shade"],
            ["Drybrush", "Dawnstone", "Layer"],
            ["Edge", "Administratum Grey", "Layer"],
            ["Gold trim", "Retributor Armour → Reikland Fleshshade → Auric Armour Gold", "Base/Shade/Layer"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Gothic Architecture guides", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Warhammer TV YouTube", "https://www.youtube.com/@WarhammerTV"),
            ("GW Paint Range", "https://www.games-workshop.com/en-GB/Paint"),
        ]),

        new(BlockKind.H1, Text: "Chaos Undivided — Dark Corrupted Stone"),

        new(BlockKind.H2, Text: "Chaos Fortifications"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Corvus Black", "Base"],
            ["Drybrush", "Skavenblight Dinge", "Layer"],
            ["Shade", "Nuln Oil", "Shade"],
            ["Drybrush", "Stormvermin Fur", "Layer"],
            ["Edge highlight", "Eshin Grey", "Layer"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Chaos painting guides", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Warhammer TV YouTube", "https://www.youtube.com/@WarhammerTV"),
            ("Midwinter Minis YouTube", "https://www.youtube.com/@MidwinterMinis"),
        ]),

        new(BlockKind.H2, Text: "Corrupted Brass & Stone (Chaos Bastions)"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Stone: Base", "Corvus Black → Eshin Grey drybrush", "Base/Layer"],
            ["Metal: Base", "Warplock Bronze", "Base"],
            ["Shade", "Agrax Earthshade", "Shade"],
            ["Layer", "Hashut Copper", "Layer"],
            ["Verdigris", "Nihilakh Oxide", "Technical"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Chaos Metal & Verdigris guides", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Citadel Colour App — Nihilakh Oxide tutorial", "https://www.games-workshop.com/en-GB/Citadel-Colour-App"),
            ("Midwinter Minis YouTube", "https://www.youtube.com/@MidwinterMinis"),
        ]),

        new(BlockKind.H1, Text: "Nurgle / Death Guard — Rotting, Diseased Walls"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Death Guard Green", "Base"],
            ["Shade", "Agrax Earthshade", "Shade"],
            ["Shade", "Athonian Camoshade", "Shade"],
            ["Layer", "Nurgling Green (raised edges)", "Layer"],
            ["Technical", "Typhus Corrosion (cracks & rot)", "Technical"],
            ["Technical", "Nurgle's Rot (slime pools)", "Technical"],
            ["Bonus", "Plaguebearer Flesh (pale stone areas)", "Contrast"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Death Guard Painting Guide", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Warhammer TV YouTube", "https://www.youtube.com/@WarhammerTV"),
            ("Citadel Colour App — Nurgle's Rot & Typhus Corrosion tutorials", "https://www.games-workshop.com/en-GB/Citadel-Colour-App"),
        ]),

        new(BlockKind.H1, Text: "Khorne — Blood-Stained Dark Stone"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Abaddon Black", "Base"],
            ["Drybrush", "Skavenblight Dinge", "Layer"],
            ["Shade", "Nuln Oil", "Shade"],
            ["Edge", "Eshin Grey", "Layer"],
            ["Rune grooves", "Khorne Red → Evil Sunz Scarlet", "Base/Layer"],
            ["Gore", "Blood for the Blood God", "Technical"],
            ["Brass trim", "Warplock Bronze → Hashut Copper", "Base/Layer"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Khorne & World Eaters guides", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Citadel Colour App — Blood for the Blood God tutorial", "https://www.games-workshop.com/en-GB/Citadel-Colour-App"),
            ("Warhammer TV YouTube", "https://www.youtube.com/@WarhammerTV"),
        ]),

        new(BlockKind.H1, Text: "Tzeentch / Thousand Sons — Arcane Sorcerous Stone"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Mechanicus Standard Grey", "Base"],
            ["Shade", "Drakenhof Nightshade (blue tint)", "Shade"],
            ["Drybrush", "Administratum Grey", "Layer"],
            ["Glowing runes", "Ahriman Blue → Baharroth Blue", "Layer"],
            ["Technical", "Tesseract Glow (OSL on rune cracks)", "Technical"],
            ["Gold trim", "Retributor Armour → Auric Armour Gold", "Base/Layer"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Thousand Sons Painting Guide", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Citadel Colour App — Tesseract Glow OSL tutorial", "https://www.games-workshop.com/en-GB/Citadel-Colour-App"),
            ("Warhammer TV YouTube", "https://www.youtube.com/@WarhammerTV"),
            ("Midwinter Minis YouTube", "https://www.youtube.com/@MidwinterMinis"),
        ]),

        new(BlockKind.H1, Text: "Orks — Ramshackle Metal & Rocky Terrain"),

        new(BlockKind.H2, Text: "Rusty Scrap Metal Walls"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Leadbelcher", "Base"],
            ["Shade", "Nuln Oil + Agrax Earthshade", "Shade"],
            ["Technical", "Typhus Corrosion", "Technical"],
            ["Drybrush", "Ryza Rust", "Dry"],
            ["Highlight", "Ironbreaker", "Layer"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Orks Painting Guide", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Citadel Colour App — Ryza Rust & Typhus Corrosion tutorials", "https://www.games-workshop.com/en-GB/Citadel-Colour-App"),
            ("Warhammer TV YouTube", "https://www.youtube.com/@WarhammerTV"),
            ("The Honest Wargamer YouTube", "https://www.youtube.com/@TheHonestWargamer"),
        ]),

        new(BlockKind.H2, Text: "Ork Rocky Ground"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Rhinox Hide", "Base"],
            ["Layer", "Mournfang Brown", "Base"],
            ["Shade", "Agrax Earthshade", "Shade"],
            ["Drybrush", "Skrag Brown", "Layer"],
            ["Drybrush", "Karak Stone", "Layer"],
            ["Final", "Tau Light Ochre", "Layer"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Basing & Rocky Ground guides", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Citadel Colour App", "https://www.games-workshop.com/en-GB/Citadel-Colour-App"),
        ]),

        new(BlockKind.H1, Text: "Necrons — Ancient Tomb World Stone"),

        new(BlockKind.H2, Text: "Dark Necrodermis Rock"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Corvus Black", "Base"],
            ["Drybrush", "Eshin Grey", "Layer"],
            ["Drybrush", "Administratum Grey", "Layer"],
            ["Shade", "Nuln Oil", "Shade"],
            ["Highlight", "Underhive Ash", "Dry"],
            ["Metal panels", "Leadbelcher → Nuln Oil → Ironbreaker", "Base/Shade/Layer"],
            ["Verdigris", "Nihilakh Oxide", "Technical"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Necron Painting Guide", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Citadel Colour App — Nihilakh Oxide tutorial", "https://www.games-workshop.com/en-GB/Citadel-Colour-App"),
            ("Warhammer TV YouTube", "https://www.youtube.com/@WarhammerTV"),
        ]),

        new(BlockKind.H2, Text: "Glowing Tomb Walls (Gauss Energy)"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Stone", "As per Dark Necrodermis Rock above", "—"],
            ["Glow recesses", "Gauss Blaster Green", "Layer"],
            ["Glow edge", "Moot Green", "Layer"],
            ["OSL", "Tesseract Glow", "Technical"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Necron Gauss Glow guides", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Citadel Colour App — Tesseract Glow OSL tutorial", "https://www.games-workshop.com/en-GB/Citadel-Colour-App"),
            ("Midwinter Minis YouTube", "https://www.youtube.com/@MidwinterMinis"),
        ]),

        new(BlockKind.H1, Text: "T'au — Clean Utilitarian Panels"),

        new(BlockKind.H2, Text: "Standard T'au Panels"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Grey Seer", "Base"],
            ["Wash recesses", "Basilicanum Grey", "Contrast"],
            ["Layer", "Administratum Grey", "Layer"],
            ["Highlight", "Ulthuan Grey", "Layer"],
            ["Edge", "White Scar", "Layer"],
            ["Panel lines", "Drakenhof Nightshade (thin)", "Shade"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — T'au Painting Guide", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Citadel Colour App", "https://www.games-workshop.com/en-GB/Citadel-Colour-App"),
            ("Warhammer TV YouTube", "https://www.youtube.com/@WarhammerTV"),
        ]),

        new(BlockKind.H2, Text: "T'au Desert Fortifications"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Wraithbone", "Base"],
            ["Contrast", "Aggaros Dunes", "Contrast"],
            ["Layer", "Karak Stone", "Layer"],
            ["Highlight", "Screaming Skull", "Layer"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Contrast Paints Guide", "https://www.warhammer-community.com/en-gb/articles/contrast-paints/"),
            ("Zorpazorp YouTube", "https://www.youtube.com/@Zorpazorp"),
        ]),

        new(BlockKind.H1, Text: "Aeldari / Craftworlds — Wraithbone Architecture"),

        new(BlockKind.H2, Text: "Standard Wraithbone"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Wraithbone", "Base"],
            ["Shade", "Seraphim Sepia", "Shade"],
            ["Layer", "Screaming Skull", "Layer"],
            ["Highlight", "Ulthuan Grey", "Layer"],
            ["Edge", "White Scar", "Layer"],
            ["Gem accents", "Aeldari Emerald + Soulstone Blue", "Contrast/Technical"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Aeldari Painting Guide", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Citadel Colour App", "https://www.games-workshop.com/en-GB/Citadel-Colour-App"),
            ("Warhammer TV YouTube", "https://www.youtube.com/@WarhammerTV"),
        ]),

        new(BlockKind.H2, Text: "Craftworld Ruins (Darker Tone)"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Rakarth Flesh", "Base"],
            ["Shade", "Agrax Earthshade", "Shade"],
            ["Layer", "Karak Stone → Screaming Skull", "Layer"],
            ["Final", "Terminatus Stone", "Dry"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Aeldari Ruins guides", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Painting Sanctuary YouTube", "https://www.youtube.com/@paintingsanctuary"),
        ]),

        new(BlockKind.H1, Text: "Drukhari — Dark Jagged Spires & Webway Architecture"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Abaddon Black", "Base"],
            ["Layer", "Incubi Darkness (panels)", "Base"],
            ["Shade", "Nuln Oil", "Shade"],
            ["Edge", "Kabalite Green", "Layer"],
            ["Sharp edge", "Sybarite Green", "Layer"],
            ["Bone spires", "Rakarth Flesh → Ushabti Bone → Screaming Skull", "Base/Layer"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Drukhari Painting Guide", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Warhammer TV YouTube", "https://www.youtube.com/@WarhammerTV"),
            ("Midwinter Minis YouTube", "https://www.youtube.com/@MidwinterMinis"),
        ]),

        new(BlockKind.H1, Text: "Tyranids — Bio-Organic Terrain & Living Structures"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Rakarth Flesh or Morghast Bone", "Base"],
            ["Shade", "Agrax Earthshade", "Shade"],
            ["Layer", "Ushabti Bone", "Layer"],
            ["Highlight", "Screaming Skull", "Layer"],
            ["Chitin structures", "Rhinox Hide → Dryad Bark → Gorthor Brown", "Base/Layer"],
            ["Bio-slime", "Nurgle's Rot", "Technical"],
            ["Alien glow", "Aeldari Emerald or Warp Lightning (recesses)", "Contrast"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Tyranids Painting Guide", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Warhammer TV YouTube", "https://www.youtube.com/@WarhammerTV"),
            ("Citadel Colour App — Nurgle's Rot tutorial", "https://www.games-workshop.com/en-GB/Citadel-Colour-App"),
        ]),

        new(BlockKind.H1, Text: "Space Wolves — Nordic Ice & Frozen Stone"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "The Fang", "Base"],
            ["Shade", "Nuln Oil", "Shade"],
            ["Drybrush", "Russ Grey", "Layer"],
            ["Drybrush", "Administratum Grey", "Layer"],
            ["Highlight", "Fenrisian Grey", "Layer"],
            ["Snow/ice", "Valhallan Blizzard", "Technical"],
            ["Ice cracks", "Pylar Glacier", "Contrast"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Space Wolves Painting Guide", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Citadel Colour App — Valhallan Blizzard snow tutorial", "https://www.games-workshop.com/en-GB/Citadel-Colour-App"),
            ("Warhammer TV YouTube", "https://www.youtube.com/@WarhammerTV"),
        ]),

        new(BlockKind.H1, Text: "Dark Angels — Verdant Jungle Stone & Fortress Monasteries"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Stone base", "Mechanicus Standard Grey", "Base"],
            ["Shade", "Nuln Oil", "Shade"],
            ["Drybrush", "Dawnstone → Administratum Grey", "Layer"],
            ["Moss/lichen", "Militarum Green (in cracks)", "Contrast"],
            ["Dark trim", "Caliban Green → Dark Angels Green", "Base/Contrast"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Dark Angels Painting Guide", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Warhammer Community — Contrast Paints Guide", "https://www.warhammer-community.com/en-gb/articles/contrast-paints/"),
            ("Citadel Colour App", "https://www.games-workshop.com/en-GB/Citadel-Colour-App"),
        ]),

        new(BlockKind.H1, Text: "Genestealer Cults / Hive Cities — Industrial Underhive"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint", "Type"], TableRows:
        [
            ["Base", "Mechanicus Standard Grey", "Base"],
            ["Shade", "Nuln Oil", "Shade"],
            ["Technical", "Astrogranite (textured concrete)", "Technical"],
            ["Drybrush", "Dawnstone", "Layer"],
            ["Rust streaks", "Typhus Corrosion → Ryza Rust", "Technical/Dry"],
            ["Grime wash", "Agrax Earthshade", "Shade"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("Warhammer Community — Necromunda & Hive City guides", "https://www.warhammer-community.com/en-gb/painting-hobby/"),
            ("Citadel Colour App — Astrogranite tutorial", "https://www.games-workshop.com/en-GB/Citadel-Colour-App"),
            ("The Honest Wargamer YouTube", "https://www.youtube.com/@TheHonestWargamer"),
        ]),

        new(BlockKind.H1, Text: "Key Dry Paints for Rocks & Stone (Any Faction)"),
        new(BlockKind.Table, TableHeader: ["Paint", "Best Use"], TableRows:
        [
            ["Terminatus Stone", "Sandy/pale stone final highlight"],
            ["Tyrant Skull", "Bone & desert stone highlight"],
            ["Underhive Ash", "Dark grey stone final drybrush"],
            ["Longbeard Grey", "Mid-tone grey stone highlight"],
            ["Praxeti White", "Extreme white stone highlight"],
            ["Ryza Rust", "Rust streaks on metal or corroded stone"],
        ]),
        new(BlockKind.Links, Links:
        [
            ("GW Citadel Dry Paint Range", "https://www.games-workshop.com/en-GB/Paint"),
            ("Warhammer TV YouTube — How to Drybrush guide", "https://www.youtube.com/@WarhammerTV"),
            ("Citadel Colour App", "https://www.games-workshop.com/en-GB/Citadel-Colour-App"),
        ]),

        new(BlockKind.Text, Text: "Disclaimer: all paint names, product names, and faction names are trademarks of Games Workshop Ltd. This guide is an unofficial compilation for personal hobby use only."),
    ]);
}
