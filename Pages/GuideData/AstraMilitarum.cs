namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> AstraMilitarumOverall =
    [
        new("Fatigues",
        [
            new("Basecoat", "Zandri Dust"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Screaming Skull", "drybrush"),
        ]),
        new("Webbing & Leather",
        [
            new("Basecoat", "Dryad Bark"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
        ]),
    ];

    private static FactionGuide BuildAstraMilitarum() => new("Astra Militarum",
    [
        new("Cadian", "The default and most iconic Regiment — khaki fatigues, dark leather webbing.", AstraMilitarumOverall, IsScheme: true),

        FactionUnit(AstraMilitarumOverall, "Infantry Squad", "Unit-Specific Details",
        [
            new("Lasgun Casing", "Abaddon Black"),
            new("Squad Markings", "Screaming Skull"),
        ]),

        FactionUnit(AstraMilitarumOverall, "Command Squad", "Unit-Specific Details",
        [
            new("Vox-Caster Antenna", "Leadbelcher"),
            new("Banner / Icon", "Mephiston Red"),
            new("Officer Cap Trim", "Runelord Brass"),
        ]),

        FactionUnit(AstraMilitarumOverall, "Heavy Weapons Squad", "Unit-Specific Details",
        [
            new("Heavy Weapon Housing", "Abaddon Black"),
            new("Weapon Barrel", "Leadbelcher"),
            new("Tripod / Mount", "Dryad Bark"),
        ]),

        FactionUnit(AstraMilitarumOverall, "Veterans", "Unit-Specific Details",
        [
            new("Carapace Armour Plates", "Administratum Grey", "distinguishes from standard fatigues"),
            new("Plate Trim", "Runelord Brass"),
        ]),

        FactionUnit(AstraMilitarumOverall, "Ogryns", "Unit-Specific Details",
        [
            new("Ripper Gun", "Abaddon Black"),
            new("Bare Skin", "Cadian Fleshtone", "Reikland Fleshshade wash"),
            new("Bandages / Straps", "Dryad Bark"),
        ]),

        FactionUnit(AstraMilitarumOverall, "Commissar", "Unit-Specific Details",
        [
            new("Greatcoat", "Abaddon Black", "distinct from squad fatigues"),
            new("Cap & Coat Trim", "Runelord Brass"),
        ]),

        FactionUnit(AstraMilitarumOverall, "Tank Commander", "Vehicle-Specific Details",
        [
            new("Turret Pennant", "Mephiston Red"),
            new("Hull Panels", "Zandri Dust", "as Overall fatigues scheme"),
            new("Command Antenna", "Leadbelcher"),
        ]),

        FactionUnit(AstraMilitarumOverall, "Leman Russ", "Vehicle-Specific Details",
        [
            new("Hull Panels", "Zandri Dust", "as Overall fatigues scheme"),
            new("Turret Barrel", "Leadbelcher"),
            new("Track Weathering", "Agrax Earthshade"),
        ]),

        FactionUnit(AstraMilitarumOverall, "Chimera", "Vehicle-Specific Details",
        [
            new("Hull Panels", "Zandri Dust", "as Overall fatigues scheme"),
            new("Firing Ports", "Abaddon Black"),
            new("Track Weathering", "Agrax Earthshade"),
        ]),

        FactionUnit(AstraMilitarumOverall, "Basilisk", "Vehicle-Specific Details",
        [
            new("Hull Panels", "Zandri Dust", "as Overall fatigues scheme"),
            new("Gun Barrel", "Leadbelcher"),
            new("Track Weathering", "Agrax Earthshade"),
        ]),
    ]);
}
