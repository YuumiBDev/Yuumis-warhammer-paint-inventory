namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> NecromundaGenestealerCultsOverall =
    [
        new("Skin (Hybrid Mutation)",
        [
            new("Basecoat", "Xereus Purple"),
            new("Shade", "Druchii Violet"),
            new("Highlight", "Genestealer Purple"),
            new("Edge Highlight", "Screamer Pink"),
        ]),
        new("Robes & Fatigues",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Doombull Brown"),
        ]),
        new("Brass & Metal",
        [
            new("Basecoat", "Warplock Bronze"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Brass Scorpion"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Stirland Mud", "underhive rubble"),
        ]),
    ];

    private static FactionGuide BuildNecromundaGenestealerCults() => new("Genestealer Cults",
    [
        new("Overall (Head-to-Toe)", "Underhive outlanders twisted by the Patriarch's taint — mottled purple hybrid flesh under worn work fatigues and improvised brass fittings, blending in with the hive until it's too late.", NecromundaGenestealerCultsOverall, IsScheme: true),

        FactionUnit(NecromundaGenestealerCultsOverall, "Neophyte Hybrid", "Unit-Specific Details",
        [
            new("Mutated Hand", "Xereus Purple", "Screamer Pink edge highlight"),
            new("Tool / Weapon Casing", "Warplock Bronze"),
        ]),

        FactionUnit(NecromundaGenestealerCultsOverall, "Acolyte Hybrid", "Unit-Specific Details",
        [
            new("Carapace Plating", "Rhinox Hide", "Agrax Earthshade wash"),
            new("Mutation", "Genestealer Purple"),
            new("Weapon Casing", "Warplock Bronze"),
        ]),

        FactionUnit(NecromundaGenestealerCultsOverall, "Primus", "Unit-Specific Details",
        [
            new("Cult Icon", "Brass Scorpion"),
            new("Robe Trim", "Doombull Brown"),
            new("Blade Edge", "Runefang Steel"),
        ]),

        FactionUnit(NecromundaGenestealerCultsOverall, "Patriarch", "Unit-Specific Details",
        [
            new("Carapace Hide", "Xereus Purple", "Druchii Violet recess shade"),
            new("Claws", "Screamer Pink"),
            new("Robes", "Rhinox Hide"),
        ]),

        FactionUnit(NecromundaGenestealerCultsOverall, "Aberrant", "Unit-Specific Details",
        [
            new("Overgrown Musculature", "Xereus Purple", "Genestealer Purple highlight"),
            new("Power Weapon Housing", "Warplock Bronze"),
            new("Bindings", "Rhinox Hide"),
        ]),
    ], Category: GuideCategory.Gangs, Game: Game.Necromunda);
}
