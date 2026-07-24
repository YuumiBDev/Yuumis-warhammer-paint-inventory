namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> AlphaLegionHHOverall =
    [
        new("Armour (Teal / Blue-Green)",
        [
            new("Basecoat", "Sotek Green"),
            new("Recess Shade", "Drakenhof Nightshade"),
            new("Layer", "Temple Guard Blue"),
            new("Edge Highlight", "Sybarite Green"),
        ]),
        new("Trim & Metal (Silver)",
        [
            new("Basecoat", "Runefang Steel"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Stormhost Silver"),
        ]),
        new("Details",
        [
            new("Hydra Icons", "Runefang Steel", "Nuln Oil recess"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Astrogranite Debris", "with Agrellan Earth cracked texture"),
        ]),
    ];

    private static FactionGuide BuildAlphaLegion() => new("Alpha Legion",
    [
        new("Alpha Legion", "The XX Legion under the primarchs Alpharius and Omegon — masters of infiltration and subterfuge, clad in teal armour with silver trim and the hydra icon of their Legion.", AlphaLegionHHOverall, IsScheme: true),

        PlainUnit(AlphaLegionHHOverall, "Legion Tactical Squad"),
        PlainUnit(AlphaLegionHHOverall, "Legion Terminator Squad"),
        PlainUnit(AlphaLegionHHOverall, "Legion Command Squad"),
        PlainUnit(AlphaLegionHHOverall, "Legion Rhino"),
        PlainUnit(AlphaLegionHHOverall, "Legion Dreadnought"),
        PlainUnit(AlphaLegionHHOverall, "Legion Praetor"),
    ], Category: GuideCategory.Traitor, Game: Game.HorusHeresy);
}
