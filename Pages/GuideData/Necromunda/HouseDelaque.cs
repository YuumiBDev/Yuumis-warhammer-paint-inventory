namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> HouseDelaqueOverall =
    [
        new("Coats & Cloth (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Edge Highlight", "Eshin Grey"),
            new("Fine Edge Highlight", "Dawnstone"),
        ]),
        new("Leather Straps & Gloves",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
        ]),
        new("Goggles & Lenses",
        [
            new("Basecoat", "Caliban Green"),
            new("Layer", "Warpstone Glow"),
            new("Edge Highlight", "Moot Green"),
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
            new("Basing", "Stirland Mud", "underhive rubble"),
        ]),
    ];

    private static FactionGuide BuildHouseDelaque() => new("House Delaque",
    [
        new("Overall (Head-to-Toe)", "Shadowy black trenchcoats, wide-brimmed hats, and glowing green goggle-lenses mark House Delaque as the underhive's spies and information brokers — muted, watchful, and unsettling.", HouseDelaqueOverall, IsScheme: true),

        FactionUnit(HouseDelaqueOverall, "Delaque Ganger", "Unit-Specific Details",
        [
            new("Combat Blade", "Ironbreaker"),
            new("Lens Glow", "Warpstone Glow"),
        ]),

        FactionUnit(HouseDelaqueOverall, "Delaque Juve", "Unit-Specific Details",
        [
            new("Coat", "Abaddon Black", "less weathering than veterans"),
            new("Strap Details", "Rhinox Hide"),
        ]),

        FactionUnit(HouseDelaqueOverall, "Delaque Champion", "Unit-Specific Details",
        [
            new("Wide-Brimmed Hat", "Abaddon Black", "Eshin Grey edge highlight"),
            new("Lens Glow", "Moot Green"),
            new("Weapon Casing", "Leadbelcher"),
        ]),

        FactionUnit(HouseDelaqueOverall, "Delaque Leader (Baron)", "Unit-Specific Details",
        [
            new("Long Coat", "Abaddon Black", "Dawnstone fine edge highlight"),
            new("House Icon", "Runefang Steel"),
            new("Command Weapon Casing", "Leadbelcher"),
        ]),

        FactionUnit(HouseDelaqueOverall, "Delaque Heavy", "Unit-Specific Details",
        [
            new("Heavy Weapon Housing", "Abaddon Black"),
            new("Weapon Barrel", "Leadbelcher"),
            new("Ammo Feed", "Ironbreaker"),
        ]),
    ], Category: GuideCategory.Gangs, Game: Game.Necromunda);
}
