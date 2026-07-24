namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> KasrkinOverall =
    [
        new("Fatigues",
        [
            new("Basecoat", "Castellan Green"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Straken Green", "drybrush"),
        ]),
        new("Carapace Armour",
        [
            new("Basecoat", "Mechanicus Standard Grey"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Dawnstone"),
        ]),
        new("Trim & Metal",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Ironbreaker"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static FactionGuide BuildKasrkin() => new("Kasrkin",
    [
        new("Kasrkin", "Astra Militarum's elite storm troopers — dark olive/khaki fatigues under heavy carapace armour, built for close-quarters void and urban assaults.", KasrkinOverall, IsScheme: true),

        FactionUnit(KasrkinOverall, "Sergeant", "Unit-Specific Details",
        [
            new("Rank Pin", "Runelord Brass"),
            new("Command Cloak", "Dryad Bark"),
        ]),

        FactionUnit(KasrkinOverall, "Veteran Guardsman", "Unit-Specific Details",
        [
            new("Lasgun Casing", "Abaddon Black"),
            new("Squad Markings", "Screaming Skull"),
        ]),

        FactionUnit(KasrkinOverall, "Demolitions Specialist", "Unit-Specific Details",
        [
            new("Melta Charges", "Abaddon Black", "housing"),
            new("Warning Stripes", "Yriel Yellow", "hazard markings on charge casing"),
        ]),

        FactionUnit(KasrkinOverall, "Vox-Operator", "Unit-Specific Details",
        [
            new("Vox-Caster Unit", "Leadbelcher"),
            new("Antenna", "Ironbreaker"),
        ]),

        FactionUnit(KasrkinOverall, "Sniper", "Unit-Specific Details",
        [
            new("Long-Las Scope Lens", "Lothern Blue"),
            new("Camo Cloak", "Dryad Bark", "Agrax Earthshade wash"),
        ]),
    ], Category: GuideCategory.Imperial, Game: Game.KillTeam);
}
