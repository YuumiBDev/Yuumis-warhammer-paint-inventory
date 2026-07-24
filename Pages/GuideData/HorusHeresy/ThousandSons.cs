namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> ThousandSonsHHOverall =
    [
        new("Armour",
        [
            new("Basecoat", "Thousand Sons Blue"),
            new("Recess Shade", "Drakenhof Nightshade"),
            new("Layer", "Caledor Sky"),
            new("Edge Highlight", "Fenrisian Grey"),
        ]),
        new("Trim & Metal (Gold)",
        [
            new("Basecoat", "Retributor Armour"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Sycorax Bronze"),
        ]),
        new("Details",
        [
            new("Icons / Script", "Screaming Skull", "fine detail work over armour panels"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Retributor Armour"),
            new("Basing", "Astrogranite Debris", "with Agrellan Earth cracked texture"),
        ]),
    ];

    private static FactionGuide BuildThousandSonsLegion() => new("Thousand Sons",
    [
        new("Thousand Sons", "The XV Legion under Magnus the Red — scholars and sorcerers of Prospero, clad in Thousand Sons Blue armour trimmed in gold, long before the Rubric.", ThousandSonsHHOverall, IsScheme: true),

        PlainUnit(ThousandSonsHHOverall, "Legion Tactical Squad"),
        PlainUnit(ThousandSonsHHOverall, "Legion Terminator Squad"),
        PlainUnit(ThousandSonsHHOverall, "Legion Command Squad"),
        PlainUnit(ThousandSonsHHOverall, "Legion Rhino"),
        PlainUnit(ThousandSonsHHOverall, "Legion Dreadnought"),
        PlainUnit(ThousandSonsHHOverall, "Legion Praetor"),
    ], Category: GuideCategory.Traitor, Game: Game.HorusHeresy);
}
