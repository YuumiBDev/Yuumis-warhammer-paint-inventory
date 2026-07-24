namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> SonsOfHorusOverall =
    [
        new("Armour (Sons of Horus Green)",
        [
            new("Basecoat", "Sons of Horus Green"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer", "Loren Forest"),
            new("Edge Highlight", "Elysian Green"),
        ]),
        new("Trim & Metal (Buff / Tan)",
        [
            new("Basecoat", "Zamesi Desert"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Ushabti Bone"),
        ]),
        new("Details",
        [
            new("Eye of Horus Icon", "Ushabti Bone", "fine detail work"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Zamesi Desert"),
            new("Basing", "Astrogranite Debris", "with Agrellan Earth cracked texture"),
        ]),
    ];

    private static FactionGuide BuildSonsOfHorus() => new("Sons of Horus",
    [
        new("Sons of Horus", "The XVI Legion under Horus Lupercal himself — the Warmaster's own, clad in dark green-grey armour trimmed in buff leather and bearing the Eye of Horus.", SonsOfHorusOverall, IsScheme: true),

        PlainUnit(SonsOfHorusOverall, "Legion Tactical Squad"),
        PlainUnit(SonsOfHorusOverall, "Legion Terminator Squad"),
        PlainUnit(SonsOfHorusOverall, "Legion Command Squad"),
        PlainUnit(SonsOfHorusOverall, "Legion Rhino"),
        PlainUnit(SonsOfHorusOverall, "Legion Dreadnought"),
        PlainUnit(SonsOfHorusOverall, "Legion Praetor"),
    ], Category: GuideCategory.Traitor, Game: Game.HorusHeresy);
}
