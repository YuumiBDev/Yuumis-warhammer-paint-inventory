namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> FyreslayersOverall =
    [
        new("Skin (Tattooed Bronze)",
        [
            new("Basecoat", "Balor Brown"),
            new("Shade", "Reikland Fleshshade"),
            new("Highlight", "Cadian Fleshtone"),
            new("Tattoos", "Troll Slayer Orange", "fine glazed lines over the highlighted skin"),
        ]),
        new("Ur-Gold (Metal)",
        [
            new("Basecoat", "Auric Armour Gold"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Liberator Gold"),
        ]),
        new("Hair & Beards (Orange)",
        [
            new("Basecoat", "Troll Slayer Orange"),
            new("Shade", "Fuegan Orange", "recess"),
            new("Highlight", "Fire Dragon Bright"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Balor Brown"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildFyreslayers() => new("Fyreslayers",
    [
        new("Ur-Gold Duardin", "The default and most iconic Fyreslayer palette — bronze tattooed skin, blazing orange hair, and gleaming Ur-Gold rune-plates worked into the flesh itself.", FyreslayersOverall, IsScheme: true),

        FactionUnit(FyreslayersOverall, "Vulkite Berzerkers", "Unit-Specific Details",
        [
            new("Fyresteel Handaxe", "Auric Armour Gold", "as Ur-Gold scheme"),
            new("Throwing Axes", "Runefang Steel", "edge highlight"),
        ]),

        FactionUnit(FyreslayersOverall, "Hearthguard Berzerkers", "Unit-Specific Details",
        [
            new("Poleaxe / Broadaxe Blade", "Auric Armour Gold", "as Ur-Gold scheme"),
            new("Rune-Plate Inlays", "Liberator Gold", "bright edge highlight distinguishing veteran status"),
        ]),

        FactionUnit(FyreslayersOverall, "Auric Hearthguard", "Unit-Specific Details",
        [
            new("Flamestrike Cannon / Hearthfyre Torch", "Auric Armour Gold", "as Ur-Gold scheme"),
            new("Flame Glow", "Troll Slayer Orange", "thinned glaze"),
        ]),

        FactionUnit(FyreslayersOverall, "Magmadroth", "Mount-Specific Details",
        [
            new("Scaled Hide", "Doombull Brown", "Agrax Earthshade wash, Balor Brown highlight"),
            new("Molten Cracks", "Troll Slayer Orange", "Fire Dragon Bright glaze along fissures"),
            new("Barding", "Auric Armour Gold", "as Ur-Gold scheme"),
        ]),

        FactionUnit(FyreslayersOverall, "Battlesmith", "Unit-Specific Details",
        [
            new("Runic Tools", "Auric Armour Gold", "as Ur-Gold scheme"),
            new("Forge Cinders Glow", "Troll Slayer Orange", "thinned glaze"),
        ]),

        FactionUnit(FyreslayersOverall, "Runefather", "Unit-Specific Details",
        [
            new("Runic Weapon", "Liberator Gold", "bright edge highlight along the full length"),
            new("Rune-Plate Regalia", "Auric Armour Gold", "gilded accents distinguish rank"),
        ]),
    ], Category: GuideCategory.Order, Game: Game.AgeOfSigmar);
}
