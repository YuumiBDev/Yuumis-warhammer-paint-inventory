namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> WordBearersLIScheme =
    [
        new("Armour (Maroon)",
        [
            new("Basecoat", "Khorne Red"),
            new("Recess Shade", "Carroburg Crimson"),
            new("Layer", "Mephiston Red"),
            new("Edge Highlight", "Wazdakka Red"),
        ]),
        new("Trim (Bone & Brass)",
        [
            new("Bone Basecoat", "Screaming Skull"),
            new("Bone Shade", "Agrax Earthshade"),
            new("Metal", "Warplock Bronze", "Nuln Oil shade, Sycorax Bronze edge"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Warplock Bronze"),
            new("Basing", "Astrogranite Debris", "small-scale flock for 10mm ranks"),
        ]),
    ];

    private static FactionGuide BuildWordBearersLegionsImperialis() => new("Word Bearers",
    [
        new("Colour Scheme", "The XVII Legion at epic scale — maroon armour with bone and brass trim, marked with the icons of the Dark Gods across whole detachments.", WordBearersLIScheme, IsScheme: true),
        PlainUnit(WordBearersLIScheme, "Legion Tactical Detachment"),
        PlainUnit(WordBearersLIScheme, "Rhino Transport Markers"),
        PlainUnit(WordBearersLIScheme, "Legion Predator Marker"),
        PlainUnit(WordBearersLIScheme, "Titan / Knight Support Marker"),
    ], Category: GuideCategory.Traitor, Game: Game.LegionsImperialis);
}
