namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> UltramarinesLegionOverall =
    [
        new("Armour (Blue)",
        [
            new("Basecoat", "Ultramarines Blue"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer", "Calgar Blue"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Trim (White)",
        [
            new("Basecoat", "Corax White"),
            new("Shade", "Celestra Grey"),
        ]),
        new("Gold Details",
        [
            new("Basecoat", "Retributor Armour"),
            new("Shade", "Reikland Fleshshade"),
            new("Edge Highlight", "Auric Armour Gold"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Auric Armour Gold"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static FactionGuide BuildUltramarinesLegion() => new("Ultramarines",
    [
        new("Ultramarines", "The Thirteenth Legion, largest and most disciplined of the Legions, builders of the Five Hundred Worlds under Roboute Guilliman.", UltramarinesLegionOverall, IsScheme: true),

        FactionUnit(UltramarinesLegionOverall, "Legion Tactical Squad", "Unit-Specific Details",
        [
            new("Squad Markings", "Corax White"),
            new("Bolter Casing", "Abaddon Black"),
        ]),

        FactionUnit(UltramarinesLegionOverall, "Legion Terminator Squad", "Unit-Specific Details",
        [
            new("Heavy Plating", "Ultramarines Blue", "extra edge highlight pass"),
            new("Combi-weapon Casing", "Abaddon Black"),
        ]),

        FactionUnit(UltramarinesLegionOverall, "Legion Command Squad", "Unit-Specific Details",
        [
            new("Company Banner Trim", "Auric Armour Gold"),
            new("Icon of the Order", "Corax White", "Celestra Grey wash"),
        ]),

        FactionUnit(UltramarinesLegionOverall, "Legion Rhino", "Vehicle-Specific Details",
        [
            new("Hull Panels", "Ultramarines Blue", "as Overall armour scheme"),
            new("Top Hatch", "Abaddon Black"),
        ]),

        FactionUnit(UltramarinesLegionOverall, "Legion Dreadnought", "Vehicle-Specific Details",
        [
            new("Sarcophagus Recesses", "Abaddon Black"),
            new("Heavy Weapon Arm", "Leadbelcher"),
        ]),

        FactionUnit(UltramarinesLegionOverall, "Legion Praetor", "Unit-Specific Details",
        [
            new("Cloak Lining", "Corax White"),
            new("Personal Heraldry", "Auric Armour Gold"),
        ]),
    ], Category: GuideCategory.Loyalist, Game: Game.HorusHeresy);
}
