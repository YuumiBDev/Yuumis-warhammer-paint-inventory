namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> WordBearersHHOverall =
    [
        new("Armour (Maroon)",
        [
            new("Basecoat", "Khorne Red"),
            new("Recess Shade", "Carroburg Crimson"),
            new("Layer", "Mephiston Red"),
            new("Edge Highlight", "Wazdakka Red"),
        ]),
        new("Trim & Metal (Bone & Brass)",
        [
            new("Bone Basecoat", "Screaming Skull"),
            new("Bone Shade", "Agrax Earthshade"),
            new("Metal", "Warplock Bronze", "Nuln Oil shade, Sycorax Bronze edge"),
        ]),
        new("Details",
        [
            new("Icons / Script", "Screaming Skull", "fine detail work over armour panels"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Warplock Bronze"),
            new("Basing", "Astrogranite Debris", "with Agrellan Earth cracked texture"),
        ]),
    ];

    private static FactionGuide BuildWordBearers() => new("Word Bearers",
    [
        new("Word Bearers", "The XVII Legion under Lorgar — already devout before the Heresy, their maroon armour was covered in icons and script long before Chaos claimed them outright.", WordBearersHHOverall, IsScheme: true),

        PlainUnit(WordBearersHHOverall, "Legion Tactical Squad"),
        PlainUnit(WordBearersHHOverall, "Legion Terminator Squad"),
        PlainUnit(WordBearersHHOverall, "Legion Command Squad"),
        PlainUnit(WordBearersHHOverall, "Legion Rhino"),
        PlainUnit(WordBearersHHOverall, "Legion Dreadnought"),
        PlainUnit(WordBearersHHOverall, "Legion Praetor"),
    ], Category: GuideCategory.Traitor, Game: Game.HorusHeresy);
}
