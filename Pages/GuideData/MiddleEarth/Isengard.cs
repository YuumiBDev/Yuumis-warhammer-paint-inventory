namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> IsengardOverall =
    [
        new("Armour",
        [
            new("Basecoat", "Mechanicus Standard Grey"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Dawnstone"),
        ]),
        new("Skin",
        [
            new("Basecoat", "Skavenblight Dinge"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Dawnstone"),
        ]),
        new("Leathers & Straps",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
        ]),
        new("White Hand Icon",
        [
            new("Basecoat", "White Scar", "freehand hand icon on helm/shield"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static FactionGuide BuildIsengard() => new("Isengard",
    [
        new("Uruk-hai Warriors", "Saruman's bred-for-war army — dark iron armour and ash-grey hide marked everywhere with the White Hand of Isengard.", IsengardOverall, IsScheme: true),

        FactionUnit(IsengardOverall, "Uruk-hai Scouts", "Unit-Specific Details",
        [
            new("Furs", "Rhinox Hide"),
            new("Boots", "Abaddon Black"),
        ]),

        FactionUnit(IsengardOverall, "Berserkers", "Unit-Specific Details",
        [
            new("Bare Chest", "Skavenblight Dinge", "as Overall skin scheme"),
            new("War Paint", "Mephiston Red", "self-inflicted battle scarring"),
        ]),

        FactionUnit(IsengardOverall, "Lurtz", "Unit-Specific Details",
        [
            new("Armour Trim", "Leadbelcher"),
            new("Cloak", "Rhinox Hide"),
        ]),

        FactionUnit(IsengardOverall, "Saruman", "Unit-Specific Details",
        [
            new("Robes", "White Scar"),
            new("Robes Shade", "Agrax Earthshade", "thinned, subtle"),
            new("Staff", "Runefang Steel"),
        ]),

        FactionUnit(IsengardOverall, "Sharku", "Unit-Specific Details",
        [
            new("Warg Mount", "Rhinox Hide"),
            new("Armour", "Mechanicus Standard Grey", "as Overall scheme"),
        ]),
    ], Category: GuideCategory.Evil, Game: Game.MiddleEarth);
}
