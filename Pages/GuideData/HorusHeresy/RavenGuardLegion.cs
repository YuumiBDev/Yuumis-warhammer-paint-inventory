namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> RavenGuardLegionOverall =
    [
        new("Armour (Matte Black)",
        [
            new("Basecoat", "Raven Guard Black"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer / Drybrush", "Eshin Grey"),
            new("Edge Highlight", "White Scar", "fine line only"),
        ]),
        new("Trim & Icons (White)",
        [
            new("Basecoat", "Corax White"),
            new("Shade", "Celestra Grey"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildRavenGuardLegion() => new("Raven Guard",
    [
        new("Raven Guard", "The Nineteenth Legion, masters of stealth and guerrilla warfare from shadowed Deliverance, led by Corvus Corax.", RavenGuardLegionOverall, IsScheme: true),

        FactionUnit(RavenGuardLegionOverall, "Legion Tactical Squad", "Unit-Specific Details",
        [
            new("Squad Markings", "Corax White"),
            new("Bolter Casing", "Abaddon Black"),
        ]),

        FactionUnit(RavenGuardLegionOverall, "Legion Terminator Squad", "Unit-Specific Details",
        [
            new("Heavy Plating", "Raven Guard Black", "extra edge highlight pass"),
            new("Combi-weapon Casing", "Abaddon Black"),
        ]),

        FactionUnit(RavenGuardLegionOverall, "Legion Command Squad", "Unit-Specific Details",
        [
            new("Company Banner Trim", "Corax White"),
            new("Icon of the Order", "Runefang Steel"),
        ]),

        FactionUnit(RavenGuardLegionOverall, "Legion Rhino", "Vehicle-Specific Details",
        [
            new("Hull Panels", "Raven Guard Black", "as Overall armour scheme"),
            new("Top Hatch", "Corax White"),
        ]),

        FactionUnit(RavenGuardLegionOverall, "Legion Dreadnought", "Vehicle-Specific Details",
        [
            new("Sarcophagus Recesses", "Abaddon Black"),
            new("Heavy Weapon Arm", "Runefang Steel"),
        ]),

        FactionUnit(RavenGuardLegionOverall, "Legion Praetor", "Unit-Specific Details",
        [
            new("Cloak Lining", "Raven Guard Black"),
            new("Personal Heraldry", "Corax White"),
        ]),
    ], Category: GuideCategory.Loyalist, Game: Game.HorusHeresy);
}
