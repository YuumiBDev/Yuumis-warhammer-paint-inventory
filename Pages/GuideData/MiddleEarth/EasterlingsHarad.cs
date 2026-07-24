namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> EasterlingsHaradOverall =
    [
        new("Armour",
        [
            new("Basecoat", "Warplock Bronze"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Hashut Copper"),
        ]),
        new("Robes & Cloth (Red)",
        [
            new("Basecoat", "Mephiston Red"),
            new("Shade", "Carroburg Crimson"),
            new("Highlight", "Evil Sunz Scarlet"),
        ]),
        new("Trim & Gold",
        [
            new("Basecoat", "Balthasar Gold"),
            new("Shade", "Reikland Fleshshade"),
            new("Highlight", "Auric Armour Gold"),
        ]),
        new("Leathers",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Rhinox Hide"),
            new("Basing", "Astrogranite"),
        ]),
    ];

    private static FactionGuide BuildEasterlingsHarad() => new("Easterlings / Harad",
    [
        new("Easterling Warriors", "The armies of the East and South answering Sauron's call — ornate bronze armour, blood-red robes, and gleaming gold trim.", EasterlingsHaradOverall, IsScheme: true),

        FactionUnit(EasterlingsHaradOverall, "Easterling Kataphrakts", "Unit-Specific Details",
        [
            new("Horse Barding", "Warplock Bronze", "as Overall armour scheme"),
            new("Barding Trim", "Balthasar Gold"),
        ]),

        FactionUnit(EasterlingsHaradOverall, "Half-Trolls of Far Harad", "Unit-Specific Details",
        [
            new("Skin", "Rakarth Flesh"),
            new("Skin Shade", "Agrax Earthshade"),
            new("Skin Highlight", "Ratskin Flesh"),
            new("Loincloth", "Rhinox Hide"),
        ]),

        FactionUnit(EasterlingsHaradOverall, "Suladan the Serpent Lord", "Unit-Specific Details",
        [
            new("Serpent Helm", "Warplock Bronze"),
            new("Cloak", "Mephiston Red"),
            new("Robes Trim", "Auric Armour Gold"),
        ]),

        FactionUnit(EasterlingsHaradOverall, "Mahud Tribesmen", "Unit-Specific Details",
        [
            new("Skin", "Rakarth Flesh"),
            new("Skin Shade", "Reikland Fleshshade"),
            new("War Paint", "White Scar", "tribal markings"),
            new("Leathers", "Rhinox Hide"),
        ]),
    ], Category: GuideCategory.Evil, Game: Game.MiddleEarth);
}
