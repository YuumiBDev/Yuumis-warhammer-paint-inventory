namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> NorseOverall =
    [
        new("Kit (Jersey & Leggings)",
        [
            new("Basecoat", "Fenrisian Grey"),
            new("Shade", "Drakenhof Nightshade"),
            new("Highlight", "White Scar", "icy edge highlight"),
        ]),
        new("Fur Trim",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
            new("Drybrush", "Screaming Skull", "pale fur trim"),
        ]),
        new("Leather & Straps",
        [
            new("Basecoat", "Mournfang Brown"),
            new("Shade", "Agrax Earthshade"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildNorse() => new("Norse",
    [
        new("Norse", "Icy blue-and-white kit trimmed with pale fur — a reckless, high-scoring roster that trades defence for relentless offence.", NorseOverall, IsScheme: true),

        FactionUnit(NorseOverall, "Lineman (Norse Raider)", "Unit-Specific Details",
        [
            new("Fur Cloak", "Rhinox Hide", "as Overall fur trim scheme"),
            new("Kit Panel", "Fenrisian Grey", "as Overall kit scheme"),
        ]),

        FactionUnit(NorseOverall, "Thrower", "Unit-Specific Details",
        [
            new("Throwing Arm Wrap", "Screaming Skull", "as Overall fur trim highlight"),
            new("Leather Strap", "Mournfang Brown", "as Overall leather scheme"),
        ]),

        FactionUnit(NorseOverall, "Berserker", "Unit-Specific Details",
        [
            new("Bare Torso", "Cadian Fleshtone", "Reikland Fleshshade wash, no armour worn into battle"),
            new("War Paint", "White Scar", "streaked across face and chest"),
        ]),

        FactionUnit(NorseOverall, "Ulfwerener", "Unit-Specific Details",
        [
            new("Wolf Pelt", "Rhinox Hide", "Agrax Earthshade wash, Screaming Skull drybrush"),
            new("Kit Panel", "Fenrisian Grey", "as Overall kit scheme"),
        ]),

        FactionUnit(NorseOverall, "Yhetee", "Unit-Specific Details",
        [
            new("Shaggy White Fur", "Ushabti Bone", "Agrax Earthshade wash, White Scar drybrush"),
            new("Claws", "Abaddon Black"),
        ]),
    ], Category: GuideCategory.Teams, Game: Game.BloodBowl);
}
