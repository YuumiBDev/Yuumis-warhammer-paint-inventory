namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> ImperialFistsLIScheme =
    [
        new("Armour (Yellow)",
        [
            new("Undercoat", "Wraithbone"),
            new("Basecoat", "Averland Sunset"),
            new("Shade", "Agrax Earthshade", "thin glaze, avoid pooling"),
            new("Edge Highlight", "Flash Gitz Yellow"),
        ]),
        new("Trim (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Edge Highlight", "Eshin Grey"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Leadbelcher"),
            new("Basing", "Astrogranite Debris", "small-scale flock for 10mm ranks"),
        ]),
    ];

    private static FactionGuide BuildImperialFistsLegionsImperialis() => new("Imperial Fists",
    [
        new("Colour Scheme", "The VII Legion at epic scale — bright yellow armour with black trim, painted over a Wraithbone undercoat and shaded in one pass to keep whole detachments consistent.", ImperialFistsLIScheme, IsScheme: true),
        PlainUnit(ImperialFistsLIScheme, "Legion Tactical Detachment"),
        PlainUnit(ImperialFistsLIScheme, "Rhino Transport Markers"),
        PlainUnit(ImperialFistsLIScheme, "Legion Predator Marker"),
        PlainUnit(ImperialFistsLIScheme, "Titan / Knight Support Marker"),
    ], Category: GuideCategory.Loyalist, Game: Game.LegionsImperialis);
}
