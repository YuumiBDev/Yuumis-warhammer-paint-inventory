namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> SororitasOverall =
    [
        new("Armour (White)",
        [
            new("Basecoat", "Corax White"),
            new("Recess Shade", "Celestra Grey", "thinned wash into panel lines"),
            new("Layer", "Ulthuan Grey"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Robes / Cloth",
        [
            new("Basecoat", "Corax White"),
            new("Shade (folds)", "Administratum Grey"),
            new("Layer", "Dawnstone"),
            new("Highlight", "White Scar", "fine edge highlight on fold ridges"),
        ]),
        new("Hair (All-White Variant)",
        [
            new("Basecoat", "Corax White"),
            new("Root Shade", "Celestra Grey", "at the roots/part-line"),
            new("Layer", "Ulthuan Grey"),
            new("Highlight", "White Scar", "on the topmost strands"),
            new("Warm Tint (optional)", "Screaming Skull", "very thin glaze for a warmer white"),
        ]),
        new("Skin",
        [
            new("Basecoat", "Kislev Flesh"),
            new("Shade", "Reikland Fleshshade"),
            new("Layer", "Cadian Fleshtone"),
            new("Highlight", "Screaming Skull", "dry highlight on cheekbones/nose"),
        ]),
        new("Metal Trim & Details",
        [
            new("Basecoat", "Retributor Armour"),
            new("Shade", "Agrax Earthshade", "recess wash"),
            new("Edge Highlight", "Runelord Brass"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Dryad Bark"),
        ]),
    ];

    // The six Orders Militant each field their own canon colour scheme — selectable
    // alongside the default (SororitasOverall, now named Order of the Sacred Rose below).
    private static readonly List<Section> OrderOurMartyredLady =
    [
        new("Armour (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer / Drybrush", "Eshin Grey"),
            new("Edge Highlight", "White Scar", "fine line only"),
        ]),
        new("Trim & Metal (Red)",
        [
            new("Basecoat", "Mephiston Red"),
            new("Shade", "Carroburg Crimson"),
            new("Edge Highlight", "Wild Rider Red"),
            new("Metal", "Leadbelcher", "Nuln Oil shade, Runefang Steel edge"),
        ]),
        new("Details",
        [
            new("Purity Seals / Parchment", "Screaming Skull", "Agrax Earthshade wash"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Auric Armour Gold"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static readonly List<Section> OrderBloodyRose =
    [
        new("Armour (Maroon)",
        [
            new("Basecoat", "Khorne Red"),
            new("Recess Shade", "Carroburg Crimson"),
            new("Layer", "Mephiston Red"),
            new("Edge Highlight", "Wazdakka Red"),
        ]),
        new("Trim & Metal (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Edge Highlight", "Eshin Grey"),
            new("Metal", "Leadbelcher", "Nuln Oil shade, Runefang Steel edge"),
        ]),
        new("Details",
        [
            new("Rose Filigree", "Auric Armour Gold"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Auric Armour Gold"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static readonly List<Section> OrderValorousHeart =
    [
        new("Armour (Yellow)",
        [
            new("Basecoat", "Averland Sunset"),
            new("Recess Shade", "Agrax Earthshade"),
            new("Layer", "Yriel Yellow"),
            new("Edge Highlight", "Dorn Yellow"),
        ]),
        new("Trim & Metal (Red)",
        [
            new("Basecoat", "Mephiston Red"),
            new("Shade", "Carroburg Crimson"),
            new("Edge Highlight", "Wild Rider Red"),
            new("Metal", "Retributor Armour", "Reikland Fleshshade shade, Auric Armour Gold edge"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Auric Armour Gold"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static readonly List<Section> OrderArgentShroud =
    [
        new("Armour (Dark Blue)",
        [
            new("Basecoat", "Kantor Blue"),
            new("Recess Shade", "Drakenhof Nightshade"),
            new("Layer", "Macragge Blue"),
            new("Edge Highlight", "Baharroth Blue"),
        ]),
        new("Trim & Metal (Silver)",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Stormhost Silver"),
        ]),
        new("Details",
        [
            new("Shroud / Veil", "Corax White", "Celestra Grey shade"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Stormhost Silver"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static readonly List<Section> OrderEbonChalice =
    [
        new("Armour (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer / Drybrush", "Eshin Grey"),
            new("Edge Highlight", "White Scar", "fine line only"),
        ]),
        new("Trim & Metal (Gold)",
        [
            new("Basecoat", "Retributor Armour"),
            new("Shade", "Reikland Fleshshade"),
            new("Edge Highlight", "Auric Armour Gold"),
        ]),
        new("Details",
        [
            new("Chalice Icon", "Auric Armour Gold", "Agrax Earthshade recess"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Auric Armour Gold"),
            new("Basing", "Dryad Bark"),
        ]),
    ];

    private static FactionGuide BuildSororitas() => new("Adepta Sororitas",
    [
        new("Order of the Sacred Rose", "The default and most iconic Order Militant — white armour, gold trim.", SororitasOverall, IsScheme: true),

        new("Order of Our Martyred Lady", "One of the six Orders Militant — black armour, red trim.", OrderOurMartyredLady, IsScheme: true),
        new("Order of the Bloody Rose", "One of the six Orders Militant — maroon armour, black trim.", OrderBloodyRose, IsScheme: true),
        new("Order of the Valorous Heart", "One of the six Orders Militant — yellow armour, red trim.", OrderValorousHeart, IsScheme: true),
        new("Order of the Argent Shroud", "One of the six Orders Militant — dark blue armour, silver trim.", OrderArgentShroud, IsScheme: true),
        new("Order of the Ebon Chalice", "One of the six Orders Militant — black armour, gold trim.", OrderEbonChalice, IsScheme: true),

        FactionUnit(SororitasOverall, "Battle Sisters Squad", "Unit-Specific Details",
        [
            new("Bolter Casing", "Abaddon Black"),
            new("Purity Seal Parchment", "Screaming Skull", "then Agrax Earthshade wash"),
            new("Squad/Rank Trim", "Runelord Brass"),
        ]),

        FactionUnit(SororitasOverall, "Seraphim", "Unit-Specific Details",
        [
            new("Jump Pack Casing", "Retributor Armour", "Agrax Earthshade wash"),
            new("Wing Feathers", "Corax White", "shade Celestra Grey, highlight White Scar — same as hair"),
            new("Pistol Housings", "Abaddon Black"),
        ]),

        FactionUnit(SororitasOverall, "Dominions", "Unit-Specific Details",
        [
            new("Special Weapon Housing", "Abaddon Black", "melta/plasma casings"),
            new("Weapon Vents", "Runelord Brass", "highlight only"),
            new("Ammo Satchels", "Dryad Bark"),
        ]),

        FactionUnit(SororitasOverall, "Retributors", "Unit-Specific Details",
        [
            new("Heavy Weapon Housing", "Abaddon Black", "heavy bolter / multi-melta"),
            new("Heavy Weapon Trim", "Runelord Brass"),
            new("Reinforced Plating", "White Scar", "extra edge highlight pass on bulk armour"),
        ]),

        FactionUnit(SororitasOverall, "Celestine", "Unit-Specific Details",
        [
            new("Wings", "Corax White", "shade Celestra Grey, highlight White Scar"),
            new("Divine Glow / Halo", "Screaming Skull", "thin glaze over White Scar for a radiant look"),
            new("Sword Hilt", "Runelord Brass"),
            new("Sword Grip", "Abaddon Black"),
        ]),

        FactionUnit(SororitasOverall, "Canoness", "Unit-Specific Details",
        [
            new("Cloak Lining (rank accent)", "Mephiston Red"),
            new("Power Weapon Glow", "Screaming Skull", "thin glaze"),
            new("Personal Heraldry / Filigree", "Runelord Brass"),
        ]),

        FactionUnit(SororitasOverall, "Hospitaller / Dialogus", "Unit-Specific Details",
        [
            new("Medical Satchel / Books", "Dryad Bark", "Agrax Earthshade wash"),
            new("Vials & Instruments", "Administratum Grey"),
        ]),

        FactionUnit(SororitasOverall, "Exorcist", "Vehicle-Specific Details",
        [
            new("Organ Pipes", "Runelord Brass", "Agrax Earthshade wash, Balthasar Gold highlight"),
            new("Hull Panels", "Corax White", "as Overall armour scheme"),
            new("Tracks / Undercarriage", "Abaddon Black", "Administratum Grey drybrush"),
        ]),

        FactionUnit(SororitasOverall, "Immolator", "Vehicle-Specific Details",
        [
            new("Heavy Bolter / Flamer", "Abaddon Black", "Runelord Brass details"),
            new("Hull Panels", "Corax White", "as Overall armour scheme"),
            new("Exhaust Weathering", "Agrax Earthshade"),
        ]),

        FactionUnit(SororitasOverall, "Castigator", "Vehicle-Specific Details",
        [
            new("Turret Gun", "Abaddon Black", "Runelord Brass banding"),
            new("Hull Panels", "Corax White", "as Overall armour scheme"),
            new("Tracks", "Abaddon Black", "Administratum Grey drybrush"),
        ]),
    ],
    [
        new("Official (Games Workshop)",
        [
            new("Starting an Adepta Sororitas Army",
                "Official studio walkthrough covering painting and lore.",
                "https://www.warhammer-community.com/en-gb/articles/PFyXcQCJ/starting-an-adepta-sororitas-army-in-warhammer-40000-everything-you-need-to-know-from-painting-to-lore/"),
            new("Citadel Colour App",
                "GW's free official app with step-by-step 'paint this army' recipes.",
                null),
            new("Warhammer TV / Warhammer+",
                "Official video painting tutorials.",
                null),
        ]),
        new("Community",
        [
            new("Warhammer Guild — How to Paint Adepta Sororitas",
                "Step-by-step recipe guide.",
                "https://warhammerguild.com/painting/how-to-paint-adepta-sororitas/"),
            new("Warhammer Guild — Beginner's Guide",
                "Army overview and getting-started guide.",
                "https://warhammerguild.com/armies/warhammer-40000/imperium/adepta-sororitas/"),
            new("Tale of Painters — Order of the Golden Light",
                "Detailed tutorial for a specific Sisters chapter scheme.",
                "https://taleofpainters.com/2024/06/tutorial-how-to-paint-sisters-of-battle-from-the-order-of-the-golden-light/"),
            new("Chest of Colors — Adepta Sororitas Army Painted",
                "Showcase with painting notes for a finished army.",
                "https://chestofcolors.com/adepta-sororitas-army/"),
            new("Paint Pad — Adepta Sororitas Recipe",
                "Community paint-recipe database entry.",
                "https://paintpad.app/recipes/3425-adepta-sororitas"),
            new("Tabletop Battles — How to Paint Everything: Sisters of Battle",
                "Full-army painting walkthrough.",
                "https://www.tabletopbattles.com/how-to-paint-everything-sisters-of-battle/"),
        ]),
    ]);
}
