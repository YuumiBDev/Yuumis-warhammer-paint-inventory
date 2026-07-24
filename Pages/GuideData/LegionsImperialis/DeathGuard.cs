namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> DeathGuardLIScheme =
    [
        new("Armour (Pale Grey-Green)",
        [
            new("Basecoat", "Nurgling Green"),
            new("Shade", "Agrax Earthshade", "thin glaze"),
            new("Layer", "Screaming Skull", "highlight blend on raised panels"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Trim (Silver)",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Leadbelcher"),
            new("Basing", "Astrogranite Debris", "small-scale flock for 10mm ranks"),
        ]),
    ];

    private static FactionGuide BuildDeathGuardLegionsImperialis() => new("Death Guard",
    [
        new("Colour Scheme", "The XIV Legion at epic scale — pale sage-green armour trimmed in silver, their pre-Heresy livery before Nurgle's gifts turned it to rot.", DeathGuardLIScheme, IsScheme: true),
        PlainUnit(DeathGuardLIScheme, "Legion Tactical Detachment"),
        PlainUnit(DeathGuardLIScheme, "Rhino Transport Markers"),
        PlainUnit(DeathGuardLIScheme, "Legion Predator Marker"),
        PlainUnit(DeathGuardLIScheme, "Titan / Knight Support Marker"),
    ], Category: GuideCategory.Traitor, Game: Game.LegionsImperialis);
}
