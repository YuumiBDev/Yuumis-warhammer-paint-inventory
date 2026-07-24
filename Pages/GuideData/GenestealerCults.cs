namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> GenestealerCultsOverall =
    [
        new("Skin (Hybrid Mutation)",
        [
            new("Basecoat", "Kantor Blue"),
            new("Shade", "Drakenhof Nightshade"),
            new("Highlight", "Genestealer Purple"),
            new("Edge Highlight", "Screamer Pink"),
        ]),
        new("Robes / Fatigues",
        [
            new("Basecoat", "Dawnstone"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Administratum Grey"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Metal & Brass Weapons",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Ironbreaker"),
            new("Brass Fittings", "Brass Scorpion", "Runelord Brass highlight"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Stirland Mud", "industrial rubble/rust"),
        ]),
    ];

    private static FactionGuide BuildGenestealerCults() => new("Genestealer Cults",
    [
        new("Overall (Head-to-Toe)", null, GenestealerCultsOverall, IsScheme: true),

        PlainUnit(GenestealerCultsOverall, "Abominant"),
        PlainUnit(GenestealerCultsOverall, "Acolyte Iconward"),
        PlainUnit(GenestealerCultsOverall, "Benefictus"),
        PlainUnit(GenestealerCultsOverall, "Biophagus"),
        PlainUnit(GenestealerCultsOverall, "Clamavus"),
        PlainUnit(GenestealerCultsOverall, "Jackal Alphus"),
        PlainUnit(GenestealerCultsOverall, "Kelermorph"),
        PlainUnit(GenestealerCultsOverall, "Locus"),
        PlainUnit(GenestealerCultsOverall, "Magus"),
        PlainUnit(GenestealerCultsOverall, "Nexos"),
        PlainUnit(GenestealerCultsOverall, "Patriarch"),
        PlainUnit(GenestealerCultsOverall, "Primus"),
        PlainUnit(GenestealerCultsOverall, "Reductus Saboteur"),
        PlainUnit(GenestealerCultsOverall, "Sanctus"),

        PlainUnit(GenestealerCultsOverall, "Acolyte Hybrids With Autopistols"),
        PlainUnit(GenestealerCultsOverall, "Acolyte Hybrids With Hand Flamers"),
        PlainUnit(GenestealerCultsOverall, "Neophyte Hybrids"),

        PlainUnit(GenestealerCultsOverall, "Aberrants"),
        PlainUnit(GenestealerCultsOverall, "Achilles Ridgerunners"),
        PlainUnit(GenestealerCultsOverall, "Atalan Jackals"),
        PlainUnit(GenestealerCultsOverall, "Hybrid Metamorphs"),
        PlainUnit(GenestealerCultsOverall, "Purestrain Genestealers"),

        PlainUnit(GenestealerCultsOverall, "Goliath Rockgrinder"),

        PlainUnit(GenestealerCultsOverall, "Goliath Truck"),
    ], Category: GuideCategory.Xenos);
}
