namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> WorldEatersHHOverall =
    [
        new("Armour (White)",
        [
            new("Basecoat", "Corax White"),
            new("Recess Shade", "Agrax Earthshade", "thinned 50/50"),
            new("Layer", "Ulthuan Grey"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Trim & Metal (Brass)",
        [
            new("Basecoat", "Hashut Copper"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Sycorax Bronze"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Hashut Copper"),
            new("Basing", "Astrogranite Debris", "with Agrellan Earth cracked texture"),
        ]),
    ];

    private static FactionGuide BuildWorldEatersLegion() => new("World Eaters",
    [
        new("World Eaters", "The XII Legion under Angron — before the Butcher's Nails and the red of Khorne, their Legion colour was pristine white armour trimmed in brass.", WorldEatersHHOverall, IsScheme: true),

        PlainUnit(WorldEatersHHOverall, "Legion Tactical Squad"),
        PlainUnit(WorldEatersHHOverall, "Legion Terminator Squad"),
        PlainUnit(WorldEatersHHOverall, "Legion Command Squad"),
        PlainUnit(WorldEatersHHOverall, "Legion Rhino"),
        PlainUnit(WorldEatersHHOverall, "Legion Dreadnought"),
        PlainUnit(WorldEatersHHOverall, "Legion Praetor"),
    ], Category: GuideCategory.Traitor, Game: Game.HorusHeresy);
}
