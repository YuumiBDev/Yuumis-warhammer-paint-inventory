namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> HouseGoliathOverall =
    [
        new("Skin",
        [
            new("Basecoat", "Ratskin Flesh"),
            new("Shade", "Reikland Fleshshade"),
            new("Highlight", "Cadian Fleshtone"),
        ]),
        new("Tribal Paint & Mohawks",
        [
            new("Basecoat", "Troll Slayer Orange"),
            new("Highlight", "Fire Dragon Bright"),
        ]),
        new("Leathers, Straps & Chains",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Doombull Brown"),
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

    private static FactionGuide BuildHouseGoliath() => new("House Goliath",
    [
        new("Overall (Head-to-Toe)", "Brutish muscle-bound gangers with exposed, chem-enhanced flesh in a hot orange/red tone, tribal warpaint, and heavy chains — Goliath fighters look built to break down doors with their bare hands.", HouseGoliathOverall, IsScheme: true),

        FactionUnit(HouseGoliathOverall, "Goliath Ganger", "Unit-Specific Details",
        [
            new("Combat Blade / Fist", "Leadbelcher"),
            new("Chain Links", "Ironbreaker", "Nuln Oil wash for grime"),
        ]),

        FactionUnit(HouseGoliathOverall, "Goliath Juve", "Unit-Specific Details",
        [
            new("Tribal Paint", "Troll Slayer Orange", "fewer markings than veterans"),
            new("Strap Details", "Rhinox Hide"),
        ]),

        FactionUnit(HouseGoliathOverall, "Goliath Champion (Forge-born)", "Unit-Specific Details",
        [
            new("Augmetic Plating", "Runefang Steel"),
            new("Trophy Skulls", "Screaming Skull"),
            new("Warpaint", "Fire Dragon Bright"),
        ]),

        FactionUnit(HouseGoliathOverall, "Goliath Leader (Boss)", "Unit-Specific Details",
        [
            new("Fur Mantle / Trophies", "Dryad Bark", "Agrax Earthshade wash"),
            new("House Icon", "Runelord Brass"),
            new("Command Weapon Casing", "Abaddon Black"),
        ]),

        FactionUnit(HouseGoliathOverall, "Goliath Heavy", "Unit-Specific Details",
        [
            new("Heavy Weapon Housing", "Abaddon Black"),
            new("Weapon Barrel", "Leadbelcher"),
            new("Ammo Feed", "Runelord Brass"),
        ]),
    ], Category: GuideCategory.Gangs, Game: Game.Necromunda);
}
