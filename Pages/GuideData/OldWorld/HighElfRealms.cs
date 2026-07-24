namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> HighElfRealmsOverall =
    [
        new("Robes (White)",
        [
            new("Basecoat", "Corax White"),
            new("Shade", "Nuln Oil", "thinned, recesses only"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Armour & Trim (Blue)",
        [
            new("Basecoat", "Kantor Blue"),
            new("Shade", "Drakenhof Nightshade"),
            new("Edge Highlight", "Teclis Blue"),
        ]),
        new("Metal (Silver)",
        [
            new("Basecoat", "Ironbreaker"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Ironbreaker"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildHighElfRealms() => new("High Elf Realms",
    [
        new("Ulthuan White & Blue", "The default and most iconic look — pristine white robes and silvered Ithilmar armour trimmed in noble blue, the bearing of an ancient and disciplined people.", HighElfRealmsOverall, IsScheme: true),

        FactionUnit(HighElfRealmsOverall, "Spearmen", "Unit-Specific Details",
        [
            new("Spear Tip", "Ironbreaker", "Nuln Oil wash"),
            new("Shield Icon", "Teclis Blue"),
        ]),

        FactionUnit(HighElfRealmsOverall, "Archers", "Unit-Specific Details",
        [
            new("Bow", "Rhinox Hide", "Agrax Earthshade wash"),
            new("Fletching", "White Scar"),
        ]),

        FactionUnit(HighElfRealmsOverall, "Silver Helms", "Mount-Specific Details",
        [
            new("Barded Steed", "Corax White", "Nuln Oil wash"),
            new("Lance", "Runefang Steel"),
        ]),

        FactionUnit(HighElfRealmsOverall, "Phoenix Guard", "Unit-Specific Details",
        [
            new("Halberd Blade", "Runefang Steel"),
            new("Crest Plume", "Mephiston Red", "distinguishes the elite temple guard"),
        ]),

        FactionUnit(HighElfRealmsOverall, "White Lions", "Unit-Specific Details",
        [
            new("Lion Pelt Cloak", "Ushabti Bone", "Agrax Earthshade wash, Screaming Skull highlight"),
            new("Great Weapon", "Ironbreaker", "Nuln Oil wash"),
        ]),

        FactionUnit(HighElfRealmsOverall, "Mage", "Unit-Specific Details",
        [
            new("Robes", "Kantor Blue", "Teclis Blue edge, as Overall"),
            new("Staff Head Gem", "Genestealer Purple", "glow"),
        ]),

        FactionUnit(HighElfRealmsOverall, "Prince", "Unit-Specific Details",
        [
            new("Cloak", "Mephiston Red"),
            new("Armour Trim", "Auric Armour Gold", "gilded"),
            new("Blade", "Runefang Steel"),
        ]),
    ], Category: GuideCategory.All, Game: Game.OldWorld);
}
