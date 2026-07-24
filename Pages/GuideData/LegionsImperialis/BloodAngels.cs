namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> BloodAngelsLIScheme =
    [
        new("Armour (Red)",
        [
            new("Basecoat", "Mephiston Red"),
            new("Recess Shade", "Carroburg Crimson"),
            new("Layer", "Evil Sunz Scarlet"),
            new("Edge Highlight", "Wild Rider Red"),
        ]),
        new("Trim (Black & Gold)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Gold Details", "Auric Armour Gold", "Reikland Fleshshade wash"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Auric Armour Gold"),
            new("Basing", "Astrogranite Debris", "small-scale flock for 10mm ranks"),
        ]),
    ];

    private static FactionGuide BuildBloodAngelsLegionsImperialis() => new("Blood Angels",
    [
        new("Colour Scheme", "The IX Legion at epic scale — deep red armour with black and gold trim, kept simple across whole companies of 10mm infantry stands.", BloodAngelsLIScheme, IsScheme: true),
        PlainUnit(BloodAngelsLIScheme, "Legion Tactical Detachment"),
        PlainUnit(BloodAngelsLIScheme, "Rhino Transport Markers"),
        PlainUnit(BloodAngelsLIScheme, "Legion Predator Marker"),
        PlainUnit(BloodAngelsLIScheme, "Titan / Knight Support Marker"),
    ], Category: GuideCategory.Loyalist, Game: Game.LegionsImperialis);
}
