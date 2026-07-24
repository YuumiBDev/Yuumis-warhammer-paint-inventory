public class RackSettings
{
    /// Whether you use physical racks at all. When false, no paint gets a rack
    /// location (same as how Sprays are always treated) and the rack UI/config
    /// below doesn't apply.
    public bool HasRacks { get; set; } = true;

    public int RowsPerRack { get; set; } = 12;
    public int ColumnsPerRack { get; set; } = 6;

    /// How many physical racks you actually have. Null means "not set" —
    /// the app falls back to however many racks the current paint count needs.
    public int? RacksOwned { get; set; }

    public int SlotsPerRack => RowsPerRack * ColumnsPerRack;
}
