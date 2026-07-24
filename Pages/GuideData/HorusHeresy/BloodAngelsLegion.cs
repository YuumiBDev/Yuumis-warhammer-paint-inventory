namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> BloodAngelsLegionOverall =
    [
        new("Armour (Red)",
        [
            new("Basecoat", "Blood Angels Red"),
            new("Recess Shade", "Carroburg Crimson"),
            new("Layer", "Evil Sunz Scarlet"),
            new("Edge Highlight", "Wild Rider Red"),
        ]),
        new("Trim (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Edge Highlight", "Eshin Grey"),
        ]),
        new("Gold Details",
        [
            new("Basecoat", "Retributor Armour"),
            new("Shade", "Reikland Fleshshade"),
            new("Edge Highlight", "Auric Armour Gold"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runelord Brass"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static FactionGuide BuildBloodAngelsLegion() => new("Blood Angels",
    [
        new("Blood Angels", "The Ninth Legion, noble and artistic sons of Baal led by Sanguinius, haunted by the Red Thirst and the Black Rage.", BloodAngelsLegionOverall, IsScheme: true),

        FactionUnit(BloodAngelsLegionOverall, "Legion Tactical Squad", "Unit-Specific Details",
        [
            new("Squad Markings", "Retributor Armour"),
            new("Bolter Casing", "Abaddon Black"),
        ]),

        FactionUnit(BloodAngelsLegionOverall, "Legion Terminator Squad", "Unit-Specific Details",
        [
            new("Heavy Plating", "Blood Angels Red", "extra edge highlight pass"),
            new("Combi-weapon Casing", "Abaddon Black"),
        ]),

        FactionUnit(BloodAngelsLegionOverall, "Legion Command Squad", "Unit-Specific Details",
        [
            new("Company Banner Trim", "Auric Armour Gold"),
            new("Icon of the Order", "Retributor Armour", "Reikland Fleshshade wash"),
        ]),

        FactionUnit(BloodAngelsLegionOverall, "Legion Rhino", "Vehicle-Specific Details",
        [
            new("Hull Panels", "Blood Angels Red", "as Overall armour scheme"),
            new("Top Hatch", "Abaddon Black"),
        ]),

        FactionUnit(BloodAngelsLegionOverall, "Legion Dreadnought", "Vehicle-Specific Details",
        [
            new("Sarcophagus Recesses", "Abaddon Black"),
            new("Heavy Weapon Arm", "Retributor Armour"),
        ]),

        FactionUnit(BloodAngelsLegionOverall, "Legion Praetor", "Unit-Specific Details",
        [
            new("Cloak Lining", "Abaddon Black"),
            new("Personal Heraldry", "Auric Armour Gold"),
        ]),
    ], Category: GuideCategory.Loyalist, Game: Game.HorusHeresy);
}
