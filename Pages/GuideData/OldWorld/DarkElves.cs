namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> DarkElvesOverall =
    [
        new("Armour (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Layer", "Eshin Grey", "drybrush"),
            new("Edge Highlight", "Dawnstone"),
        ]),
        new("Cloth & Accent (Purple)",
        [
            new("Basecoat", "Xereus Purple"),
            new("Shade", "Druchii Violet"),
            new("Edge Highlight", "Genestealer Purple"),
        ]),
        new("Metal",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildDarkElves() => new("Dark Elves",
    [
        new("Naggaroth Black & Purple", "The default and most iconic look — black armour and violet cloth, the cold, cruel colours of a people who rule Naggaroth through fear.", DarkElvesOverall, IsScheme: true),

        FactionUnit(DarkElvesOverall, "Dark Elf Warriors", "Unit-Specific Details",
        [
            new("Repeater Crossbow / Blade", "Leadbelcher", "Nuln Oil wash"),
            new("Shield Icon", "Xereus Purple"),
        ]),

        FactionUnit(DarkElvesOverall, "Dark Elf Crossbowmen", "Unit-Specific Details",
        [
            new("Crossbow Stock", "Abaddon Black", "Eshin Grey drybrush, as Overall"),
            new("Bolt Tips", "Leadbelcher"),
        ]),

        FactionUnit(DarkElvesOverall, "Witch Elves", "Unit-Specific Details",
        [
            new("Pale Skin", "Ushabti Bone", "thin Reikland Fleshshade wash"),
            new("Wild Hair", "Xereus Purple"),
        ]),

        FactionUnit(DarkElvesOverall, "Cold One Knights", "Mount-Specific Details",
        [
            new("Cold One Hide", "Death Guard Green", "Agrax Earthshade wash"),
            new("Barding", "Abaddon Black", "as Overall"),
        ]),

        FactionUnit(DarkElvesOverall, "Sorceress", "Unit-Specific Details",
        [
            new("Robes", "Xereus Purple", "Genestealer Purple edge, as Overall"),
            new("Staff Head Glow", "Sybarite Green"),
        ]),

        FactionUnit(DarkElvesOverall, "Executioners", "Unit-Specific Details",
        [
            new("Great Blade", "Leadbelcher", "Nuln Oil wash, Runefang Steel edge"),
            new("Executioner's Hood", "Abaddon Black", "as Overall"),
        ]),

        FactionUnit(DarkElvesOverall, "Black Dragon", "Unit-Specific Details",
        [
            new("Scales", "Abaddon Black", "Eshin Grey drybrush, as Overall"),
            new("Wing Membrane", "Naggaroth Night", "Druchii Violet glaze"),
            new("Claws & Teeth", "Ushabti Bone", "Agrax Earthshade wash"),
        ]),
    ], Category: GuideCategory.All, Game: Game.OldWorld);
}
