namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    // Generic Khorne-aligned scheme used as the faction "Overall" default.
    // Nurgle/Tzeentch/Slaanesh/Undivided units use the same base method with
    // god-appropriate colours (green/bone, blue/gold, purple/pink, etc.).
    private static readonly List<Section> ChaosDaemonsOverall =
    [
        new("Skin / Armour",
        [
            new("Basecoat", "Mephiston Red"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer", "Wild Rider Red"),
            new("Edge Highlight", "Fire Dragon Bright"),
        ]),
        new("Trim & Horns",
        [
            new("Basecoat", "Hashut Copper"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Sycorax Bronze"),
        ]),
        new("Details",
        [
            new("Skulls / Bone", "Ushabti Bone", "Agrax Earthshade wash, Screaming Skull edge"),
            new("Blood Effects", "Blood for the Blood God", "technical paint on weapons and bases"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Balthasar Gold"),
            new("Basing", "Astrogranite Debris", "with Ushabti Bone drybrushed skulls"),
        ]),
    ];

    private static FactionGuide BuildChaosDaemons() => new("Chaos Daemons",
    [
        new("Overall (Head-to-Toe)", null, ChaosDaemonsOverall, IsScheme: true),

        PlainUnit(ChaosDaemonsOverall, "Be'lakor"),
        PlainUnit(ChaosDaemonsOverall, "Bloodmaster"),
        PlainUnit(ChaosDaemonsOverall, "Bloodthirster"),
        PlainUnit(ChaosDaemonsOverall, "Karanak"),
        PlainUnit(ChaosDaemonsOverall, "Rendmaster On Blood Throne"),
        PlainUnit(ChaosDaemonsOverall, "Skarbrand"),
        PlainUnit(ChaosDaemonsOverall, "Skullmaster"),
        PlainUnit(ChaosDaemonsOverall, "Skulltaker"),
        PlainUnit(ChaosDaemonsOverall, "Tormentbringer"),
        PlainUnit(ChaosDaemonsOverall, "Epidemius"),
        PlainUnit(ChaosDaemonsOverall, "Great Unclean One"),
        PlainUnit(ChaosDaemonsOverall, "Horticulous Slimux"),
        PlainUnit(ChaosDaemonsOverall, "Poxbringer"),
        PlainUnit(ChaosDaemonsOverall, "Rotigus"),
        PlainUnit(ChaosDaemonsOverall, "Sloppity Bilepiper"),
        PlainUnit(ChaosDaemonsOverall, "Spoilpox Scrivener"),
        PlainUnit(ChaosDaemonsOverall, "Changecaster"),
        PlainUnit(ChaosDaemonsOverall, "Exalted Flamer"),
        PlainUnit(ChaosDaemonsOverall, "Fateskimmer"),
        PlainUnit(ChaosDaemonsOverall, "Fluxmaster"),
        PlainUnit(ChaosDaemonsOverall, "Kairos Fateweaver"),
        PlainUnit(ChaosDaemonsOverall, "Lord of Change"),
        PlainUnit(ChaosDaemonsOverall, "The Blue Scribes"),
        PlainUnit(ChaosDaemonsOverall, "The Changeling"),
        PlainUnit(ChaosDaemonsOverall, "Contorted Epitome"),
        PlainUnit(ChaosDaemonsOverall, "Infernal Enrapturess"),
        PlainUnit(ChaosDaemonsOverall, "Keeper Of Secrets"),
        PlainUnit(ChaosDaemonsOverall, "Shalaxi Helbane"),
        PlainUnit(ChaosDaemonsOverall, "Syll'esske"),
        PlainUnit(ChaosDaemonsOverall, "The Masque Of Slaanesh"),
        PlainUnit(ChaosDaemonsOverall, "Tranceweaver"),
        PlainUnit(ChaosDaemonsOverall, "Daemon Prince of Chaos"),
        PlainUnit(ChaosDaemonsOverall, "Daemon Prince Of Chaos With Wings"),
        PlainUnit(ChaosDaemonsOverall, "Chaos Lord"),
        PlainUnit(ChaosDaemonsOverall, "Chaos Lord In Terminator Armour"),
        PlainUnit(ChaosDaemonsOverall, "Chaos Lord with Jump Pack"),
        PlainUnit(ChaosDaemonsOverall, "Cultist Firebrand"),
        PlainUnit(ChaosDaemonsOverall, "Dark Apostle"),
        PlainUnit(ChaosDaemonsOverall, "Dark Commune"),
        PlainUnit(ChaosDaemonsOverall, "Master Of Possession"),
        PlainUnit(ChaosDaemonsOverall, "Sorcerer"),
        PlainUnit(ChaosDaemonsOverall, "Sorcerer In Terminator Armour"),
        PlainUnit(ChaosDaemonsOverall, "Traitor Enforcer"),

        PlainUnit(ChaosDaemonsOverall, "Bloodletters"),
        PlainUnit(ChaosDaemonsOverall, "Blue Horrors"),
        PlainUnit(ChaosDaemonsOverall, "Daemonettes"),
        PlainUnit(ChaosDaemonsOverall, "Nurglings"),
        PlainUnit(ChaosDaemonsOverall, "Pink Horrors"),
        PlainUnit(ChaosDaemonsOverall, "Plaguebearers"),
        PlainUnit(ChaosDaemonsOverall, "Cultist Mob"),
        PlainUnit(ChaosDaemonsOverall, "Legionaries"),

        PlainUnit(ChaosDaemonsOverall, "Bloodcrushers"),
        PlainUnit(ChaosDaemonsOverall, "Flesh Hounds"),
        PlainUnit(ChaosDaemonsOverall, "Beasts Of Nurgle"),
        PlainUnit(ChaosDaemonsOverall, "Plague Drones"),
        PlainUnit(ChaosDaemonsOverall, "Screamers"),
        PlainUnit(ChaosDaemonsOverall, "Fiends"),
        PlainUnit(ChaosDaemonsOverall, "Seekers"),
        PlainUnit(ChaosDaemonsOverall, "Accursed Cultists"),
        PlainUnit(ChaosDaemonsOverall, "Chaos Terminator Squad"),
        PlainUnit(ChaosDaemonsOverall, "Chosen"),
        PlainUnit(ChaosDaemonsOverall, "Fellgor Beastmen"),
        PlainUnit(ChaosDaemonsOverall, "Havocs"),
        PlainUnit(ChaosDaemonsOverall, "Possessed"),
        PlainUnit(ChaosDaemonsOverall, "Raptors"),
        PlainUnit(ChaosDaemonsOverall, "Traitor Guardsmen Squad"),
        PlainUnit(ChaosDaemonsOverall, "Warp Talons"),

        PlainUnit(ChaosDaemonsOverall, "Burning Chariot"),
        PlainUnit(ChaosDaemonsOverall, "Hellflayers"),
        PlainUnit(ChaosDaemonsOverall, "Skull Cannon"),

        PlainUnit(ChaosDaemonsOverall, "Soul Grinder"),

        PlainUnit(ChaosDaemonsOverall, "Feculent Gnarlmaw"),
        PlainUnit(ChaosDaemonsOverall, "Skull Altar"),
    ], Category: GuideCategory.Chaos);
}
