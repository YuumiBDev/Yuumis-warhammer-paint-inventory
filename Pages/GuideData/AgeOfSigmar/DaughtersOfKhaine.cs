namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> DaughtersOfKhaineOverall =
    [
        new("Skin",
        [
            new("Basecoat", "Kislev Flesh"),
            new("Shade", "Reikland Fleshshade", "thinned"),
            new("Highlight", "Pallid Wych Flesh"),
        ]),
        new("Robes & Armour (Red)",
        [
            new("Basecoat", "Mephiston Red"),
            new("Recess Shade", "Carroburg Crimson"),
            new("Layer", "Evil Sunz Scarlet"),
            new("Edge Highlight", "Wazdakka Red"),
        ]),
        new("Cloth & Trim (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Highlight", "Eshin Grey"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildDaughtersOfKhaine() => new("Daughters of Khaine",
    [
        new("Khainite Red", "The default and most iconic Daughters of Khaine palette — pale aelf skin under blood-red robes and black leathers, worn by every Temple that serves the Bloody-Handed God.", DaughtersOfKhaineOverall, IsScheme: true),

        FactionUnit(DaughtersOfKhaineOverall, "Witch Aelves", "Unit-Specific Details",
        [
            new("Sacrificial Knives", "Runefang Steel", "edge highlight"),
            new("Ritual Blood Splatter", "Mephiston Red", "Carroburg Crimson wash for a wet look"),
        ]),

        FactionUnit(DaughtersOfKhaineOverall, "Doomfire Warlocks", "Mount-Specific Details",
        [
            new("Doomfire Steed", "Naggaroth Night", "spectral flame effect"),
            new("Mane & Flame Trails", "Baharroth Blue", "thinned glaze for an ethereal glow"),
        ]),

        FactionUnit(DaughtersOfKhaineOverall, "Blood Sisters", "Unit-Specific Details",
        [
            new("Chained Blades", "Runefang Steel", "edge highlight"),
            new("Blood Chains", "Mephiston Red", "Carroburg Crimson wash"),
        ]),

        FactionUnit(DaughtersOfKhaineOverall, "Khinerai Heartrenders", "Unit-Specific Details",
        [
            new("Wing Membrane", "Naggaroth Night", "Druchii Violet glaze"),
            new("Talons", "Runefang Steel", "edge highlight"),
        ]),

        FactionUnit(DaughtersOfKhaineOverall, "Morathi", "Unit-Specific Details",
        [
            new("Serpent Coils", "Naggaroth Night", "Druchii Violet glaze, Genestealer Purple highlight"),
            new("Armour & Regalia", "Auric Armour Gold", "gilded, distinct from the rank-and-file"),
            new("Sword of Khaine", "Runefang Steel", "edge highlight"),
        ]),

        FactionUnit(DaughtersOfKhaineOverall, "Bloodwrack Medusa", "Unit-Specific Details",
        [
            new("Snake Hair", "Naggaroth Night", "Druchii Violet glaze"),
            new("Bloodwrack Stare Glow", "Mephiston Red", "thinned glaze"),
        ]),

        FactionUnit(DaughtersOfKhaineOverall, "Hag Queen", "Unit-Specific Details",
        [
            new("Sacrificial Knife", "Runefang Steel", "edge highlight"),
            new("Ritual Regalia", "Auric Armour Gold", "marks her authority within the Temple"),
        ]),
    ], Category: GuideCategory.Order, Game: Game.AgeOfSigmar);
}
