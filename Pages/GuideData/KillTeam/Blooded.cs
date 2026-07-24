namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> BloodedOverall =
    [
        new("Fatigues (Corrupted Khaki)",
        [
            new("Basecoat", "Zandri Dust"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Screaming Skull", "drybrush"),
        ]),
        new("Corruption Details",
        [
            new("Sigils / Markings", "Mephiston Red"),
            new("Wash", "Nuln Oil"),
        ]),
        new("Webbing & Leather",
        [
            new("Basecoat", "Dryad Bark"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildBlooded() => new("Blooded",
    [
        new("Blooded", "Astra Militarum regiments turned traitor — the same khaki fatigues and webbing as their loyalist kin, corrupted with daubed sigils and grime.", BloodedOverall, IsScheme: true),

        FactionUnit(BloodedOverall, "Vulture", "Unit-Specific Details",
        [
            new("Trench Coat", "Dryad Bark"),
            new("Warband Icon", "Mephiston Red"),
        ]),

        FactionUnit(BloodedOverall, "Butcher", "Unit-Specific Details",
        [
            new("Cleaver Blade", "Leadbelcher"),
            new("Blood Stains", "Mephiston Red", "thin dry marks"),
        ]),

        FactionUnit(BloodedOverall, "Ogre", "Unit-Specific Details",
        [
            new("Bulky Armour Plates", "Steel Legion Drab"),
            new("Plate Rivets", "Leadbelcher"),
        ]),

        FactionUnit(BloodedOverall, "Rabble", "Unit-Specific Details",
        [
            new("Lasgun Casing", "Abaddon Black"),
            new("Mismatched Kit", "Steel Legion Drab", "scavenged gear in a contrasting tone"),
        ]),

        FactionUnit(BloodedOverall, "Trapper", "Unit-Specific Details",
        [
            new("Sniper Rifle", "Leadbelcher"),
            new("Camo Netting", "Dryad Bark", "Agrax Earthshade wash"),
        ]),
    ], Category: GuideCategory.Chaos, Game: Game.KillTeam);
}
