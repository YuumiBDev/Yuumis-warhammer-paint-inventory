namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> IdonethDeepkinOverall =
    [
        new("Skin (Pale Blue)",
        [
            new("Basecoat", "The Fang"),
            new("Shade", "Drakenhof Nightshade", "thinned"),
            new("Highlight", "Fenrisian Grey"),
        ]),
        new("Armour (Teal / Turquoise)",
        [
            new("Basecoat", "Sotek Green"),
            new("Recess Shade", "Coelia Greenshade"),
            new("Layer", "Temple Guard Blue"),
            new("Edge Highlight", "Baharroth Blue"),
        ]),
        new("Trim & Fittings (Bone/Gold)",
        [
            new("Basecoat", "Auric Armour Gold"),
            new("Shade", "Agrax Earthshade"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildIdonethDeepkin() => new("Idoneth Deepkin",
    [
        new("Ionrach Teal", "The default and most iconic Idoneth Deepkin palette — pale blue-grey aelf skin under teal-turquoise armour, evoking the depths of the Deepkin's realmsea enclaves.", IdonethDeepkinOverall, IsScheme: true),

        FactionUnit(IdonethDeepkinOverall, "Namarti Thralls", "Unit-Specific Details",
        [
            new("Coral Blades", "Sotek Green", "Coelia Greenshade wash for an organic sheen"),
            new("Soul-Bound Chains", "Runefang Steel", "edge highlight"),
        ]),

        FactionUnit(IdonethDeepkinOverall, "Namarti Reavers", "Unit-Specific Details",
        [
            new("Barbed Hooks", "Runefang Steel", "edge highlight"),
            new("Coral Weaponry", "Sotek Green", "Coelia Greenshade wash"),
        ]),

        FactionUnit(IdonethDeepkinOverall, "Eidolon of Mathlann", "Unit-Specific Details",
        [
            new("Spectral Form", "Temple Guard Blue", "thinned glazes for a ghostly, translucent effect"),
            new("Weapon", "Auric Armour Gold", "as Trim & Fittings scheme"),
        ]),

        FactionUnit(IdonethDeepkinOverall, "Akhelian King", "Mount-Specific Details",
        [
            new("Soul-Render Blade", "Runefang Steel", "edge highlight"),
            new("Eel Mount Hide", "Sotek Green", "as Armour scheme, brighter edge highlight"),
            new("Crown & Regalia", "Auric Armour Gold"),
        ]),

        FactionUnit(IdonethDeepkinOverall, "Akhelian Guard", "Mount-Specific Details",
        [
            new("Ishlaen / Alopex Eel Hide", "Sotek Green", "as Armour scheme"),
            new("Helm Lance", "Runefang Steel", "edge highlight"),
        ]),

        FactionUnit(IdonethDeepkinOverall, "Isharann Soulscryer", "Unit-Specific Details",
        [
            new("Soul Lantern Glow", "Baharroth Blue", "thinned glaze"),
            new("Robes", "Temple Guard Blue", "as Armour scheme"),
        ]),

        FactionUnit(IdonethDeepkinOverall, "Akhelian Allopexes", "Mount-Specific Details",
        [
            new("Allopex Hide", "Sotek Green", "as Armour scheme, drybrushed highlight"),
            new("Teeth & Underbelly", "Ushabti Bone", "Agrax Earthshade wash"),
        ]),
    ], Category: GuideCategory.Order, Game: Game.AgeOfSigmar);
}
