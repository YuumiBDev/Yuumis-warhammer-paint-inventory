namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> SplinteredFangOverall =
    [
        new("Skin",
        [
            new("Basecoat", "Cadian Fleshtone"),
            new("Shade", "Reikland Fleshshade"),
        ]),
        new("Leather & Cloth",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Mournfang Brown"),
        ]),
        new("Snake Scale Masks",
        [
            new("Basecoat", "Death Guard Green"),
            new("Glaze", "Biel-Tan Green"),
            new("Highlight", "Nurgling Green"),
        ]),
        new("Poisoned Weapons",
        [
            new("Basecoat", "Warpstone Glow"),
            new("Glaze", "Biel-Tan Green"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildSplinteredFang() => new("Splintered Fang",
    [
        new("Splintered Fang", "A Nurgle-tainted snake cult of poisoners and stranglers, wrapped in scaled masks and tattered leathers, dealing death from the shadows.", SplinteredFangOverall, IsScheme: true),

        FactionUnit(SplinteredFangOverall, "Serpent Caller", "Unit-Specific Details",
        [
            new("Snake Staff", "Warpstone Glow", "as Overall weapon scheme"),
            new("Mask", "Death Guard Green", "as Overall mask scheme"),
        ]),

        FactionUnit(SplinteredFangOverall, "Longfang", "Unit-Specific Details",
        [
            new("Fangblade", "Warpstone Glow", "as Overall weapon scheme"),
            new("Cloak", "Rhinox Hide", "as Overall cloth scheme"),
        ]),

        FactionUnit(SplinteredFangOverall, "Sentinel", "Unit-Specific Details",
        [
            new("Blowpipe", "Rhinox Hide", "as Overall cloth scheme"),
            new("Mask", "Death Guard Green", "as Overall mask scheme"),
        ]),

        FactionUnit(SplinteredFangOverall, "Adder", "Unit-Specific Details",
        [
            new("Twin Knives", "Warpstone Glow", "as Overall weapon scheme"),
            new("Skin", "Cadian Fleshtone", "as Overall skin scheme, Death Guard Green tattoos"),
        ]),
    ], Category: GuideCategory.All, Game: Game.Warcry);
}
