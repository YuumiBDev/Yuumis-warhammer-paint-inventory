namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> OrcOverall =
    [
        new("Skin",
        [
            new("Basecoat", "Waaagh! Flesh"),
            new("Shade", "Athonian Camoshade"),
            new("Highlight", "Biel-Tan Green", "drybrush"),
        ]),
        new("Kit (Jersey & Pads)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Highlight", "Eshin Grey", "edge highlight"),
            new("Trim", "Warboss Green"),
        ]),
        new("Leather & Metal",
        [
            new("Leather Basecoat", "Rhinox Hide"),
            new("Metal", "Leadbelcher"),
            new("Metal Shade", "Nuln Oil"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildOrc() => new("Orc",
    [
        new("Orc", "Black-and-green kit over mottled green hide — a brawling, physical roster that leans on brute strength and sheer intimidation over finesse.", OrcOverall, IsScheme: true),

        FactionUnit(OrcOverall, "Lineman", "Unit-Specific Details",
        [
            new("Tusks", "Ushabti Bone"),
            new("Studded Leather Pads", "Rhinox Hide", "as Overall leather scheme"),
        ]),

        FactionUnit(OrcOverall, "Blitzer", "Unit-Specific Details",
        [
            new("Spiked Shoulder Guard", "Leadbelcher", "Nuln Oil recess"),
            new("Green Kit Trim", "Warboss Green", "as Overall kit trim, brighter than Linemen"),
        ]),

        FactionUnit(OrcOverall, "Black Orc", "Unit-Specific Details",
        [
            new("Heavy Plate Armour", "Leadbelcher", "Nuln Oil wash, distinguishes it from lighter Orc Blockers"),
            new("Kit Cloth", "Abaddon Black", "as Overall kit scheme"),
        ]),

        FactionUnit(OrcOverall, "Thrower", "Unit-Specific Details",
        [
            new("Throwing Arm Wrap", "Ushabti Bone"),
            new("Skin", "Waaagh! Flesh", "as Overall skin scheme"),
        ]),

        FactionUnit(OrcOverall, "Troll", "Unit-Specific Details",
        [
            new("Warty Hide", "Death Guard Green", "Athonian Camoshade wash, distinct sickly hide from Orc skin"),
            new("Loincloth", "Rhinox Hide", "as Overall leather scheme"),
        ]),
    ], Category: GuideCategory.Teams, Game: Game.BloodBowl);
}
