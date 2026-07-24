namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> TyranidsOverall =
    [
        new("Body / Carapace",
        [
            new("Basecoat", "Wraithbone", "via primer/spray"),
            new("Shade", "Skeleton Horde", "Contrast, bone areas"),
            new("Highlight", "Pallid Wych Flesh"),
        ]),
        new("Carapace Plates",
        [
            new("Basecoat", "Naggaroth Night"),
            new("Layer", "Xereus Purple"),
            new("Highlight", "Genestealer Purple"),
        ]),
        new("Claws / Talons",
        [
            new("Basecoat", "Abaddon Black"),
            new("Highlight", "Mechanicus Standard Grey"),
            new("Edge Highlight", "Dawnstone"),
        ]),
        new("Base / Rims",
        [
            new("Basing", "Stirland Mud", "with Agrellan Earth cracks, tufts optional"),
        ]),
    ];

    // The major Hive Fleets each field their own canon colour scheme — selectable
    // alongside the default (TyranidsOverall, now named Hive Fleet Behemoth below).
    private static readonly List<Section> HiveFleetKraken =
    [
        new("Carapace (Blue-Purple)",
        [
            new("Basecoat", "Kantor Blue"),
            new("Recess Shade", "Drakenhof Nightshade"),
            new("Layer", "Genestealer Purple", "blended over the blue basecoat"),
            new("Edge Highlight", "Baharroth Blue"),
        ]),
        new("Underbelly / Soft Tissue (Cream)",
        [
            new("Basecoat", "Ushabti Bone"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Screaming Skull"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Stirland Mud", "with Agrellan Earth cracks"),
        ]),
    ];

    private static readonly List<Section> HiveFleetLeviathan =
    [
        new("Carapace (Dark Grey-Purple)",
        [
            new("Basecoat", "Dawnstone"),
            new("Glaze", "Xereus Purple", "thinned glaze over the grey for a purple sheen"),
            new("Layer", "Administratum Grey"),
            new("Edge Highlight", "Ulthuan Grey"),
        ]),
        new("Underbelly / Soft Tissue (Sickly Bio-Glow)",
        [
            new("Basecoat", "Caliban Green"),
            new("Shade", "Nuln Oil"),
            new("Glow", "Warpstone Glow", "glaze over glands/bio-luminescent spots"),
            new("Highlight", "Moot Green", "brightest point of the glow"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Stirland Mud", "with Agrellan Earth cracks"),
        ]),
    ];

    private static readonly List<Section> HiveFleetHydra =
    [
        new("Carapace (Green-Teal)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Glaze", "Sotek Green", "built up in thin layers for a teal sheen"),
            new("Layer", "Kabalite Green", "edge highlight on raised ridges"),
            new("Accent Highlight", "Genestealer Purple", "fine highlight blended in on ridge tips"),
        ]),
        new("Underbelly / Soft Tissue (Purple)",
        [
            new("Basecoat", "Genestealer Purple"),
            new("Shade", "Druchii Violet"),
            new("Highlight", "Slaanesh Grey"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Stirland Mud", "with Agrellan Earth cracks"),
        ]),
    ];

    private static FactionGuide BuildTyranids() => new("Tyranids",
    [
        new("Hive Fleet Behemoth", "The default and most iconic Hive Fleet — the first encountered by the Imperium, purple carapace with a bone underbelly.", TyranidsOverall, IsScheme: true),

        new("Hive Fleet Kraken", "One of the major Tyranid Hive Fleets — fast and adaptable, took unusual routes through the galaxy, blue-purple carapace with a pale cream underbelly.", HiveFleetKraken, IsScheme: true),
        new("Hive Fleet Leviathan", "One of the major Tyranid Hive Fleets — the largest fleet, still active and expanding, dark grey-purple carapace with a sickly green bio-glow.", HiveFleetLeviathan, IsScheme: true),
        new("Hive Fleet Hydra", "One of the major Tyranid Hive Fleets — noted for regenerative bio-adaptations, green-teal carapace with purple highlights and underbelly.", HiveFleetHydra, IsScheme: true),

        PlainUnit(TyranidsOverall, "Broodlord"),
        PlainUnit(TyranidsOverall, "Deathleaper"),
        PlainUnit(TyranidsOverall, "Hive Tyrant"),
        PlainUnit(TyranidsOverall, "Winged Hive Tyrant"),
        PlainUnit(TyranidsOverall, "Neurotyrant"),
        PlainUnit(TyranidsOverall, "Old One Eye"),
        PlainUnit(TyranidsOverall, "Parasite Of Mortrex"),
        PlainUnit(TyranidsOverall, "Tervigon"),
        PlainUnit(TyranidsOverall, "The Red Terror"),
        PlainUnit(TyranidsOverall, "The Swarmlord"),
        PlainUnit(TyranidsOverall, "Tyranid Prime With Lash Whip"),
        PlainUnit(TyranidsOverall, "Winged Tyranid Prime"),
        PlainUnit(TyranidsOverall, "Norn Assimilator"),
        PlainUnit(TyranidsOverall, "Norn Emissary"),

        PlainUnit(TyranidsOverall, "Termagants"),
        PlainUnit(TyranidsOverall, "Hormagaunts"),
        PlainUnit(TyranidsOverall, "Gargoyles"),

        PlainUnit(TyranidsOverall, "Genestealers"),
        PlainUnit(TyranidsOverall, "Ripper Swarms"),
        PlainUnit(TyranidsOverall, "Tyranid Warriors With Melee Bio-weapons"),
        PlainUnit(TyranidsOverall, "Tyranid Warriors With Ranged Bio-weapons"),
        PlainUnit(TyranidsOverall, "Tyrant Guard"),
        PlainUnit(TyranidsOverall, "Venomthropes"),
        PlainUnit(TyranidsOverall, "Zoanthropes"),
        PlainUnit(TyranidsOverall, "Lictor"),
        PlainUnit(TyranidsOverall, "Neurolictor"),
        PlainUnit(TyranidsOverall, "Hive Guard"),
        PlainUnit(TyranidsOverall, "Biovores"),
        PlainUnit(TyranidsOverall, "Pyrovores"),
        PlainUnit(TyranidsOverall, "Raveners"),
        PlainUnit(TyranidsOverall, "Hyperadapted Raveners"),
        PlainUnit(TyranidsOverall, "Von Ryan's Leapers"),
        PlainUnit(TyranidsOverall, "Barbgaunts"),
        PlainUnit(TyranidsOverall, "Neurogaunts"),
        PlainUnit(TyranidsOverall, "Spore Mines"),
        PlainUnit(TyranidsOverall, "Mucolid Spores"),
        PlainUnit(TyranidsOverall, "Psychophage"),
        PlainUnit(TyranidsOverall, "Screamer-killer"),
        PlainUnit(TyranidsOverall, "Toxicrene"),

        PlainUnit(TyranidsOverall, "Sporocyst"),
        PlainUnit(TyranidsOverall, "Tyrannocyte"),

        PlainUnit(TyranidsOverall, "Carnifexes"),
        PlainUnit(TyranidsOverall, "Exocrine"),
        PlainUnit(TyranidsOverall, "Tyrannofex"),
        PlainUnit(TyranidsOverall, "Haruspex"),
        PlainUnit(TyranidsOverall, "Maleceptor"),
        PlainUnit(TyranidsOverall, "Mawloc"),
        PlainUnit(TyranidsOverall, "Trygon"),
        PlainUnit(TyranidsOverall, "Hive Crone"),
        PlainUnit(TyranidsOverall, "Harpy"),
    ]);
}
