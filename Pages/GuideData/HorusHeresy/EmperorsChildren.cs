namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> EmperorsChildrenOverall =
    [
        new("Armour",
        [
            new("Basecoat", "Xereus Purple"),
            new("Recess Shade", "Druchii Violet"),
            new("Layer", "Genestealer Purple"),
            new("Edge Highlight", "Slaanesh Grey"),
        ]),
        new("Trim & Metal",
        [
            new("Basecoat", "Retributor Armour"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Sycorax Bronze"),
        ]),
        new("Details",
        [
            new("Purity Seals / Laurels", "Screaming Skull", "Agrax Earthshade wash"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Retributor Armour"),
            new("Basing", "Astrogranite Debris", "with Agrellan Earth cracked texture"),
        ]),
    ];

    private static FactionGuide BuildEmperorsChildren() => new("Emperor's Children",
    [
        new("Emperor's Children", "The III Legion — perfectionist warriors led by the Phoenician, Fulgrim. Even before the Heresy their armour was kept immaculate, deep purple trimmed in gold.", EmperorsChildrenOverall, IsScheme: true),

        PlainUnit(EmperorsChildrenOverall, "Legion Tactical Squad"),
        PlainUnit(EmperorsChildrenOverall, "Legion Terminator Squad"),
        PlainUnit(EmperorsChildrenOverall, "Legion Command Squad"),
        PlainUnit(EmperorsChildrenOverall, "Legion Rhino"),
        PlainUnit(EmperorsChildrenOverall, "Legion Dreadnought"),
        PlainUnit(EmperorsChildrenOverall, "Legion Praetor"),
    ], Category: GuideCategory.Traitor, Game: Game.HorusHeresy);
}
