namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> GondorOverall =
    [
        new("Armour",
        [
            new("Basecoat", "Abaddon Black"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Eshin Grey", "edge highlight"),
        ]),
        new("Trim & Metal",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Ironbreaker"),
        ]),
        new("Robes & Cloth",
        [
            new("Basecoat", "Abaddon Black"),
            new("Highlight", "Dawnstone", "drybrush"),
        ]),
        new("White Tree Heraldry",
        [
            new("Basecoat", "White Scar", "freehand tree emblem on breastplate/tabard"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static FactionGuide BuildGondor() => new("Gondor",
    [
        new("Warriors of Minas Tirith", "The soldiers of the White City — black steel armour under black robes, silver trim, and the White Tree of Gondor worn as a badge of loyalty.", GondorOverall, IsScheme: true),

        FactionUnit(GondorOverall, "Rangers of Gondor", "Unit-Specific Details",
        [
            new("Cloak", "Straken Green", "Ithilien camouflage cloak"),
            new("Cloak Shade", "Athonian Camoshade"),
            new("Leathers", "Rhinox Hide"),
        ]),

        FactionUnit(GondorOverall, "Knights of Minas Tirith", "Unit-Specific Details",
        [
            new("Horse Barding", "Abaddon Black", "as Overall armour scheme"),
            new("Barding Trim", "White Scar"),
            new("Helm Plume", "White Scar"),
        ]),

        FactionUnit(GondorOverall, "Citadel Guard", "Unit-Specific Details",
        [
            new("Ceremonial Armour", "Leadbelcher"),
            new("Guard Cloak", "Mephiston Red"),
            new("Helm Plume", "Mephiston Red"),
        ]),

        FactionUnit(GondorOverall, "Boromir", "Unit-Specific Details",
        [
            new("Fur Mantle", "Rhinox Hide"),
            new("Horn of Gondor", "Auric Armour Gold"),
            new("Vambraces", "Leadbelcher"),
        ]),

        FactionUnit(GondorOverall, "Faramir", "Unit-Specific Details",
        [
            new("Ranger Garb", "Straken Green"),
            new("Cloak Clasp", "Runelord Brass"),
        ]),
    ], Category: GuideCategory.Good, Game: Game.MiddleEarth);
}
