namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> MorgoksKrushasOverall =
    [
        new("Green Skin",
        [
            new("Basecoat", "Waaagh! Flesh"),
            new("Glaze", "Biel-Tan Green"),
            new("Highlight", "Skarsnik Green"),
        ]),
        new("Crude Armour",
        [
            new("Basecoat", "Leadbelcher"),
            new("Wash", "Nuln Oil"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Leather Straps",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Highlight", "Mournfang Brown"),
        ]),
        new("Warpaint",
        [
            new("Basecoat", "Mephiston Red"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildMorgoksKrushas() => new("Morgok's Krushas",
    [
        new("Morgok's Krushas", "A warband of Orruk brawlers who settle every argument with a choppa — green hide, scavenged plate and crude red warpaint.", MorgoksKrushasOverall, IsScheme: true),

        FactionUnit(MorgoksKrushasOverall, "Morgok", "Unit-Specific Details",
        [
            new("Big Choppa", "Leadbelcher", "as Overall armour scheme"),
            new("Warpaint", "Mephiston Red", "as Overall warpaint scheme"),
        ]),

        FactionUnit(MorgoksKrushasOverall, "Krusha", "Unit-Specific Details",
        [
            new("Choppa & Shield", "Leadbelcher", "as Overall armour scheme"),
            new("Skin", "Waaagh! Flesh", "as Overall skin scheme"),
        ]),

        FactionUnit(MorgoksKrushasOverall, "Boar Rider", "Unit-Specific Details",
        [
            new("Spear", "Leadbelcher", "as Overall armour scheme"),
            new("Straps", "Rhinox Hide", "as Overall leather scheme"),
        ]),

        FactionUnit(MorgoksKrushasOverall, "Snarlfang", "Unit-Specific Details",
        [
            new("Hide", "Rhinox Hide", "Agrax Earthshade wash"),
            new("Tusks", "Ushabti Bone"),
        ]),
    ], Category: GuideCategory.All, Game: Game.WarhammerUnderworlds);
}
