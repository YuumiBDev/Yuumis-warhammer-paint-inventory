namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> KingdomOfBretonniaOverall =
    [
        new("Armour (Steel)",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Ironbreaker"),
        ]),
        new("Heraldry (Blue)",
        [
            new("Basecoat", "Kantor Blue"),
            new("Shade", "Drakenhof Nightshade"),
            new("Layer", "Macragge Blue"),
            new("Edge Highlight", "Teclis Blue"),
        ]),
        new("Heraldry (White)",
        [
            new("Basecoat", "Corax White"),
            new("Shade", "Nuln Oil", "thinned, recesses only"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Trim & Gold",
        [
            new("Basecoat", "Retributor Armour"),
            new("Shade", "Reikland Fleshshade"),
            new("Edge Highlight", "Auric Armour Gold"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Leadbelcher"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static FactionGuide BuildKingdomOfBretonnia() => new("Kingdom of Bretonnia",
    [
        new("Errantry War Heraldry", "The default and most iconic Bretonnian look — polished plate over blue and white heraldic livery, the chivalric colours of a knight questing in the Lady's name.", KingdomOfBretonniaOverall, IsScheme: true),

        FactionUnit(KingdomOfBretonniaOverall, "Men-at-Arms", "Unit-Specific Details",
        [
            new("Spear / Bill", "Leadbelcher", "Nuln Oil wash"),
            new("Livery Tabard", "Kantor Blue", "as Overall heraldry"),
        ]),

        FactionUnit(KingdomOfBretonniaOverall, "Bowmen", "Unit-Specific Details",
        [
            new("Bow Stave", "Rhinox Hide", "Agrax Earthshade wash"),
            new("Fletching", "White Scar"),
        ]),

        FactionUnit(KingdomOfBretonniaOverall, "Knights of the Realm", "Unit-Specific Details",
        [
            new("Barding", "Kantor Blue", "as Overall heraldry blue/white"),
            new("Lance Tip", "Runefang Steel"),
            new("Helm Plume", "Mephiston Red"),
        ]),

        FactionUnit(KingdomOfBretonniaOverall, "Knights Errant", "Unit-Specific Details",
        [
            new("Pennant", "Corax White", "blue heraldic trim"),
            new("Lance", "Runefang Steel"),
        ]),

        FactionUnit(KingdomOfBretonniaOverall, "Pegasus Knight", "Mount-Specific Details",
        [
            new("Pegasus Feathers", "Corax White", "Nuln Oil wash, Screaming Skull highlight"),
            new("Pegasus Beak & Claws", "Troll Slayer Orange"),
        ]),

        FactionUnit(KingdomOfBretonniaOverall, "Grail Knight", "Unit-Specific Details",
        [
            new("Grail Shield", "Auric Armour Gold", "gilded, distinguishes the Lady's chosen"),
            new("Pure White Barding", "Corax White", "distinguishes from standard knightly barding"),
        ]),

        FactionUnit(KingdomOfBretonniaOverall, "Damsel of the Lady", "Unit-Specific Details",
        [
            new("Robes", "Kantor Blue", "Teclis Blue edge highlight"),
            new("Grail Relic", "Auric Armour Gold"),
        ]),
    ], Category: GuideCategory.All, Game: Game.OldWorld);
}
