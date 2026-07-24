namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> HumanOverall =
    [
        new("Kit (Jersey & Leggings)",
        [
            new("Basecoat", "Macragge Blue"),
            new("Shade", "Drakenhof Nightshade"),
            new("Highlight", "Calgar Blue", "edge highlight"),
        ]),
        new("Trim & Gold Details",
        [
            new("Basecoat", "Retributor Armour"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Auric Armour Gold"),
        ]),
        new("Leather & Padding",
        [
            new("Basecoat", "Doombull Brown"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Mournfang Brown"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildHuman() => new("Human",
    [
        new("Human", "The classic blue-and-gold sporting kit — a disciplined, well-drilled roster with no glaring weaknesses, built around solid fundamentals rather than any single gimmick.", HumanOverall, IsScheme: true),

        FactionUnit(HumanOverall, "Lineman", "Unit-Specific Details",
        [
            new("Helmet", "Retributor Armour", "as Overall trim scheme"),
            new("Squad Number", "White Scar"),
        ]),

        FactionUnit(HumanOverall, "Thrower", "Unit-Specific Details",
        [
            new("Throwing Arm Padding", "Screaming Skull", "distinguishes the passing arm"),
            new("Ball Grip Glove", "Dryad Bark"),
        ]),

        FactionUnit(HumanOverall, "Catcher", "Unit-Specific Details",
        [
            new("Lightweight Padding", "Ushabti Bone", "trimmed-down armour built for speed"),
            new("Boots", "Abaddon Black"),
        ]),

        FactionUnit(HumanOverall, "Blitzer", "Unit-Specific Details",
        [
            new("Reinforced Shoulder Guards", "Retributor Armour", "heavier gold trim than Linemen"),
            new("Studded Gauntlets", "Leadbelcher"),
        ]),

        FactionUnit(HumanOverall, "Ogre", "Unit-Specific Details",
        [
            new("Bare Skin", "Cadian Fleshtone", "Reikland Fleshshade wash"),
            new("Chain Harness", "Leadbelcher", "Nuln Oil wash"),
            new("Kit Cloth Patch", "Macragge Blue", "as Overall kit scheme, small panel only"),
        ]),
    ], Category: GuideCategory.Teams, Game: Game.BloodBowl);
}
