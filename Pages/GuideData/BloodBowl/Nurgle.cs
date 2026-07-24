namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> NurgleOverall =
    [
        new("Skin",
        [
            new("Basecoat", "Death Guard Green"),
            new("Shade", "Athonian Camoshade"),
            new("Highlight", "Nurgling Green", "edge highlight"),
        ]),
        new("Decayed Kit Rags",
        [
            new("Basecoat", "Dryad Bark"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Steel Legion Drab"),
        ]),
        new("Pustules & Rot",
        [
            new("Basecoat", "Rakarth Flesh"),
            new("Ooze", "Nurgle's Rot", "technical paint dabbed onto boils and wounds"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildNurgle() => new("Nurgle",
    [
        new("Nurgle", "Sickly green hide under rotted brown kit rags — a slow, resilient roster that shrugs off punishment its opponents can't.", NurgleOverall, IsScheme: true),

        FactionUnit(NurgleOverall, "Rotter (Lineman)", "Unit-Specific Details",
        [
            new("Skin", "Death Guard Green", "as Overall skin scheme"),
            new("Tattered Kit", "Dryad Bark", "as Overall kit scheme, extra grime"),
        ]),

        FactionUnit(NurgleOverall, "Pestigor", "Unit-Specific Details",
        [
            new("Fur Legs", "Dryad Bark", "Agrax Earthshade wash"),
            new("Horns", "Rakarth Flesh"),
        ]),

        FactionUnit(NurgleOverall, "Nurgle Warrior", "Unit-Specific Details",
        [
            new("Boil-Covered Armour", "Death Guard Green", "as Overall skin scheme, heavier build-up of Nurgle's Rot"),
            new("Kit Rags", "Dryad Bark", "as Overall kit scheme"),
        ]),

        FactionUnit(NurgleOverall, "Bloater", "Unit-Specific Details",
        [
            new("Distended Belly", "Death Guard Green", "Athonian Camoshade wash, extra Nurgle's Rot ooze"),
            new("Straining Kit Straps", "Dryad Bark", "as Overall kit scheme"),
        ]),

        FactionUnit(NurgleOverall, "Rotspawn", "Unit-Specific Details",
        [
            new("Mutated Flesh", "Death Guard Green", "blended into Rakarth Flesh boils for corrupted variety"),
            new("Exposed Bone / Claws", "Ushabti Bone", "Agrax Earthshade wash"),
        ]),
    ], Category: GuideCategory.Teams, Game: Game.BloodBowl);
}
