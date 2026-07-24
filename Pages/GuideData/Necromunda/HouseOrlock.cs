namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> HouseOrlockOverall =
    [
        new("Skin",
        [
            new("Basecoat", "Bugman's Glow"),
            new("Shade", "Reikland Fleshshade"),
            new("Highlight", "Cadian Fleshtone"),
        ]),
        new("Denim & Fatigues",
        [
            new("Basecoat", "Fenrisian Grey"),
            new("Shade", "Drakenhof Nightshade"),
            new("Highlight", "Administratum Grey"),
        ]),
        new("Leather Jackets",
        [
            new("Basecoat", "Dryad Bark"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Mournfang Brown"),
        ]),
        new("Trim & Metal",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Ironbreaker"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Stirland Mud", "industrial rubble"),
        ]),
    ];

    private static FactionGuide BuildHouseOrlock() => new("House Orlock",
    [
        new("Overall (Head-to-Toe)", "Blue-grey denim and worn leather give Orlock gangers a rugged, biker-gang look — the workhorse House of the underhive, dependable and unglamorous.", HouseOrlockOverall, IsScheme: true),

        FactionUnit(HouseOrlockOverall, "Orlock Ganger", "Unit-Specific Details",
        [
            new("Combat Blade", "Ironbreaker"),
            new("Bandana / Patch", "Mephiston Red"),
        ]),

        FactionUnit(HouseOrlockOverall, "Orlock Juve", "Unit-Specific Details",
        [
            new("Denim Vest", "Fenrisian Grey", "lighter wear than veterans"),
            new("Strap Details", "Dryad Bark"),
        ]),

        FactionUnit(HouseOrlockOverall, "Orlock Champion", "Unit-Specific Details",
        [
            new("Goggles / Lenses", "Leadbelcher", "Nuln Oil wash"),
            new("Trophy Chain", "Ironbreaker"),
            new("Patch Colour", "Mephiston Red"),
        ]),

        FactionUnit(HouseOrlockOverall, "Orlock Leader (Boss)", "Unit-Specific Details",
        [
            new("Long Coat", "Dryad Bark", "Agrax Earthshade wash"),
            new("House Icon", "Runelord Brass"),
            new("Command Weapon Casing", "Abaddon Black"),
        ]),

        FactionUnit(HouseOrlockOverall, "Orlock Heavy", "Unit-Specific Details",
        [
            new("Heavy Weapon Housing", "Abaddon Black"),
            new("Weapon Barrel", "Leadbelcher"),
            new("Ammo Feed", "Runelord Brass"),
        ]),
    ], Category: GuideCategory.Gangs, Game: Game.Necromunda);
}
