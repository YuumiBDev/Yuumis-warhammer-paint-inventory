namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> LegioMortisTitanicusScheme =
    [
        new("Carapace Armour (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Layer", "Eshin Grey", "raised panels and edges"),
            new("Edge Highlight", "Dawnstone"),
        ]),
        new("Panels (Purple)",
        [
            new("Basecoat", "Xereus Purple"),
            new("Recess Shade", "Druchii Violet"),
            new("Edge Highlight", "Genestealer Purple"),
        ]),
        new("Bone & Skull Motifs",
        [
            new("Basecoat", "Screaming Skull"),
            new("Shade", "Agrax Earthshade"),
            new("Skull Icons", "Screaming Skull", "freehand on carapace and shoulder plates"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Warplock Bronze"),
            new("Basing", "Astrogranite Debris", "with Agrellan Earth cracked texture"),
        ]),
    ];

    private static FactionGuide BuildLegioMortisTitanicus() => new("Legio Mortis",
    [
        new("Colour Scheme", "A Traitor Titan Legion in black and purple carapace armour, covered in bone-white skull iconography — they marched for the Warmaster and never looked back.", LegioMortisTitanicusScheme, IsScheme: true),
        PlainUnit(LegioMortisTitanicusScheme, "Warhound Titan"),
        PlainUnit(LegioMortisTitanicusScheme, "Reaver Titan"),
        PlainUnit(LegioMortisTitanicusScheme, "Warlord Titan"),
        PlainUnit(LegioMortisTitanicusScheme, "Titan Command / Princeps Seniores"),
    ], Category: GuideCategory.Traitor, Game: Game.AdeptusTitanicus);
}
