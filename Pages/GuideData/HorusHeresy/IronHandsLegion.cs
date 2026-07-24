namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> IronHandsLegionOverall =
    [
        new("Armour (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer / Drybrush", "Eshin Grey"),
            new("Edge Highlight", "Dawnstone"),
        ]),
        new("Trim & Cybernetics (Steel)",
        [
            new("Basecoat", "Iron Hands Steel"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Stormhost Silver"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Stormhost Silver"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildIronHandsLegion() => new("Iron Hands",
    [
        new("Iron Hands", "The Tenth Legion, believers that flesh is weak, replacing their bodies with augmetics under Ferrus Manus.", IronHandsLegionOverall, IsScheme: true),

        FactionUnit(IronHandsLegionOverall, "Legion Tactical Squad", "Unit-Specific Details",
        [
            new("Squad Markings", "Iron Hands Steel"),
            new("Bolter Casing", "Abaddon Black"),
        ]),

        FactionUnit(IronHandsLegionOverall, "Legion Terminator Squad", "Unit-Specific Details",
        [
            new("Heavy Plating", "Abaddon Black", "extra edge highlight pass"),
            new("Bionic Fist", "Iron Hands Steel", "Nuln Oil shade"),
        ]),

        FactionUnit(IronHandsLegionOverall, "Legion Command Squad", "Unit-Specific Details",
        [
            new("Clan Company Banner Trim", "Stormhost Silver"),
            new("Icon of the Order", "Iron Hands Steel"),
        ]),

        FactionUnit(IronHandsLegionOverall, "Legion Rhino", "Vehicle-Specific Details",
        [
            new("Hull Panels", "Abaddon Black", "as Overall armour scheme"),
            new("Track Weathering", "Nuln Oil"),
        ]),

        FactionUnit(IronHandsLegionOverall, "Legion Dreadnought", "Vehicle-Specific Details",
        [
            new("Sarcophagus Recesses", "Iron Hands Steel"),
            new("Heavy Weapon Arm", "Iron Hands Steel", "Nuln Oil shade"),
        ]),

        FactionUnit(IronHandsLegionOverall, "Legion Praetor", "Unit-Specific Details",
        [
            new("Cloak Lining", "Abaddon Black"),
            new("Personal Heraldry", "Stormhost Silver"),
        ]),
    ], Category: GuideCategory.Loyalist, Game: Game.HorusHeresy);
}
