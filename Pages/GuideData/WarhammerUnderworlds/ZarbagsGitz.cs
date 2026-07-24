namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> ZarbagsGitzOverall =
    [
        new("Goblin Skin",
        [
            new("Basecoat", "Skarsnik Green"),
            new("Glaze", "Biel-Tan Green"),
            new("Highlight", "Moot Green"),
        ]),
        new("Moon-Pale Robes",
        [
            new("Basecoat", "Corax White"),
            new("Glaze", "Drakenhof Nightshade"),
            new("Highlight", "Ulthuan Grey"),
        ]),
        new("Squig Hide",
        [
            new("Basecoat", "Mephiston Red"),
            new("Shade", "Agrax Earthshade"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildZarbagsGitz() => new("Zarbag's Gitz",
    [
        new("Zarbag's Gitz", "A Gloomspite mob of moon-pale grots and their bouncing, biting squigs — pallid goblin skin under tattered white robes.", ZarbagsGitzOverall, IsScheme: true),

        FactionUnit(ZarbagsGitzOverall, "Zarbag", "Unit-Specific Details",
        [
            new("Staff & Trinkets", "Ushabti Bone", "Agrax Earthshade wash"),
            new("Robes", "Corax White", "as Overall robe scheme"),
        ]),

        FactionUnit(ZarbagsGitzOverall, "Fungoid Cave-Shaman", "Unit-Specific Details",
        [
            new("Mushroom Staff", "Death Guard Green", "Biel-Tan Green glaze"),
            new("Robes", "Corax White", "as Overall robe scheme"),
        ]),

        FactionUnit(ZarbagsGitzOverall, "Squig Herder", "Unit-Specific Details",
        [
            new("Whip & Prod", "Rhinox Hide"),
            new("Skin", "Skarsnik Green", "as Overall skin scheme"),
        ]),

        FactionUnit(ZarbagsGitzOverall, "Cave Squig", "Unit-Specific Details",
        [
            new("Hide", "Mephiston Red", "as Overall squig scheme"),
            new("Teeth", "Ushabti Bone"),
        ]),
    ], Category: GuideCategory.All, Game: Game.WarhammerUnderworlds);
}
