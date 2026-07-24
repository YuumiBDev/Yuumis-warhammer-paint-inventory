namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> LuminethRealmLordsOverall =
    [
        new("Robes (White)",
        [
            new("Basecoat", "Wraithbone"),
            new("Recess Shade", "Agrax Earthshade", "thinned"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Armour & Trim (Gold)",
        [
            new("Basecoat", "Auric Armour Gold"),
            new("Shade", "Reikland Fleshshade"),
            new("Edge Highlight", "Liberator Gold"),
        ]),
        new("Accent Cloth (Teal)",
        [
            new("Basecoat", "Temple Guard Blue"),
            new("Highlight", "Sotek Green"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Auric Armour Gold"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildLuminethRealmLords() => new("Lumineth Realm-Lords",
    [
        new("Vanari White & Gold", "The default and most iconic Lumineth palette — pristine white robes over gilded armour with teal accent cloth, evoking the light of Hysh itself.", LuminethRealmLordsOverall, IsScheme: true),

        FactionUnit(LuminethRealmLordsOverall, "Vanari Auralan Sentinels", "Unit-Specific Details",
        [
            new("Bow & Fletching", "Auric Armour Gold", "as Armour & Trim scheme"),
            new("Sunmetal Arrowheads", "Liberator Gold", "bright edge highlight"),
        ]),

        FactionUnit(LuminethRealmLordsOverall, "Vanari Dawnriders", "Mount-Specific Details",
        [
            new("Great Eagle Feathers", "Wraithbone", "Agrax Earthshade wash, White Scar highlight"),
            new("Lance", "Auric Armour Gold", "as Armour & Trim scheme"),
        ]),

        FactionUnit(LuminethRealmLordsOverall, "Scinari Cathallar", "Unit-Specific Details",
        [
            new("Aetherquartz Regalia", "Temple Guard Blue", "thinned glaze for a glassy shimmer"),
            new("Robes", "Wraithbone", "as Robes scheme"),
        ]),

        FactionUnit(LuminethRealmLordsOverall, "Alarith Stoneguard", "Unit-Specific Details",
        [
            new("Stone Mallet Head", "Administratum Grey", "Nuln Oil wash, Dawnstone highlight"),
            new("Armour", "Auric Armour Gold", "as Armour & Trim scheme"),
        ]),

        FactionUnit(LuminethRealmLordsOverall, "Alarith Wardens", "Unit-Specific Details",
        [
            new("Stone Guardian Weapon", "Administratum Grey", "Nuln Oil wash, Dawnstone highlight"),
            new("Armour", "Auric Armour Gold", "as Armour & Trim scheme"),
        ]),

        FactionUnit(LuminethRealmLordsOverall, "Avalenor the Stoneheart", "Unit-Specific Details",
        [
            new("Living Mountain Stone", "Administratum Grey", "Nuln Oil wash, Dawnstone drybrush"),
            new("Gilded Regalia", "Auric Armour Gold", "as Armour & Trim scheme"),
        ]),

        FactionUnit(LuminethRealmLordsOverall, "Vanari Bladelords", "Unit-Specific Details",
        [
            new("Blade", "Liberator Gold", "bright edge highlight along the full length"),
            new("Crest & Trim", "Temple Guard Blue", "as Accent Cloth scheme"),
        ]),
    ], Category: GuideCategory.Order, Game: Game.AgeOfSigmar);
}
