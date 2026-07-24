namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> KommandosOverall =
    [
        new("Skin",
        [
            new("Basecoat", "Waaagh! Flesh"),
            new("Shade", "Biel-Tan Green", "recesses"),
            new("Highlight", "Skarsnik Green", "edges"),
        ]),
        new("Camo Gear (Green/Khaki)",
        [
            new("Basecoat", "Straken Green"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Zandri Dust"),
        ]),
        new("Metal & Weapons",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Ironbreaker"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel", "chipped edges"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static FactionGuide BuildKommandos() => new("Kommandos",
    [
        new("Kommandos", "Ork sneaky boyz who paint themselves up in camo gear to infiltrate and ambush — green skin under mottled khaki-and-green camo webbing.", KommandosOverall, IsScheme: true),

        FactionUnit(KommandosOverall, "Boss Nob", "Unit-Specific Details",
        [
            new("Big Choppa", "Leadbelcher"),
            new("Trophy Rack", "Zandri Dust", "bone trophies"),
        ]),

        FactionUnit(KommandosOverall, "Kommando", "Unit-Specific Details",
        [
            new("Slugga", "Leadbelcher"),
            new("Camo Cloak", "Straken Green", "as Overall camo scheme"),
        ]),

        FactionUnit(KommandosOverall, "Breacha Boy", "Unit-Specific Details",
        [
            new("Breachin' Charge", "Abaddon Black"),
            new("Warning Stripes", "Yriel Yellow"),
        ]),

        FactionUnit(KommandosOverall, "Rokkit Launcha", "Unit-Specific Details",
        [
            new("Launcher Tube", "Leadbelcher"),
            new("Rokkit Warhead", "Mephiston Red"),
        ]),

        FactionUnit(KommandosOverall, "Spotter", "Unit-Specific Details",
        [
            new("Squig Hound", "Rhinox Hide"),
            new("Marker Flag", "Yriel Yellow"),
        ]),
    ], Category: GuideCategory.Xenos, Game: Game.KillTeam);
}
