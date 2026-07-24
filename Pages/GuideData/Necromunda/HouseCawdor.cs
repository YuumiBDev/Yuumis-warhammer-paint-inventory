namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> HouseCawdorOverall =
    [
        new("Robes & Hoods",
        [
            new("Basecoat", "Dryad Bark"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Doombull Brown"),
        ]),
        new("Zealot Cloth (Red)",
        [
            new("Basecoat", "Khorne Red"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Evil Sunz Scarlet"),
        ]),
        new("Chains, Icons & Metal",
        [
            new("Basecoat", "Warplock Bronze"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Brass Scorpion"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Balthasar Gold"),
            new("Basing", "Stirland Mud", "underhive rubble"),
        ]),
    ];

    private static FactionGuide BuildHouseCawdor() => new("House Cawdor",
    [
        new("Overall (Head-to-Toe)", "Ragged brown robes, rusted chains, and blood-red zealot cloth give House Cawdor the look of a hooded doomsday cult crawling up from the deepest underhive.", HouseCawdorOverall, IsScheme: true),

        FactionUnit(HouseCawdorOverall, "Cawdor Ganger", "Unit-Specific Details",
        [
            new("Flail / Blade", "Warplock Bronze"),
            new("Holy Symbol", "Brass Scorpion"),
        ]),

        FactionUnit(HouseCawdorOverall, "Cawdor Juve", "Unit-Specific Details",
        [
            new("Robe", "Dryad Bark", "less weathered than veterans"),
            new("Rope / Bindings", "Doombull Brown"),
        ]),

        FactionUnit(HouseCawdorOverall, "Cawdor Champion (Zealot)", "Unit-Specific Details",
        [
            new("Ritual Scarring", "Khorne Red"),
            new("Icon Chain", "Brass Scorpion"),
            new("Robe Trim", "Evil Sunz Scarlet"),
        ]),

        FactionUnit(HouseCawdorOverall, "Cawdor Leader (Prophet)", "Unit-Specific Details",
        [
            new("Prophet's Cloak", "Khorne Red", "Nuln Oil recess shade"),
            new("House Icon", "Balthasar Gold"),
            new("Command Weapon Casing", "Abaddon Black"),
        ]),

        FactionUnit(HouseCawdorOverall, "Cawdor Heavy", "Unit-Specific Details",
        [
            new("Heavy Weapon Housing", "Abaddon Black"),
            new("Weapon Barrel", "Warplock Bronze"),
            new("Ammo Feed", "Brass Scorpion"),
        ]),
    ], Category: GuideCategory.Gangs, Game: Game.Necromunda);
}
