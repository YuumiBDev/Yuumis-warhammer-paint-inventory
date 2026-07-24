namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> MordorOverall =
    [
        new("Armour",
        [
            new("Basecoat", "Abaddon Black"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Eshin Grey", "edge highlight"),
        ]),
        new("Skin",
        [
            new("Basecoat", "Dawnstone"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Administratum Grey"),
        ]),
        new("Trim & Metal",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil", "heavy, pitted"),
            new("Highlight", "Ironbreaker", "sparse"),
        ]),
        new("Leathers & Straps",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Stirland Mud", "ashen wasteland"),
        ]),
    ];

    private static FactionGuide BuildMordor() => new("Mordor",
    [
        new("Orcs of Mordor", "The teeming hosts of the Dark Lord — jagged black iron armour over sallow, grey-brown hide, marched under the Red Eye.", MordorOverall, IsScheme: true),

        FactionUnit(MordorOverall, "Morannon Orcs", "Unit-Specific Details",
        [
            new("Black Gate Livery", "Abaddon Black", "as Overall armour scheme"),
            new("Eye of Sauron Icon", "Mephiston Red"),
        ]),

        FactionUnit(MordorOverall, "Black Uruks", "Unit-Specific Details",
        [
            new("Heavier Armour", "Eshin Grey", "as Overall scheme, more coverage"),
            new("Topknot", "Rhinox Hide"),
            new("Blade Edge", "Ironbreaker"),
        ]),

        FactionUnit(MordorOverall, "The Mouth of Sauron", "Unit-Specific Details",
        [
            new("Robes", "Abaddon Black"),
            new("Helm", "Leadbelcher"),
            new("Eye Symbol", "Mephiston Red"),
        ]),

        FactionUnit(MordorOverall, "Gothmog", "Unit-Specific Details",
        [
            new("Diseased Flesh", "Rakarth Flesh"),
            new("Flesh Shade", "Carroburg Crimson", "sickly, wounded look"),
            new("Armour", "Leadbelcher"),
        ]),

        FactionUnit(MordorOverall, "Nazgul", "Unit-Specific Details",
        [
            new("Tattered Robes", "Abaddon Black"),
            new("Robes Highlight", "Dawnstone", "drybrush"),
            new("Crown", "Runefang Steel"),
        ]),
    ], Category: GuideCategory.Evil, Game: Game.MiddleEarth);
}
