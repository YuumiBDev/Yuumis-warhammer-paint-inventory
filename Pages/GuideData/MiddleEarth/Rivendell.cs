namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> RivendellOverall =
    [
        new("Elven Armour",
        [
            new("Basecoat", "Stormhost Silver"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Runefang Steel"),
        ]),
        new("Robes & Cloth",
        [
            new("Basecoat", "Kantor Blue"),
            new("Shade", "Druchii Violet"),
            new("Highlight", "Teclis Blue", "edge highlight"),
        ]),
        new("Trim & Filigree",
        [
            new("Basecoat", "Ironbreaker"),
            new("Highlight", "Stormhost Silver"),
        ]),
        new("Skin & Hair",
        [
            new("Skin Basecoat", "Kislev Flesh"),
            new("Skin Shade", "Reikland Fleshshade"),
            new("Hair", "Ushabti Bone"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Stormhost Silver"),
            new("Basing", "Stirland Mud", "with static grass"),
        ]),
    ];

    private static FactionGuide BuildRivendell() => new("Rivendell",
    [
        new("Rivendell Knights", "The Last Homely House and the Fellowship it sent forth — flowing silver-and-blue elven armour and robes for the elves, individual traveling gear for Frodo's companions.", RivendellOverall, IsScheme: true),

        FactionUnit(RivendellOverall, "Wood Elves", "Unit-Specific Details",
        [
            new("Cloak", "Straken Green", "Mirkwood forest green"),
            new("Leathers", "Rhinox Hide"),
        ]),

        FactionUnit(RivendellOverall, "Frodo", "Unit-Specific Details",
        [
            new("Waistcoat", "Macragge Blue"),
            new("Lórien Cloak", "Straken Green"),
            new("Mithril Shirt", "Stormhost Silver"),
        ]),

        FactionUnit(RivendellOverall, "Gandalf the Grey", "Unit-Specific Details",
        [
            new("Robes", "Dawnstone"),
            new("Robes Shade", "Nuln Oil"),
            new("Hat", "Fenrisian Grey"),
            new("Staff", "Rhinox Hide"),
        ]),

        FactionUnit(RivendellOverall, "Aragorn", "Unit-Specific Details",
        [
            new("Leather Jerkin", "Rhinox Hide"),
            new("Ranger Cloak", "Fenrisian Grey"),
            new("Blade", "Ironbreaker"),
        ]),

        FactionUnit(RivendellOverall, "Legolas", "Unit-Specific Details",
        [
            new("Leathers", "Rhinox Hide"),
            new("Bow", "Dryad Bark"),
            new("Quiver Fletching", "White Scar"),
        ]),

        FactionUnit(RivendellOverall, "Gimli", "Unit-Specific Details",
        [
            new("Beard", "Doombull Brown"),
            new("Armour", "Leadbelcher"),
            new("Chainmail", "Ironbreaker"),
        ]),
    ], Category: GuideCategory.Good, Game: Game.MiddleEarth);
}
