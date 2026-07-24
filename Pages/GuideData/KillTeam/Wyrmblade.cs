namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> WyrmbladeOverall =
    [
        new("Skin (Hybrid Mutation)",
        [
            new("Basecoat", "Kantor Blue"),
            new("Shade", "Drakenhof Nightshade"),
            new("Highlight", "Genestealer Purple"),
            new("Edge Highlight", "Screamer Pink"),
        ]),
        new("Robes / Fatigues",
        [
            new("Basecoat", "Dawnstone"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Administratum Grey"),
        ]),
        new("Metal & Brass Weapons",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Ironbreaker"),
            new("Brass Fittings", "Brass Scorpion", "Runelord Brass highlight"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Stirland Mud", "industrial rubble/rust"),
        ]),
    ];

    private static FactionGuide BuildWyrmblade() => new("Wyrmblade",
    [
        new("Wyrmblade", "The Patriarch's most devoted inner circle within a Genestealer Cult — purple hybrid skin beneath grey robes and brass-fitted weaponry.", WyrmbladeOverall, IsScheme: true),

        FactionUnit(WyrmbladeOverall, "Patriarch's Chosen", "Unit-Specific Details",
        [
            new("Robed Vestments", "Genestealer Purple", "extra highlight to mark status"),
            new("Talismans", "Brass Scorpion"),
        ]),

        FactionUnit(WyrmbladeOverall, "Neophyte Hybrid", "Unit-Specific Details",
        [
            new("Autopistol", "Leadbelcher"),
            new("Cult Icon", "Mephiston Red"),
        ]),

        FactionUnit(WyrmbladeOverall, "Purestrain Genestealer", "Unit-Specific Details",
        [
            new("Carapace", "Kantor Blue", "as Overall skin scheme, no clothing"),
            new("Talons", "Screamer Pink", "edge highlight"),
        ]),

        FactionUnit(WyrmbladeOverall, "Acolyte Hybrid", "Unit-Specific Details",
        [
            new("Industrial Tool/Weapon", "Leadbelcher"),
            new("Work Apron", "Dryad Bark"),
        ]),

        FactionUnit(WyrmbladeOverall, "Primus", "Unit-Specific Details",
        [
            new("Command Sash", "Mephiston Red"),
            new("Sidearm", "Leadbelcher"),
        ]),
    ], Category: GuideCategory.Xenos, Game: Game.KillTeam);
}
