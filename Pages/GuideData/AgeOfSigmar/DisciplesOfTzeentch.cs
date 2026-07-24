namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> DisciplesOfTzeentchOverall =
    [
        new("Body / Feathers (Blue)",
        [
            new("Basecoat", "Kantor Blue"),
            new("Recess Shade", "Drakenhof Nightshade"),
            new("Layer", "Teclis Blue"),
            new("Edge Highlight", "Lothern Blue"),
        ]),
        new("Pink Accents",
        [
            new("Basecoat", "Screamer Pink"),
            new("Shade", "Druchii Violet", "thinned wash for depth"),
            new("Highlight", "Screamer Pink", "clean re-highlight to keep the colour vivid"),
        ]),
        new("Trim & Gold",
        [
            new("Basecoat", "Auric Armour Gold"),
            new("Shade", "Reikland Fleshshade"),
            new("Edge Highlight", "Sycorax Bronze"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Auric Armour Gold"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildDisciplesOfTzeentch() => new("Disciples of Tzeentch",
    [
        new("Overall (Head-to-Toe)", "The default Disciples of Tzeentch colour scheme — vivid blue skin and feathers with hot pink accents, finished in gilded gold trim. A scheme built for magical, ever-shifting spectacle.", DisciplesOfTzeentchOverall, IsScheme: true),

        FactionUnit(DisciplesOfTzeentchOverall, "Pink Horrors", "Unit-Specific Details",
        [
            new("Body", "Screamer Pink", "as Overall pink accent scheme, applied to the whole body"),
            new("Shade", "Druchii Violet", "thinned wash for depth in the folds"),
            new("Beak / Claws", "Auric Armour Gold"),
        ]),

        FactionUnit(DisciplesOfTzeentchOverall, "Blue Horrors", "Unit-Specific Details",
        [
            new("Body", "Kantor Blue", "as Overall body scheme"),
            new("Highlight", "Lothern Blue"),
            new("Beak / Claws", "Auric Armour Gold"),
        ]),

        FactionUnit(DisciplesOfTzeentchOverall, "Tzaangors", "Unit-Specific Details",
        [
            new("Fur", "Mournfang Brown", "Agrax Earthshade wash, Doombull Brown drybrush"),
            new("Feathered Crest", "Kantor Blue", "as Overall body scheme"),
            new("Weapons", "Leadbelcher", "Nuln Oil wash"),
        ]),

        FactionUnit(DisciplesOfTzeentchOverall, "Kairic Acolytes", "Unit-Specific Details",
        [
            new("Robes", "Kantor Blue", "as Overall body scheme"),
            new("Icons / Script", "Screamer Pink", "fine detail work over robes"),
            new("Weapons", "Leadbelcher", "Nuln Oil wash"),
        ]),

        FactionUnit(DisciplesOfTzeentchOverall, "Lord Of Change", "Unit-Specific Details",
        [
            new("Wings", "Kantor Blue", "as Overall body scheme, larger surface for smooth blending"),
            new("Staff Head", "Auric Armour Gold", "Reikland Fleshshade wash"),
            new("Sorcerous Glow", "Screamer Pink", "thin glaze around the staff head"),
        ]),

        FactionUnit(DisciplesOfTzeentchOverall, "Curseling", "Unit-Specific Details",
        [
            new("Robes", "Kantor Blue", "as Overall body scheme"),
            new("Familiar / Disc", "Screamer Pink", "as Overall pink accent scheme"),
        ]),

        FactionUnit(DisciplesOfTzeentchOverall, "Fatemaster", "Unit-Specific Details",
        [
            new("Disc of Tzeentch", "Kantor Blue", "as Overall body scheme"),
            new("Standard", "Screamer Pink", "with Auric Armour Gold finial"),
        ]),

        FactionUnit(DisciplesOfTzeentchOverall, "Screamers", "Unit-Specific Details",
        [
            new("Body", "Kantor Blue", "as Overall body scheme"),
            new("Trailing Edges", "Screamer Pink", "as Overall pink accent scheme"),
            new("Tail Blade", "Auric Armour Gold"),
        ]),
    ], Category: GuideCategory.Chaos, Game: Game.AgeOfSigmar);
}
