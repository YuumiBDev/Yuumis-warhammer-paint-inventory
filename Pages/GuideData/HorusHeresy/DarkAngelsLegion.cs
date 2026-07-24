namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> DarkAngelsLegionOverall =
    [
        new("Armour",
        [
            new("Basecoat", "Dark Angels Green"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer", "Caliban Green", "reapplied to raised panels"),
            new("Edge Highlight", "Warpstone Glow"),
        ]),
        new("Trim (Bone / White)",
        [
            new("Basecoat", "Ushabti Bone"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Screaming Skull"),
        ]),
        new("Metal",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Stormhost Silver"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Balthasar Gold"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static FactionGuide BuildDarkAngelsLegion() => new("Dark Angels",
    [
        new("Dark Angels", "The First Legion, secretive keepers of a shame surrounding the fall of Caliban, fighting alongside the Emperor since the Unification Wars.", DarkAngelsLegionOverall, IsScheme: true),

        FactionUnit(DarkAngelsLegionOverall, "Legion Tactical Squad", "Unit-Specific Details",
        [
            new("Squad Markings", "Ushabti Bone"),
            new("Bolter Casing", "Abaddon Black"),
        ]),

        FactionUnit(DarkAngelsLegionOverall, "Legion Terminator Squad", "Unit-Specific Details",
        [
            new("Heavy Plating", "Dark Angels Green", "extra edge highlight pass"),
            new("Combi-weapon Casing", "Abaddon Black"),
        ]),

        FactionUnit(DarkAngelsLegionOverall, "Legion Command Squad", "Unit-Specific Details",
        [
            new("Chapter Banner Trim", "Balthasar Gold"),
            new("Icon of the Order", "Ushabti Bone", "Agrax Earthshade wash"),
        ]),

        FactionUnit(DarkAngelsLegionOverall, "Legion Rhino", "Vehicle-Specific Details",
        [
            new("Hull Panels", "Dark Angels Green", "as Overall armour scheme"),
            new("Track Weathering", "Agrax Earthshade"),
        ]),

        FactionUnit(DarkAngelsLegionOverall, "Legion Dreadnought", "Vehicle-Specific Details",
        [
            new("Sarcophagus Recesses", "Abaddon Black"),
            new("Heavy Weapon Arm", "Leadbelcher"),
        ]),

        FactionUnit(DarkAngelsLegionOverall, "Legion Praetor", "Unit-Specific Details",
        [
            new("Cloak Lining", "Ushabti Bone"),
            new("Personal Heraldry", "Balthasar Gold"),
        ]),
    ], Category: GuideCategory.Loyalist, Game: Game.HorusHeresy);
}
