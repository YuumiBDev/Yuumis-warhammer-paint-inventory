namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> OgorMawtribesOverall =
    [
        new("Skin",
        [
            new("Basecoat", "Cadian Fleshtone"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Kislev Flesh"),
        ]),
        new("Fur & Hide Cloaks",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
            new("Drybrush", "Baneblade Brown"),
            new("Highlight", "Tallarn Sand"),
        ]),
        new("Leather Straps & Belts",
        [
            new("Basecoat", "Doombull Brown"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Baneblade Brown"),
        ]),
        new("Metal & Weapons",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Ironbreaker"),
        ]),
        new("Bone Trophies & Tusks",
        [
            new("Basecoat", "Zandri Dust"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Screaming Skull"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Rhinox Hide"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static FactionGuide BuildOgorMawtribes() => new("Ogor Mawtribes",
    [
        new("Overall (Head-to-Toe)", "The default scheme for a wandering Mawtribe — weathered leather-tan skin, thick fur and hide cloaks, and crude iron weapons, all built for a brutish life spent marching from one feast to the next.", OgorMawtribesOverall, IsScheme: true),

        PlainUnit(OgorMawtribesOverall, "Ogor Gluttons"),

        FactionUnit(OgorMawtribesOverall, "Ironguts", "Unit-Specific Details",
        [
            new("Gutplate", "Leadbelcher", "Nuln Oil shade, Ironbreaker edge highlight — the more dented and battered, the better"),
            new("Great Weapon", "Leadbelcher", "as Overall metal section"),
        ]),

        FactionUnit(OgorMawtribesOverall, "Leadbelchers", "Unit-Specific Details",
        [
            new("Leadbelcher Gun Housing", "Leadbelcher", "Nuln Oil shade, Ironbreaker edge highlight"),
            new("Scorch Marks", "Abaddon Black", "dry-brushed lightly around the muzzle"),
        ]),

        FactionUnit(OgorMawtribesOverall, "Mournfang Cavalry", "Unit-Specific Details",
        [
            new("Mournfang Hide", "Rhinox Hide", "Agrax Earthshade wash, Baneblade Brown drybrush as Overall fur section"),
            new("Tusks", "Zandri Dust", "Agrax Earthshade wash, Screaming Skull highlight"),
        ]),

        FactionUnit(OgorMawtribesOverall, "Tyrant", "Unit-Specific Details",
        [
            new("Great Weapon / Maw-clamps", "Leadbelcher", "Nuln Oil shade, Ironbreaker edge highlight"),
            new("Trophy Rack", "Zandri Dust", "Agrax Earthshade wash, Screaming Skull highlight"),
        ]),

        FactionUnit(OgorMawtribesOverall, "Firebelly", "Unit-Specific Details",
        [
            new("Stomach Fire Glow", "Troll Slayer Orange", "thin glaze around the belly and mouth"),
            new("Brazier / Torch", "Fire Dragon Bright", "glaze over Troll Slayer Orange basecoat"),
        ]),

        FactionUnit(OgorMawtribesOverall, "Stonehorn", "Unit-Specific Details",
        [
            new("Stonehorn Hide", "Rhinox Hide", "Agrax Earthshade wash, Baneblade Brown drybrush as Overall fur section"),
            new("Horns", "Zandri Dust", "Agrax Earthshade wash, Screaming Skull highlight"),
        ]),
    ], Category: GuideCategory.Destruction, Game: Game.AgeOfSigmar);
}
