namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> DeathwatchOverall =
    [
        new("Armour",
        [
            new("Basecoat", "Abaddon Black"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Eshin Grey"),
        ]),
        new("Trim & Shoulder Pad",
        [
            new("Trim Basecoat", "Leadbelcher"),
            new("Trim Shade", "Nuln Oil"),
            new("Trim Edge Highlight", "Ironbreaker"),
            new("Shoulder Pad", "Corax White", "Celestra Grey highlight"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Ironbreaker"),
            new("Basing", "Stirland Mud", "with Straken Green"),
        ]),
    ];

    // Deathwatch-exclusive datasheets only (Kill Teams, unique characters) — the generic
    // Space Marines units they can also field are already covered under the Space Marines guide.
    private static FactionGuide BuildDeathwatch() => new("Deathwatch",
    [
        new("Overall (Head-to-Toe)", null, DeathwatchOverall, IsScheme: true),

        PlainUnit(DeathwatchOverall, "Watch Master"),
        PlainUnit(DeathwatchOverall, "Watch Captain Artemis"),

        PlainUnit(DeathwatchOverall, "Deathwatch Veterans"),
        PlainUnit(DeathwatchOverall, "Decimus Kill Team"),
        PlainUnit(DeathwatchOverall, "Fortis Kill Team"),
        PlainUnit(DeathwatchOverall, "Indomitor Kill Team"),
        PlainUnit(DeathwatchOverall, "Spectrus Kill Team"),
        PlainUnit(DeathwatchOverall, "Talonstrike Kill Team"),

        PlainUnit(DeathwatchOverall, "Deathwatch Terminator Squad"),

        PlainUnit(DeathwatchOverall, "Corvus Blackstar"),
    ]);
}
