namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> DrukhariOverall =
    [
        new("Armour",
        [
            new("Basecoat", "Xereus Purple"),
            new("Shade", "Druchii Violet"),
            new("Layer", "Genestealer Purple"),
            new("Highlight", "Screamer Pink", "fine edges"),
        ]),
        new("Skin / Bone",
        [
            new("Basecoat", "Rakarth Flesh"),
            new("Shade", "Seraphim Sepia"),
            new("Highlight", "Pallid Wych Flesh"),
        ]),
        new("Weapons / Armour Trim",
        [
            new("Basecoat", "Abaddon Black"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Leadbelcher"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Astrogranite Debris", "black volcanic sand look"),
        ]),
    ];

    private static FactionGuide BuildDrukhari() => new("Drukhari",
    [
        new("Overall (Head-to-Toe)", null, DrukhariOverall, IsScheme: true),

        PlainUnit(DrukhariOverall, "Archon"),
        PlainUnit(DrukhariOverall, "Drazhar"),
        PlainUnit(DrukhariOverall, "Haemonculus"),
        PlainUnit(DrukhariOverall, "Lady Malys"),
        PlainUnit(DrukhariOverall, "Lelith Hesperax"),
        PlainUnit(DrukhariOverall, "Succubus"),
        PlainUnit(DrukhariOverall, "Urien Rakarth"),
        PlainUnit(DrukhariOverall, "Beastmaster"),

        PlainUnit(DrukhariOverall, "Kabalite Warriors"),
        PlainUnit(DrukhariOverall, "Wracks"),
        PlainUnit(DrukhariOverall, "Wyches"),

        PlainUnit(DrukhariOverall, "Court of the Archon"),
        PlainUnit(DrukhariOverall, "Grotesques"),
        PlainUnit(DrukhariOverall, "Hand of the Archon"),
        PlainUnit(DrukhariOverall, "Hellions"),
        PlainUnit(DrukhariOverall, "Incubi"),
        PlainUnit(DrukhariOverall, "Mandrakes"),
        PlainUnit(DrukhariOverall, "Reavers"),
        PlainUnit(DrukhariOverall, "Scourges with Heavy Weapons"),
        PlainUnit(DrukhariOverall, "Scourges with Shardcarbines"),

        PlainUnit(DrukhariOverall, "Ravager"),
        PlainUnit(DrukhariOverall, "Razorwing Jetfighter"),
        PlainUnit(DrukhariOverall, "Raven Strike Fighter"),
        PlainUnit(DrukhariOverall, "Reaper"),
        PlainUnit(DrukhariOverall, "Tantalus"),
        PlainUnit(DrukhariOverall, "Voidraven Bomber"),

        PlainUnit(DrukhariOverall, "Cronos"),
        PlainUnit(DrukhariOverall, "Talos"),

        PlainUnit(DrukhariOverall, "Raider"),
        PlainUnit(DrukhariOverall, "Venom"),
    ]);
}
