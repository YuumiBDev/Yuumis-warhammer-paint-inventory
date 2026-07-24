using Microsoft.AspNetCore.Components;

namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private bool _loaded;

    // internal (not private): the paint cross-reference index on other pages
    // (AllPaints/ByRack/WishList) reads these directly via Guides.PaintUsageIndex.
    internal record Step(string Label, string Paint, string? Note = null);
    internal record Section(string Title, List<Step> Steps);
    internal record UnitGuide(string Name, string? Intro, List<Section> Sections, string? ImageUrl = null, bool IsScheme = false);
    internal record Source(string Name, string Description, string? Url);
    internal record SourceGroup(string Title, List<Source> Sources);
    internal record FactionGuide(string Name, List<UnitGuide> Units, GuideCategory Category = GuideCategory.Imperial, Game Game = Game.Warhammer40K, List<SourceGroup>? Sources = null);

    private FactionGuide _faction = null!;
    private UnitGuide _scheme = null!;
    private UnitGuide _selectedUnit = null!;

    private void SelectFaction(FactionGuide f)
    {
        _faction = f;
        _scheme = f.Units.First(u => u.IsScheme);
        _selectedUnit = f.Units.First(u => !u.IsScheme);
    }

    private void OnSchemeSelected(ChangeEventArgs e)
    {
        var match = _faction.Units.FirstOrDefault(u => u.IsScheme && u.Name == e.Value?.ToString());
        if (match is not null) _scheme = match;
    }

    private void OnUnitSelected(ChangeEventArgs e)
    {
        var match = _faction.Units.FirstOrDefault(u => !u.IsScheme && u.Name == e.Value?.ToString());
        if (match is not null) _selectedUnit = match;
    }

    // ---- General guides (Skin Tone, Rocks/Walls/Buildings) — not tied to any one
    // game, so they render as their own section above the Game picker, with their
    // own independent picker state (kept separate so it doesn't fight over shared
    // state with whichever game/category is also expanded at the same time).
    private bool _generalExpanded;
    private FactionGuide _generalFaction = null!;
    private UnitGuide _generalScheme = null!;
    private UnitGuide _generalSelectedUnit = null!;

    private void ToggleGeneral() => _generalExpanded = !_generalExpanded;

    private void SelectGeneralFaction(FactionGuide f)
    {
        _generalFaction = f;
        _generalScheme = f.Units.First(u => u.IsScheme);
        _generalSelectedUnit = f.Units.First(u => !u.IsScheme);
    }

    private void OnGeneralSchemeSelected(ChangeEventArgs e)
    {
        var match = _generalFaction.Units.FirstOrDefault(u => u.IsScheme && u.Name == e.Value?.ToString());
        if (match is not null) _generalScheme = match;
    }

    private void OnGeneralUnitSelected(ChangeEventArgs e)
    {
        var match = _generalFaction.Units.FirstOrDefault(u => !u.IsScheme && u.Name == e.Value?.ToString());
        if (match is not null) _generalSelectedUnit = match;
    }

    private List<FactionGuide> GeneralFactions => _factions.Where(f => f.Category == GuideCategory.General).ToList();

    // Every non-"Overall" unit is rendered on top of whichever Colour Scheme is
    // currently selected, plus this short block of unit-specific gear/iconography callouts.
    private static UnitGuide FactionUnit(List<Section> overall, string name, string extraTitle, List<Step> extraSteps) =>
        new(name, null, [new(extraTitle, extraSteps)]);

    // For full-roster factions where hand-written per-unit callouts aren't available —
    // just renders whichever Colour Scheme is currently selected.
    private static UnitGuide PlainUnit(List<Section> overall, string name) =>
        new(name, null, []);

    // ---- Top-level games, each with its own set of categories that roll down to factions ----
    internal enum Game
    {
        Warhammer40K, AgeOfSigmar, KillTeam, Necromunda,
        HorusHeresy, AdeptusTitanicus, LegionsImperialis,
        OldWorld, MiddleEarth, Warcry, WarhammerUnderworlds, WarhammerQuestDarkwater,
        BloodBowl,
    }

    internal enum GuideCategory { General, Imperial, Chaos, Xenos, Order, Death, Destruction, Gangs, Loyalist, Traitor, Good, Evil, Teams, All }

    private static readonly Game[] _games =
    [
        Game.Warhammer40K, Game.AgeOfSigmar, Game.KillTeam, Game.Necromunda,
        Game.HorusHeresy, Game.AdeptusTitanicus, Game.LegionsImperialis,
        Game.OldWorld, Game.MiddleEarth, Game.Warcry, Game.WarhammerUnderworlds, Game.WarhammerQuestDarkwater,
        Game.BloodBowl,
    ];

    // General isn't listed per-game — it's the same guides regardless of game,
    // rendered as its own section above the Game picker (see _generalFaction etc.)
    private static readonly Dictionary<Game, GuideCategory[]> _categoriesByGame = new()
    {
        [Game.Warhammer40K] = [GuideCategory.Imperial, GuideCategory.Chaos, GuideCategory.Xenos],
        [Game.AgeOfSigmar] = [GuideCategory.Order, GuideCategory.Chaos, GuideCategory.Death, GuideCategory.Destruction],
        [Game.KillTeam] = [GuideCategory.Imperial, GuideCategory.Chaos, GuideCategory.Xenos],
        [Game.Necromunda] = [GuideCategory.Gangs],
        [Game.HorusHeresy] = [GuideCategory.Loyalist, GuideCategory.Traitor],
        [Game.AdeptusTitanicus] = [GuideCategory.Loyalist, GuideCategory.Traitor],
        [Game.LegionsImperialis] = [GuideCategory.Loyalist, GuideCategory.Traitor],
        [Game.OldWorld] = [GuideCategory.All],
        [Game.MiddleEarth] = [GuideCategory.Good, GuideCategory.Evil],
        [Game.Warcry] = [GuideCategory.All],
        [Game.WarhammerUnderworlds] = [GuideCategory.All],
        [Game.WarhammerQuestDarkwater] = [GuideCategory.All],
        [Game.BloodBowl] = [GuideCategory.Teams],
    };

    internal static string GameLabel(Game g) => g switch
    {
        Game.Warhammer40K => "Warhammer 40,000",
        Game.AgeOfSigmar => "Age of Sigmar",
        Game.KillTeam => "Kill Team",
        Game.Necromunda => "Necromunda",
        Game.HorusHeresy => "The Horus Heresy",
        Game.AdeptusTitanicus => "Adeptus Titanicus",
        Game.LegionsImperialis => "Legions Imperialis",
        Game.OldWorld => "The Old World",
        Game.MiddleEarth => "Middle-earth",
        Game.Warcry => "Warcry",
        Game.WarhammerUnderworlds => "Warhammer Underworlds",
        Game.WarhammerQuestDarkwater => "Warhammer Quest: Darkwater",
        Game.BloodBowl => "Blood Bowl",
        _ => g.ToString(),
    };

    private static GuideCategory CategoryOf(FactionGuide f) => f.Category;

    private static string CategoryLabel(GuideCategory cat) => cat switch
    {
        GuideCategory.General => "General",
        GuideCategory.Imperial => "Imperial",
        GuideCategory.Chaos => "Chaos",
        GuideCategory.Xenos => "Xenos",
        GuideCategory.Order => "Order",
        GuideCategory.Death => "Death",
        GuideCategory.Destruction => "Destruction",
        GuideCategory.Gangs => "Gangs",
        GuideCategory.Loyalist => "Loyalist",
        GuideCategory.Traitor => "Traitor",
        GuideCategory.Good => "Good",
        GuideCategory.Evil => "Evil",
        GuideCategory.Teams => "Teams",
        GuideCategory.All => "All",
        _ => cat.ToString(),
    };

    private Game _selectedGame = Game.Warhammer40K;
    private GuideCategory? _expandedCategory = GuideCategory.Imperial;

    private List<FactionGuide> FactionsIn(Game g, GuideCategory cat) =>
        _factionsByGameAndCategory.TryGetValue(g, out var byCat) && byCat.TryGetValue(cat, out var list)
            ? list
            : [];

    private void SelectGame(Game g)
    {
        _selectedGame = g;
        var categories = _categoriesByGame[g];
        // Pick the first category in this game that actually has any guides yet,
        // falling back to the first category at all if none do (still empty).
        var expanded = categories.FirstOrDefault(cat => FactionsIn(g, cat).Count > 0, categories[0]);
        _expandedCategory = expanded;

        var faction = FactionsIn(g, expanded).FirstOrDefault();
        if (faction is not null) SelectFaction(faction);
    }

    private void ToggleCategory(GuideCategory cat)
    {
        if (_expandedCategory == cat)
        {
            _expandedCategory = null;
            return;
        }

        _expandedCategory = cat;
        if (_faction.Game != _selectedGame || CategoryOf(_faction) != cat)
        {
            var faction = FactionsIn(_selectedGame, cat).FirstOrDefault();
            if (faction is not null) SelectFaction(faction);
        }
    }

    private readonly List<FactionGuide> _factions;
    private readonly Dictionary<Game, Dictionary<GuideCategory, List<FactionGuide>>> _factionsByGameAndCategory;

    // The single source of truth for every faction/kill-team/gang/etc. guide in
    // the app. Static (not tied to a live Guides page instance) so other pages
    // can build the paint cross-reference index without instantiating Guides.
    private static List<FactionGuide> BuildAllFactions() =>
        [
            BuildSororitas(),
            BuildSpaceMarines(),
            BuildNecrons(),
            BuildAstraMilitarum(),
            BuildAdeptusCustodes(),
            BuildAdeptusMechanicus(),
            BuildGreyKnights(),
            BuildDeathwatch(),
            BuildImperialKnights(),
            BuildBlackTemplars(),
            BuildBloodAngels(),
            BuildDarkAngels(),
            BuildSpaceWolves(),
            BuildOrks(),
            BuildTyranids(),
            BuildGenestealerCults(),
            BuildLeaguesOfVotann(),
            BuildAeldari(),
            BuildDrukhari(),
            BuildTauEmpire(),
            BuildChaosSpaceMarines(),
            BuildDeathGuard(),
            BuildThousandSons(),
            BuildWorldEaters(),
            BuildChaosDaemons(),
            BuildChaosKnights(),
            BuildSkinToneGuide(),
            BuildRocksWallsBuildingsGuide(),

            // Age of Sigmar — Order
            BuildStormcastEternals(),
            BuildCitiesOfSigmar(),
            BuildDaughtersOfKhaine(),
            BuildIdonethDeepkin(),
            BuildLuminethRealmLords(),
            BuildFyreslayers(),
            BuildKharadronOverlords(),
            BuildSeraphon(),

            // Age of Sigmar — Chaos
            BuildSlavesToDarkness(),
            BuildBladesOfKhorne(),
            BuildDisciplesOfTzeentch(),
            BuildMaggotkinOfNurgle(),
            BuildHedonitesOfSlaanesh(),
            BuildSkaven(),

            // Age of Sigmar — Death
            BuildNighthaunt(),
            BuildOssiarchBonereapers(),
            BuildSoulblightGravelords(),
            BuildFleshEaterCourts(),

            // Age of Sigmar — Destruction
            BuildOrrukWarclans(),
            BuildGloomspiteGitz(),
            BuildOgorMawtribes(),
            BuildSonsOfBehemat(),

            // Kill Team
            BuildKasrkin(),
            BuildAngelsOfDeath(),
            BuildHunterClade(),
            BuildLegionary(),
            BuildBlooded(),
            BuildHierotekCircle(),
            BuildKommandos(),
            BuildWyrmblade(),
            BuildCorsairVoidscarred(),

            // Necromunda
            BuildHouseEscher(),
            BuildHouseGoliath(),
            BuildHouseOrlock(),
            BuildHouseVanSaar(),
            BuildHouseCawdor(),
            BuildHouseDelaque(),
            BuildEnforcers(),
            BuildNecromundaGenestealerCults(),
            BuildChaosCult(),

            // The Horus Heresy — Loyalist
            BuildDarkAngelsLegion(),
            BuildWhiteScarsLegion(),
            BuildSpaceWolvesLegion(),
            BuildImperialFistsLegion(),
            BuildBloodAngelsLegion(),
            BuildIronHandsLegion(),
            BuildUltramarinesLegion(),
            BuildSalamandersLegion(),
            BuildRavenGuardLegion(),

            // The Horus Heresy — Traitor
            BuildEmperorsChildren(),
            BuildIronWarriorsLegion(),
            BuildNightLordsLegion(),
            BuildWorldEatersLegion(),
            BuildThousandSonsLegion(),
            BuildSonsOfHorus(),
            BuildWordBearers(),
            BuildAlphaLegion(),
            BuildDeathGuardLegion(),

            // The Old World
            BuildTheEmpire(),
            BuildKingdomOfBretonnia(),
            BuildOrcAndGoblinTribes(),
            BuildTombKingsOfKhemri(),
            BuildVampireCounts(),
            BuildDwarfenMountainHolds(),
            BuildWoodElfRealms(),
            BuildHighElfRealms(),
            BuildDarkElves(),

            // Middle-earth
            BuildGondor(),
            BuildRohan(),
            BuildRivendell(),
            BuildDwarvesOfErebor(),
            BuildMordor(),
            BuildIsengard(),
            BuildMoriaGoblins(),
            BuildEasterlingsHarad(),

            // Warcry
            BuildUntamedBeasts(),
            BuildIronGolems(),
            BuildCypherLords(),
            BuildSplinteredFang(),
            BuildCorvusCabal(),
            BuildSpireTyrants(),

            // Warhammer Underworlds
            BuildGrymwatch(),
            BuildIronsoulsCondemnors(),
            BuildMorgoksKrushas(),
            BuildTheWurmspat(),
            BuildZarbagsGitz(),
            BuildSkittershanksClawpack(),

            // Warhammer Quest: Darkwater
            BuildHeroesOfDarkwater(),
            BuildSkavenMarauders(),

            // Blood Bowl
            BuildHuman(),
            BuildOrc(),
            BuildDwarf(),
            BuildBloodBowlSkaven(),
            BuildChaosChosen(),
            BuildUndead(),
            BuildHighElf(),
            BuildDarkElf(),
            BuildNorse(),
            BuildNurgle(),

            // Adeptus Titanicus
            BuildLegioFureansTitanicus(),
            BuildLegioIgnatumTitanicus(),
            BuildLegioAstorumTitanicus(),
            BuildLegioMortisTitanicus(),
            BuildLegioVulcanumTitanicus(),
            BuildLegioAudaxTitanicus(),

            // Legions Imperialis
            BuildUltramarinesLegionsImperialis(),
            BuildImperialFistsLegionsImperialis(),
            BuildBloodAngelsLegionsImperialis(),
            BuildSonsOfHorusLegionsImperialis(),
            BuildDeathGuardLegionsImperialis(),
            BuildWordBearersLegionsImperialis(),
        ];

    public Guides()
    {
        _factions = BuildAllFactions();
        _factionsByGameAndCategory = _factions
            .GroupBy(f => f.Game)
            .ToDictionary(gg => gg.Key, gg => gg.GroupBy(CategoryOf).ToDictionary(cg => cg.Key, cg => cg.ToList()));
        SelectFaction(_factions.First(f => f.Category != GuideCategory.General));

        var generalFaction = _factions.FirstOrDefault(f => f.Category == GuideCategory.General);
        if (generalFaction is not null) SelectGeneralFaction(generalFaction);
    }

    // ---- Paint "used in" cross-reference — built once, reused by All Paints /
    // By Rack / Wish List to show which guides call for a given paint. Indexed
    // per scheme and per unit's own extra Sections (not the full combined
    // scheme+unit render), since that stays meaningful without combinatorial
    // blowup across every scheme x unit combination.
    internal record PaintUsage(Game Game, string FactionName, string UnitName);

    private static Dictionary<string, List<PaintUsage>>? _paintUsageIndexCache;

    internal static Dictionary<string, List<PaintUsage>> PaintUsageIndex
    {
        get
        {
            if (_paintUsageIndexCache is not null) return _paintUsageIndexCache;

            var index = new Dictionary<string, List<PaintUsage>>(StringComparer.OrdinalIgnoreCase);
            foreach (var faction in BuildAllFactions())
            {
                foreach (var unit in faction.Units)
                {
                    var unitLabel = unit.IsScheme ? $"{unit.Name} (Colour Scheme)" : unit.Name;
                    foreach (var step in unit.Sections.SelectMany(s => s.Steps))
                    {
                        if (!index.TryGetValue(step.Paint, out var uses))
                            index[step.Paint] = uses = [];

                        if (!uses.Any(u => u.Game == faction.Game && u.FactionName == faction.Name && u.UnitName == unitLabel))
                            uses.Add(new PaintUsage(faction.Game, faction.Name, unitLabel));
                    }
                }
            }
            _paintUsageIndexCache = index;
            return index;
        }
    }

    internal static List<PaintUsage> WhereUsed(string paintName) =>
        PaintUsageIndex.TryGetValue(paintName, out var uses) ? uses : [];

    protected override async Task OnInitializedAsync()
    {
        await Manager.InitializeAsync();
        _loaded = true;
    }

    private bool IsOwned(string paintName) =>
        Manager.Paints.FirstOrDefault(p => p.Name.Equals(paintName, StringComparison.OrdinalIgnoreCase))?.IsOwned ?? false;
}
