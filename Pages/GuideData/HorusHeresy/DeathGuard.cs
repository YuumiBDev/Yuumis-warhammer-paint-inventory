namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> DeathGuardHHOverall =
    [
        new("Armour (Pale Grey-Green)",
        [
            new("Basecoat", "Castellan Green"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer", "Sybarite Green"),
            new("Edge Highlight", "Screaming Skull"),
        ]),
        new("Trim & Metal (Silver)",
        [
            new("Basecoat", "Runefang Steel"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Stormhost Silver"),
        ]),
        new("Details",
        [
            new("Bone / Skulls", "Ushabti Bone", "Agrax Earthshade wash, Screaming Skull edge"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Astrogranite Debris", "with Agrellan Earth cracked texture"),
        ]),
    ];

    private static FactionGuide BuildDeathGuardLegion() => new("Death Guard",
    [
        new("Death Guard", "The XIV Legion under Mortarion — before Nurgle's rot claimed them, the Legion wore disciplined pale grey-green armour trimmed in silver, prized for their resilience and unbreakable will.", DeathGuardHHOverall, IsScheme: true),

        PlainUnit(DeathGuardHHOverall, "Legion Tactical Squad"),
        PlainUnit(DeathGuardHHOverall, "Legion Terminator Squad"),
        PlainUnit(DeathGuardHHOverall, "Legion Command Squad"),
        PlainUnit(DeathGuardHHOverall, "Legion Rhino"),
        PlainUnit(DeathGuardHHOverall, "Legion Dreadnought"),
        PlainUnit(DeathGuardHHOverall, "Legion Praetor"),
    ], Category: GuideCategory.Traitor, Game: Game.HorusHeresy);
}
