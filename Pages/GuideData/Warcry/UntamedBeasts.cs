namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> UntamedBeastsOverall =
    [
        new("Fur & Pelts",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
            new("Drybrush", "Mournfang Brown"),
            new("Highlight", "Baneblade Brown", "light drybrush on ridges"),
        ]),
        new("Skin",
        [
            new("Basecoat", "Cadian Fleshtone"),
            new("Shade", "Reikland Fleshshade"),
        ]),
        new("Horns & Bone",
        [
            new("Basecoat", "Ushabti Bone"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Screaming Skull"),
        ]),
        new("Tribal Markings",
        [
            new("Warpaint", "Wild Rider Red", "thin freehand stripes"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildUntamedBeasts() => new("Untamed Beasts",
    [
        new("Untamed Beasts", "Feral warriors twisted by Chaos into something more animal than man — matted fur pelts, curling horns and crude warpaint.", UntamedBeastsOverall, IsScheme: true),

        FactionUnit(UntamedBeastsOverall, "Beastspeaker", "Unit-Specific Details",
        [
            new("Totem Staff", "Dryad Bark", "Agrax Earthshade wash"),
            new("Bound Trophies", "Ushabti Bone", "as Overall horn scheme"),
        ]),

        FactionUnit(UntamedBeastsOverall, "Screamer Killer", "Unit-Specific Details",
        [
            new("Twin Blades", "Leadbelcher", "Nuln Oil recess"),
            new("Fur", "Rhinox Hide", "as Overall fur scheme, extra Mournfang Brown drybrush"),
        ]),

        FactionUnit(UntamedBeastsOverall, "Twistgorn Devotee", "Unit-Specific Details",
        [
            new("Weapon Haft", "Dryad Bark"),
            new("Fur", "Rhinox Hide", "as Overall fur scheme"),
        ]),

        FactionUnit(UntamedBeastsOverall, "Ungor", "Unit-Specific Details",
        [
            new("Ragged Cloak", "Dryad Bark", "Agrax Earthshade wash"),
            new("Horn Bow", "Ushabti Bone", "as Overall horn scheme"),
        ]),

        FactionUnit(UntamedBeastsOverall, "Bullgor", "Unit-Specific Details",
        [
            new("Bulk Fur", "Rhinox Hide", "as Overall fur scheme, largest surface for smooth drybrushing"),
            new("Iron Ring & Axe", "Leadbelcher", "Nuln Oil recess"),
        ]),
    ], Category: GuideCategory.All, Game: Game.Warcry);
}
