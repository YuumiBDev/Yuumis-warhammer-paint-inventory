namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> OssiarchBonereapersOverall =
    [
        new("Bone Constructs",
        [
            new("Basecoat", "Ushabti Bone"),
            new("Shade", "Agrax Earthshade"),
            new("Layer", "Screaming Skull"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Soulfire Green Energy",
        [
            new("Basecoat", "Moot Green"),
            new("Layer", "Warpstone Glow"),
            new("Highlight", "Sybarite Green", "fine lines along runes and binding-glyphs"),
        ]),
        new("Gold Trim & Regalia",
        [
            new("Basecoat", "Retributor Armour"),
            new("Shade", "Reikland Fleshshade", "warms the gold"),
            new("Highlight", "Auric Armour Gold"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildOssiarchBonereapers() => new("Ossiarch Bonereapers",
    [
        new("Default Scheme", "The default and most iconic Ossiarch palette — bleached bone constructs bound with sickly green soulfire energy and trimmed in gold regalia befitting Nagash's perfect soldiers. Keep the bone tones bright and clean; these constructs are precision-built, not ragged like other Death factions.", OssiarchBonereapersOverall, IsScheme: true),

        new("Katakros, Mortarch of the Necropolis", "The supreme commander of the Ossiarch Bonereapers and a striking centrepiece model — ancient bone architecture wrapped in a swirling mantle of soulfire and mounted on an ornate palanquin throne. Build the green mantle glow in thin layered glazes so it reads as smoke rather than a flat colour.",
        [
            new("Bone Architecture",
            [
                new("Basecoat", "Ushabti Bone"),
                new("Shade", "Agrax Earthshade"),
                new("Layer", "Screaming Skull"),
                new("Edge Highlight", "White Scar"),
            ]),
            new("Gold Regalia & Throne Fittings",
            [
                new("Basecoat", "Retributor Armour"),
                new("Shade", "Reikland Fleshshade"),
                new("Highlight", "Auric Armour Gold"),
            ]),
            new("Soulfire Mantle (Glow)",
            [
                new("Basecoat", "Moot Green"),
                new("Layer", "Warpstone Glow"),
                new("Highlight", "Sybarite Green"),
                new("Glaze", "Warpstone Glow", "thinned glaze trailing across nearby bone and stone"),
            ]),
            new("Base / Rims",
            [
                new("Rim", "Abaddon Black"),
                new("Basing", "Astrogranite Debris"),
            ]),
        ]),

        FactionUnit(OssiarchBonereapersOverall, "Mortek Guard", "Unit-Specific Details",
        [
            new("Nadirite Blade", "Ironbreaker", "edge highlight"),
            new("Shield Rim", "Retributor Armour", "as Gold Trim scheme"),
        ]),

        FactionUnit(OssiarchBonereapersOverall, "Kavalos Deathriders", "Unit-Specific Details",
        [
            new("Skeletal Steed", "Ushabti Bone", "as Bone Constructs scheme"),
            new("Lance Tip", "Ironbreaker", "edge highlight"),
            new("Barding", "Retributor Armour"),
        ]),

        FactionUnit(OssiarchBonereapersOverall, "Immortis Guard", "Unit-Specific Details",
        [
            new("Reinforced Plating", "White Scar", "extra edge highlight pass to mark elite status"),
            new("Standard & Trim", "Retributor Armour", "as Gold Trim scheme"),
        ]),

        FactionUnit(OssiarchBonereapersOverall, "Necropolis Stalkers", "Unit-Specific Details",
        [
            new("Reaping Blades", "Ironbreaker", "edge highlight"),
            new("Carapace Joints", "Moot Green", "small soulfire glow accents at each joint"),
        ]),

        FactionUnit(OssiarchBonereapersOverall, "Mortisan Boneshaper", "Unit-Specific Details",
        [
            new("Staff Head", "Moot Green", "soulfire glow"),
            new("Robes & Wrappings", "Ushabti Bone", "Agrax Earthshade wash"),
        ]),

        FactionUnit(OssiarchBonereapersOverall, "Gothizzar Harvester", "Beast-Specific Details",
        [
            new("Bone Chassis", "Ushabti Bone", "as Bone Constructs scheme"),
            new("Harvest Cage & Blades", "Ironbreaker", "Nuln Oil wash"),
            new("Soulfire Vents", "Moot Green", "glowing glaze"),
        ]),
    ], Category: GuideCategory.Death, Game: Game.AgeOfSigmar);
}
