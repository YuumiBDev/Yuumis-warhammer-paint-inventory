namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> TheWurmspatOverall =
    [
        new("Rotten Flesh",
        [
            new("Basecoat", "Death Guard Green"),
            new("Glaze", "Biel-Tan Green"),
            new("Highlight", "Nurgling Green"),
        ]),
        new("Rusted Armour",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Rust", "Typhus Corrosion", "technical paint stippled onto edges"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Cloth & Robes",
        [
            new("Basecoat", "Dryad Bark"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Steel Legion Drab"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Leadbelcher"),
            new("Basing", "Nurgle's Rot", "technical paint for slime pooling"),
        ]),
    ];

    private static FactionGuide BuildTheWurmspat() => new("The Wurmspat",
    [
        new("The Wurmspat", "Plague-bloated servants of Nurgle, their rotten green flesh and rusted armour dripping with disease.", TheWurmspatOverall, IsScheme: true),

        FactionUnit(TheWurmspatOverall, "Bloab Rotspawned", "Unit-Specific Details",
        [
            new("Fly-Blown Robes", "Dryad Bark", "as Overall cloth scheme"),
            new("Bloated Flesh", "Death Guard Green", "as Overall flesh scheme"),
        ]),

        FactionUnit(TheWurmspatOverall, "Corrupter Horticulix", "Unit-Specific Details",
        [
            new("Rusted Blade", "Rhinox Hide", "as Overall armour scheme"),
            new("Flesh", "Death Guard Green", "as Overall flesh scheme"),
        ]),

        FactionUnit(TheWurmspatOverall, "Sepsimus", "Unit-Specific Details",
        [
            new("Cauldron & Chains", "Leadbelcher", "Typhus Corrosion rust patches"),
            new("Robes", "Dryad Bark", "as Overall cloth scheme"),
        ]),

        FactionUnit(TheWurmspatOverall, "Spoilpox Scrivener", "Unit-Specific Details",
        [
            new("Chitin Wings", "Death Guard Green", "as Overall flesh scheme"),
            new("Quill & Ledger", "Ushabti Bone", "Agrax Earthshade wash"),
        ]),
    ], Category: GuideCategory.All, Game: Game.WarhammerUnderworlds);
}
