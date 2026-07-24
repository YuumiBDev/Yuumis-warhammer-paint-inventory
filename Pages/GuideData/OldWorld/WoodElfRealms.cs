namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> WoodElfRealmsOverall =
    [
        new("Skin",
        [
            new("Basecoat", "Cadian Fleshtone"),
            new("Shade", "Reikland Fleshshade"),
            new("Highlight", "Kislev Flesh"),
        ]),
        new("Cloth & Leaves (Green)",
        [
            new("Basecoat", "Loren Forest"),
            new("Shade", "Biel-Tan Green"),
            new("Edge Highlight", "Sybarite Green"),
        ]),
        new("Leather & Bark",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Mournfang Brown"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Rhinox Hide"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static FactionGuide BuildWoodElfRealms() => new("Wood Elf Realms",
    [
        new("Athel Loren Green", "The default and most iconic look — dappled forest green and earthy bark tones that let the kindreds of the wood melt into the trees they defend.", WoodElfRealmsOverall, IsScheme: true),

        FactionUnit(WoodElfRealmsOverall, "Glade Guard", "Unit-Specific Details",
        [
            new("Bow", "Rhinox Hide", "Agrax Earthshade wash"),
            new("Fletching", "Sybarite Green"),
        ]),

        FactionUnit(WoodElfRealmsOverall, "Dryads", "Unit-Specific Details",
        [
            new("Bark Body", "Rhinox Hide", "Agrax Earthshade wash, Mournfang Brown highlight"),
            new("Leaf Accents", "Loren Forest"),
        ]),

        FactionUnit(WoodElfRealmsOverall, "Wardancers", "Unit-Specific Details",
        [
            new("Bare Skin", "Cadian Fleshtone", "Reikland Fleshshade wash, as Overall"),
            new("War Paint", "Sybarite Green", "tattoo accents"),
        ]),

        FactionUnit(WoodElfRealmsOverall, "Glade Riders", "Mount-Specific Details",
        [
            new("Elven Steed Hide", "Ushabti Bone", "Agrax Earthshade wash"),
            new("Bow", "Rhinox Hide", "as Glade Guard"),
        ]),

        FactionUnit(WoodElfRealmsOverall, "Treeman", "Unit-Specific Details",
        [
            new("Bark", "Rhinox Hide", "heavy Agrax Earthshade wash, Mournfang Brown drybrush"),
            new("Foliage", "Loren Forest", "Sybarite Green highlight"),
        ]),

        FactionUnit(WoodElfRealmsOverall, "Spellweaver", "Unit-Specific Details",
        [
            new("Robes", "Loren Forest", "Sybarite Green edge"),
            new("Staff Head Gem", "Genestealer Purple"),
        ]),

        FactionUnit(WoodElfRealmsOverall, "Waywatchers", "Unit-Specific Details",
        [
            new("Cloak", "Dryad Bark"),
            new("Longbow", "Rhinox Hide", "Agrax Earthshade wash"),
        ]),
    ], Category: GuideCategory.All, Game: Game.OldWorld);
}
