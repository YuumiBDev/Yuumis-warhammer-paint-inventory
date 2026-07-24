namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> KharadronOverlordsOverall =
    [
        new("Hull & Armour Plates (Red)",
        [
            new("Basecoat", "Mephiston Red"),
            new("Recess Shade", "Carroburg Crimson"),
            new("Layer", "Evil Sunz Scarlet"),
            new("Edge Highlight", "Wild Rider Red"),
        ]),
        new("Brass & Copper Fittings",
        [
            new("Basecoat", "Warplock Bronze"),
            new("Shade", "Reikland Fleshshade"),
            new("Edge Highlight", "Sycorax Bronze"),
        ]),
        new("Leather & Rigging",
        [
            new("Basecoat", "Dryad Bark"),
            new("Highlight", "Mournfang Brown"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Warplock Bronze"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    // The major Sky-ports each field their own canon colour scheme — selectable
    // alongside the default red Overall above (which is itself Barak-Zon);
    // unit entries below stay on whichever scheme is currently selected.
    private static readonly List<Section> SkyportBarakUrbaz =
    [
        new("Hull & Armour Plates (Purple)",
        [
            new("Basecoat", "Xereus Purple"),
            new("Recess Shade", "Druchii Violet"),
            new("Layer", "Genestealer Purple"),
            new("Edge Highlight", "Slaanesh Grey"),
        ]),
        new("Brass & Copper Fittings",
        [
            new("Basecoat", "Warplock Bronze"),
            new("Shade", "Reikland Fleshshade"),
            new("Edge Highlight", "Sycorax Bronze"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Warplock Bronze"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static readonly List<Section> SkyportBarakNar =
    [
        new("Hull & Armour Plates (Burgundy)",
        [
            new("Basecoat", "Doombull Brown"),
            new("Recess Shade", "Druchii Violet"),
            new("Layer", "Mournfang Brown"),
            new("Edge Highlight", "Wazdakka Red"),
        ]),
        new("Brass & Copper Fittings",
        [
            new("Basecoat", "Warplock Bronze"),
            new("Shade", "Reikland Fleshshade"),
            new("Edge Highlight", "Sycorax Bronze"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Warplock Bronze"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildKharadronOverlords() => new("Kharadron Overlords",
    [
        new("Barak-Zon", "The default and most iconic Sky-port — deep red hulls with brass and copper fittings. Barak-Zon crews are the boldest and most aggressive of the sky-faring duardin.", KharadronOverlordsOverall, IsScheme: true),
        new("Barak-Urbaz", "One of the major Sky-ports — rich purple hulls with brass fittings. The wealthiest of the Sky-ports, obsessed with trade and profit.", SkyportBarakUrbaz, IsScheme: true),
        new("Barak-Nar", "One of the major Sky-ports — burgundy hulls with brass fittings. Home of the largest shipyards, and the most militaristic of the Sky-ports.", SkyportBarakNar, IsScheme: true),

        FactionUnit(KharadronOverlordsOverall, "Arkanaut Company", "Unit-Specific Details",
        [
            new("Aethercannon / Skypike", "Warplock Bronze", "Reikland Fleshshade wash"),
            new("Sky-suit Rivets", "Sycorax Bronze", "edge highlight"),
        ]),

        FactionUnit(KharadronOverlordsOverall, "Skywardens", "Unit-Specific Details",
        [
            new("Gun-hauler Tools", "Warplock Bronze", "as Brass & Copper Fittings scheme"),
            new("Drill Launcher", "Leadbelcher", "Nuln Oil wash"),
        ]),

        FactionUnit(KharadronOverlordsOverall, "Endrinriggers", "Unit-Specific Details",
        [
            new("Aethermatic Volley Gun", "Leadbelcher", "Nuln Oil wash, Runefang Steel edge"),
            new("Grapnel Launcher", "Warplock Bronze", "as Brass & Copper Fittings scheme"),
        ]),

        FactionUnit(KharadronOverlordsOverall, "Grundstok Thunderers", "Unit-Specific Details",
        [
            new("Aethershot Rifle / Cannon", "Warplock Bronze", "Reikland Fleshshade wash"),
            new("Barrel", "Leadbelcher", "Nuln Oil wash"),
        ]),

        FactionUnit(KharadronOverlordsOverall, "Frigate / Ironclad Crew", "Vehicle-Specific Details",
        [
            new("Hull Panels", "Mephiston Red", "as Hull & Armour Plates scheme"),
            new("Aether-Endrin Balloon", "Rakarth Flesh", "Agrax Earthshade wash"),
            new("Rigging & Rope", "Dryad Bark", "as Leather & Rigging scheme"),
        ]),

        FactionUnit(KharadronOverlordsOverall, "Aether-Khemist", "Unit-Specific Details",
        [
            new("Alchemical Apparatus", "Warplock Bronze", "as Brass & Copper Fittings scheme"),
            new("Aethergold Glow", "Troll Slayer Orange", "thinned glaze"),
        ]),

        FactionUnit(KharadronOverlordsOverall, "Endrinmaster", "Unit-Specific Details",
        [
            new("Endrinwork Harness", "Warplock Bronze", "as Brass & Copper Fittings scheme"),
            new("Command Regalia", "Sycorax Bronze", "gilded accents distinguish rank"),
        ]),
    ], Category: GuideCategory.Order, Game: Game.AgeOfSigmar);
}
