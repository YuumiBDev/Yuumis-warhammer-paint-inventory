namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> WorldEatersOverall =
    [
        new("Armour",
        [
            new("Basecoat", "Wazdakka Red"),
            new("Recess Shade", "Carroburg Crimson"),
            new("Layer", "Wild Rider Red"),
            new("Edge Highlight", "Fire Dragon Bright"),
        ]),
        new("Trim & Metal",
        [
            new("Basecoat", "Hashut Copper"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Sycorax Bronze"),
        ]),
        new("Details",
        [
            new("Skulls / Bone", "Ushabti Bone", "Agrax Earthshade wash, Screaming Skull edge"),
            new("Blood Spatter", "Blood for the Blood God", "technical paint on blades and armour"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Balthasar Gold"),
            new("Basing", "Astrogranite Debris", "with Blood for the Blood God accents"),
        ]),
    ];

    private static FactionGuide BuildWorldEaters() => new("World Eaters",
    [
        new("Overall (Head-to-Toe)", null, WorldEatersOverall, IsScheme: true),

        PlainUnit(WorldEatersOverall, "Angron"),
        PlainUnit(WorldEatersOverall, "Bloodthirster"),
        PlainUnit(WorldEatersOverall, "Daemon Prince of Khorne"),
        PlainUnit(WorldEatersOverall, "Daemon Prince of Khorne with Wings"),
        PlainUnit(WorldEatersOverall, "Khârn The Betrayer"),
        PlainUnit(WorldEatersOverall, "Lord Invocatus"),
        PlainUnit(WorldEatersOverall, "Lord on Juggernaut"),
        PlainUnit(WorldEatersOverall, "Master of Executions"),
        PlainUnit(WorldEatersOverall, "Skarbrand"),
        PlainUnit(WorldEatersOverall, "Slaughterbound"),

        PlainUnit(WorldEatersOverall, "Bloodletters"),
        PlainUnit(WorldEatersOverall, "Khorne Berzerkers"),

        PlainUnit(WorldEatersOverall, "Bloodcrushers"),
        PlainUnit(WorldEatersOverall, "Chaos Terminators"),
        PlainUnit(WorldEatersOverall, "Eightbound"),
        PlainUnit(WorldEatersOverall, "Exalted Eightbound"),
        PlainUnit(WorldEatersOverall, "Flesh Hounds"),
        PlainUnit(WorldEatersOverall, "Goremongers"),
        PlainUnit(WorldEatersOverall, "Jakhals"),

        PlainUnit(WorldEatersOverall, "Chaos Land Raider"),
        PlainUnit(WorldEatersOverall, "Chaos Predator Annihilator"),
        PlainUnit(WorldEatersOverall, "Chaos Predator Destructor"),
        PlainUnit(WorldEatersOverall, "Heldrake"),

        PlainUnit(WorldEatersOverall, "Chaos Spawn"),
        PlainUnit(WorldEatersOverall, "Defiler"),
        PlainUnit(WorldEatersOverall, "Forgefiend"),
        PlainUnit(WorldEatersOverall, "Helbrute"),
        PlainUnit(WorldEatersOverall, "Khorne Lord of Skulls"),
        PlainUnit(WorldEatersOverall, "Maulerfiend"),

        PlainUnit(WorldEatersOverall, "Chaos Rhino"),
    ]);
}
