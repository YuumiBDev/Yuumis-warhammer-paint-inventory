namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> WhiteScarsLegionOverall =
    [
        new("Armour (Bone-White)",
        [
            new("Basecoat", "White Scars Bone"),
            new("Recess Shade", "Agrax Earthshade"),
            new("Layer", "Ushabti Bone"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Trim & Icons (Red)",
        [
            new("Basecoat", "Mephiston Red"),
            new("Shade", "Carroburg Crimson"),
            new("Edge Highlight", "Wild Rider Red"),
        ]),
        new("Metal",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Leadbelcher"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildWhiteScarsLegion() => new("White Scars",
    [
        new("White Scars", "The Fifth Legion, swift raiders and horse-lords of Chogoris under Jaghatai Khan, favouring hit-and-run warfare over grinding sieges.", WhiteScarsLegionOverall, IsScheme: true),

        FactionUnit(WhiteScarsLegionOverall, "Legion Tactical Squad", "Unit-Specific Details",
        [
            new("Squad Markings", "Mephiston Red"),
            new("Bolter Casing", "Leadbelcher"),
        ]),

        FactionUnit(WhiteScarsLegionOverall, "Legion Terminator Squad", "Unit-Specific Details",
        [
            new("Heavy Plating", "White Scars Bone", "extra edge highlight pass"),
            new("Combi-weapon Casing", "Abaddon Black"),
        ]),

        FactionUnit(WhiteScarsLegionOverall, "Legion Command Squad", "Unit-Specific Details",
        [
            new("Company Banner Trim", "Mephiston Red"),
            new("Icon of the Order", "Runefang Steel"),
        ]),

        FactionUnit(WhiteScarsLegionOverall, "Legion Rhino", "Vehicle-Specific Details",
        [
            new("Hull Panels", "White Scars Bone", "as Overall armour scheme"),
            new("Speed Markings", "Mephiston Red"),
        ]),

        FactionUnit(WhiteScarsLegionOverall, "Legion Dreadnought", "Vehicle-Specific Details",
        [
            new("Sarcophagus Recesses", "Abaddon Black"),
            new("Heavy Weapon Arm", "Leadbelcher"),
        ]),

        FactionUnit(WhiteScarsLegionOverall, "Legion Praetor", "Unit-Specific Details",
        [
            new("Cloak Lining", "Mephiston Red"),
            new("Personal Heraldry", "Runefang Steel"),
        ]),
    ], Category: GuideCategory.Loyalist, Game: Game.HorusHeresy);
}
