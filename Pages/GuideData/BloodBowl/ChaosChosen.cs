namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> ChaosChosenOverall =
    [
        new("Kit (Jersey & Pads)",
        [
            new("Basecoat", "Khorne Red"),
            new("Shade", "Carroburg Crimson"),
            new("Highlight", "Evil Sunz Scarlet"),
        ]),
        new("Trim & Straps",
        [
            new("Basecoat", "Abaddon Black"),
            new("Highlight", "Eshin Grey", "edge highlight"),
        ]),
        new("Icon & Metal",
        [
            new("Metal Basecoat", "Warplock Bronze"),
            new("Metal Shade", "Agrax Earthshade"),
            new("Metal Highlight", "Sycorax Bronze"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildChaosChosen() => new("Chaos Chosen",
    [
        new("Chaos Chosen", "Blood-red and black kit stamped with brazen Chaos icons — a brutal, mutation-heavy roster that punishes opponents through raw violence.", ChaosChosenOverall, IsScheme: true),

        FactionUnit(ChaosChosenOverall, "Beastman", "Unit-Specific Details",
        [
            new("Fur Legs", "Dryad Bark", "Agrax Earthshade wash"),
            new("Horns", "Ushabti Bone"),
        ]),

        FactionUnit(ChaosChosenOverall, "Chaos Warrior", "Unit-Specific Details",
        [
            new("Heavy Plate Armour", "Abaddon Black", "as Overall trim scheme, full plate rather than pads"),
            new("Icon Detailing", "Warplock Bronze", "as Overall icon scheme"),
        ]),

        FactionUnit(ChaosChosenOverall, "Chaos Troll", "Unit-Specific Details",
        [
            new("Warty Hide", "Death Guard Green", "Athonian Camoshade wash"),
            new("Loincloth", "Khorne Red", "as Overall kit scheme"),
        ]),

        FactionUnit(ChaosChosenOverall, "Chaos Ogre", "Unit-Specific Details",
        [
            new("Bare Skin", "Cadian Fleshtone", "Reikland Fleshshade wash"),
            new("Chain Harness", "Warplock Bronze", "as Overall icon scheme"),
        ]),

        FactionUnit(ChaosChosenOverall, "Chaos Spawn", "Unit-Specific Details",
        [
            new("Mutated Flesh", "Khorne Red", "blended into Death Guard Green patches for corrupted variety"),
            new("Exposed Bone / Claws", "Ushabti Bone", "Agrax Earthshade wash"),
        ]),
    ], Category: GuideCategory.Teams, Game: Game.BloodBowl);
}
