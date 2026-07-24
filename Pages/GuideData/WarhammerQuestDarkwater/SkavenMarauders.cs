namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> SkavenMaraudersOverall =
    [
        new("Fur",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
            new("Drybrush", "Mournfang Brown"),
        ]),
        new("Rusted Metal",
        [
            new("Basecoat", "Leadbelcher"),
            new("Wash", "Nuln Oil"),
            new("Rust", "Typhus Corrosion", "technical paint stippled onto edges"),
        ]),
        new("Cloth & Robes",
        [
            new("Basecoat", "Dryad Bark"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Steel Legion Drab"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Leadbelcher"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildSkavenMarauders() => new("Skaven Marauders",
    [
        new("Skaven Marauders", "The vermin swarms of the Darkwater depths — filthy brown fur and rusted scavenged metal, bred cheap and sent in by the thousand.", SkavenMaraudersOverall, IsScheme: true),

        FactionUnit(SkavenMaraudersOverall, "Clanrat", "Unit-Specific Details",
        [
            new("Rusty Blade", "Leadbelcher", "Typhus Corrosion rust patches"),
            new("Fur", "Rhinox Hide", "as Overall fur scheme"),
        ]),

        FactionUnit(SkavenMaraudersOverall, "Stormvermin", "Unit-Specific Details",
        [
            new("Heavy Armour", "Leadbelcher", "as Overall metal scheme, cleaner and more polished than Clanrats"),
            new("Halberd Blade", "Runefang Steel", "Nuln Oil recess"),
        ]),

        FactionUnit(SkavenMaraudersOverall, "Verminlord Despoiler", "Unit-Specific Details",
        [
            new("Fur", "Rhinox Hide", "as Overall fur scheme, largest surface for smooth blending"),
            new("Warpstone Weapon", "Warpstone Glow", "Biel-Tan Green glaze"),
        ]),

        FactionUnit(SkavenMaraudersOverall, "Vermin Swarm", "Unit-Specific Details",
        [
            new("Mass Fur", "Rhinox Hide", "as Overall fur scheme, dry-brushed heavily for texture"),
            new("Claws & Teeth", "Ushabti Bone"),
        ]),
    ], Category: GuideCategory.All, Game: Game.WarhammerQuestDarkwater);
}
