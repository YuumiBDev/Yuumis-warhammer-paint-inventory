namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> GreyKnightsOverall =
    [
        new("Armour",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Layer", "Ironbreaker"),
            new("Edge Highlight", "Stormhost Silver"),
        ]),
        new("Trim",
        [
            new("Basecoat", "Kantor Blue"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Fenrisian Grey"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Stormhost Silver"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildGreyKnights() => new("Grey Knights",
    [
        new("Overall (Head-to-Toe)", null, GreyKnightsOverall, IsScheme: true),

        PlainUnit(GreyKnightsOverall, "Brother-Captain"),
        PlainUnit(GreyKnightsOverall, "Brotherhood Champion"),
        PlainUnit(GreyKnightsOverall, "Brotherhood Chaplain"),
        PlainUnit(GreyKnightsOverall, "Brotherhood Librarian"),
        PlainUnit(GreyKnightsOverall, "Brotherhood Techmarine"),
        PlainUnit(GreyKnightsOverall, "Castellan Crowe"),
        PlainUnit(GreyKnightsOverall, "Grand Master"),
        PlainUnit(GreyKnightsOverall, "Grand Master in Nemesis Dreadknight"),
        PlainUnit(GreyKnightsOverall, "Grand Master Voldus"),
        PlainUnit(GreyKnightsOverall, "Venerable Dreadnought"),

        PlainUnit(GreyKnightsOverall, "Brotherhood Terminator Squad"),
        PlainUnit(GreyKnightsOverall, "Strike Squad"),

        PlainUnit(GreyKnightsOverall, "Interceptor Squad"),
        PlainUnit(GreyKnightsOverall, "Paladin Squad"),
        PlainUnit(GreyKnightsOverall, "Purgation Squad"),
        PlainUnit(GreyKnightsOverall, "Purifier Squad"),

        PlainUnit(GreyKnightsOverall, "Land Raider"),
        PlainUnit(GreyKnightsOverall, "Land Raider Crusader"),
        PlainUnit(GreyKnightsOverall, "Land Raider Redeemer"),
        PlainUnit(GreyKnightsOverall, "Stormhawk Interceptor"),
        PlainUnit(GreyKnightsOverall, "Stormraven Gunship"),
        PlainUnit(GreyKnightsOverall, "Stormtalon Gunship"),
        PlainUnit(GreyKnightsOverall, "Razorback"),
        PlainUnit(GreyKnightsOverall, "Rhino"),

        PlainUnit(GreyKnightsOverall, "Nemesis Dreadknight"),
    ]);
}
