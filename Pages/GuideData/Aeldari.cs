namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> AeldariOverall =
    [
        new("Armour / Wraithbone",
        [
            new("Basecoat", "Wraithbone"),
            new("Shade", "Agrax Earthshade"),
            new("Layer", "Wraithbone", "reapply to raised areas"),
            new("Highlight", "Ulthuan Grey", "fine edges"),
        ]),
        new("Trim / Panels",
        [
            new("Basecoat", "Caledor Sky"),
            new("Shade", "Drakenhof Nightshade"),
            new("Highlight", "Lothern Blue"),
        ]),
        new("Gems / Lenses",
        [
            new("Basecoat", "Mephiston Red"),
            new("Layer", "Wild Rider Red"),
            new("Highlight", "Fire Dragon Bright", "gloss varnish for shine"),
        ]),
        new("Weapons / Metal",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Astrogranite Debris", "with static grass tufts"),
        ]),
    ];

    // Five of the major Aeldari Craftworlds each field their own canon colour scheme —
    // selectable alongside the default Wraithbone Overall above; unit entries below stay on the default.
    private static readonly List<Section> CraftworldUlthwe =
    [
        new("Armour (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer / Drybrush", "Eshin Grey"),
            new("Edge Highlight", "Dawnstone"),
        ]),
        new("Trim & Bone (Off-White)",
        [
            new("Basecoat", "Screaming Skull"),
            new("Shade", "Agrax Earthshade"),
            new("Layer", "Screaming Skull", "reapply to raised areas"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Runes / Gems (Red)",
        [
            new("Basecoat", "Mephiston Red"),
            new("Layer", "Wild Rider Red"),
            new("Highlight", "Fire Dragon Bright", "gloss varnish for shine"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static readonly List<Section> CraftworldBielTan =
    [
        new("Armour (Green)",
        [
            new("Basecoat", "Moot Green"),
            new("Shade", "Biel-Tan Green"),
            new("Layer", "Warpstone Glow"),
            new("Edge Highlight", "Sybarite Green"),
        ]),
        new("Trim & Metal (Yellow/Gold)",
        [
            new("Basecoat", "Averland Sunset"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Yriel Yellow"),
            new("Metal", "Auric Armour Gold", "Reikland Fleshshade shade, Auric Armour Gold edge"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Auric Armour Gold"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static readonly List<Section> CraftworldAlaitoc =
    [
        new("Armour (Pale Blue-Grey)",
        [
            new("Basecoat", "Russ Grey"),
            new("Recess Shade", "Drakenhof Nightshade", "thinned wash into panel lines"),
            new("Layer", "Fenrisian Grey"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Trim & Details (Bone/Black)",
        [
            new("Basecoat", "Screaming Skull"),
            new("Shade", "Agrax Earthshade"),
            new("Watchful Eye Marking", "Abaddon Black", "White Scar dot highlight"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static readonly List<Section> CraftworldSaimHann =
    [
        new("Armour (Red)",
        [
            new("Basecoat", "Mephiston Red"),
            new("Recess Shade", "Carroburg Crimson"),
            new("Layer", "Evil Sunz Scarlet"),
            new("Edge Highlight", "Wild Rider Red"),
        ]),
        new("Trim & Metal (Yellow/White)",
        [
            new("Basecoat", "Averland Sunset"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "White Scar", "banding stripes"),
            new("Metal", "Leadbelcher", "Nuln Oil shade, Runefang Steel edge"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static readonly List<Section> CraftworldIyanden =
    [
        new("Armour (Sunburst Yellow)",
        [
            new("Basecoat", "Averland Sunset"),
            new("Recess Shade", "Agrax Earthshade"),
            new("Layer", "Yriel Yellow"),
            new("Edge Highlight", "Dorn Yellow"),
        ]),
        new("Trim & Metal (Deep Blue)",
        [
            new("Basecoat", "Kantor Blue"),
            new("Shade", "Drakenhof Nightshade"),
            new("Edge Highlight", "Baharroth Blue"),
            new("Metal", "Leadbelcher", "Nuln Oil shade, Runefang Steel edge"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    // Includes Harlequins and Ynnari units, which share the Aeldari codex as sub-detachments.
    private static FactionGuide BuildAeldari() => new("Aeldari",
    [
        new("Classic Aeldari (Wraithbone/Blue)", "The default scheme — bone-coloured Wraithbone armour with Caledor Sky blue trim. Doesn't match any of the 5 named Craftworlds below exactly.", AeldariOverall, IsScheme: true),

        new("Craftworld Ulthwé", "One of the major Aeldari Craftworlds — black armour, bone trim; the seer craftworld, most fatalistic.", CraftworldUlthwe, IsScheme: true),
        new("Craftworld Biel-Tan", "One of the major Aeldari Craftworlds — green armour, yellow/gold trim; the purist warrior craftworld.", CraftworldBielTan, IsScheme: true),
        new("Craftworld Alaitoc", "One of the major Aeldari Craftworlds — pale blue-grey armour, bone/white trim with black watchful-eye markings; rangers and pathfinders.", CraftworldAlaitoc, IsScheme: true),
        new("Craftworld Saim-Hann", "One of the major Aeldari Craftworlds — red armour, yellow/white trim; the wild, free-spirited biker/jetbike warhost.", CraftworldSaimHann, IsScheme: true),
        new("Craftworld Iyanden", "One of the major Aeldari Craftworlds — sunburst yellow armour, deep blue trim; the ghost warrior craftworld built around Wraith constructs.", CraftworldIyanden, IsScheme: true),

        PlainUnit(AeldariOverall, "Asurmen"),
        PlainUnit(AeldariOverall, "Autarch"),
        PlainUnit(AeldariOverall, "Autarch Wayleaper"),
        PlainUnit(AeldariOverall, "Avatar of Khaine"),
        PlainUnit(AeldariOverall, "Baharroth"),
        PlainUnit(AeldariOverall, "Death Jester"),
        PlainUnit(AeldariOverall, "Eldrad Ulthran"),
        PlainUnit(AeldariOverall, "Farseer"),
        PlainUnit(AeldariOverall, "Farseer Skyrunner"),
        PlainUnit(AeldariOverall, "Fuegan"),
        PlainUnit(AeldariOverall, "Jain Zar"),
        PlainUnit(AeldariOverall, "Kharseth"),
        PlainUnit(AeldariOverall, "Lhykhis"),
        PlainUnit(AeldariOverall, "Maugan Ra"),
        PlainUnit(AeldariOverall, "Prince Yriel"),
        PlainUnit(AeldariOverall, "Shadowseer"),
        PlainUnit(AeldariOverall, "Solitaire"),
        PlainUnit(AeldariOverall, "Spiritseer"),
        PlainUnit(AeldariOverall, "The Visarch"),
        PlainUnit(AeldariOverall, "The Yncarne"),
        PlainUnit(AeldariOverall, "Troupe Master"),
        PlainUnit(AeldariOverall, "Warlock"),
        PlainUnit(AeldariOverall, "Yvraine"),

        PlainUnit(AeldariOverall, "Guardian Defenders"),
        PlainUnit(AeldariOverall, "Storm Guardians"),
        PlainUnit(AeldariOverall, "Corsair Voidreavers"),

        PlainUnit(AeldariOverall, "Dark Reapers"),
        PlainUnit(AeldariOverall, "Dire Avengers"),
        PlainUnit(AeldariOverall, "Fire Dragons"),
        PlainUnit(AeldariOverall, "Howling Banshees"),
        PlainUnit(AeldariOverall, "Rangers"),
        PlainUnit(AeldariOverall, "Striking Scorpions"),
        PlainUnit(AeldariOverall, "Swooping Hawks"),
        PlainUnit(AeldariOverall, "Warp Spiders"),
        PlainUnit(AeldariOverall, "Wraithblades"),
        PlainUnit(AeldariOverall, "Wraithguard"),
        PlainUnit(AeldariOverall, "Warlock Conclave"),
        PlainUnit(AeldariOverall, "Troupe"),
        PlainUnit(AeldariOverall, "Corsair Skyreavers"),
        PlainUnit(AeldariOverall, "Corsair Voidscarred"),
        PlainUnit(AeldariOverall, "D-cannon Platform"),
        PlainUnit(AeldariOverall, "Shadow Weaver Platform"),
        PlainUnit(AeldariOverall, "Vibro Cannon Platform"),

        PlainUnit(AeldariOverall, "Falcon"),
        PlainUnit(AeldariOverall, "Fire Prism"),
        PlainUnit(AeldariOverall, "Night Spinner"),
        PlainUnit(AeldariOverall, "War Walkers"),
        PlainUnit(AeldariOverall, "Vypers"),
        PlainUnit(AeldariOverall, "Windriders"),
        PlainUnit(AeldariOverall, "Shining Spears"),
        PlainUnit(AeldariOverall, "Shroud Runners"),
        PlainUnit(AeldariOverall, "Skyweavers"),
        PlainUnit(AeldariOverall, "Starfangs"),
        PlainUnit(AeldariOverall, "Voidweaver"),
        PlainUnit(AeldariOverall, "Crimson Hunter"),
        PlainUnit(AeldariOverall, "Hemlock Wraithfighter"),
        PlainUnit(AeldariOverall, "Warlock Skyrunners"),

        PlainUnit(AeldariOverall, "Wraithlord"),
        PlainUnit(AeldariOverall, "Wraithknight"),
        PlainUnit(AeldariOverall, "Wraithknight with Ghostglaive"),

        PlainUnit(AeldariOverall, "Wave Serpent"),
        PlainUnit(AeldariOverall, "Starweaver"),
    ]);
}
