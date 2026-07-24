namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> SpaceMarinesOverall =
    [
        new("Armour",
        [
            new("Basecoat", "Macragge Blue"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer", "Calgar Blue"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Trim & Details",
        [
            new("Trim", "Retributor Armour"),
            new("Trim Shade", "Agrax Earthshade"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Dryad Bark"),
        ]),
    ];

    // Six more First Founding Chapters each field their own canon colour scheme — selectable
    // alongside the default Ultramarines blue Overall above; unit entries below stay on the default.
    private static readonly List<Section> ChapterSalamanders =
    [
        new("Armour (Dark Green)",
        [
            new("Basecoat", "Caliban Green"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer", "Loren Forest"),
            new("Edge Highlight", "Warpstone Glow"),
        ]),
        new("Weapon Housings (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Edge Highlight", "Eshin Grey"),
        ]),
        new("Trim & Metal (Bronze)",
        [
            new("Basecoat", "Warplock Bronze"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Brass Scorpion"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runelord Brass"),
            new("Basing", "Martian Ironcrust", "volcanic rock texture, Ryza Rust drybrush"),
        ]),
    ];

    private static readonly List<Section> ChapterImperialFists =
    [
        new("Armour (Solar Yellow)",
        [
            new("Basecoat", "Averland Sunset"),
            new("Recess Shade", "Agrax Earthshade"),
            new("Layer", "Yriel Yellow"),
            new("Edge Highlight", "Dorn Yellow"),
        ]),
        new("Trim & Metal (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Edge Highlight", "Eshin Grey"),
            new("Metal", "Leadbelcher", "Nuln Oil shade, Runefang Steel edge"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Retributor Armour"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static readonly List<Section> ChapterIronHands =
    [
        new("Armour (Gunmetal)",
        [
            new("Basecoat", "Leadbelcher"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer", "Ironbreaker"),
            new("Edge Highlight", "Stormhost Silver"),
        ]),
        new("Trim (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Edge Highlight", "Eshin Grey"),
        ]),
        new("Details (Cybernetics)",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Stormhost Silver"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static readonly List<Section> ChapterWhiteScars =
    [
        new("Armour (White)",
        [
            new("Basecoat", "Corax White"),
            new("Recess Shade", "Celestra Grey"),
            new("Layer", "Ulthuan Grey"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Trim & Icons (Red)",
        [
            new("Basecoat", "Mephiston Red"),
            new("Shade", "Carroburg Crimson"),
            new("Edge Highlight", "Wild Rider Red"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Leadbelcher"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static readonly List<Section> ChapterRavenGuard =
    [
        new("Armour (Matte Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer / Drybrush", "Eshin Grey"),
            new("Edge Highlight", "White Scar", "fine line only"),
        ]),
        new("Trim & Icons (White)",
        [
            new("Basecoat", "Corax White"),
            new("Shade", "Celestra Grey"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static readonly List<Section> ChapterCrimsonFists =
    [
        new("Armour (Deep Blue)",
        [
            new("Basecoat", "Kantor Blue"),
            new("Recess Shade", "Drakenhof Nightshade"),
            new("Layer", "Macragge Blue"),
            new("Edge Highlight", "Baharroth Blue"),
        ]),
        new("Trim & Icon (Red)",
        [
            new("Basecoat", "Mephiston Red"),
            new("Shade", "Carroburg Crimson"),
            new("Edge Highlight", "Wild Rider Red"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Stormhost Silver"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static FactionGuide BuildSpaceMarines() => new("Space Marines",
    [
        new("Ultramarines", "The default and most iconic First Founding Chapter — Macragge Blue armour, gold trim.", SpaceMarinesOverall, IsScheme: true),

        new("Salamanders", "One of the First Founding Chapters — dark green armour, bronze trim, volcanic basing.", ChapterSalamanders, IsScheme: true),
        new("Imperial Fists", "One of the First Founding Chapters — solar yellow armour, black trim.", ChapterImperialFists, IsScheme: true),
        new("Iron Hands", "One of the First Founding Chapters — gunmetal armour, steel-edged cybernetics.", ChapterIronHands, IsScheme: true),
        new("White Scars", "One of the First Founding Chapters — white armour, red trim.", ChapterWhiteScars, IsScheme: true),
        new("Raven Guard", "One of the First Founding Chapters — matte black armour, white trim.", ChapterRavenGuard, IsScheme: true),
        new("Crimson Fists", "One of the First Founding Chapters — deep blue armour, red fist icon.", ChapterCrimsonFists, IsScheme: true),

        FactionUnit(SpaceMarinesOverall, "Intercessor Squad", "Unit-Specific Details",
        [
            new("Bolt Rifle Casing", "Abaddon Black"),
            new("Chapter Icon", "Retributor Armour", "Agrax Earthshade wash"),
            new("Squad Markings", "White Scar"),
        ]),

        FactionUnit(SpaceMarinesOverall, "Assault Intercessors", "Unit-Specific Details",
        [
            new("Chainsword Teeth", "Leadbelcher"),
            new("Jump Pack Vents", "Nuln Oil", "wash"),
            new("Helmet Trim", "White Scar"),
        ]),

        FactionUnit(SpaceMarinesOverall, "Terminators", "Unit-Specific Details",
        [
            new("Storm Bolter Casing", "Abaddon Black"),
            new("Teleport Homer", "Retributor Armour"),
            new("Heavy Armour Plating", "White Scar", "extra edge highlight pass"),
        ]),

        FactionUnit(SpaceMarinesOverall, "Devastators", "Unit-Specific Details",
        [
            new("Heavy Weapon Housing", "Abaddon Black"),
            new("Weapon Barrel", "Leadbelcher"),
            new("Ammo Feed", "Runelord Brass"),
        ]),

        FactionUnit(SpaceMarinesOverall, "Captain", "Unit-Specific Details",
        [
            new("Cloak Lining (rank accent)", "Mephiston Red"),
            new("Power Sword Glow", "Screaming Skull", "thin glaze"),
            new("Personal Heraldry", "Retributor Armour"),
        ]),

        FactionUnit(SpaceMarinesOverall, "Librarian", "Unit-Specific Details",
        [
            new("Psychic Hood", "Retributor Armour"),
            new("Force Weapon Glow", "Calgar Blue", "thin glaze"),
            new("Under-Robes", "Abaddon Black"),
        ]),

        FactionUnit(SpaceMarinesOverall, "Chaplain", "Unit-Specific Details",
        [
            new("Armour Accent", "Abaddon Black", "chaplains wear black rather than chapter blue"),
            new("Skull Iconography", "Screaming Skull"),
            new("Crozius Arcanum Head", "Runelord Brass"),
        ]),

        FactionUnit(SpaceMarinesOverall, "Dreadnought", "Vehicle-Specific Details",
        [
            new("Sarcophagus Recesses", "Abaddon Black"),
            new("Heavy Weapon Arm", "Leadbelcher"),
            new("Hull Panels", "Macragge Blue", "as Overall armour scheme"),
        ]),

        FactionUnit(SpaceMarinesOverall, "Rhino / Razorback", "Vehicle-Specific Details",
        [
            new("Hull Panels", "Macragge Blue", "as Overall armour scheme"),
            new("Top Hatch", "Abaddon Black"),
            new("Exhaust Weathering", "Agrax Earthshade"),
        ]),

        FactionUnit(SpaceMarinesOverall, "Land Raider", "Vehicle-Specific Details",
        [
            new("Hull Panels", "Macragge Blue", "as Overall armour scheme"),
            new("Side Sponsons", "Abaddon Black"),
            new("Track Weathering", "Agrax Earthshade"),
        ]),
    ]);
}
