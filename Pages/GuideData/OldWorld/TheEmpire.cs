namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> TheEmpireOverall =
    [
        new("Doublet (Reikland Blue)",
        [
            new("Basecoat", "Kantor Blue"),
            new("Shade", "Drakenhof Nightshade"),
            new("Layer", "Macragge Blue"),
            new("Edge Highlight", "Alaitoc Blue"),
        ]),
        new("Doublet & Hose (White)",
        [
            new("Basecoat", "Corax White"),
            new("Shade", "Nuln Oil", "thinned, recesses only"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Leather & Straps",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Mournfang Brown"),
        ]),
        new("Trim & Metal",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Ironbreaker"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Rhinox Hide"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static FactionGuide BuildTheEmpire() => new("The Empire",
    [
        new("Reikland (State Colours)", "The default and most iconic Empire province — halved blue and white livery over practical leather and steel, the look of the state armies that hold the human heartlands together.", TheEmpireOverall, IsScheme: true),

        FactionUnit(TheEmpireOverall, "State Troops Halberdiers", "Unit-Specific Details",
        [
            new("Halberd Blade", "Leadbelcher", "Nuln Oil wash"),
            new("Provincial Livery Sash", "Mephiston Red"),
        ]),

        FactionUnit(TheEmpireOverall, "Handgunners", "Unit-Specific Details",
        [
            new("Handgun Barrel", "Leadbelcher", "Nuln Oil wash"),
            new("Powder Horn & Straps", "Rhinox Hide"),
        ]),

        FactionUnit(TheEmpireOverall, "Knightly Order", "Unit-Specific Details",
        [
            new("Plate Armour", "Ironbreaker", "Nuln Oil wash, Runefang Steel edge"),
            new("Barding", "Kantor Blue", "as Overall doublet blue/white"),
            new("Helm Plume", "Mephiston Red"),
        ]),

        FactionUnit(TheEmpireOverall, "Greatswords", "Unit-Specific Details",
        [
            new("Slashed Doublet Panels", "Corax White", "alternating blue/white panels as Overall"),
            new("Zweihander Blade", "Ironbreaker", "Nuln Oil wash"),
        ]),

        FactionUnit(TheEmpireOverall, "Empire Cannon", "Vehicle-Specific Details",
        [
            new("Barrel", "Leadbelcher", "Nuln Oil wash"),
            new("Carriage", "Rhinox Hide"),
            new("Wheel Rims", "Ironbreaker"),
        ]),

        FactionUnit(TheEmpireOverall, "General of the Empire", "Unit-Specific Details",
        [
            new("Cloak", "Mephiston Red", "Evil Sunz Scarlet highlight"),
            new("Armour Trim", "Retributor Armour", "gilded, distinguishes rank"),
            new("Sword", "Runefang Steel"),
        ]),

        FactionUnit(TheEmpireOverall, "Wizard", "Unit-Specific Details",
        [
            new("Order Robes", "Auric Armour Gold", "shown here as a Gold Order caster; swap hue per Order"),
            new("Staff Head Gem", "Genestealer Purple"),
        ]),
    ], Category: GuideCategory.All, Game: Game.OldWorld);
}
