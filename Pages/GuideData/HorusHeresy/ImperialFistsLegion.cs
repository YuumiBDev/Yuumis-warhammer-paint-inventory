namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> ImperialFistsLegionOverall =
    [
        new("Armour (Solar Yellow)",
        [
            new("Basecoat", "Imperial Fists Yellow"),
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

    private static FactionGuide BuildImperialFistsLegion() => new("Imperial Fists",
    [
        new("Imperial Fists", "The Seventh Legion, unbreakable siege-masters and defenders under Rogal Dorn, embodiment of stoic discipline.", ImperialFistsLegionOverall, IsScheme: true),

        FactionUnit(ImperialFistsLegionOverall, "Legion Tactical Squad", "Unit-Specific Details",
        [
            new("Squad Markings", "Abaddon Black"),
            new("Bolter Casing", "Leadbelcher"),
        ]),

        FactionUnit(ImperialFistsLegionOverall, "Legion Terminator Squad", "Unit-Specific Details",
        [
            new("Heavy Plating", "Imperial Fists Yellow", "extra edge highlight pass"),
            new("Combi-weapon Casing", "Abaddon Black"),
        ]),

        FactionUnit(ImperialFistsLegionOverall, "Legion Command Squad", "Unit-Specific Details",
        [
            new("Company Banner Trim", "Retributor Armour"),
            new("Icon of the Order", "Abaddon Black"),
        ]),

        FactionUnit(ImperialFistsLegionOverall, "Legion Rhino", "Vehicle-Specific Details",
        [
            new("Hull Panels", "Imperial Fists Yellow", "as Overall armour scheme"),
            new("Top Hatch", "Abaddon Black"),
        ]),

        FactionUnit(ImperialFistsLegionOverall, "Legion Dreadnought", "Vehicle-Specific Details",
        [
            new("Sarcophagus Recesses", "Abaddon Black"),
            new("Heavy Weapon Arm", "Leadbelcher"),
        ]),

        FactionUnit(ImperialFistsLegionOverall, "Legion Praetor", "Unit-Specific Details",
        [
            new("Cloak Lining", "Abaddon Black"),
            new("Personal Heraldry", "Retributor Armour"),
        ]),
    ], Category: GuideCategory.Loyalist, Game: Game.HorusHeresy);
}
