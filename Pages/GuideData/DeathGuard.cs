namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> DeathGuardOverall =
    [
        new("Armour",
        [
            new("Basecoat", "Death Guard Green"),
            new("Recess Shade", "Athonian Camoshade"),
            new("Layer", "Straken Green"),
            new("Edge Highlight", "Screaming Skull"),
        ]),
        new("Trim & Metal",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Typhus Corrosion", "rust texture on corroded panels"),
            new("Edge Highlight", "Ironbreaker"),
        ]),
        new("Details",
        [
            new("Bone / Skulls", "Ushabti Bone", "Agrax Earthshade wash, Screaming Skull edge"),
            new("Slime / Pustules", "Nurgle's Rot", "technical paint on wounds and effluvia"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Leadbelcher"),
            new("Basing", "Astrogranite Debris", "with Death World Forest tufts"),
        ]),
    ];

    private static FactionGuide BuildDeathGuard() => new("Death Guard",
    [
        new("Overall (Head-to-Toe)", null, DeathGuardOverall, IsScheme: true),

        PlainUnit(DeathGuardOverall, "Biologus Putrifier"),
        PlainUnit(DeathGuardOverall, "Daemon Prince of Nurgle"),
        PlainUnit(DeathGuardOverall, "Daemon Prince of Nurgle with Wings"),
        PlainUnit(DeathGuardOverall, "Foul Blightspawn"),
        PlainUnit(DeathGuardOverall, "Great Unclean One"),
        PlainUnit(DeathGuardOverall, "Icon Bearer"),
        PlainUnit(DeathGuardOverall, "Lord of Contagion"),
        PlainUnit(DeathGuardOverall, "Lord of Poxes"),
        PlainUnit(DeathGuardOverall, "Lord of Virulence"),
        PlainUnit(DeathGuardOverall, "Malignant Plaguecaster"),
        PlainUnit(DeathGuardOverall, "Mortarion"),
        PlainUnit(DeathGuardOverall, "Noxious Blightbringer"),
        PlainUnit(DeathGuardOverall, "Plague Surgeon"),
        PlainUnit(DeathGuardOverall, "Rotigus"),
        PlainUnit(DeathGuardOverall, "Tallyman"),
        PlainUnit(DeathGuardOverall, "Typhus"),

        PlainUnit(DeathGuardOverall, "Plague Marines"),
        PlainUnit(DeathGuardOverall, "Plaguebearers"),

        PlainUnit(DeathGuardOverall, "Beasts of Nurgle"),
        PlainUnit(DeathGuardOverall, "Blightlord Terminators"),
        PlainUnit(DeathGuardOverall, "Deathshroud Terminators"),
        PlainUnit(DeathGuardOverall, "Nurglings"),
        PlainUnit(DeathGuardOverall, "Plague Drones"),
        PlainUnit(DeathGuardOverall, "Poxwalkers"),

        PlainUnit(DeathGuardOverall, "Chaos Land Raider"),
        PlainUnit(DeathGuardOverall, "Chaos Predator Annihilator"),
        PlainUnit(DeathGuardOverall, "Chaos Predator Destructor"),
        PlainUnit(DeathGuardOverall, "Plagueburst Crawler"),

        PlainUnit(DeathGuardOverall, "Chaos Spawn"),
        PlainUnit(DeathGuardOverall, "Defiler"),
        PlainUnit(DeathGuardOverall, "Foetid Bloat-drone"),
        PlainUnit(DeathGuardOverall, "Foetid Bloat-drone with Heavy Blight Launcher"),
        PlainUnit(DeathGuardOverall, "Helbrute"),
        PlainUnit(DeathGuardOverall, "Myphitic Blight-hauler"),

        PlainUnit(DeathGuardOverall, "Chaos Rhino"),

        PlainUnit(DeathGuardOverall, "Miasmic Malignifier"),
    ], Category: GuideCategory.Chaos);
}
