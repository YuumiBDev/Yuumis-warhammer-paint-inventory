using Microsoft.AspNetCore.Components;

namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private bool _loaded;

    private record Step(string Label, string Paint, string? Note = null);
    private record Section(string Title, List<Step> Steps);
    private record UnitGuide(string Name, string? Intro, List<Section> Sections, string? ImageUrl = null, bool IsScheme = false);
    private record Source(string Name, string Description, string? Url);
    private record SourceGroup(string Title, List<Source> Sources);
    private record FactionGuide(string Name, List<UnitGuide> Units, List<SourceGroup>? Sources = null);

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

    // Every non-"Overall" unit is rendered on top of whichever Colour Scheme is
    // currently selected, plus this short block of unit-specific gear/iconography callouts.
    private static UnitGuide FactionUnit(List<Section> overall, string name, string extraTitle, List<Step> extraSteps) =>
        new(name, null, [new(extraTitle, extraSteps)]);

    // For full-roster factions where hand-written per-unit callouts aren't available —
    // just renders whichever Colour Scheme is currently selected.
    private static UnitGuide PlainUnit(List<Section> overall, string name) =>
        new(name, null, []);

    // ---- General (non-faction-tab) guides — accordion below the faction picker ----
    private enum BlockKind { H1, H2, Text, Bullets, Table, Links }

    private record GuideBlock(
        BlockKind Kind,
        string? Text = null,
        List<string>? Items = null,
        string[]? TableHeader = null,
        List<string[]>? TableRows = null,
        List<(string Label, string Url)>? Links = null);

    private record GeneralGuide(string Title, List<GuideBlock> Blocks);

    private string? _expandedGuide;

    private void ToggleGuide(string title) =>
        _expandedGuide = _expandedGuide == title ? null : title;

    private readonly List<GeneralGuide> _generalGuides =
        [SkinToneGuide(), NightbringerGuide(), RocksWallsBuildingsGuide()];

    // ---- Top-row categories: General / Imperial / Chaos / Xenos — each rolls down to its factions ----
    private enum GuideCategory { General, Imperial, Chaos, Xenos }

    private static readonly GuideCategory[] _categories =
        [GuideCategory.General, GuideCategory.Imperial, GuideCategory.Chaos, GuideCategory.Xenos];

    private static readonly HashSet<string> ChaosFactionNames =
        ["Chaos Space Marines", "Death Guard", "Thousand Sons", "World Eaters", "Chaos Daemons", "Chaos Knights"];

    private static readonly HashSet<string> XenosFactionNames =
        ["Necrons", "Orks", "Tyranids", "Genestealer Cults", "Leagues of Votann", "Aeldari", "Drukhari", "T'au Empire"];

    private static GuideCategory CategoryOf(FactionGuide f) =>
        ChaosFactionNames.Contains(f.Name) ? GuideCategory.Chaos :
        XenosFactionNames.Contains(f.Name) ? GuideCategory.Xenos :
        GuideCategory.Imperial;

    private static string CategoryLabel(GuideCategory cat) => cat switch
    {
        GuideCategory.General => "General",
        GuideCategory.Imperial => "Imperial",
        GuideCategory.Chaos => "Chaos",
        GuideCategory.Xenos => "Xenos",
        _ => cat.ToString(),
    };

    private GuideCategory? _expandedCategory = GuideCategory.Imperial;

    private void ToggleCategory(GuideCategory cat)
    {
        if (_expandedCategory == cat)
        {
            _expandedCategory = null;
            return;
        }

        _expandedCategory = cat;
        if (cat != GuideCategory.General && CategoryOf(_faction) != cat)
        {
            SelectFaction(_factionsByCategory[cat][0]);
        }
    }

    private readonly List<FactionGuide> _factions;
    private readonly Dictionary<GuideCategory, List<FactionGuide>> _factionsByCategory;

    public Guides()
    {
        _factions =
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
        ];
        _factionsByCategory = _factions.GroupBy(CategoryOf).ToDictionary(g => g.Key, g => g.ToList());
        SelectFaction(_factions[0]);
    }

    protected override async Task OnInitializedAsync()
    {
        await Manager.InitializeAsync();
        _loaded = true;
    }

    private bool IsOwned(string paintName) =>
        Manager.Paints.FirstOrDefault(p => p.Name.Equals(paintName, StringComparison.OrdinalIgnoreCase))?.IsOwned ?? false;
}
