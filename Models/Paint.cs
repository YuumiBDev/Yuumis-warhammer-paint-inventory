using System.Text.Json.Serialization;

public enum PaintCategory
{
    Base,
    Layer,
    Contrast,
    Dry,
    Technical,
    Shade,
    Air,
    Spray
}

public class Paint
{
    /// Matches warhammer_paint_master.paint_id. A negative Id means this paint
    /// came from the hardcoded fallback list (Supabase was unreachable at load),
    /// not a real database row.
    public long Id { get; set; }

    public string Name { get; set; } = "";

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public PaintCategory Category { get; set; }

    public int RackNumber { get; set; }
    public int Row { get; set; }
    public int Column { get; set; }
    public bool IsOwned { get; set; }
    public int Quantity { get; set; }
    public bool IsWishlisted { get; set; }

    /// Name with the "Category: " prefix stripped for on-screen display
    /// (the category is already shown separately via a badge/border everywhere
    /// this is used). The full prefixed Name stays the unique DB key.
    [JsonIgnore]
    public string DisplayName
    {
        get
        {
            var prefix = $"{Category}: ";
            return Name.StartsWith(prefix, StringComparison.OrdinalIgnoreCase) ? Name[prefix.Length..] : Name;
        }
    }

    [JsonIgnore]
    public string Location => RackNumber == 0
        ? "Not racked"
        : $"Rack {RackNumber}  Row {Row,2}  Col {Column}";

    [JsonIgnore]
    public string CategoryCssColor => Category switch
    {
        PaintCategory.Base      => "#e74c3c",
        PaintCategory.Layer     => "#5dade2",
        PaintCategory.Contrast  => "#a569bd",
        PaintCategory.Dry       => "#f4d03f",
        PaintCategory.Technical => "#48c9b0",
        PaintCategory.Shade     => "#52be80",
        PaintCategory.Air       => "#e67e22",
        PaintCategory.Spray     => "#95a5a6",
        _                       => "#aaaaaa"
    };

    [JsonIgnore]
    public string CategoryTextColor => Category switch
    {
        PaintCategory.Dry   => "#1a1a1a",
        PaintCategory.Spray => "#1a1a1a",
        _                   => "#ffffff"
    };
}
