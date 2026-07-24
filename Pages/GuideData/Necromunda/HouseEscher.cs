namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> HouseEscherOverall =
    [
        new("Skin",
        [
            new("Basecoat", "Kislev Flesh"),
            new("Shade", "Reikland Fleshshade"),
            new("Highlight", "Pallid Wych Flesh"),
        ]),
        new("Leathers & Bodysuits (Purple)",
        [
            new("Basecoat", "Xereus Purple"),
            new("Shade", "Druchii Violet"),
            new("Layer", "Genestealer Purple"),
            new("Edge Highlight", "Screamer Pink"),
        ]),
        new("Toxic Accents (Hair / Warpaint)",
        [
            new("Basecoat", "Warpstone Glow"),
            new("Shade", "Biel-Tan Green"),
            new("Highlight", "Moot Green"),
        ]),
        new("Trim & Metal",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Ironbreaker"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Stirland Mud", "underhive rubble"),
        ]),
    ];

    private static FactionGuide BuildHouseEscher() => new("House Escher",
    [
        new("Overall (Head-to-Toe)", "Lithe underhive-punk gangers in toxic purple and acid green — skintight bodysuits, exposed muscle, and venom-bright hair make Escher fighters look as dangerous as their chem-fuelled reputation.", HouseEscherOverall, IsScheme: true),

        FactionUnit(HouseEscherOverall, "Escher Ganger", "Unit-Specific Details",
        [
            new("Combat Blade", "Ironbreaker"),
            new("Chem Canister", "Warpstone Glow", "toxic warpaint colour"),
        ]),

        FactionUnit(HouseEscherOverall, "Escher Juve", "Unit-Specific Details",
        [
            new("Hair", "Screamer Pink", "brighter than veteran fighters"),
            new("Bodysuit Patches", "Genestealer Purple"),
        ]),

        FactionUnit(HouseEscherOverall, "Escher Champion (Wyld Runner)", "Unit-Specific Details",
        [
            new("Trophy Rack", "Screaming Skull"),
            new("Blade Edge", "White Scar", "razor-sharp glint"),
            new("Warpaint Streaks", "Moot Green"),
        ]),

        FactionUnit(HouseEscherOverall, "Escher Leader (Matriarch)", "Unit-Specific Details",
        [
            new("Cloak / Trailing Cloth", "Genestealer Purple", "Druchii Violet recess shade"),
            new("House Icon", "Runefang Steel"),
            new("Command Weapon Casing", "Abaddon Black"),
        ]),

        FactionUnit(HouseEscherOverall, "Escher Heavy", "Unit-Specific Details",
        [
            new("Heavy Weapon Housing", "Abaddon Black"),
            new("Weapon Barrel", "Leadbelcher"),
            new("Ammo Feed", "Runelord Brass"),
        ]),
    ], Category: GuideCategory.Gangs, Game: Game.Necromunda);
}
