namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> GrymwatchOverall =
    [
        new("Ethereal Robes",
        [
            new("Basecoat", "Corax White"),
            new("Wash", "Nighthaunt Gloom", "Contrast, thinned"),
            new("Glaze", "Coelia Greenshade"),
            new("Highlight", "Ulthuan Grey"),
        ]),
        new("Ghostly Weapons",
        [
            new("Basecoat", "Runefang Steel"),
            new("Glaze", "Coelia Greenshade"),
        ]),
        new("Chains & Trim",
        [
            new("Basecoat", "Leadbelcher"),
            new("Wash", "Nuln Oil"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildGrymwatch() => new("Grymwatch",
    [
        new("Grymwatch", "Nighthaunt spectres bound to the mortal realm, rendered in bone-white shrouds glazed a sickly ethereal green.", GrymwatchOverall, IsScheme: true),

        FactionUnit(GrymwatchOverall, "Lady Harrow", "Unit-Specific Details",
        [
            new("Wraithblade", "Runefang Steel", "as Overall weapon scheme"),
            new("Robes", "Corax White", "as Overall robe scheme"),
        ]),

        FactionUnit(GrymwatchOverall, "Reaper of Grymwatch", "Unit-Specific Details",
        [
            new("Great Scythe", "Runefang Steel", "as Overall weapon scheme"),
            new("Trailing Shroud", "Corax White", "as Overall robe scheme, heavier Coelia Greenshade glaze"),
        ]),

        FactionUnit(GrymwatchOverall, "Glaivewraith Stalker", "Unit-Specific Details",
        [
            new("Glaive", "Runefang Steel", "as Overall weapon scheme"),
            new("Robes", "Corax White", "as Overall robe scheme"),
        ]),

        FactionUnit(GrymwatchOverall, "Chainrasp", "Unit-Specific Details",
        [
            new("Rusted Chains", "Leadbelcher", "as Overall chain scheme"),
            new("Robes", "Corax White", "as Overall robe scheme"),
        ]),
    ], Category: GuideCategory.All, Game: Game.WarhammerUnderworlds);
}
