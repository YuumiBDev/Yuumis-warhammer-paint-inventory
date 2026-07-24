namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> HierotekCircleOverall =
    [
        new("Metal Body",
        [
            new("Basecoat", "Leadbelcher"),
            new("Wash", "Nuln Oil"),
            new("Layer", "Ironbreaker"),
            new("Highlight", "Stormhost Silver"),
        ]),
        new("Glowing Details",
        [
            new("Eyes / Rods", "Moot Green", "thin glaze for a glowing look"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildHierotekCircle() => new("Hierotek Circle",
    [
        new("Hierotek Circle", "Necron Cryptek-led cabals guarding a dynasty's most precious relics and secrets — the default gunmetal body with green glowing energy.", HierotekCircleOverall, IsScheme: true),

        FactionUnit(HierotekCircleOverall, "Cryptek", "Unit-Specific Details",
        [
            new("Arcane Staff", "Leadbelcher"),
            new("Tech Glow", "Moot Green", "thin glaze"),
        ]),

        FactionUnit(HierotekCircleOverall, "Deathmark", "Unit-Specific Details",
        [
            new("Synaptic Disintegrator", "Leadbelcher"),
            new("Targeting Glow", "Moot Green", "thin glaze"),
        ]),

        FactionUnit(HierotekCircleOverall, "Flayed One", "Unit-Specific Details",
        [
            new("Flayed Skin Cloak", "Abaddon Black", "Agrax Earthshade wash for a ragged texture"),
            new("Claws", "Leadbelcher"),
        ]),

        FactionUnit(HierotekCircleOverall, "Skorpekh Destroyer", "Unit-Specific Details",
        [
            new("Hyperphase Blades", "Stormhost Silver", "edge highlight"),
            new("Reactor Core Glow", "Moot Green", "larger glaze area"),
        ]),

        FactionUnit(HierotekCircleOverall, "Canoptek Scarab Swarm", "Unit-Specific Details",
        [
            new("Carapace", "Ironbreaker"),
            new("Underbelly Glow", "Moot Green", "thin glaze"),
        ]),
    ], Category: GuideCategory.Xenos, Game: Game.KillTeam);
}
