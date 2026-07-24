namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> DwarfenMountainHoldsOverall =
    [
        new("Armour (Steel)",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Ironbreaker"),
        ]),
        new("Trim & Regalia (Gold)",
        [
            new("Basecoat", "Retributor Armour"),
            new("Shade", "Reikland Fleshshade"),
            new("Edge Highlight", "Auric Armour Gold"),
        ]),
        new("Beard",
        [
            new("Basecoat", "Troll Slayer Orange"),
            new("Shade", "Seraphim Sepia"),
            new("Edge Highlight", "Fire Dragon Bright"),
        ]),
        new("Cloth & Livery (Red)",
        [
            new("Basecoat", "Mephiston Red"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Evil Sunz Scarlet"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Leadbelcher"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static FactionGuide BuildDwarfenMountainHolds() => new("Dwarfen Mountain Holds",
    [
        new("Ancestral Hold Colours", "The default and most iconic look — deep gold and burnished steel over a fiery beard, the disciplined, unyielding livery of the mountain holds.", DwarfenMountainHoldsOverall, IsScheme: true),

        FactionUnit(DwarfenMountainHoldsOverall, "Dwarf Warriors", "Unit-Specific Details",
        [
            new("Axe / Shield", "Leadbelcher", "Nuln Oil wash"),
            new("Shield Icon", "Retributor Armour"),
        ]),

        FactionUnit(DwarfenMountainHoldsOverall, "Dwarf Quarrellers", "Unit-Specific Details",
        [
            new("Crossbow", "Rhinox Hide", "Agrax Earthshade wash"),
            new("Bolt Tips", "Leadbelcher"),
        ]),

        FactionUnit(DwarfenMountainHoldsOverall, "Longbeards", "Unit-Specific Details",
        [
            new("Aged Beard", "Screaming Skull", "brighter highlight than Overall, shows venerability"),
            new("Ancestral Axe", "Runefang Steel"),
        ]),

        FactionUnit(DwarfenMountainHoldsOverall, "Hammerers", "Unit-Specific Details",
        [
            new("Great Hammer Head", "Leadbelcher", "Nuln Oil wash, Ironbreaker edge"),
            new("Livery Sash", "Mephiston Red", "distinguishes the king's royal guard"),
        ]),

        FactionUnit(DwarfenMountainHoldsOverall, "Cannon", "Vehicle-Specific Details",
        [
            new("Barrel", "Leadbelcher", "Nuln Oil wash"),
            new("Carriage", "Rhinox Hide"),
            new("Rune Etching", "Auric Armour Gold"),
        ]),

        FactionUnit(DwarfenMountainHoldsOverall, "Thane", "Unit-Specific Details",
        [
            new("Cloak", "Mephiston Red", "Evil Sunz Scarlet highlight"),
            new("Armour Trim", "Auric Armour Gold", "gilded"),
        ]),

        FactionUnit(DwarfenMountainHoldsOverall, "Runesmith", "Unit-Specific Details",
        [
            new("Rune Inlay Glow", "Auric Armour Gold"),
            new("Apron & Tools", "Rhinox Hide"),
        ]),
    ], Category: GuideCategory.All, Game: Game.OldWorld);
}
