namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> CorsairVoidscarredOverall =
    [
        new("Armour / Wraithbone",
        [
            new("Basecoat", "Wraithbone"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Ulthuan Grey", "fine edges"),
        ]),
        new("Trim (Purple/Orange)",
        [
            new("Basecoat", "Xereus Purple"),
            new("Shade", "Druchii Violet"),
            new("Accent Stripes", "Fire Dragon Bright", "bold contrasting stripes for a piratical look"),
        ]),
        new("Weapons / Metal",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildCorsairVoidscarred() => new("Corsair Voidscarred",
    [
        new("Corsair Voidscarred", "Aeldari corsairs and pirates who abandoned their Craftworlds and Paths to raid the void — wraithbone armour trimmed in a vivid purple-and-orange colour scheme.", CorsairVoidscarredOverall, IsScheme: true),

        FactionUnit(CorsairVoidscarredOverall, "Corsair Prince", "Unit-Specific Details",
        [
            new("Cloak", "Xereus Purple", "as Overall trim scheme"),
            new("Trophy Regalia", "Fire Dragon Bright"),
        ]),

        FactionUnit(CorsairVoidscarredOverall, "Voidscarred", "Unit-Specific Details",
        [
            new("Shuriken Weapon Casing", "Leadbelcher"),
            new("Helm Crest", "Fire Dragon Bright"),
        ]),

        FactionUnit(CorsairVoidscarredOverall, "Reaver", "Unit-Specific Details",
        [
            new("Jetbike/Skyboard Hull", "Wraithbone", "as Overall armour scheme"),
            new("Speed Stripes", "Fire Dragon Bright"),
        ]),

        FactionUnit(CorsairVoidscarredOverall, "Bladestorm Warrior", "Unit-Specific Details",
        [
            new("Shuriken Catapult", "Leadbelcher"),
            new("Sash", "Xereus Purple"),
        ]),

        FactionUnit(CorsairVoidscarredOverall, "Skyreaper", "Unit-Specific Details",
        [
            new("Skyreaper Launcher", "Leadbelcher"),
            new("Targeting Lens", "Fire Dragon Bright"),
        ]),
    ], Category: GuideCategory.Xenos, Game: Game.KillTeam);
}
