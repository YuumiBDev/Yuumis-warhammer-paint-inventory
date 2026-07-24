namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> EnforcersOverall =
    [
        new("Riot Armour (Dark Blue)",
        [
            new("Basecoat", "Macragge Blue"),
            new("Shade", "Drakenhof Nightshade"),
            new("Layer", "Macragge Blue", "reapplied to raised panels"),
            new("Edge Highlight", "Fenrisian Grey"),
        ]),
        new("Tactical Webbing & Undersuit",
        [
            new("Basecoat", "Abaddon Black"),
            new("Edge Highlight", "Dawnstone"),
        ]),
        new("Trim & Metal",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Ironbreaker"),
        ]),
        new("Details (Visor / Badges)",
        [
            new("Visor", "White Scar"),
            new("Badge Trim", "Auric Armour Gold"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Astrogranite Debris", "hab-block plaza rubble"),
        ]),
    ];

    private static FactionGuide BuildEnforcers() => new("Enforcers",
    [
        new("Overall (Head-to-Toe)", "House Helmawr's law-keepers wear dark blue riot armour with black tactical webbing — uniform, disciplined, and instantly recognisable against the underhive's chaos.", EnforcersOverall, IsScheme: true),

        FactionUnit(EnforcersOverall, "Enforcer Patrolman", "Unit-Specific Details",
        [
            new("Shield", "Macragge Blue", "Fenrisian Grey edge highlight"),
            new("Baton", "Leadbelcher"),
        ]),

        FactionUnit(EnforcersOverall, "Enforcer Sergeant", "Unit-Specific Details",
        [
            new("Rank Stripes", "Auric Armour Gold"),
            new("Vox-Bead / Comms", "Leadbelcher"),
            new("Visor", "White Scar"),
        ]),

        FactionUnit(EnforcersOverall, "Enforcer Heavy", "Unit-Specific Details",
        [
            new("Heavy Weapon Housing", "Abaddon Black"),
            new("Weapon Barrel", "Leadbelcher"),
            new("Ammo Feed", "Runefang Steel"),
        ]),

        FactionUnit(EnforcersOverall, "Enforcer Subjugator (Psyker)", "Unit-Specific Details",
        [
            new("Psychic Hood", "Teclis Blue", "Lothern Blue edge highlight"),
            new("Undersuit", "Abaddon Black"),
            new("Icon Trim", "Auric Armour Gold"),
        ]),

        FactionUnit(EnforcersOverall, "Enforcer Leader (Suppression Squad Prime)", "Unit-Specific Details",
        [
            new("Command Pauldron", "Auric Armour Gold"),
            new("Armour Trim", "White Scar"),
            new("Weapon Casing", "Leadbelcher"),
        ]),
    ], Category: GuideCategory.Gangs, Game: Game.Necromunda);
}
