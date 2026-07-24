namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> LegioIgnatumTitanicusScheme =
    [
        new("Carapace Armour (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Layer", "Eshin Grey", "raised panels and edges"),
            new("Edge Highlight", "Dawnstone"),
        ]),
        new("Panels & Flame Livery (Red)",
        [
            new("Basecoat", "Mephiston Red"),
            new("Recess Shade", "Carroburg Crimson"),
            new("Edge Highlight", "Evil Sunz Scarlet"),
        ]),
        new("Trim & Metal",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Leadbelcher"),
            new("Basing", "Astrogranite Debris", "with Agrellan Earth cracked texture"),
        ]),
    ];

    private static FactionGuide BuildLegioIgnatumTitanicus() => new("Legio Ignatum",
    [
        new("Colour Scheme", "The Loyalist \"Firebrands\" — black carapace armour slashed with red flame livery, marching their Titans to war with an aggressive, close-range fighting doctrine.", LegioIgnatumTitanicusScheme, IsScheme: true),
        PlainUnit(LegioIgnatumTitanicusScheme, "Warhound Titan"),
        PlainUnit(LegioIgnatumTitanicusScheme, "Reaver Titan"),
        PlainUnit(LegioIgnatumTitanicusScheme, "Warlord Titan"),
        PlainUnit(LegioIgnatumTitanicusScheme, "Titan Command / Princeps Seniores"),
    ], Category: GuideCategory.Loyalist, Game: Game.AdeptusTitanicus);
}
