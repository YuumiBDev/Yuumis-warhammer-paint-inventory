namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> UndeadOverall =
    [
        new("Bone",
        [
            new("Basecoat", "Ushabti Bone"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Screaming Skull"),
        ]),
        new("Tattered Kit Cloth",
        [
            new("Basecoat", "Xereus Purple"),
            new("Shade", "Druchii Violet"),
            new("Highlight", "Genestealer Purple", "dry, patchy edge highlight"),
        ]),
        new("Metal & Trim",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildUndead() => new("Undead",
    [
        new("Undead", "Sun-bleached bone under rotted purple kit rags — a slow, relentless roster of the tireless dead that never seems to actually leave the pitch.", UndeadOverall, IsScheme: true),

        FactionUnit(UndeadOverall, "Skeleton", "Unit-Specific Details",
        [
            new("Ribcage & Limbs", "Ushabti Bone", "as Overall bone scheme"),
            new("Ancient Weapon", "Leadbelcher", "Nuln Oil wash"),
        ]),

        FactionUnit(UndeadOverall, "Zombie", "Unit-Specific Details",
        [
            new("Rotting Flesh", "Death Guard Green", "Agrax Earthshade wash"),
            new("Tattered Kit", "Xereus Purple", "as Overall kit scheme, extra grime"),
        ]),

        FactionUnit(UndeadOverall, "Ghoul", "Unit-Specific Details",
        [
            new("Sickly Bare Skin", "Death Guard Green", "Athonian Camoshade wash"),
            new("Claws", "Ushabti Bone", "Agrax Earthshade wash"),
        ]),

        FactionUnit(UndeadOverall, "Wight", "Unit-Specific Details",
        [
            new("Ancient Armour", "Leadbelcher", "as Overall metal scheme, heavier plate than Skeletons"),
            new("Bone", "Ushabti Bone", "as Overall bone scheme"),
        ]),

        FactionUnit(UndeadOverall, "Mummy", "Unit-Specific Details",
        [
            new("Bandages", "Ushabti Bone", "Agrax Earthshade wash, heavy build-up in the recesses"),
            new("Exposed Wrappings", "Screaming Skull", "as Overall bone highlight"),
        ]),
    ], Category: GuideCategory.Teams, Game: Game.BloodBowl);
}
