namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> IronsoulsCondemnorsOverall =
    [
        new("Armour",
        [
            new("Basecoat", "Runefang Steel"),
            new("Wash", "Nuln Oil"),
            new("Highlight", "Stormhost Silver"),
        ]),
        new("Gold Trim",
        [
            new("Basecoat", "Retributor Gold"),
            new("Wash", "Agrax Earthshade"),
            new("Highlight", "Liberator Gold"),
        ]),
        new("Cloak",
        [
            new("Basecoat", "Caledor Sky"),
            new("Shade", "Drakenhof Nightshade"),
            new("Highlight", "Hoeth Blue"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildIronsoulsCondemnors() => new("Ironsoul's Condemnors",
    [
        new("Ironsoul's Condemnors", "Stormcast Eternals sworn to hunt down the guilty — gleaming steel and gold judicial armour beneath sweeping blue cloaks.", IronsoulsCondemnorsOverall, IsScheme: true),

        FactionUnit(IronsoulsCondemnorsOverall, "Knight-Judicator", "Unit-Specific Details",
        [
            new("Boltstorm Crossbow", "Runefang Steel", "as Overall armour scheme"),
            new("Cloak", "Caledor Sky", "as Overall cloak scheme"),
        ]),

        FactionUnit(IronsoulsCondemnorsOverall, "Justicar", "Unit-Specific Details",
        [
            new("Warblade", "Runefang Steel", "as Overall armour scheme"),
            new("Trim", "Retributor Gold", "as Overall gold scheme"),
        ]),

        FactionUnit(IronsoulsCondemnorsOverall, "Gryph-hound", "Unit-Specific Details",
        [
            new("Feathers", "Caledor Sky", "Drakenhof Nightshade shade"),
            new("Beak & Talons", "Retributor Gold", "as Overall gold scheme"),
        ]),

        FactionUnit(IronsoulsCondemnorsOverall, "Sequitor", "Unit-Specific Details",
        [
            new("Shield Face", "Caledor Sky", "as Overall cloak scheme"),
            new("Warhammer", "Runefang Steel", "as Overall armour scheme"),
        ]),
    ], Category: GuideCategory.All, Game: Game.WarhammerUnderworlds);
}
