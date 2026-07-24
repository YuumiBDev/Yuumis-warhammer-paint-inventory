namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> LegionaryOverall =
    [
        new("Armour (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Recess Shade", "Nuln Oil", "extra thinned wash into panel lines for depth"),
            new("Drybrush", "Eshin Grey"),
            new("Edge Highlight", "Dawnstone"),
        ]),
        new("Trim (Brass)",
        [
            new("Basecoat", "Hashut Copper"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Sycorax Bronze"),
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

    private static FactionGuide BuildLegionary() => new("Legionary",
    [
        new("Legionary", "Renegade Chaos Space Marines fighting outside the sanction of any Legion — black power armour trimmed in brass, marked with whatever icons the warband favours.", LegionaryOverall, IsScheme: true),

        FactionUnit(LegionaryOverall, "Aspiring Champion", "Unit-Specific Details",
        [
            new("Icon / Trophy Rack", "Sycorax Bronze", "as Overall trim scheme"),
            new("Blade Edge", "Runefang Steel"),
        ]),

        FactionUnit(LegionaryOverall, "Chosen", "Unit-Specific Details",
        [
            new("Additional Trim", "Hashut Copper", "as Overall trim scheme"),
            new("Heavy Weapon Housing", "Leadbelcher"),
        ]),

        FactionUnit(LegionaryOverall, "Cultist", "Unit-Specific Details",
        [
            new("Ragged Robes", "Dryad Bark"),
            new("Chaos Sigils", "Mephiston Red", "daubed markings"),
        ]),

        FactionUnit(LegionaryOverall, "Heavy Weapon", "Unit-Specific Details",
        [
            new("Weapon Barrel", "Leadbelcher"),
            new("Ammo Belt", "Hashut Copper"),
        ]),

        FactionUnit(LegionaryOverall, "Icon Bearer", "Unit-Specific Details",
        [
            new("Chaos Icon", "Mephiston Red"),
            new("Warp Glow", "Warpstone Glow", "thin glaze"),
        ]),
    ], Category: GuideCategory.Chaos, Game: Game.KillTeam);
}
