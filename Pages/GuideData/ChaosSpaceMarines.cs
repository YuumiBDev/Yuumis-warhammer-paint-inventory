namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> ChaosSpaceMarinesOverall =
    [
        new("Armour",
        [
            new("Basecoat", "Abaddon Black"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer", "Eshin Grey"),
            new("Edge Highlight", "Dawnstone"),
        ]),
        new("Trim & Metal",
        [
            new("Basecoat", "Retributor Armour"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Sycorax Bronze"),
        ]),
        new("Details",
        [
            new("Blades / Chain", "Leadbelcher", "Nuln Oil wash, Runefang Steel edge"),
            new("Red Heraldry", "Mephiston Red", "Carroburg Crimson wash, Wild Rider Red edge"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Retributor Armour"),
            new("Basing", "Astrogranite Debris", "with Agrellan Earth cracked texture"),
        ]),
    ];

    // The Traitor Legions each field their own canon colour scheme — selectable
    // alongside the default black/gold Overall above (which is itself Black Legion);
    // unit entries below stay on whichever scheme is currently selected.
    private static readonly List<Section> LegionWordBearers =
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

    private static readonly List<Section> LegionIronWarriors =
    [
        new("Armour (Grey)",
        [
            new("Basecoat", "Administratum Grey"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer", "Dawnstone"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Trim & Metal (Hazard Stripes)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Stripe", "Averland Sunset"),
            new("Metal", "Leadbelcher", "Nuln Oil shade, Runefang Steel edge"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Leadbelcher"),
            new("Basing", "Astrogranite Debris", "with Agrellan Earth cracked texture"),
        ]),
    ];

    private static readonly List<Section> LegionNightLords =
    [
        new("Armour (Dark Blue-Black)",
        [
            new("Basecoat", "Corvus Black"),
            new("Layer", "Kantor Blue", "edges and raised panels"),
            new("Edge Highlight", "Baharroth Blue", "fine line only"),
        ]),
        new("Details (Chrome & Lightning)",
        [
            new("Skulls / Details", "Stormhost Silver"),
            new("Shade", "Nuln Oil"),
            new("Lightning Bolt Icons", "Stormhost Silver", "freehand over armour plates"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Stormhost Silver"),
            new("Basing", "Astrogranite Debris", "with Agrellan Earth cracked texture"),
        ]),
    ];

    private static readonly List<Section> LegionAlphaLegion =
    [
        new("Armour (Teal / Blue-Green)",
        [
            new("Basecoat", "Sotek Green"),
            new("Recess Shade", "Drakenhof Nightshade"),
            new("Layer", "Temple Guard Blue"),
            new("Edge Highlight", "Sybarite Green"),
        ]),
        new("Trim & Metal (Silver)",
        [
            new("Basecoat", "Runefang Steel"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Stormhost Silver"),
        ]),
        new("Details",
        [
            new("Hydra Icons", "Runefang Steel", "Nuln Oil recess"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Astrogranite Debris", "with Agrellan Earth cracked texture"),
        ]),
    ];

    private static FactionGuide BuildChaosSpaceMarines() => new("Chaos Space Marines",
    [
        new("Black Legion", "One of the Traitor Legions — black armour, gold trim, red details. Abaddon the Despoiler's Legion, the largest and most iconic.", ChaosSpaceMarinesOverall, IsScheme: true),
        new("Word Bearers", "One of the Traitor Legions — maroon armour, bone and brass trim. The religious zealot Legion, covered in icons and script.", LegionWordBearers, IsScheme: true),
        new("Iron Warriors", "One of the Traitor Legions — grey armour, black-and-yellow hazard-stripe trim. The siege-master Legion.", LegionIronWarriors, IsScheme: true),
        new("Night Lords", "One of the Traitor Legions — dark blue-black armour, chrome skull details. The terror-tactics Legion.", LegionNightLords, IsScheme: true),
        new("Alpha Legion", "One of the Traitor Legions — teal armour, silver trim, hydra icons. The infiltration and subterfuge Legion.", LegionAlphaLegion, IsScheme: true),

        PlainUnit(ChaosSpaceMarinesOverall, "Abaddon The Despoiler"),
        PlainUnit(ChaosSpaceMarinesOverall, "Chaos Lord"),
        PlainUnit(ChaosSpaceMarinesOverall, "Chaos Lord In Terminator Armour"),
        PlainUnit(ChaosSpaceMarinesOverall, "Chaos Lord with Jump Pack"),
        PlainUnit(ChaosSpaceMarinesOverall, "Cultist Firebrand"),
        PlainUnit(ChaosSpaceMarinesOverall, "Cypher"),
        PlainUnit(ChaosSpaceMarinesOverall, "Dark Apostle"),
        PlainUnit(ChaosSpaceMarinesOverall, "Dark Commune"),
        PlainUnit(ChaosSpaceMarinesOverall, "Fabius Bile"),
        PlainUnit(ChaosSpaceMarinesOverall, "Haarken Worldclaimer"),
        PlainUnit(ChaosSpaceMarinesOverall, "Heretic Astartes Daemon Prince"),
        PlainUnit(ChaosSpaceMarinesOverall, "Heretic Astartes Daemon Prince With Wings"),
        PlainUnit(ChaosSpaceMarinesOverall, "Huron Blackheart"),
        PlainUnit(ChaosSpaceMarinesOverall, "Kravek Morne"),
        PlainUnit(ChaosSpaceMarinesOverall, "Lord Discordant On Helstalker"),
        PlainUnit(ChaosSpaceMarinesOverall, "Master Of Executions"),
        PlainUnit(ChaosSpaceMarinesOverall, "Master Of Possession"),
        PlainUnit(ChaosSpaceMarinesOverall, "Red Corsairs Reave-Captain"),
        PlainUnit(ChaosSpaceMarinesOverall, "Sorcerer"),
        PlainUnit(ChaosSpaceMarinesOverall, "Sorcerer In Terminator Armour"),
        PlainUnit(ChaosSpaceMarinesOverall, "Traitor Enforcer"),
        PlainUnit(ChaosSpaceMarinesOverall, "Vashtorr The Arkifane"),
        PlainUnit(ChaosSpaceMarinesOverall, "Warpsmith"),

        PlainUnit(ChaosSpaceMarinesOverall, "Cultist Mob"),
        PlainUnit(ChaosSpaceMarinesOverall, "Legionaries"),
        PlainUnit(ChaosSpaceMarinesOverall, "Khorne Berzerkers"),
        PlainUnit(ChaosSpaceMarinesOverall, "Plague Marines"),
        PlainUnit(ChaosSpaceMarinesOverall, "Rubric Marines"),

        PlainUnit(ChaosSpaceMarinesOverall, "Accursed Cultists"),
        PlainUnit(ChaosSpaceMarinesOverall, "Chaos Bikers"),
        PlainUnit(ChaosSpaceMarinesOverall, "Chaos Terminator Squad"),
        PlainUnit(ChaosSpaceMarinesOverall, "Chosen"),
        PlainUnit(ChaosSpaceMarinesOverall, "Fellgor Beastmen"),
        PlainUnit(ChaosSpaceMarinesOverall, "Havocs"),
        PlainUnit(ChaosSpaceMarinesOverall, "Masters of the Maelstrom"),
        PlainUnit(ChaosSpaceMarinesOverall, "Mutilators"),
        PlainUnit(ChaosSpaceMarinesOverall, "Nemesis Claw"),
        PlainUnit(ChaosSpaceMarinesOverall, "Obliterators"),
        PlainUnit(ChaosSpaceMarinesOverall, "Possessed"),
        PlainUnit(ChaosSpaceMarinesOverall, "Raptors"),
        PlainUnit(ChaosSpaceMarinesOverall, "Red Corsairs Raiders"),
        PlainUnit(ChaosSpaceMarinesOverall, "Traitor Guardsmen Squad"),
        PlainUnit(ChaosSpaceMarinesOverall, "Warp Talons"),
        PlainUnit(ChaosSpaceMarinesOverall, "Noise Marines"),

        PlainUnit(ChaosSpaceMarinesOverall, "Chaos Land Raider"),
        PlainUnit(ChaosSpaceMarinesOverall, "Chaos Predator Annihilator"),
        PlainUnit(ChaosSpaceMarinesOverall, "Chaos Predator Destructor"),
        PlainUnit(ChaosSpaceMarinesOverall, "Chaos Vindicator"),
        PlainUnit(ChaosSpaceMarinesOverall, "Heldrake"),

        PlainUnit(ChaosSpaceMarinesOverall, "Chaos Spawn"),
        PlainUnit(ChaosSpaceMarinesOverall, "Defiler"),
        PlainUnit(ChaosSpaceMarinesOverall, "Forgefiend"),
        PlainUnit(ChaosSpaceMarinesOverall, "Helbrute"),
        PlainUnit(ChaosSpaceMarinesOverall, "Khorne Lord Of Skulls"),
        PlainUnit(ChaosSpaceMarinesOverall, "Maulerfiend"),
        PlainUnit(ChaosSpaceMarinesOverall, "Venomcrawler"),

        PlainUnit(ChaosSpaceMarinesOverall, "Chaos Rhino"),

        PlainUnit(ChaosSpaceMarinesOverall, "Noctilith Crown"),
    ], Category: GuideCategory.Chaos);
}
