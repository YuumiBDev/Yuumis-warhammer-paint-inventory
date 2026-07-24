namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> ChaosKnightsOverall =
    [
        new("Armour",
        [
            new("Basecoat", "Abaddon Black"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer", "Eshin Grey"),
            new("Edge Highlight", "Dawnstone"),
        ]),
        new("Trim & Metal",
        [
            new("Basecoat", "Warplock Bronze"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Sycorax Bronze"),
        ]),
        new("Details",
        [
            new("Heraldry / Banners", "Mephiston Red", "Carroburg Crimson wash, Wild Rider Red edge"),
            new("Icons / Chains", "Retributor Armour", "Agrax Earthshade wash"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Retributor Armour"),
            new("Basing", "Astrogranite Debris", "with Agrellan Earth cracked texture"),
        ]),
    ];

    private static FactionGuide BuildChaosKnights() => new("Chaos Knights",
    [
        new("Overall (Head-to-Toe)", null, ChaosKnightsOverall, IsScheme: true),

        PlainUnit(ChaosKnightsOverall, "Knight Abominant"),
        PlainUnit(ChaosKnightsOverall, "Knight Desecrator"),
        PlainUnit(ChaosKnightsOverall, "Knight Despoiler"),
        PlainUnit(ChaosKnightsOverall, "Knight Rampager"),
        PlainUnit(ChaosKnightsOverall, "Knight Ruinator"),
        PlainUnit(ChaosKnightsOverall, "Knight Tyrant"),
        PlainUnit(ChaosKnightsOverall, "Cultist Firebrand"),
        PlainUnit(ChaosKnightsOverall, "Dark Commune"),
        PlainUnit(ChaosKnightsOverall, "Traitor Enforcer"),
        PlainUnit(ChaosKnightsOverall, "Chaos Cerastus Knight Acheron"),
        PlainUnit(ChaosKnightsOverall, "Chaos Cerastus Knight Atrapos"),
        PlainUnit(ChaosKnightsOverall, "Chaos Cerastus Knight Castigator"),
        PlainUnit(ChaosKnightsOverall, "Chaos Cerastus Knight Lancer"),
        PlainUnit(ChaosKnightsOverall, "Chaos Questoris Knight Magaera"),
        PlainUnit(ChaosKnightsOverall, "Chaos Questoris Knight Styrix"),

        PlainUnit(ChaosKnightsOverall, "Cultist Mob"),

        PlainUnit(ChaosKnightsOverall, "Accursed Cultists"),
        PlainUnit(ChaosKnightsOverall, "Fellgor Beastmen"),
        PlainUnit(ChaosKnightsOverall, "Traitor Guardsmen Squad"),

        PlainUnit(ChaosKnightsOverall, "War Dog Brigand"),
        PlainUnit(ChaosKnightsOverall, "War Dog Executioner"),
        PlainUnit(ChaosKnightsOverall, "War Dog Huntsman"),
        PlainUnit(ChaosKnightsOverall, "War Dog Karnivore"),
        PlainUnit(ChaosKnightsOverall, "War Dog Stalker"),
        PlainUnit(ChaosKnightsOverall, "War Dog Moirax"),
        PlainUnit(ChaosKnightsOverall, "Chaos Acastus Knight Asterius"),
        PlainUnit(ChaosKnightsOverall, "Chaos Acastus Knight Porphyrion"),
    ]);
}
