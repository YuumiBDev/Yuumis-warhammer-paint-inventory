using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;

public class InventoryManager
{
    private readonly HttpClient _http;
    private const string MasterPath      = "/rest/v1/warhammer_paint_master";
    private const string OwnedPath       = "/rest/v1/warhammer_owned_paints";
    private const string WishlistPath    = "/rest/v1/warhammer_wishlist_paints";
    private const string SettingsPath    = "/rest/v1/warhammer_category_settings";
    private const string RackSettingsPath = "/rest/v1/warhammer_rack_settings";
    private const string AppSettingsPath = "/rest/v1/warhammer_app_settings";
    private const string EquivalentsPath = "/rest/v1/warhammer_paint_equivalents";

    private List<Paint> _paints = [];
    private List<CategorySetting> _categorySettings = PaintDatabase.DefaultCategorySettings();
    private RackSettings _rackSettings = new();
    private AppSettings _appSettings = new();

    // Null until a successful fetch of warhammer_paint_master; if it stays null,
    // the app is running on the hardcoded fallback list (Supabase unreachable).
    private List<(long Id, string Name, PaintCategory Category)>? _masterRows;

    private Dictionary<long, int> _ownedQuantities = [];
    private HashSet<long> _wishlistSet = [];

    public IReadOnlyList<Paint> Paints => _paints;
    public IReadOnlyList<CategorySetting> CategorySettings => _categorySettings;
    public RackSettings RackSettings => _rackSettings;
    public AppSettings AppSettings => _appSettings;
    public bool IsUsingFallbackList => _masterRows == null;

    /// How many racks the current paint count actually occupies (ignores RacksOwned).
    public int RacksNeeded => _paints.Count == 0 ? 0 : _paints.Max(p => p.RackNumber);

    public InventoryManager(IHttpClientFactory httpClientFactory)
    {
        _http = httpClientFactory.CreateClient("Supabase");
    }

    public async Task InitializeAsync()
    {
        try
        {
            var rows = await _http.GetFromJsonAsync<List<CategorySettingRow>>(
                $"{SettingsPath}?select=category,enabled,sort_order&order=sort_order");

            var loaded = (rows ?? [])
                .Select(r => new CategorySetting
                {
                    Category  = Enum.Parse<PaintCategory>(r.Category),
                    Enabled   = r.Enabled,
                    SortOrder = r.SortOrder
                })
                .ToDictionary(s => s.Category);

            // Any category added to the code but not yet persisted (e.g. Air/Spray
            // before the seed migration has run) gets a sensible default appended,
            // instead of silently disappearing from the app.
            int nextOrder = loaded.Count > 0 ? loaded.Values.Max(s => s.SortOrder) : 0;
            var merged = new List<CategorySetting>();
            foreach (var cat in Enum.GetValues<PaintCategory>())
            {
                merged.Add(loaded.TryGetValue(cat, out var existing)
                    ? existing
                    : new CategorySetting { Category = cat, Enabled = true, SortOrder = ++nextOrder });
            }
            _categorySettings = merged;
        }
        catch { _categorySettings = PaintDatabase.DefaultCategorySettings(); }

        try
        {
            var rackRows = await _http.GetFromJsonAsync<List<RackSettingsRow>>(
                $"{RackSettingsPath}?select=has_racks,rows_per_rack,columns_per_rack,racks_owned&id=eq.1");
            var rackRow = rackRows?.FirstOrDefault();
            if (rackRow != null)
                _rackSettings = new RackSettings
                {
                    HasRacks = rackRow.HasRacks,
                    RowsPerRack = rackRow.RowsPerRack,
                    ColumnsPerRack = rackRow.ColumnsPerRack,
                    RacksOwned = rackRow.RacksOwned
                };
        }
        catch { _rackSettings = new RackSettings(); }

        try
        {
            var appRows = await _http.GetFromJsonAsync<List<AppSettingsRow>>(
                $"{AppSettingsPath}?select=home_link_url&id=eq.1");
            var appRow = appRows?.FirstOrDefault();
            if (appRow != null)
                _appSettings = new AppSettings { HomeLinkUrl = appRow.HomeLinkUrl };
        }
        catch { _appSettings = new AppSettings(); }

        try
        {
            var master = await _http.GetFromJsonAsync<List<MasterPaintRow>>(
                $"{MasterPath}?select=paint_id,name,type&order=paint_id");
            _masterRows = master is { Count: > 0 }
                ? master.Select(m => (m.PaintId, m.Name, Enum.Parse<PaintCategory>(m.Type))).ToList()
                : null;
        }
        catch { _masterRows = null; }

        try
        {
            var owned = await _http.GetFromJsonAsync<List<OwnedRow>>($"{OwnedPath}?select=paint_id,quantity");
            if (owned != null)
                _ownedQuantities = owned.ToDictionary(p => p.PaintId, p => p.Quantity);
        }
        catch { }

        try
        {
            var wishlist = await _http.GetFromJsonAsync<List<WishlistRow>>($"{WishlistPath}?select=paint_id");
            if (wishlist != null)
                _wishlistSet = wishlist.Select(p => p.PaintId).ToHashSet();
        }
        catch { }

        RebuildPaintList();
    }

    private void RebuildPaintList()
    {
        var paints = _masterRows != null
            ? PaintDatabase.BuildPaintList(_masterRows, _categorySettings, _rackSettings)
            : PaintDatabase.BuildPaintListFallback(_categorySettings, _rackSettings);

        foreach (var paint in paints)
        {
            if (_ownedQuantities.TryGetValue(paint.Id, out var qty))
            {
                paint.IsOwned  = true;
                paint.Quantity = qty;
            }
            paint.IsWishlisted = _wishlistSet.Contains(paint.Id);
        }
        _paints = paints;
    }

    private Paint? FindPaintById(long id) => _paints.FirstOrDefault(p => p.Id == id);

    private Paint? FindPaint(string name) =>
        _paints.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

    // ── OWNED / QUANTITY ─────────────────────────────────────────────
    public async Task SetOwnedAsync(Paint paint, bool owned)
    {
        if (owned) await SetQuantityAsync(paint, 1);
        else await RemoveOwnedAsync(paint);
    }

    public async Task SetQuantityAsync(Paint paint, int quantity)
    {
        if (quantity <= 0)
        {
            await RemoveOwnedAsync(paint);
            return;
        }

        bool prevOwned = paint.IsOwned;
        int prevQty = paint.Quantity;
        paint.IsOwned = true;
        paint.Quantity = quantity;

        try
        {
            var request = new HttpRequestMessage(HttpMethod.Post, OwnedPath);
            request.Headers.Add("Prefer", "resolution=merge-duplicates");
            request.Content = JsonContent.Create(new OwnedPaintRow(paint.Id, quantity));
            var response = await _http.SendAsync(request);
            response.EnsureSuccessStatusCode();
            _ownedQuantities[paint.Id] = quantity;
        }
        catch
        {
            paint.IsOwned = prevOwned;
            paint.Quantity = prevQty;
        }
    }

    private async Task RemoveOwnedAsync(Paint paint)
    {
        bool prevOwned = paint.IsOwned;
        int prevQty = paint.Quantity;
        paint.IsOwned = false;
        paint.Quantity = 0;

        try
        {
            var response = await _http.DeleteAsync($"{OwnedPath}?paint_id=eq.{paint.Id}");
            response.EnsureSuccessStatusCode();
            _ownedQuantities.Remove(paint.Id);
        }
        catch
        {
            paint.IsOwned = prevOwned;
            paint.Quantity = prevQty;
        }
    }

    // ── WISHLIST ─────────────────────────────────────────────────────
    public async Task SetWishlistAsync(Paint paint, bool wishlisted)
    {
        bool previous = paint.IsWishlisted;
        paint.IsWishlisted = wishlisted;

        try
        {
            HttpResponseMessage response;
            if (wishlisted)
            {
                var request = new HttpRequestMessage(HttpMethod.Post, WishlistPath);
                request.Headers.Add("Prefer", "resolution=merge-duplicates");
                request.Content = JsonContent.Create(new WishlistRow(paint.Id));
                response = await _http.SendAsync(request);
            }
            else
            {
                response = await _http.DeleteAsync($"{WishlistPath}?paint_id=eq.{paint.Id}");
            }
            response.EnsureSuccessStatusCode();

            if (wishlisted) _wishlistSet.Add(paint.Id);
            else _wishlistSet.Remove(paint.Id);
        }
        catch
        {
            paint.IsWishlisted = previous;
        }
    }

    /// Adds every currently-missing (not owned) paint that isn't already
    /// wishlisted. Returns the number of paints added.
    public async Task<int> AddAllMissingToWishlistAsync()
    {
        var toAdd = GetMissing().Where(p => !p.IsWishlisted).ToList();
        if (toAdd.Count == 0) return 0;

        try
        {
            var request = new HttpRequestMessage(HttpMethod.Post, WishlistPath);
            request.Headers.Add("Prefer", "resolution=merge-duplicates");
            request.Content = JsonContent.Create(toAdd.Select(p => new WishlistRow(p.Id)).ToList());
            var response = await _http.SendAsync(request);
            response.EnsureSuccessStatusCode();

            foreach (var p in toAdd)
            {
                p.IsWishlisted = true;
                _wishlistSet.Add(p.Id);
            }
            return toAdd.Count;
        }
        catch
        {
            return 0;
        }
    }

    // ── CATEGORY SETTINGS ────────────────────────────────────────────
    public async Task<bool> SetCategoryEnabledAsync(PaintCategory category, bool enabled)
    {
        var setting = _categorySettings.FirstOrDefault(s => s.Category == category);
        if (setting == null) return false;

        bool previous = setting.Enabled;
        setting.Enabled = enabled;

        try
        {
            var request = new HttpRequestMessage(HttpMethod.Patch, $"{SettingsPath}?category=eq.{category}");
            request.Content = JsonContent.Create(new { enabled });
            var response = await _http.SendAsync(request);
            response.EnsureSuccessStatusCode();
            RebuildPaintList();
            return true;
        }
        catch
        {
            setting.Enabled = previous;
            return false;
        }
    }

    /// Persists a full new category display/fill order (1-based), then
    /// recomputes rack locations to match (packing planner).
    public async Task<bool> SetCategoryOrderAsync(List<PaintCategory> orderedCategories)
    {
        var previousOrders = _categorySettings.ToDictionary(s => s.Category, s => s.SortOrder);

        for (int i = 0; i < orderedCategories.Count; i++)
        {
            var setting = _categorySettings.FirstOrDefault(s => s.Category == orderedCategories[i]);
            if (setting != null) setting.SortOrder = i + 1;
        }

        try
        {
            var payload = _categorySettings
                .Select(s => new { category = s.Category.ToString(), sort_order = s.SortOrder })
                .ToList();
            var request = new HttpRequestMessage(HttpMethod.Post, SettingsPath);
            request.Headers.Add("Prefer", "resolution=merge-duplicates");
            request.Content = JsonContent.Create(payload);
            var response = await _http.SendAsync(request);
            response.EnsureSuccessStatusCode();
            RebuildPaintList();
            return true;
        }
        catch
        {
            foreach (var (cat, order) in previousOrders)
            {
                var setting = _categorySettings.FirstOrDefault(s => s.Category == cat);
                if (setting != null) setting.SortOrder = order;
            }
            return false;
        }
    }

    /// Persists whether you use racks, rack rows/columns, and how many racks you
    /// own, then recomputes rack locations to match (packing planner).
    public async Task<bool> SetRackSettingsAsync(bool hasRacks, int rowsPerRack, int columnsPerRack, int? racksOwned)
    {
        var previous = new RackSettings
        {
            HasRacks = _rackSettings.HasRacks,
            RowsPerRack = _rackSettings.RowsPerRack,
            ColumnsPerRack = _rackSettings.ColumnsPerRack,
            RacksOwned = _rackSettings.RacksOwned
        };

        _rackSettings.HasRacks = hasRacks;
        _rackSettings.RowsPerRack = rowsPerRack;
        _rackSettings.ColumnsPerRack = columnsPerRack;
        _rackSettings.RacksOwned = racksOwned;

        try
        {
            var request = new HttpRequestMessage(HttpMethod.Post, RackSettingsPath);
            request.Headers.Add("Prefer", "resolution=merge-duplicates");
            request.Content = JsonContent.Create(new RackSettingsUpsertRow(1, hasRacks, rowsPerRack, columnsPerRack, racksOwned));
            var response = await _http.SendAsync(request);
            response.EnsureSuccessStatusCode();
            RebuildPaintList();
            return true;
        }
        catch
        {
            _rackSettings = previous;
            return false;
        }
    }

    /// Persists the optional sidebar "Home" link. Null/empty hides it.
    public async Task<bool> SetHomeLinkUrlAsync(string? homeLinkUrl)
    {
        var previous = _appSettings.HomeLinkUrl;
        _appSettings.HomeLinkUrl = homeLinkUrl;

        try
        {
            var request = new HttpRequestMessage(HttpMethod.Post, AppSettingsPath);
            request.Headers.Add("Prefer", "resolution=merge-duplicates");
            request.Content = JsonContent.Create(new AppSettingsUpsertRow(1, homeLinkUrl));
            var response = await _http.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return true;
        }
        catch
        {
            _appSettings.HomeLinkUrl = previous;
            return false;
        }
    }

    // ── QUERIES ──────────────────────────────────────────────────────
    public List<Paint> Search(string query) =>
        _paints.Where(p => p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();

    public List<Paint> GetByCategory(PaintCategory category) =>
        _paints.Where(p => p.Category == category).ToList();

    public List<Paint> GetByRack(int rack) =>
        _paints.Where(p => p.RackNumber == rack).ToList();

    public List<Paint> GetOwned() =>
        _paints.Where(p => p.IsOwned).ToList();

    public List<Paint> GetMissing() =>
        _paints.Where(p => !p.IsOwned).ToList();

    public List<Paint> GetWishlist() =>
        _paints.Where(p => p.IsWishlisted).ToList();

    public (int Total, int Owned, int Missing) GetStats() =>
        (_paints.Count, _paints.Count(p => p.IsOwned), _paints.Count(p => !p.IsOwned));

    public Dictionary<PaintCategory, (int Total, int Owned)> GetStatsByCategory() =>
        Enum.GetValues<PaintCategory>()
            .ToDictionary(
                cat => cat,
                cat => (
                    _paints.Count(p => p.Category == cat),
                    _paints.Count(p => p.Category == cat && p.IsOwned)
                ));

    // ── 3RD-PARTY EQUIVALENTS ────────────────────────────────────────
    // Community-sourced, not official. Loaded lazily (only by the
    // Equivalents page) since no other page needs this data.
    public async Task<Dictionary<long, List<PaintEquivalent>>> LoadEquivalentsAsync()
    {
        try
        {
            var rows = await _http.GetFromJsonAsync<List<EquivalentRow>>(
                $"{EquivalentsPath}?select=id,paint_id,brand,equivalent_name&order=brand,equivalent_name");
            return (rows ?? [])
                .Select(r => new PaintEquivalent
                {
                    Id             = r.Id,
                    PaintId        = r.PaintId,
                    Brand          = r.Brand,
                    EquivalentName = r.EquivalentName
                })
                .GroupBy(e => e.PaintId)
                .ToDictionary(g => g.Key, g => g.ToList());
        }
        catch
        {
            return [];
        }
    }

    public async Task<PaintEquivalent?> AddEquivalentAsync(long paintId, string brand, string equivalentName)
    {
        try
        {
            var request = new HttpRequestMessage(HttpMethod.Post, EquivalentsPath);
            request.Headers.Add("Prefer", "return=representation,resolution=merge-duplicates");
            request.Content = JsonContent.Create(new EquivalentInsertRow(paintId, brand, equivalentName));
            var response = await _http.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var created = await response.Content.ReadFromJsonAsync<List<EquivalentRow>>();
            var row = created?.FirstOrDefault();
            return row == null ? null : new PaintEquivalent
            {
                Id = row.Id, PaintId = row.PaintId, Brand = row.Brand, EquivalentName = row.EquivalentName
            };
        }
        catch
        {
            return null;
        }
    }

    public async Task<bool> DeleteEquivalentAsync(long equivalentId)
    {
        try
        {
            var response = await _http.DeleteAsync($"{EquivalentsPath}?id=eq.{equivalentId}");
            response.EnsureSuccessStatusCode();
            return true;
        }
        catch
        {
            return false;
        }
    }

    private record EquivalentRow(
        [property: JsonPropertyName("id")] long Id,
        [property: JsonPropertyName("paint_id")] long PaintId,
        [property: JsonPropertyName("brand")] string Brand,
        [property: JsonPropertyName("equivalent_name")] string EquivalentName);

    private record EquivalentInsertRow(
        [property: JsonPropertyName("paint_id")] long PaintId,
        [property: JsonPropertyName("brand")] string Brand,
        [property: JsonPropertyName("equivalent_name")] string EquivalentName);

    // ── CSV ──────────────────────────────────────────────────────────
    // paint_id is the authoritative match on import; name/category are for
    // human readability and as a fallback when paint_id isn't present (e.g.
    // a hand-typed list).
    public string GenerateOwnedCsv()
    {
        var sb = new StringBuilder();
        sb.AppendLine("paint_id,name,category,quantity");
        foreach (var p in GetOwned().OrderBy(p => p.Category).ThenBy(p => p.DisplayName))
            sb.AppendLine($"{p.Id},{EscapeCsv(p.DisplayName)},{p.Category},{p.Quantity}");
        return sb.ToString();
    }

    public string GenerateWishlistCsv()
    {
        var sb = new StringBuilder();
        sb.AppendLine("paint_id,name,category");
        foreach (var p in GetWishlist().OrderBy(p => p.Category).ThenBy(p => p.DisplayName))
            sb.AppendLine($"{p.Id},{EscapeCsv(p.DisplayName)},{p.Category}");
        return sb.ToString();
    }

    public string GenerateFullCsv()
    {
        var sb = new StringBuilder();
        sb.AppendLine("paint_id,name,category,owned,quantity,wishlisted,rack,row,column");
        foreach (var p in _paints.OrderBy(p => p.Category).ThenBy(p => p.DisplayName))
            sb.AppendLine($"{p.Id},{EscapeCsv(p.DisplayName)},{p.Category},{p.IsOwned},{p.Quantity},{p.IsWishlisted},{p.RackNumber},{p.Row},{p.Column}");
        return sb.ToString();
    }

    private Paint? FindPaintByDisplayName(string displayName, PaintCategory? category)
    {
        var matches = _paints
            .Where(p => p.DisplayName.Equals(displayName, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (category.HasValue)
            return matches.FirstOrDefault(p => p.Category == category.Value);

        // No category given: only safe to match if the display name is unique
        // across every category (otherwise we can't tell which one was meant).
        return matches.Count == 1 ? matches[0] : null;
    }

    /// Bulk-sets owned status (and quantity, if present) for every recognized
    /// paint in the CSV text. Reads a header row to find paint_id/name/category/
    /// quantity columns. paint_id is matched first (most reliable); if it's
    /// missing or doesn't resolve, falls back to a category-aware name match.
    /// Unrecognized or ambiguous rows are skipped.
    public async Task<(int Imported, int Skipped)> ImportOwnedCsvAsync(string csvContent)
    {
        var lines = csvContent.Replace("\r\n", "\n").Split('\n', StringSplitOptions.RemoveEmptyEntries);
        var toImport = new List<(long Id, int Quantity)>();
        int skipped = 0;
        if (lines.Length == 0) return (0, 0);

        var header = lines[0].Split(',').Select(h => h.Trim().Trim('"').ToLowerInvariant()).ToList();
        int idIdx = header.IndexOf("paint_id");
        int nameIdx = header.IndexOf("name");
        int catIdx = header.IndexOf("category");
        int qtyIdx = header.IndexOf("quantity");
        bool hasHeader = idIdx >= 0 || nameIdx >= 0;
        if (!hasHeader) { nameIdx = 0; idIdx = -1; qtyIdx = -1; catIdx = -1; }

        for (int i = hasHeader ? 1 : 0; i < lines.Length; i++)
        {
            var line = lines[i].Trim();
            if (line.Length == 0) continue;

            var parts = line.Split(',');

            Paint? paint = null;
            if (idIdx >= 0 && idIdx < parts.Length && long.TryParse(parts[idIdx].Trim(), out var id))
                paint = FindPaintById(id);

            if (paint == null && nameIdx >= 0 && nameIdx < parts.Length)
            {
                var name = parts[nameIdx].Trim().Trim('"');
                if (name.Length > 0)
                {
                    PaintCategory? category = null;
                    if (catIdx >= 0 && catIdx < parts.Length &&
                        Enum.TryParse<PaintCategory>(parts[catIdx].Trim(), true, out var parsedCat))
                        category = parsedCat;

                    // Try an exact (possibly prefixed) Name match first — covers CSVs
                    // exported before the display-name change — then fall back to a
                    // category-aware display-name match.
                    paint = FindPaint(name) ?? FindPaintByDisplayName(name, category);
                }
            }

            if (paint == null) { skipped++; continue; }

            int quantity = 1;
            if (qtyIdx >= 0 && qtyIdx < parts.Length &&
                int.TryParse(parts[qtyIdx].Trim(), out var q) && q > 0) quantity = q;

            toImport.Add((paint.Id, quantity));
        }

        if (toImport.Count == 0) return (0, skipped);

        try
        {
            var payload = toImport.Select(t => new OwnedPaintRow(t.Id, t.Quantity)).ToList();
            var request = new HttpRequestMessage(HttpMethod.Post, OwnedPath);
            request.Headers.Add("Prefer", "resolution=merge-duplicates");
            request.Content = JsonContent.Create(payload);
            var response = await _http.SendAsync(request);
            response.EnsureSuccessStatusCode();

            foreach (var (id, quantity) in toImport)
            {
                var paint = FindPaintById(id)!;
                paint.IsOwned = true;
                paint.Quantity = quantity;
                _ownedQuantities[id] = quantity;
            }

            return (toImport.Count, skipped);
        }
        catch
        {
            return (0, lines.Length);
        }
    }

    private static string EscapeCsv(string value) =>
        value.Contains(',') || value.Contains('"')
            ? $"\"{value.Replace("\"", "\"\"")}\""
            : value;

    private record MasterPaintRow(
        [property: JsonPropertyName("paint_id")] long PaintId,
        [property: JsonPropertyName("name")] string Name,
        [property: JsonPropertyName("type")] string Type);

    private record OwnedRow(
        [property: JsonPropertyName("paint_id")] long PaintId,
        [property: JsonPropertyName("quantity")] int Quantity);

    private record OwnedPaintRow(
        [property: JsonPropertyName("paint_id")] long PaintId,
        [property: JsonPropertyName("quantity")] int Quantity);

    private record WishlistRow([property: JsonPropertyName("paint_id")] long PaintId);

    private record CategorySettingRow(
        [property: JsonPropertyName("category")] string Category,
        [property: JsonPropertyName("enabled")] bool Enabled,
        [property: JsonPropertyName("sort_order")] int SortOrder);

    private record RackSettingsRow(
        [property: JsonPropertyName("has_racks")] bool HasRacks,
        [property: JsonPropertyName("rows_per_rack")] int RowsPerRack,
        [property: JsonPropertyName("columns_per_rack")] int ColumnsPerRack,
        [property: JsonPropertyName("racks_owned")] int? RacksOwned);

    private record RackSettingsUpsertRow(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("has_racks")] bool HasRacks,
        [property: JsonPropertyName("rows_per_rack")] int RowsPerRack,
        [property: JsonPropertyName("columns_per_rack")] int ColumnsPerRack,
        [property: JsonPropertyName("racks_owned")] int? RacksOwned);

    private record AppSettingsRow(
        [property: JsonPropertyName("home_link_url")] string? HomeLinkUrl);

    private record AppSettingsUpsertRow(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("home_link_url")] string? HomeLinkUrl);
}
