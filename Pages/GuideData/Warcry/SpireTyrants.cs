namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> SpireTyrantsOverall =
    [
        new("Skin",
        [
            new("Basecoat", "Cadian Fleshtone"),
            new("Shade", "Carroburg Crimson", "bruised gladiator look"),
            new("Highlight", "Kislev Flesh"),
        ]),
        new("Armour & Chains",
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
            new("Basecoat", "Khorne Red"),
            new("Edge Highlight", "Wild Rider Red"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildSpireTyrants() => new("Spire Tyrants",
    [
        new("Spire Tyrants", "Brutal gladiators bred for the fighting pits, draped in chains and scarred flesh, who paint themselves red before every kill.", SpireTyrantsOverall, IsScheme: true),

        FactionUnit(SpireTyrantsOverall, "Gladiator", "Unit-Specific Details",
        [
            new("Twin Cestus", "Leadbelcher", "as Overall armour scheme"),
            new("Warpaint", "Khorne Red", "as Overall warpaint scheme"),
        ]),

        FactionUnit(SpireTyrantsOverall, "Slaughterborn", "Unit-Specific Details",
        [
            new("Chained Weapon", "Leadbelcher", "as Overall armour scheme"),
            new("Skin", "Cadian Fleshtone", "as Overall skin scheme, extra Carroburg Crimson scarring"),
        ]),

        FactionUnit(SpireTyrantsOverall, "Bloodhunter", "Unit-Specific Details",
        [
            new("Throwing Blades", "Runefang Steel"),
            new("Harness", "Rhinox Hide", "as Overall leather scheme"),
        ]),

        FactionUnit(SpireTyrantsOverall, "Bruiser", "Unit-Specific Details",
        [
            new("Iron Collar & Chains", "Leadbelcher", "as Overall armour scheme"),
            new("Warpaint", "Khorne Red", "as Overall warpaint scheme"),
        ]),
    ], Category: GuideCategory.All, Game: Game.Warcry);
}
