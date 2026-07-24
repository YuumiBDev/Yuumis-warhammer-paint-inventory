namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> LeaguesOfVotannOverall =
    [
        new("Skin",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Reikland Fleshshade"),
            new("Highlight", "Cadian Fleshtone"),
        ]),
        new("Armour (Metallic)",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Runefang Steel"),
        ]),
        new("Accent Trim",
        [
            new("Basecoat", "Troll Slayer Orange"),
            new("Shade", "Agrax Earthshade", "recess"),
            new("Edge Highlight", "Fire Dragon Bright"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Astrogranite", "or Martian Ironearth"),
        ]),
    ];

    private static FactionGuide BuildLeaguesOfVotann() => new("Leagues of Votann",
    [
        new("Overall (Head-to-Toe)", null, LeaguesOfVotannOverall, IsScheme: true),

        PlainUnit(LeaguesOfVotannOverall, "Arkanyst Evaluator"),
        PlainUnit(LeaguesOfVotannOverall, "Berehk Stornbröw"),
        PlainUnit(LeaguesOfVotannOverall, "Brôkhyr Iron-master"),
        PlainUnit(LeaguesOfVotannOverall, "Buri Aegnirssen"),
        PlainUnit(LeaguesOfVotannOverall, "Einhyr Champion"),
        PlainUnit(LeaguesOfVotannOverall, "Grimnyr"),
        PlainUnit(LeaguesOfVotannOverall, "Kâhl"),
        PlainUnit(LeaguesOfVotannOverall, "Memnyr Strategist"),
        PlainUnit(LeaguesOfVotannOverall, "Ûthar the Destined"),

        PlainUnit(LeaguesOfVotannOverall, "Hearthkyn Warriors"),

        PlainUnit(LeaguesOfVotannOverall, "Brôkhyr Thunderkyn"),
        PlainUnit(LeaguesOfVotannOverall, "Cthonian Beserks"),
        PlainUnit(LeaguesOfVotannOverall, "Einhyr Hearthguard"),
        PlainUnit(LeaguesOfVotannOverall, "Hernkyn Pioneers"),
        PlainUnit(LeaguesOfVotannOverall, "Hernkyn Yaegirs"),
        PlainUnit(LeaguesOfVotannOverall, "Ironkin Steeljacks with Heavy Volkanite Disintegrators"),
        PlainUnit(LeaguesOfVotannOverall, "Ironkin Steeljacks with Melee Weapons"),

        PlainUnit(LeaguesOfVotannOverall, "Cthonian Earthshakers"),
        PlainUnit(LeaguesOfVotannOverall, "Hekaton Land Fortress"),
        PlainUnit(LeaguesOfVotannOverall, "Kapricus Defenders"),

        PlainUnit(LeaguesOfVotannOverall, "Kapricus Carrier"),
        PlainUnit(LeaguesOfVotannOverall, "Sagitaur"),
    ]);
}
