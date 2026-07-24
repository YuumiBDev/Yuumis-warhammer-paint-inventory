namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> NightLordsHHOverall =
    [
        new("Armour (Dark Blue-Black)",
        [
            new("Basecoat", "Corvus Black"),
            new("Layer", "Kantor Blue", "edges and raised panels"),
            new("Edge Highlight", "Baharroth Blue", "fine line only"),
        ]),
        new("Details (Chrome & Lightning)",
        [
            new("Skulls / Trophies", "Stormhost Silver"),
            new("Shade", "Nuln Oil"),
            new("Lightning Bolt Icons", "Stormhost Silver", "freehand over armour plates"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Stormhost Silver"),
            new("Basing", "Astrogranite Debris", "with Agrellan Earth cracked texture"),
        ]),
    ];

    private static FactionGuide BuildNightLordsLegion() => new("Night Lords",
    [
        new("Night Lords", "The VIII Legion — masters of terror under Konrad Curze. Even in their loyalist-seeming early days their armour was near-black, hung with chrome skulls and trophies taken from the fearful.", NightLordsHHOverall, IsScheme: true),

        PlainUnit(NightLordsHHOverall, "Legion Tactical Squad"),
        PlainUnit(NightLordsHHOverall, "Legion Terminator Squad"),
        PlainUnit(NightLordsHHOverall, "Legion Command Squad"),
        PlainUnit(NightLordsHHOverall, "Legion Rhino"),
        PlainUnit(NightLordsHHOverall, "Legion Dreadnought"),
        PlainUnit(NightLordsHHOverall, "Legion Praetor"),
    ], Category: GuideCategory.Traitor, Game: Game.HorusHeresy);
}
