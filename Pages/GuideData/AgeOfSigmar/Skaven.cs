namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> SkavenOverall =
    [
        new("Fur",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
            new("Drybrush", "Mournfang Brown"),
            new("Edge Highlight", "Skrag Brown"),
        ]),
        new("Rusted Metal & Weapons",
        [
            new("Basecoat", "Leadbelcher"),
            new("Wash", "Nuln Oil"),
            new("Rust Patches", "Typhus Corrosion", "technical paint stippled onto edges"),
            new("Edge Highlight", "Runefang Steel"),
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

    private static FactionGuide BuildSkaven() => new("Skaven",
    [
        new("Overall (Head-to-Toe)", "The default Skaven colour scheme — filthy brown fur, rusted scavenged metal and tattered cloth. Cheap, disposable and built by the thousand, exactly as the Under-Empire intends.", SkavenOverall, IsScheme: true),

        FactionUnit(SkavenOverall, "Clanrats", "Unit-Specific Details",
        [
            new("Fur", "Rhinox Hide", "as Overall fur scheme"),
            new("Rusty Blade", "Leadbelcher", "Typhus Corrosion rust patches"),
            new("Tattered Robes", "Dryad Bark", "as Overall cloth scheme"),
        ]),

        FactionUnit(SkavenOverall, "Stormvermin", "Unit-Specific Details",
        [
            new("Heavy Armour", "Leadbelcher", "as Overall metal scheme, cleaner and more polished than Clanrats"),
            new("Fur", "Rhinox Hide", "as Overall fur scheme"),
            new("Halberd Blade", "Runefang Steel", "Nuln Oil recess"),
        ]),

        FactionUnit(SkavenOverall, "Plague Monks", "Unit-Specific Details",
        [
            new("Ragged Robes", "Dryad Bark", "as Overall cloth scheme, extra Typhus Corrosion grime"),
            new("Fur", "Rhinox Hide", "as Overall fur scheme"),
            new("Weapon", "Leadbelcher", "Typhus Corrosion rust patches"),
        ]),

        FactionUnit(SkavenOverall, "Gutter Runners", "Unit-Specific Details",
        [
            new("Fur", "Rhinox Hide", "as Overall fur scheme, slightly darker for stealth"),
            new("Blades", "Runefang Steel", "Nuln Oil recess, thin black poison glaze at the tip"),
        ]),

        FactionUnit(SkavenOverall, "Warp Lightning Cannon", "Vehicle-Specific Details",
        [
            new("Cannon Frame", "Leadbelcher", "Typhus Corrosion rust patches"),
            new("Warpstone Core", "Warpstone Glow", "Biel-Tan Green glaze for a crackling glow"),
            new("Crew Fur", "Rhinox Hide", "as Overall fur scheme"),
        ]),

        FactionUnit(SkavenOverall, "Grey Seer", "Unit-Specific Details",
        [
            new("Fur", "Dawnstone", "Nuln Oil wash, White Scar drybrush for a distinctive grey pelt"),
            new("Robes", "Dryad Bark", "as Overall cloth scheme"),
            new("Warpstone Staff", "Warpstone Glow", "Biel-Tan Green glaze"),
        ]),

        FactionUnit(SkavenOverall, "Verminlord", "Unit-Specific Details",
        [
            new("Fur", "Rhinox Hide", "as Overall fur scheme, largest surface for smooth blending"),
            new("Weapons / Armour", "Leadbelcher", "Typhus Corrosion rust patches"),
            new("Warpstone Details", "Warpstone Glow", "Biel-Tan Green glaze"),
        ]),

        FactionUnit(SkavenOverall, "Rat Ogors", "Unit-Specific Details",
        [
            new("Fur", "Rhinox Hide", "as Overall fur scheme"),
            new("Exposed Muscle / Wounds", "Carroburg Crimson", "deep glaze in torn areas"),
            new("Bionic Fittings", "Leadbelcher", "Typhus Corrosion rust patches"),
        ]),
    ], Category: GuideCategory.Chaos, Game: Game.AgeOfSigmar);
}
