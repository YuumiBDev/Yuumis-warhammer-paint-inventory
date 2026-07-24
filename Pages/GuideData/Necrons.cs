namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> NecronsOverall =
    [
        new("Metal Body",
        [
            new("Basecoat", "Leadbelcher"),
            new("Wash", "Nuln Oil"),
            new("Layer", "Ironbreaker"),
            new("Highlight", "Stormhost Silver"),
        ]),
        new("Glowing Details",
        [
            new("Eyes / Rods", "Moot Green", "thin glaze for a glowing look"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
        ]),
    ];

    // The major Necron Dynasties each field their own canon colour scheme — selectable
    // alongside the default gunmetal/green Overall above (which is itself the Sautekh Dynasty);
    // unit entries below stay on whichever scheme is currently selected.
    private static readonly List<Section> DynastyNovokh =
    [
        new("Body (Black Gunmetal)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Recess Shade", "Nuln Oil", "extra thinned wash into panel lines for depth"),
            new("Layer / Drybrush", "Leadbelcher", "light drybrush to pick out raised edges"),
            new("Edge Highlight", "Ironbreaker"),
        ]),
        new("Glowing Details (Red)",
        [
            new("Basecoat", "Mephiston Red"),
            new("Glaze", "Wazdakka Red", "thin glaze for an aggressive, bloodthirsty glow"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static readonly List<Section> DynastyNihilakh =
    [
        new("Body (Verdigris Bronze)",
        [
            new("Basecoat", "Warplock Bronze"),
            new("Patina Wash", "Nihilakh Oxide", "technical paint applied liberally for an authentic verdigris patina"),
            new("Layer", "Warpstone Glow", "light drybrush on raised edges to restore the bronze tone"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Glowing Details (Turquoise)",
        [
            new("Basecoat", "Moot Green"),
            new("Glaze", "Sotek Green", "thin glaze for a cold turquoise-teal glow"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static readonly List<Section> DynastyMephrit =
    [
        new("Body (Copper/Bronze)",
        [
            new("Basecoat", "Warplock Bronze"),
            new("Shade", "Reikland Fleshshade", "wash for warm copper depth"),
            new("Layer", "Sycorax Bronze"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Glowing Details (Orange/Red)",
        [
            new("Basecoat", "Troll Slayer Orange"),
            new("Glaze", "Fire Dragon Bright", "thin glaze for an irradiated orange-red glow"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static readonly List<Section> DynastyNephrekh =
    [
        new("Body (Chrome Silver)",
        [
            new("Basecoat", "Leadbelcher"),
            new("Recess Shade", "Nuln Oil", "thinned wash into panel lines"),
            new("Layer", "Runefang Steel"),
            new("Edge Highlight", "Stormhost Silver"),
        ]),
        new("Glowing Details (Blue)",
        [
            new("Basecoat", "Alaitoc Blue"),
            new("Glaze", "Baharroth Blue", "thin glaze for a swift, teleportation-blue glow"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildNecrons() => new("Necrons",
    [
        new("Sautekh Dynasty", "One of the major Necron Dynasties — gunmetal body, green glowing details. The default and most common Dynasty, ruled by Imotekh the Stormlord.", NecronsOverall, IsScheme: true),
        new("Novokh Dynasty", "One of the major Necron Dynasties — black gunmetal body, red glowing details. The most bloodthirsty and warlike of the Dynasties.", DynastyNovokh, IsScheme: true),
        new("Nihilakh Dynasty", "One of the major Necron Dynasties — verdigris bronze body, turquoise glowing details. Obsessed with reclaiming their lost dominion.", DynastyNihilakh, IsScheme: true),
        new("Mephrit Dynasty", "One of the major Necron Dynasties — copper/bronze body, orange-red glowing details. Masters of siege warfare and irradiated weaponry.", DynastyMephrit, IsScheme: true),
        new("Nephrekh Dynasty", "One of the major Necron Dynasties — chrome silver body, blue glowing details. Masters of teleportation and swift strikes.", DynastyNephrekh, IsScheme: true),

        new("C'tan Shard of the Nightbringer", "One of the most iconic centrepiece models in the Necron range — a C'tan Shard with its own unique living-metal and shadow-cloak scheme, distinct from any Dynasty colours. Paint the green OSL last: thin glazes bleeding onto nearby cloak edges and the base tie the whole model together. Layer greens thinly for a smoother glow, and drybrush the Runefang Steel boldly so the body reads almost mirror-bright against the dark cloak.",
        [
            new("Necrodermis Body (Living Metal)",
            [
                new("Basecoat", "Leadbelcher"),
                new("Drybrush", "Runefang Steel", "build up a strong shine"),
                new("Recess Shade", "Nuln Oil"),
                new("Glaze", "Aethermatic Blue", "or Nighthaunt Gloom, thinned with Lahmian Medium"),
                new("Edge Highlight", "Stormhost Silver"),
            ]),
            new("Dark Robes & Cloak",
            [
                new("Base", "Abaddon Black"),
                new("Mid Highlight", "Skavenblight Dinge"),
                new("Upper Highlight", "Stormvermin Fur"),
                new("Purple OSL", "Xereus Purple", "thinned glaze near energy zones"),
            ]),
            new("Glowing Green Energy (Cloak Fragments & Scarabs)",
            [
                new("Base", "Caliban Green"),
                new("Layer", "Warpstone Glow"),
                new("Highlight", "Moot Green"),
                new("Brightest Glow Tips", "Yriel Yellow", "or Flash Gitz Yellow"),
                new("Scarabs", "Kabalite Green", "→ Sybarite Green → White Scar reflection dot"),
                new("Base Vines / Tendrils", "Moot Green", "drybrushed over Abaddon Black"),
            ]),
            new("The Scythe",
            [
                new("Base", "Incubi Darkness"),
                new("Highlight", "Kabalite Green", "→ Sybarite Green"),
                new("Edge Gleam", "White Scar", "or Stormhost Silver along the blade"),
            ]),
            new("Face & Skull",
            [
                new("Base", "Abaddon Black"),
                new("Highlight", "The Fang", "→ Fenrisian Grey"),
                new("Glowing Eyes", "Moot Green", "base; Yriel Yellow centre; thinned Warpstone Glow glazed outward"),
            ]),
            new("Base / Rims",
            [
                new("Texture", "Astrogranite Debris", "or Armageddon Dust"),
                new("Drybrush", "Mechanicus Standard Grey", "→ Administratum Grey"),
                new("Skulls", "Zandri Dust", "→ Screaming Skull"),
            ]),
        ]),

        FactionUnit(NecronsOverall, "Warriors", "Unit-Specific Details",
        [
            new("Gauss Flayer Barrel", "Leadbelcher"),
            new("Weapon Glow", "Moot Green", "thin glaze"),
        ]),

        FactionUnit(NecronsOverall, "Immortals", "Unit-Specific Details",
        [
            new("Gauss Blaster Housing", "Ironbreaker"),
            new("Chestplate Highlight", "Stormhost Silver", "extra edge pass"),
            new("Weapon Glow", "Moot Green", "thin glaze"),
        ]),

        FactionUnit(NecronsOverall, "Deathmarks", "Unit-Specific Details",
        [
            new("Sniper Rifle", "Leadbelcher"),
            new("Cloak", "Abaddon Black"),
            new("Targeting Glow", "Moot Green", "thin glaze"),
        ]),

        FactionUnit(NecronsOverall, "Lychguard", "Unit-Specific Details",
        [
            new("Warscythe Blade", "Stormhost Silver", "edge highlight"),
            new("Hyperphase Sword Glow", "Moot Green", "thin glaze"),
            new("Shield Trim", "Ironbreaker"),
        ]),

        FactionUnit(NecronsOverall, "Flayed Ones", "Unit-Specific Details",
        [
            new("Flayed Skin Cloak", "Abaddon Black", "Agrax Earthshade wash for a grim, ragged texture"),
            new("Claws", "Leadbelcher"),
        ]),

        FactionUnit(NecronsOverall, "Overlord", "Unit-Specific Details",
        [
            new("Staff of Light Shaft", "Ironbreaker"),
            new("Staff Glow", "Moot Green", "thin glaze"),
            new("Royal Regalia", "Retributor Armour", "gilded accents distinguish nobility"),
            new("Cloak", "Abaddon Black"),
        ]),

        FactionUnit(NecronsOverall, "Cryptek", "Unit-Specific Details",
        [
            new("Arcane Staff", "Leadbelcher"),
            new("Tech Glow", "Moot Green", "thin glaze"),
            new("Cloak", "Abaddon Black"),
        ]),

        FactionUnit(NecronsOverall, "Destroyer", "Unit-Specific Details",
        [
            new("Gravitic Engine Housing", "Ironbreaker"),
            new("Engine Glow", "Moot Green", "thin glaze"),
            new("Hover Base Underside", "Abaddon Black"),
        ]),

        FactionUnit(NecronsOverall, "Ghost Ark", "Vehicle-Specific Details",
        [
            new("Hull Panels", "Leadbelcher", "as Overall metal body scheme"),
            new("Crew Cradle Glow", "Moot Green", "thin glaze"),
            new("Hull Trim", "Stormhost Silver"),
        ]),

        FactionUnit(NecronsOverall, "Monolith", "Vehicle-Specific Details",
        [
            new("Hull Panels", "Leadbelcher", "as Overall metal body scheme"),
            new("Portal Glow", "Moot Green", "larger glaze area"),
            new("Hull Trim", "Stormhost Silver"),
        ]),
    ], Category: GuideCategory.Xenos);
}
