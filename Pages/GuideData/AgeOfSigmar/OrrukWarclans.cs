namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    // Ironjawz are the default/most iconic Warclan colour scheme — unit entries below
    // stay on this scheme regardless of which Warclan colour scheme is selected.
    private static readonly List<Section> OrrukWarclansOverall =
    [
        new("Skin",
        [
            new("Basecoat", "Waaagh! Flesh"),
            new("Shade", "Biel-Tan Green", "recesses"),
            new("Layer", "Warboss Green / Skarsnik Green", "50/50 mix"),
            new("Highlight", "Skarsnik Green", "edges"),
        ]),
        new("Armour (Black Iron)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Recess Shade", "Nuln Oil"),
            new("Drybrush", "Eshin Grey"),
            new("Edge Highlight", "Dawnstone", "sparing highlight on raised edges only"),
        ]),
        new("Metal & Studs",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Ironbreaker"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel", "chipped edges"),
            new("Basing", "Stirland Mud", "with Agrellan Earth cracks"),
        ]),
    ];

    // The major Warclans each field their own canon colour scheme — selectable
    // alongside the default Ironjawz (OrrukWarclansOverall) above; unit entries below stay on the default.
    private static readonly List<Section> WarclanKruleboyz =
    [
        new("Skin (Sickly Green)",
        [
            new("Basecoat", "Skarsnik Green"),
            new("Recess Shade", "Biel-Tan Green", "thinned wash"),
            new("Layer", "Sybarite Green"),
            new("Edge Highlight", "Moot Green"),
        ]),
        new("Bone Armour & Trophies",
        [
            new("Basecoat", "Zandri Dust"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Screaming Skull"),
        ]),
        new("Leather & Straps",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Doombull Brown"),
        ]),
        new("Base / Rims (Swamp)",
        [
            new("Basing", "Stirland Mud", "swamp muck"),
            new("Slime Detail", "Nurgle's Rot", "technical paint, dabbed sparingly for a sickly swamp sheen"),
        ]),
    ];

    private static readonly List<Section> WarclanBonesplitterz =
    [
        new("Skin (Clay-Daubed)",
        [
            new("Basecoat", "Waaagh! Flesh"),
            new("Recess Shade", "Biel-Tan Green"),
            new("Clay Daubs", "Screaming Skull", "irregular blotches and swirls over the green for ceremonial white clay markings"),
            new("Edge Highlight", "Skarsnik Green", "on skin left uncovered by clay"),
        ]),
        new("Bone Armour & Totems",
        [
            new("Basecoat", "Zandri Dust"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Screaming Skull"),
        ]),
        new("Wood & Leather",
        [
            new("Basecoat", "Steel Legion Drab"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Tallarn Sand"),
        ]),
        new("War Paint (Red)",
        [
            new("Basecoat", "Mephiston Red", "tribal markings and daubs only, no full coverage"),
        ]),
        new("Base / Rims",
        [
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static FactionGuide BuildOrrukWarclans() => new("Orruk Warclans",
    [
        new("Warclan: Ironjawz", "The default Warclan in this guide — brutish green skin under heavy black iron armour, bashed together from scrap and studded with rivets.", OrrukWarclansOverall, IsScheme: true),
        new("Warclan: Kruleboyz", "One of the major Warclans — sickly swamp-green skin, bone trophies and leather, favouring ambush and poison over a straight fight.", WarclanKruleboyz, IsScheme: true),
        new("Warclan: Bonesplitterz", "One of the major Warclans — skin daubed in white clay and bone fetishes, worshippers of the Great Green Idol who charge into battle screaming for Gork (or is it Mork?).", WarclanBonesplitterz, IsScheme: true),

        FactionUnit(OrrukWarclansOverall, "Megaboss", "Unit-Specific Details",
        [
            new("Boss Klaw / Great Weapon", "Ironbreaker", "Nuln Oil shade, Runefang Steel edge highlight"),
            new("Fur Trophies", "Rhinox Hide", "Agrax Earthshade wash"),
        ]),

        FactionUnit(OrrukWarclansOverall, "Warchanter", "Unit-Specific Details",
        [
            new("Drum / Icon", "Leadbelcher", "Nuln Oil shade, Runefang Steel edge highlight — the icon that carries Gorkamorka's war-chant into battle"),
            new("Waaagh! Energy Glow", "Warpstone Glow", "thin glaze around the drumsticks when mid-chant"),
        ]),

        PlainUnit(OrrukWarclansOverall, "Ardboys"),
        PlainUnit(OrrukWarclansOverall, "Brutes"),
        PlainUnit(OrrukWarclansOverall, "Gore-gruntas"),

        FactionUnit(OrrukWarclansOverall, "Killaboss", "Unit-Specific Details",
        [
            new("Hooked Blade", "Leadbelcher", "Nuln Oil shade, Ironbreaker edge highlight"),
            new("Bone Trophies", "Zandri Dust", "Agrax Earthshade wash, Screaming Skull highlight"),
        ]),

        PlainUnit(OrrukWarclansOverall, "Kruleboyz Gutrippaz"),
    ], Category: GuideCategory.Destruction, Game: Game.AgeOfSigmar);
}
