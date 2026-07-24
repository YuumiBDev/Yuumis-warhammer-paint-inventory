namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> HunterCladeOverall =
    [
        new("Robes",
        [
            new("Basecoat", "Mephiston Red"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Evil Sunz Scarlet"),
        ]),
        new("Copper Plating",
        [
            new("Basecoat", "Warplock Bronze"),
            new("Shade", "Reikland Fleshshade"),
            new("Layer", "Sycorax Bronze"),
            new("Highlight", "Runefang Steel"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildHunterClade() => new("Hunter Clade",
    [
        new("Hunter Clade", "Adeptus Mechanicus Skitarii formations hunting Necron relics and technology — red robes over copper-plated carapace armour.", HunterCladeOverall, IsScheme: true),

        FactionUnit(HunterCladeOverall, "Skitarii Marshal", "Unit-Specific Details",
        [
            new("Rank Icon", "Runefang Steel"),
            new("Cognis Signum", "Leadbelcher"),
        ]),

        FactionUnit(HunterCladeOverall, "Ranger Alpha", "Unit-Specific Details",
        [
            new("Galvanic Rifle", "Leadbelcher"),
            new("Targeting Optics", "Moot Green", "thin glaze"),
        ]),

        FactionUnit(HunterCladeOverall, "Sicarian Infiltrator", "Unit-Specific Details",
        [
            new("Stalker Silhouette Cloak", "Abaddon Black"),
            new("Taser Goad", "Moot Green", "thin glaze crackle"),
        ]),

        FactionUnit(HunterCladeOverall, "Serberys Raider", "Unit-Specific Details",
        [
            new("Cyber-Mount Hide", "Rhinox Hide"),
            new("Carapace Barding", "Warplock Bronze", "as Overall copper scheme"),
        ]),

        FactionUnit(HunterCladeOverall, "Kataphron Destroyer", "Unit-Specific Details",
        [
            new("Servitor Housing", "Leadbelcher"),
            new("Grafted Flesh", "Cadian Fleshtone", "Reikland Fleshshade wash"),
        ]),
    ], Category: GuideCategory.Imperial, Game: Game.KillTeam);
}
