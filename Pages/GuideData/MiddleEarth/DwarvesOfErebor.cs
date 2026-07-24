namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> DwarvesOfEreborOverall =
    [
        new("Armour",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Ironbreaker"),
        ]),
        new("Cloth & Robes (Blue)",
        [
            new("Basecoat", "Kantor Blue"),
            new("Shade", "Druchii Violet"),
            new("Highlight", "Caledor Sky"),
        ]),
        new("Trim & Gold",
        [
            new("Basecoat", "Balthasar Gold"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Auric Armour Gold"),
        ]),
        new("Beards",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Highlight", "Doombull Brown", "drybrush"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Warplock Bronze"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static FactionGuide BuildDwarvesOfErebor() => new("Dwarves of Erebor",
    [
        new("Erebor Veterans", "The dwarves of the Lonely Mountain — heavy steel armour, deep royal blue cloth, and gold filigree befitting a kingdom built on wealth.", DwarvesOfEreborOverall, IsScheme: true),

        FactionUnit(DwarvesOfEreborOverall, "Iron Hills Dwarves", "Unit-Specific Details",
        [
            new("Heavy Armour Plates", "Mechanicus Standard Grey"),
            new("Helm Crest", "Mephiston Red"),
        ]),

        FactionUnit(DwarvesOfEreborOverall, "Dain Ironfoot", "Unit-Specific Details",
        [
            new("Battle Boar Tusks", "Ushabti Bone"),
            new("Armour Trim", "Auric Armour Gold"),
        ]),

        FactionUnit(DwarvesOfEreborOverall, "Thorin Oakenshield", "Unit-Specific Details",
        [
            new("Fur Mantle", "Rhinox Hide"),
            new("Oakenshield", "Dryad Bark"),
            new("Royal Coat", "Kantor Blue"),
        ]),

        FactionUnit(DwarvesOfEreborOverall, "Balin", "Unit-Specific Details",
        [
            new("Robes", "Mechanicus Standard Grey"),
            new("Beard", "Ushabti Bone", "white beard of age"),
        ]),
    ], Category: GuideCategory.Good, Game: Game.MiddleEarth);
}
