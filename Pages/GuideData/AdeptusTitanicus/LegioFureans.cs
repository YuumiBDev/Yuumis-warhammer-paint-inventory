namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> LegioFureansTitanicusScheme =
    [
        new("Carapace Armour (Green)",
        [
            new("Basecoat", "Warboss Green"),
            new("Recess Shade", "Biel-Tan Green", "thinned glaze into panel recesses"),
            new("Layer", "Warpstone Glow"),
            new("Edge Highlight", "Moot Green"),
        ]),
        new("Trim & Weapons (Gold)",
        [
            new("Basecoat", "Auric Armour Gold"),
            new("Shade", "Reikland Fleshshade"),
            new("Edge Highlight", "Sycorax Bronze"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Auric Armour Gold"),
            new("Basing", "Astrogranite Debris", "with Agrellan Earth cracked texture for a battlefield-rubble base"),
        ]),
    ];

    private static FactionGuide BuildLegioFureansTitanicus() => new("Legio Fureans",
    [
        new("Colour Scheme", "A Loyalist Titan Legion fielding their god-machines in deep green carapace armour trimmed with gold — disciplined, methodical war-engines that favour attrition over spectacle.", LegioFureansTitanicusScheme, IsScheme: true),
        PlainUnit(LegioFureansTitanicusScheme, "Warhound Titan"),
        PlainUnit(LegioFureansTitanicusScheme, "Reaver Titan"),
        PlainUnit(LegioFureansTitanicusScheme, "Warlord Titan"),
        PlainUnit(LegioFureansTitanicusScheme, "Titan Command / Princeps Seniores"),
    ], Category: GuideCategory.Loyalist, Game: Game.AdeptusTitanicus);
}
