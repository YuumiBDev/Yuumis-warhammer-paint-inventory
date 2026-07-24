namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> OrksOverall =
    [
        new("Skin",
        [
            new("Basecoat", "Waaagh! Flesh"),
            new("Shade", "Biel-Tan Green", "recesses"),
            new("Layer", "Warboss Green / Skarsnik Green", "50/50 mix"),
            new("Highlight", "Skarsnik Green", "edges"),
        ]),
        new("Armour / Clothing",
        [
            new("Basecoat", "Mephiston Red"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Evil Sunz Scarlet"),
        ]),
        new("Metal / Weapons",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Ironbreaker"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel", "chipped edges"),
            new("Basing", "Stirland Mud", "with Agrellan Earth cracks"),
        ]),
    ];

    // The major Ork Klans each field their own canon colour scheme — selectable
    // alongside the default Evil Sunz (OrksOverall) above; unit entries below stay on the default.
    private static readonly List<Section> KlanGoffs =
    [
        new("Armour / Clothing (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Recess Shade", "Nuln Oil"),
            new("Drybrush", "Eshin Grey"),
            new("Edge Highlight", "Dawnstone", "sparing highlight on raised edges only"),
        ]),
        new("Metal & Weapons",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Ironbreaker"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Leadbelcher", "chipped edges"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static readonly List<Section> KlanDeathskulls =
    [
        new("Armour (Blue)",
        [
            new("Basecoat", "Kantor Blue"),
            new("Recess Shade", "Drakenhof Nightshade"),
            new("Layer", "Alaitoc Blue"),
            new("Edge Highlight", "Fenrisian Grey"),
        ]),
        new("Looted Plating & Trim (Random)",
        [
            new("Scavenged Panel (vary per model)", "Death Guard Green / Averland Sunset / Wazdakka Red", "pick 2-3 contrasting colours across the squad to sell mismatched loot"),
            new("Metal", "Leadbelcher", "Nuln Oil shade, Ironbreaker edge"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel", "chipped edges"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static readonly List<Section> KlanBadMoons =
    [
        new("Armour (Yellow)",
        [
            new("Basecoat", "Averland Sunset"),
            new("Recess Shade", "Agrax Earthshade"),
            new("Layer", "Yriel Yellow"),
            new("Edge Highlight", "Dorn Yellow"),
        ]),
        new("Trim & Metal (Gold)",
        [
            new("Basecoat", "Retributor Armour"),
            new("Shade", "Reikland Fleshshade"),
            new("Edge Highlight", "Auric Armour Gold"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Auric Armour Gold"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static readonly List<Section> KlanBloodAxes =
    [
        new("Armour (Khaki / Olive Drab)",
        [
            new("Basecoat", "Straken Green"),
            new("Recess Shade", "Agrax Earthshade"),
            new("Layer", "Straken Green", "thin re-layer to restore midtone after shading"),
            new("Edge Highlight", "Zandri Dust"),
        ]),
        new("Trim & Metal",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Ironbreaker"),
        ]),
        new("Details (Camo Patterns)",
        [
            new("Camo Blotches", "Death Guard Green", "irregular patches over the base khaki, Agrax Earthshade wash to blend"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel", "chipped edges"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static readonly List<Section> KlanSnakebites =
    [
        new("Hide & Fur",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
            new("Layer", "Steel Legion Drab"),
            new("Highlight", "Tallarn Sand", "dry highlight on raised fur/hide texture"),
        ]),
        new("Bone & Tusks",
        [
            new("Basecoat", "Zandri Dust"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Screaming Skull"),
        ]),
        new("War Paint (Red Accents)",
        [
            new("Basecoat", "Mephiston Red", "tribal markings and daubs only, no full armour plates"),
            new("Edge Highlight", "Wazdakka Red"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Rhinox Hide", "chipped edges"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static FactionGuide BuildOrks() => new("Orks",
    [
        new("Klan: Evil Sunz", "The default Klan in this guide — everything painted red, because 'red wunz go fasta'.", OrksOverall, IsScheme: true),

        new("Klan: Goffs", "One of the major Ork Klans — the biggest and meanest, black armour with iron trim and almost no decoration.", KlanGoffs, IsScheme: true),
        new("Klan: Deathskulls", "One of the major Ork Klans — blue armour with mismatched looted parts in random scavenged colours.", KlanDeathskulls, IsScheme: true),
        new("Klan: Bad Moons", "One of the major Ork Klans — the wealthiest, rich yellow armour with lavish gold trim.", KlanBadMoons, IsScheme: true),
        new("Klan: Blood Axes", "One of the major Ork Klans — the most military-minded, khaki/olive drab armour with camo patterns.", KlanBloodAxes, IsScheme: true),
        new("Klan: Snakebites", "One of the major Ork Klans — the most primitive, raw hide and bone tones with little proper paint, just red war paint accents.", KlanSnakebites, IsScheme: true),

        PlainUnit(OrksOverall, "Ghazghkull Thraka"),
        PlainUnit(OrksOverall, "Warboss"),
        PlainUnit(OrksOverall, "Warboss In Mega Armour"),
        PlainUnit(OrksOverall, "Bigboss"),
        PlainUnit(OrksOverall, "Bannernob"),
        PlainUnit(OrksOverall, "Beastboss"),
        PlainUnit(OrksOverall, "Beastboss On Squigosaur"),
        PlainUnit(OrksOverall, "Big Mek"),
        PlainUnit(OrksOverall, "Big Mek In Mega Armour"),
        PlainUnit(OrksOverall, "Big Mek With Shokk Attack Gun"),
        PlainUnit(OrksOverall, "Deffkilla Wartrike"),
        PlainUnit(OrksOverall, "Mek"),
        PlainUnit(OrksOverall, "Painboss"),
        PlainUnit(OrksOverall, "Painboy"),
        PlainUnit(OrksOverall, "Weirdboy"),
        PlainUnit(OrksOverall, "Wurrboy"),

        PlainUnit(OrksOverall, "Boyz"),
        PlainUnit(OrksOverall, "Beast Snagga Boyz"),

        PlainUnit(OrksOverall, "Gretchin"),
        PlainUnit(OrksOverall, "Breaka Boyz"),
        PlainUnit(OrksOverall, "Burna Boyz"),
        PlainUnit(OrksOverall, "Kommandos"),
        PlainUnit(OrksOverall, "Lootas"),
        PlainUnit(OrksOverall, "Stormboyz"),
        PlainUnit(OrksOverall, "Tankbustas"),
        PlainUnit(OrksOverall, "Flash Gitz"),
        PlainUnit(OrksOverall, "Nobz"),
        PlainUnit(OrksOverall, "Meganobz"),
        PlainUnit(OrksOverall, "Skorchas"),

        PlainUnit(OrksOverall, "Battlewagon"),
        PlainUnit(OrksOverall, "Boomdakka Snazzwagon"),
        PlainUnit(OrksOverall, "Deffkoptas"),
        PlainUnit(OrksOverall, "Killa Kans"),
        PlainUnit(OrksOverall, "Kustom Boosta-blasta"),
        PlainUnit(OrksOverall, "Megatrakk Scrapjet"),
        PlainUnit(OrksOverall, "Mek Gunz"),
        PlainUnit(OrksOverall, "Warbikers"),
        PlainUnit(OrksOverall, "Rukkatrukk Squigbuggy"),
        PlainUnit(OrksOverall, "Shokkjump Dragsta"),
        PlainUnit(OrksOverall, "Squighog Boyz"),
        PlainUnit(OrksOverall, "Big Trakk"),
        PlainUnit(OrksOverall, "Warbuggies"),
        PlainUnit(OrksOverall, "Wartrakks"),
        PlainUnit(OrksOverall, "Kannonwagon"),
        PlainUnit(OrksOverall, "Blitza-bommer"),
        PlainUnit(OrksOverall, "Burna-bommer"),
        PlainUnit(OrksOverall, "Dakkajet"),
        PlainUnit(OrksOverall, "Wazbom Blastajet"),
        PlainUnit(OrksOverall, "Attack Fighta"),
        PlainUnit(OrksOverall, "Chinork Warkopta"),

        PlainUnit(OrksOverall, "Deff Dread"),
        PlainUnit(OrksOverall, "Gorkanaut"),
        PlainUnit(OrksOverall, "Morkanaut"),
        PlainUnit(OrksOverall, "Hunta Rig"),
        PlainUnit(OrksOverall, "Kill Rig"),
        PlainUnit(OrksOverall, "Dakkarig"),
        PlainUnit(OrksOverall, "Stompa"),
        PlainUnit(OrksOverall, "Gargantuan Squiggoth"),
        PlainUnit(OrksOverall, "Squiggoth"),

        PlainUnit(OrksOverall, "Big'ed Bossbunka"),
        PlainUnit(OrksOverall, "Mekboy Workshop"),
    ], Category: GuideCategory.Xenos);
}
