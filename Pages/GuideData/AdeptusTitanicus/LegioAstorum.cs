namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> LegioAstorumTitanicusScheme =
    [
        new("Carapace Armour (Dark Blue)",
        [
            new("Basecoat", "Kantor Blue"),
            new("Recess Shade", "Drakenhof Nightshade"),
            new("Layer", "Alaitoc Blue"),
            new("Edge Highlight", "Fenrisian Grey"),
        ]),
        new("Trim & Metal (Silver)",
        [
            new("Basecoat", "Stormhost Silver"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "White Scar", "fine line only"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Stormhost Silver"),
            new("Basing", "Astrogranite Debris", "with Agrellan Earth cracked texture"),
        ]),
    ];

    private static FactionGuide BuildLegioAstorumTitanicus() => new("Legio Astorum",
    [
        new("Colour Scheme", "The Loyalist \"Warmonger Titans\" — dark blue carapace armour trimmed in bright silver, one of the oldest and most storied Titan Legions still loyal to the Emperor.", LegioAstorumTitanicusScheme, IsScheme: true),
        PlainUnit(LegioAstorumTitanicusScheme, "Warhound Titan"),
        PlainUnit(LegioAstorumTitanicusScheme, "Reaver Titan"),
        PlainUnit(LegioAstorumTitanicusScheme, "Warlord Titan"),
        PlainUnit(LegioAstorumTitanicusScheme, "Titan Command / Princeps Seniores"),
    ], Category: GuideCategory.Loyalist, Game: Game.AdeptusTitanicus);
}
