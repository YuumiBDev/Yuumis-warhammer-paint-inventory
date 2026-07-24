namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> AngelsOfDeathOverall =
    [
        new("Armour (Grey)",
        [
            new("Basecoat", "Mechanicus Standard Grey"),
            new("Shade", "Nuln Oil"),
            new("Layer", "Dawnstone"),
            new("Highlight", "Administratum Grey"),
        ]),
        new("Trim (Blue)",
        [
            new("Basecoat", "Kantor Blue"),
            new("Shade", "Drakenhof Nightshade"),
            new("Highlight", "Alaitoc Blue"),
        ]),
        new("Metal & Weapons",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Ironbreaker"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildAngelsOfDeath() => new("Angels of Death",
    [
        new("Angels of Death", "A generic Space Marine kill team scheme — grey power armour with blue trim, adaptable to represent any unspecified Chapter.", AngelsOfDeathOverall, IsScheme: true),

        FactionUnit(AngelsOfDeathOverall, "Intercessor", "Unit-Specific Details",
        [
            new("Bolt Rifle Casing", "Abaddon Black"),
            new("Chapter Icon", "Retributor Armour"),
        ]),

        FactionUnit(AngelsOfDeathOverall, "Assault Intercessor", "Unit-Specific Details",
        [
            new("Chainsword Teeth", "Ironbreaker"),
            new("Blood & Chips", "Mephiston Red", "thin dry marks along the blade"),
        ]),

        FactionUnit(AngelsOfDeathOverall, "Aggressor", "Unit-Specific Details",
        [
            new("Auto Boltstorm Gauntlets", "Leadbelcher"),
            new("Reinforced Plating", "Administratum Grey", "extra edge highlight to sell the bulk"),
        ]),

        FactionUnit(AngelsOfDeathOverall, "Eliminator", "Unit-Specific Details",
        [
            new("Camo Cloak", "Dawnstone"),
            new("Las-Fusil Lens", "Lothern Blue"),
        ]),

        FactionUnit(AngelsOfDeathOverall, "Reiver", "Unit-Specific Details",
        [
            new("Grapnel Launcher", "Leadbelcher"),
            new("Skull Helm Details", "Screaming Skull"),
        ]),
    ], Category: GuideCategory.Imperial, Game: Game.KillTeam);
}
