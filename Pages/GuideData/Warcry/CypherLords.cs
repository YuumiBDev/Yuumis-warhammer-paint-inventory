namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> CypherLordsOverall =
    [
        new("Robes",
        [
            new("Basecoat", "Xereus Purple"),
            new("Shade", "Druchii Violet"),
            new("Highlight", "Genestealer Purple"),
            new("Edge Highlight", "Pink Horror"),
        ]),
        new("Iridescent Trim",
        [
            new("Basecoat", "Fulgurite Copper"),
            new("Edge Highlight", "Sycorax Bronze"),
        ]),
        new("Masks & Bone",
        [
            new("Basecoat", "Ushabti Bone"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "White Scar"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildCypherLords() => new("Cypher Lords",
    [
        new("Cypher Lords", "Slaanesh-aligned thieves and duellists draped in iridescent pastel silks, prizing speed, secrets and beauty above brute strength.", CypherLordsOverall, IsScheme: true),

        FactionUnit(CypherLordsOverall, "Cypher Lord", "Unit-Specific Details",
        [
            new("Twin Blades", "Runefang Steel", "as Overall base scheme"),
            new("Mask", "Ushabti Bone", "as Overall mask scheme"),
        ]),

        FactionUnit(CypherLordsOverall, "Duelist", "Unit-Specific Details",
        [
            new("Rapier", "Runefang Steel"),
            new("Sash", "Pink Horror", "as Overall robe edge highlight"),
        ]),

        FactionUnit(CypherLordsOverall, "Blade-Dancer", "Unit-Specific Details",
        [
            new("Twin Daggers", "Runefang Steel"),
            new("Trailing Ribbons", "Genestealer Purple", "as Overall robe scheme"),
        ]),

        FactionUnit(CypherLordsOverall, "Shrivenor", "Unit-Specific Details",
        [
            new("Hood", "Xereus Purple", "as Overall robe scheme"),
            new("Charms & Trinkets", "Fulgurite Copper", "as Overall trim scheme"),
        ]),

        FactionUnit(CypherLordsOverall, "Reaver", "Unit-Specific Details",
        [
            new("Cloak", "Xereus Purple", "as Overall robe scheme"),
            new("Mask", "Ushabti Bone", "as Overall mask scheme"),
        ]),
    ], Category: GuideCategory.All, Game: Game.Warcry);
}
