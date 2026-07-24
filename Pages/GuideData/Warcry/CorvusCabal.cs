namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> CorvusCabalOverall =
    [
        new("Cloth & Robes",
        [
            new("Basecoat", "Abaddon Black"),
            new("Edge Highlight", "Eshin Grey"),
            new("Highlight", "Dawnstone"),
        ]),
        new("Raven Masks & Bone",
        [
            new("Basecoat", "Ushabti Bone"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Screaming Skull"),
        ]),
        new("Feathers",
        [
            new("Basecoat", "Abaddon Black"),
            new("Drybrush", "Eshin Grey"),
        ]),
        new("Leather Straps",
        [
            new("Basecoat", "Dryad Bark"),
            new("Highlight", "Mournfang Brown"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildCorvusCabal() => new("Corvus Cabal",
    [
        new("Corvus Cabal", "Raven-masked killers who strike from rooftops and shadow — deep blacks broken only by bone-white masks and dark feathers.", CorvusCabalOverall, IsScheme: true),

        FactionUnit(CorvusCabalOverall, "Shadowpiper", "Unit-Specific Details",
        [
            new("Bone Flute", "Ushabti Bone", "as Overall mask scheme"),
            new("Cloak", "Abaddon Black", "as Overall cloth scheme"),
        ]),

        FactionUnit(CorvusCabalOverall, "Shrike", "Unit-Specific Details",
        [
            new("Twin Blades", "Runefang Steel", "as Overall base scheme"),
            new("Mask", "Ushabti Bone", "as Overall mask scheme"),
        ]),

        FactionUnit(CorvusCabalOverall, "Blackguard", "Unit-Specific Details",
        [
            new("Great Cloak", "Abaddon Black", "as Overall cloth scheme, extra Eshin Grey edging"),
            new("Talons", "Runefang Steel"),
        ]),

        FactionUnit(CorvusCabalOverall, "Corvid Reaver", "Unit-Specific Details",
        [
            new("Feathered Cape", "Abaddon Black", "as Overall feather scheme"),
            new("Leather Harness", "Dryad Bark", "as Overall leather scheme"),
        ]),
    ], Category: GuideCategory.All, Game: Game.Warcry);
}
