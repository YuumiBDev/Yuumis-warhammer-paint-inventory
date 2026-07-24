namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> IronGolemsOverall =
    [
        new("Bronze Armour",
        [
            new("Basecoat", "Warplock Bronze"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Runelord Brass"),
        ]),
        new("Skin",
        [
            new("Basecoat", "Skavenblight Dinge"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Dawnstone"),
        ]),
        new("Leather & Straps",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Highlight", "Mournfang Brown"),
        ]),
        new("Steel Weapons",
        [
            new("Basecoat", "Leadbelcher"),
            new("Wash", "Nuln Oil"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Balthasar Gold"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildIronGolems() => new("Iron Golems",
    [
        new("Iron Golems", "Ironclad mercenaries who prize discipline and heavy bronze plate above all else — a warband built to grind down anything in its path.", IronGolemsOverall, IsScheme: true),

        FactionUnit(IronGolemsOverall, "Warleader", "Unit-Specific Details",
        [
            new("Great Helm", "Runelord Brass", "as Overall armour scheme"),
            new("Command Icon", "Mephiston Red"),
        ]),

        FactionUnit(IronGolemsOverall, "Icon Bearer", "Unit-Specific Details",
        [
            new("Banner Cloth", "Mephiston Red", "Nuln Oil recess in folds"),
            new("Pole & Fittings", "Leadbelcher", "as Overall weapon scheme"),
        ]),

        FactionUnit(IronGolemsOverall, "Ironhand", "Unit-Specific Details",
        [
            new("Shield Face", "Warplock Bronze", "as Overall armour scheme"),
            new("Shield Rim", "Runefang Steel"),
        ]),

        FactionUnit(IronGolemsOverall, "Berserker", "Unit-Specific Details",
        [
            new("Twin Axes", "Leadbelcher", "as Overall weapon scheme"),
            new("Exposed Skin", "Skavenblight Dinge", "as Overall skin scheme"),
        ]),

        FactionUnit(IronGolemsOverall, "Marauder", "Unit-Specific Details",
        [
            new("Light Armour Plates", "Warplock Bronze", "as Overall armour scheme, fewer plates than Warleader"),
            new("Sling Weapon", "Rhinox Hide", "as Overall leather scheme"),
        ]),
    ], Category: GuideCategory.All, Game: Game.Warcry);
}
