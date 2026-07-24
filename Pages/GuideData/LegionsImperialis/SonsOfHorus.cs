namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> SonsOfHorusLIScheme =
    [
        new("Armour (Dark Green)",
        [
            new("Basecoat", "Caliban Green"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer", "Loren Forest"),
            new("Edge Highlight", "Straken Green"),
        ]),
        new("Trim (Tan / Buff)",
        [
            new("Basecoat", "Zandri Dust"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Ushabti Bone"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Zandri Dust"),
            new("Basing", "Astrogranite Debris", "small-scale flock for 10mm ranks"),
        ]),
    ];

    private static FactionGuide BuildSonsOfHorusLegionsImperialis() => new("Sons of Horus",
    [
        new("Colour Scheme", "The XVI Legion at epic scale — dark green armour with buff/tan trim, worn by the Warmaster's own before the Legion turned to the Long War.", SonsOfHorusLIScheme, IsScheme: true),
        PlainUnit(SonsOfHorusLIScheme, "Legion Tactical Detachment"),
        PlainUnit(SonsOfHorusLIScheme, "Rhino Transport Markers"),
        PlainUnit(SonsOfHorusLIScheme, "Legion Predator Marker"),
        PlainUnit(SonsOfHorusLIScheme, "Titan / Knight Support Marker"),
    ], Category: GuideCategory.Traitor, Game: Game.LegionsImperialis);
}
