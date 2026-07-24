namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> DarkElfOverall =
    [
        new("Armour & Kit",
        [
            new("Basecoat", "Abaddon Black"),
            new("Highlight", "Eshin Grey", "edge highlight"),
        ]),
        new("Trim & Cloth",
        [
            new("Basecoat", "Xereus Purple"),
            new("Shade", "Druchii Violet"),
            new("Highlight", "Genestealer Purple"),
        ]),
        new("Metal & Blades",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Runefang Steel"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildDarkElf() => new("Dark Elf",
    [
        new("Dark Elf", "Black armour over dark purple cloth — a cruel, precise roster that punishes any lapse in the opponent's defensive line.", DarkElfOverall, IsScheme: true),

        FactionUnit(DarkElfOverall, "Lineman", "Unit-Specific Details",
        [
            new("Cloak", "Xereus Purple", "as Overall trim scheme"),
            new("Blade", "Leadbelcher", "Nuln Oil recess"),
        ]),

        FactionUnit(DarkElfOverall, "Runner", "Unit-Specific Details",
        [
            new("Lightweight Armour", "Abaddon Black", "trimmed-down plating built for speed"),
            new("Trim", "Genestealer Purple", "as Overall trim highlight"),
        ]),

        FactionUnit(DarkElfOverall, "Assassin", "Unit-Specific Details",
        [
            new("Concealed Wraps", "Abaddon Black", "no purple trim, deliberately unmarked"),
            new("Twin Blades", "Runefang Steel", "as Overall metal highlight"),
        ]),

        FactionUnit(DarkElfOverall, "Blitzer", "Unit-Specific Details",
        [
            new("Reinforced Pauldron", "Leadbelcher", "Nuln Oil wash"),
            new("Cloak Trim", "Xereus Purple", "as Overall trim scheme, wider band than Linemen"),
        ]),

        FactionUnit(DarkElfOverall, "Witch Elf", "Unit-Specific Details",
        [
            new("Bare Skin", "Cadian Fleshtone", "Reikland Fleshshade wash"),
            new("Ritual Wraps", "Xereus Purple", "as Overall trim scheme"),
            new("Twin Blades", "Runefang Steel", "as Overall metal highlight"),
        ]),
    ], Category: GuideCategory.Teams, Game: Game.BloodBowl);
}
