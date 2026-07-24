public class RackSettings
{
    public int RowsPerRack { get; set; } = 12;
    public int ColumnsPerRack { get; set; } = 6;

    /// How many physical racks you actually have. Null means "not set" —
    /// the app falls back to however many racks the current paint count needs.
    public int? RacksOwned { get; set; }

    public int SlotsPerRack => RowsPerRack * ColumnsPerRack;
}
