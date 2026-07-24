namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> BloodBowlSkavenOverall =
    [
        new("Fur",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Mournfang Brown", "drybrush"),
        ]),
        new("Kit (Jersey & Pads)",
        [
            new("Basecoat", "Xereus Purple"),
            new("Shade", "Druchii Violet"),
            new("Highlight", "Genestealer Purple"),
            new("Trim", "Abaddon Black"),
        ]),
        new("Metal & Weapons",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Rust Patches", "Typhus Corrosion", "technical paint stippled onto edges"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Leadbelcher"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildBloodBowlSkaven() => new("Skaven",
    [
        new("Skaven", "Purple-and-black kit over filthy brown fur — a fast, fragile roster built entirely around speed and sheer numbers, exactly as the Under-Empire intends.", BloodBowlSkavenOverall, IsScheme: true),

        FactionUnit(BloodBowlSkavenOverall, "Lineman", "Unit-Specific Details",
        [
            new("Fur", "Rhinox Hide", "as Overall fur scheme"),
            new("Rusty Blade", "Leadbelcher", "Typhus Corrosion rust patches"),
        ]),

        FactionUnit(BloodBowlSkavenOverall, "Thrower", "Unit-Specific Details",
        [
            new("Kit Trim", "Xereus Purple", "as Overall kit scheme"),
            new("Throwing Arm Wrap", "Ushabti Bone"),
        ]),

        FactionUnit(BloodBowlSkavenOverall, "Gutter Runner", "Unit-Specific Details",
        [
            new("Fur", "Rhinox Hide", "as Overall fur scheme, slightly darker for stealth"),
            new("Blades", "Leadbelcher", "Nuln Oil recess, thin black poison glaze at the tip"),
        ]),

        FactionUnit(BloodBowlSkavenOverall, "Blitzer", "Unit-Specific Details",
        [
            new("Reinforced Padding", "Genestealer Purple", "as Overall kit highlight, wider trim than Linemen"),
            new("Claws", "Leadbelcher", "Nuln Oil wash"),
        ]),

        FactionUnit(BloodBowlSkavenOverall, "Rat Ogre", "Unit-Specific Details",
        [
            new("Fur", "Rhinox Hide", "as Overall fur scheme"),
            new("Exposed Muscle / Wounds", "Carroburg Crimson", "deep glaze in torn areas"),
            new("Bionic Fittings", "Leadbelcher", "Typhus Corrosion rust patches"),
        ]),
    ], Category: GuideCategory.Teams, Game: Game.BloodBowl);
}
