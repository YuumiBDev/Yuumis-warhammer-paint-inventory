namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> LegioVulcanumTitanicusScheme =
    [
        new("Carapace Armour (Red)",
        [
            new("Basecoat", "Mephiston Red"),
            new("Recess Shade", "Carroburg Crimson"),
            new("Layer", "Evil Sunz Scarlet"),
            new("Edge Highlight", "Wazdakka Red"),
        ]),
        new("Trim & Metal (Silver)",
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

    private static FactionGuide BuildLegioVulcanumTitanicus() => new("Legio Vulcanum",
    [
        new("Colour Scheme", "A Traitor Titan Legion in bright red carapace armour trimmed with steel, throwing their war-engines against the Emperor's forces with reckless aggression.", LegioVulcanumTitanicusScheme, IsScheme: true),
        PlainUnit(LegioVulcanumTitanicusScheme, "Warhound Titan"),
        PlainUnit(LegioVulcanumTitanicusScheme, "Reaver Titan"),
        PlainUnit(LegioVulcanumTitanicusScheme, "Warlord Titan"),
        PlainUnit(LegioVulcanumTitanicusScheme, "Titan Command / Princeps Seniores"),
    ], Category: GuideCategory.Traitor, Game: Game.AdeptusTitanicus);
}
