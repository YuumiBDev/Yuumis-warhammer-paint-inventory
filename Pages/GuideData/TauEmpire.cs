namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> TauEmpireOverall =
    [
        new("Armour",
        [
            new("Basecoat", "Celestra Grey"),
            new("Shade", "Drakenhof Nightshade", "thinned"),
            new("Layer", "Celestra Grey", "reapply to raised panels"),
            new("Highlight", "White Scar", "fine edges"),
        ]),
        new("Sept Trim (Vior'la)",
        [
            new("Basecoat", "Fire Dragon Bright"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Troll Slayer Orange"),
        ]),
        new("Weapons / Metal",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Stormhost Silver"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Martian Ivory", "Agrax Earthshade wash"),
        ]),
    ];

    private static FactionGuide BuildTauEmpire() => new("T'au Empire",
    [
        new("Overall (Head-to-Toe)", null, TauEmpireOverall, IsScheme: true),

        PlainUnit(TauEmpireOverall, "Cadre Fireblade"),
        PlainUnit(TauEmpireOverall, "Commander Farsight"),
        PlainUnit(TauEmpireOverall, "Commander in Coldstar Battlesuit"),
        PlainUnit(TauEmpireOverall, "Commander in Enforcer Battlesuit"),
        PlainUnit(TauEmpireOverall, "Commander Shadowsun"),
        PlainUnit(TauEmpireOverall, "Darkstrider"),
        PlainUnit(TauEmpireOverall, "Ethereal"),
        PlainUnit(TauEmpireOverall, "Firesight Team"),
        PlainUnit(TauEmpireOverall, "Kroot Flesh Shaper"),
        PlainUnit(TauEmpireOverall, "Kroot Lone-Spear"),
        PlainUnit(TauEmpireOverall, "Kroot Trail Shaper"),
        PlainUnit(TauEmpireOverall, "Kroot War Shaper"),
        PlainUnit(TauEmpireOverall, "The Twin Lance"),

        PlainUnit(TauEmpireOverall, "Breacher Team"),
        PlainUnit(TauEmpireOverall, "Strike Team"),

        PlainUnit(TauEmpireOverall, "Broadside Battlesuits"),
        PlainUnit(TauEmpireOverall, "Crisis Fireknife Battlesuits"),
        PlainUnit(TauEmpireOverall, "Crisis Starscythe Battlesuits"),
        PlainUnit(TauEmpireOverall, "Crisis Sunforge Battlesuits"),
        PlainUnit(TauEmpireOverall, "Ghostkeel Battlesuit"),
        PlainUnit(TauEmpireOverall, "Kroot Carnivores"),
        PlainUnit(TauEmpireOverall, "Kroot Farstalkers"),
        PlainUnit(TauEmpireOverall, "Kroot Hounds"),
        PlainUnit(TauEmpireOverall, "Krootox Rampagers"),
        PlainUnit(TauEmpireOverall, "Krootox Riders"),
        PlainUnit(TauEmpireOverall, "Pathfinder Team"),
        PlainUnit(TauEmpireOverall, "Stealth Battlesuits"),
        PlainUnit(TauEmpireOverall, "Vespid Stingwings"),

        PlainUnit(TauEmpireOverall, "Hammerhead Gunship"),
        PlainUnit(TauEmpireOverall, "Piranhas"),
        PlainUnit(TauEmpireOverall, "Razorshark Strike Fighter"),
        PlainUnit(TauEmpireOverall, "Sky Ray Gunship"),
        PlainUnit(TauEmpireOverall, "Sun Shark Bomber"),

        PlainUnit(TauEmpireOverall, "Riptide Battlesuit"),
        PlainUnit(TauEmpireOverall, "Stormsurge"),

        PlainUnit(TauEmpireOverall, "Tidewall Droneport"),
        PlainUnit(TauEmpireOverall, "Tidewall Gunrig"),
        PlainUnit(TauEmpireOverall, "Tidewall Shieldline"),

        PlainUnit(TauEmpireOverall, "Devilfish"),
    ]);
}
