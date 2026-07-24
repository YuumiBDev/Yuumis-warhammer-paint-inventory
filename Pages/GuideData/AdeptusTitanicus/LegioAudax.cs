namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> LegioAudaxTitanicusScheme =
    [
        new("Carapace Armour (Yellow)",
        [
            new("Undercoat", "Wraithbone"),
            new("Basecoat", "Averland Sunset"),
            new("Shade", "Agrax Earthshade", "thin glaze, avoid pooling"),
            new("Edge Highlight", "Flash Gitz Yellow"),
        ]),
        new("Hazard Stripes (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Stripe Masking", "Averland Sunset", "diagonal hazard stripes on leg armour"),
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

    private static FactionGuide BuildLegioAudaxTitanicus() => new("Legio Audax",
    [
        new("Colour Scheme", "A Traitor Titan Legion in yellow carapace armour marked with black hazard stripes, warning any who approach of the destruction their god-machines bring.", LegioAudaxTitanicusScheme, IsScheme: true),
        PlainUnit(LegioAudaxTitanicusScheme, "Warhound Titan"),
        PlainUnit(LegioAudaxTitanicusScheme, "Reaver Titan"),
        PlainUnit(LegioAudaxTitanicusScheme, "Warlord Titan"),
        PlainUnit(LegioAudaxTitanicusScheme, "Titan Command / Princeps Seniores"),
    ], Category: GuideCategory.Traitor, Game: Game.AdeptusTitanicus);
}
