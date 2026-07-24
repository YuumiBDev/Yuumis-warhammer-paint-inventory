namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> SalamandersLegionOverall =
    [
        new("Armour (Dark Green)",
        [
            new("Basecoat", "Salamanders Green"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer", "Loren Forest"),
            new("Edge Highlight", "Warpstone Glow"),
        ]),
        new("Weapon Housings (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Edge Highlight", "Eshin Grey"),
        ]),
        new("Trim & Metal (Bronze)",
        [
            new("Basecoat", "Warplock Bronze"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Brass Scorpion"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runelord Brass"),
            new("Basing", "Martian Ironcrust", "volcanic rock texture, Ryza Rust drybrush"),
        ]),
    ];

    private static FactionGuide BuildSalamandersLegion() => new("Salamanders",
    [
        new("Salamanders", "The Eighteenth Legion, master artisans and protectors of the common people from volcanic Nocturne, led by Vulkan.", SalamandersLegionOverall, IsScheme: true),

        FactionUnit(SalamandersLegionOverall, "Legion Tactical Squad", "Unit-Specific Details",
        [
            new("Squad Markings", "Warplock Bronze"),
            new("Bolter Casing", "Abaddon Black"),
        ]),

        FactionUnit(SalamandersLegionOverall, "Legion Terminator Squad", "Unit-Specific Details",
        [
            new("Heavy Plating", "Salamanders Green", "extra edge highlight pass"),
            new("Combi-weapon Casing", "Abaddon Black"),
        ]),

        FactionUnit(SalamandersLegionOverall, "Legion Command Squad", "Unit-Specific Details",
        [
            new("Company Banner Trim", "Brass Scorpion"),
            new("Icon of the Order", "Warplock Bronze", "Agrax Earthshade wash"),
        ]),

        FactionUnit(SalamandersLegionOverall, "Legion Rhino", "Vehicle-Specific Details",
        [
            new("Hull Panels", "Salamanders Green", "as Overall armour scheme"),
            new("Exhaust Weathering", "Agrax Earthshade"),
        ]),

        FactionUnit(SalamandersLegionOverall, "Legion Dreadnought", "Vehicle-Specific Details",
        [
            new("Sarcophagus Recesses", "Abaddon Black"),
            new("Heavy Weapon Arm", "Warplock Bronze"),
        ]),

        FactionUnit(SalamandersLegionOverall, "Legion Praetor", "Unit-Specific Details",
        [
            new("Cloak Lining", "Abaddon Black"),
            new("Personal Heraldry", "Brass Scorpion"),
        ]),
    ], Category: GuideCategory.Loyalist, Game: Game.HorusHeresy);
}
