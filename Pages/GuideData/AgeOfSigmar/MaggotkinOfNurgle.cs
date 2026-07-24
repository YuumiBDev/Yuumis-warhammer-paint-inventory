namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> MaggotkinOfNurgleOverall =
    [
        new("Flesh / Skin (Sickly Green)",
        [
            new("Basecoat", "Elysian Green"),
            new("Recess Shade", "Biel-Tan Green", "thinned wash for a diseased tint"),
            new("Layer", "Nurgling Green"),
            new("Edge Highlight", "Pallid Wych Flesh"),
        ]),
        new("Armour & Rusted Metal",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Rust Texture", "Typhus Corrosion", "technical paint stippled onto edges and rivets"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Details",
        [
            new("Buboes / Sores", "Pallid Wych Flesh", "Carroburg Crimson glaze for weeping wounds"),
            new("Fungus / Growths", "Nurgling Green", "Biel-Tan Green glaze"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Typhus Corrosion"),
            new("Basing", "Astrogranite Debris", "with Nurgle's Rot technical paint for oozing slime"),
        ]),
    ];

    private static FactionGuide BuildMaggotkinOfNurgle() => new("Maggotkin of Nurgle",
    [
        new("Overall (Head-to-Toe)", "The default Maggotkin of Nurgle colour scheme — sickly green flesh over rusted, corroded armour, finished with technical paint for weeping sores and slime. Rot is not a flaw here, it's a feature.", MaggotkinOfNurgleOverall, IsScheme: true),

        FactionUnit(MaggotkinOfNurgleOverall, "Plaguebearers", "Unit-Specific Details",
        [
            new("Body", "Elysian Green", "as Overall skin scheme"),
            new("Plaguesword", "Rhinox Hide", "Typhus Corrosion rust texture"),
            new("Fly Wings", "Pallid Wych Flesh", "thin translucent glaze"),
        ]),

        FactionUnit(MaggotkinOfNurgleOverall, "Putrid Blightkings", "Unit-Specific Details",
        [
            new("Bloated Flesh", "Elysian Green", "as Overall skin scheme, extra Carroburg Crimson glaze on sores"),
            new("Rusted Armour Plates", "Rhinox Hide", "as Overall armour scheme"),
            new("Weapons", "Leadbelcher", "Typhus Corrosion rust patches"),
        ]),

        FactionUnit(MaggotkinOfNurgleOverall, "Plague Drones", "Unit-Specific Details",
        [
            new("Fly Carapace", "Rhinox Hide", "Agrax Earthshade wash, Typhus Corrosion patches"),
            new("Wings", "Pallid Wych Flesh", "thin translucent glaze"),
            new("Rider Flesh", "Elysian Green", "as Overall skin scheme"),
        ]),

        FactionUnit(MaggotkinOfNurgleOverall, "Great Unclean One", "Unit-Specific Details",
        [
            new("Belly & Body", "Elysian Green", "as Overall skin scheme, largest surface for smooth blending"),
            new("Buboes / Wounds", "Pallid Wych Flesh", "Carroburg Crimson glaze"),
            new("Bell / Blade", "Rhinox Hide", "Typhus Corrosion rust texture"),
        ]),

        FactionUnit(MaggotkinOfNurgleOverall, "Rotbringer Sorcerer", "Unit-Specific Details",
        [
            new("Robes", "Rhinox Hide", "Agrax Earthshade wash"),
            new("Staff Glow", "Nurgling Green", "thin glaze"),
            new("Skin", "Elysian Green", "as Overall skin scheme"),
        ]),

        FactionUnit(MaggotkinOfNurgleOverall, "Beasts Of Nurgle", "Unit-Specific Details",
        [
            new("Hide", "Elysian Green", "as Overall skin scheme"),
            new("Slime Trail", "Nurgle's Rot", "technical paint along the base and hide"),
            new("Eyes", "Pallid Wych Flesh"),
        ]),

        FactionUnit(MaggotkinOfNurgleOverall, "Sloppity Bilepiper", "Unit-Specific Details",
        [
            new("Jester Motley", "Rhinox Hide", "Typhus Corrosion rust patches, torn patchwork"),
            new("Bagpipes", "Pallid Wych Flesh", "sickly translucent flesh-bag"),
            new("Skin", "Elysian Green", "as Overall skin scheme"),
        ]),
    ], Category: GuideCategory.Chaos, Game: Game.AgeOfSigmar);
}
