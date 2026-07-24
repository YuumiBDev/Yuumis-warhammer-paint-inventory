namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> UltramarinesLIScheme =
    [
        new("Armour (Blue)",
        [
            new("Basecoat", "Macragge Blue"),
            new("Recess Shade", "Drakenhof Nightshade"),
            new("Layer", "Calgar Blue"),
            new("Edge Highlight", "Fenrisian Grey"),
        ]),
        new("Trim (White & Gold)",
        [
            new("Shoulder Trim", "Corax White"),
            new("Gold Details", "Auric Armour Gold", "Reikland Fleshshade wash"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Auric Armour Gold"),
            new("Basing", "Astrogranite Debris", "small-scale flock for 10mm ranks"),
        ]),
    ];

    private static FactionGuide BuildUltramarinesLegionsImperialis() => new("Ultramarines",
    [
        new("Colour Scheme", "The XIII Legion at epic scale — Macragge Blue armour with white shoulder trim and gold heraldry, painted fast and clean to cover whole detachments at 10mm.", UltramarinesLIScheme, IsScheme: true),
        PlainUnit(UltramarinesLIScheme, "Legion Tactical Detachment"),
        PlainUnit(UltramarinesLIScheme, "Rhino Transport Markers"),
        PlainUnit(UltramarinesLIScheme, "Legion Predator Marker"),
        PlainUnit(UltramarinesLIScheme, "Titan / Knight Support Marker"),
    ], Category: GuideCategory.Loyalist, Game: Game.LegionsImperialis);
}
