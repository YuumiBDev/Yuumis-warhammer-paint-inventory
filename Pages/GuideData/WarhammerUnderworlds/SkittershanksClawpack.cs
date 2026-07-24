namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> SkittershanksClawpackOverall =
    [
        new("Fur",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
            new("Drybrush", "Mournfang Brown"),
            new("Edge Highlight", "Skrag Brown"),
        ]),
        new("Rusted Metal",
        [
            new("Basecoat", "Leadbelcher"),
            new("Wash", "Nuln Oil"),
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
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildSkittershanksClawpack() => new("Skittershank's Clawpack",
    [
        new("Skittershank's Clawpack", "A pack of Skaven cutthroats and scavengers — filthy brown fur, patched cloth and weapons scavenged from rustier days.", SkittershanksClawpackOverall, IsScheme: true),

        FactionUnit(SkittershanksClawpackOverall, "Skittershank", "Unit-Specific Details",
        [
            new("Twin Blades", "Runefang Steel", "as Overall metal scheme"),
            new("Fur", "Rhinox Hide", "as Overall fur scheme"),
        ]),

        FactionUnit(SkittershanksClawpackOverall, "Deathrunner", "Unit-Specific Details",
        [
            new("Throwing Blades", "Leadbelcher", "as Overall metal scheme"),
            new("Cloak", "Dryad Bark", "as Overall cloth scheme"),
        ]),

        FactionUnit(SkittershanksClawpackOverall, "Clan Rat", "Unit-Specific Details",
        [
            new("Rusty Blade", "Leadbelcher", "Typhus Corrosion rust patches"),
            new("Fur", "Rhinox Hide", "as Overall fur scheme"),
        ]),

        FactionUnit(SkittershanksClawpackOverall, "Warpfang", "Unit-Specific Details",
        [
            new("Fur", "Rhinox Hide", "as Overall fur scheme, darker for stealth"),
            new("Blade", "Runefang Steel", "Nuln Oil recess"),
        ]),
    ], Category: GuideCategory.All, Game: Game.WarhammerUnderworlds);
}
