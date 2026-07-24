namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> RohanOverall =
    [
        new("Tunic & Cloak",
        [
            new("Basecoat", "Castellan Green"),
            new("Shade", "Athonian Camoshade"),
            new("Highlight", "Straken Green"),
        ]),
        new("Leathers",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Doombull Brown"),
        ]),
        new("Trim & Gold",
        [
            new("Basecoat", "Balthasar Gold"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Auric Armour Gold"),
        ]),
        new("Chainmail & Armour",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Ironbreaker"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Rhinox Hide"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static FactionGuide BuildRohan() => new("Rohan",
    [
        new("Riders of Rohan", "The horse-lords of the Mark — forest-green cloaks and tunics over leather and mail, trimmed in warm gold, riding to war on horseback.", RohanOverall, IsScheme: true),

        FactionUnit(RohanOverall, "Warriors of Rohan", "Unit-Specific Details",
        [
            new("Shield Emblem", "Mephiston Red", "horse-of-Rohan freehand"),
            new("Helm", "Leadbelcher"),
        ]),

        FactionUnit(RohanOverall, "Royal Guard", "Unit-Specific Details",
        [
            new("Cloak Trim", "Auric Armour Gold"),
            new("Chainmail", "Ironbreaker"),
        ]),

        FactionUnit(RohanOverall, "Eomer", "Unit-Specific Details",
        [
            new("Cloak", "Castellan Green", "as Overall scheme"),
            new("Winged Helm", "Leadbelcher"),
            new("Horse Tack", "Auric Armour Gold"),
        ]),

        FactionUnit(RohanOverall, "Theoden", "Unit-Specific Details",
        [
            new("Royal Robes", "Macragge Blue"),
            new("Crown & Trim", "Auric Armour Gold"),
        ]),

        FactionUnit(RohanOverall, "Éowyn", "Unit-Specific Details",
        [
            new("Gown", "White Scar"),
            new("Cloak", "Fenrisian Grey"),
            new("Hair", "Ushabti Bone"),
        ]),
    ], Category: GuideCategory.Good, Game: Game.MiddleEarth);
}
