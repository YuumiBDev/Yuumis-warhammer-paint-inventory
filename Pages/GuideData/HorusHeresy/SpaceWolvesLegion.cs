namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> SpaceWolvesLegionOverall =
    [
        new("Armour (Battleship Grey)",
        [
            new("Basecoat", "Space Wolves Grey"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer", "Dawnstone"),
            new("Edge Highlight", "Administratum Grey"),
        ]),
        new("Trim (Red)",
        [
            new("Basecoat", "Mephiston Red"),
            new("Shade", "Carroburg Crimson"),
        ]),
        new("Pelts & Fur (White)",
        [
            new("Basecoat", "Ushabti Bone"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Screaming Skull"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Leadbelcher"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildSpaceWolvesLegion() => new("Space Wolves",
    [
        new("Space Wolves", "The Sixth Legion, savage and fiercely loyal wolves of Fenris led by Leman Russ, the Emperor's chosen executioners.", SpaceWolvesLegionOverall, IsScheme: true),

        FactionUnit(SpaceWolvesLegionOverall, "Legion Tactical Squad", "Unit-Specific Details",
        [
            new("Squad Markings", "Mephiston Red"),
            new("Bolter Casing", "Leadbelcher"),
        ]),

        FactionUnit(SpaceWolvesLegionOverall, "Legion Terminator Squad", "Unit-Specific Details",
        [
            new("Heavy Plating", "Space Wolves Grey", "extra edge highlight pass"),
            new("Pelt Trophies", "Ushabti Bone"),
        ]),

        FactionUnit(SpaceWolvesLegionOverall, "Legion Command Squad", "Unit-Specific Details",
        [
            new("Great Company Banner Trim", "Mephiston Red"),
            new("Wolf Tail Fetish", "Ushabti Bone", "Agrax Earthshade wash"),
        ]),

        FactionUnit(SpaceWolvesLegionOverall, "Legion Rhino", "Vehicle-Specific Details",
        [
            new("Hull Panels", "Space Wolves Grey", "as Overall armour scheme"),
            new("Track Weathering", "Agrax Earthshade"),
        ]),

        FactionUnit(SpaceWolvesLegionOverall, "Legion Dreadnought", "Vehicle-Specific Details",
        [
            new("Sarcophagus Recesses", "Abaddon Black"),
            new("Heavy Weapon Arm", "Leadbelcher"),
        ]),

        FactionUnit(SpaceWolvesLegionOverall, "Legion Praetor", "Unit-Specific Details",
        [
            new("Cloak Lining", "Ushabti Bone"),
            new("Personal Heraldry", "Mephiston Red"),
        ]),
    ], Category: GuideCategory.Loyalist, Game: Game.HorusHeresy);
}
