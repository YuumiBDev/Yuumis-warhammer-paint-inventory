namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> ImperialKnightsOverall =
    [
        new("Armour (House Terryn)",
        [
            new("Basecoat", "Macragge Blue"),
            new("Shade", "Drakenhof Nightshade"),
            new("Layer", "Calgar Blue"),
            new("Edge Highlight", "Fenrisian Grey"),
        ]),
        new("Trim, Metal & Heraldry",
        [
            new("Trim Basecoat", "Leadbelcher"),
            new("Trim Shade", "Nuln Oil"),
            new("Trim Edge Highlight", "Ironbreaker"),
            new("Heraldry", "Corax White", "Celestra Grey highlight"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Auric Armour Gold"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildImperialKnights() => new("Imperial Knights",
    [
        new("Overall (Head-to-Toe)", null, ImperialKnightsOverall, IsScheme: true),

        PlainUnit(ImperialKnightsOverall, "Canis Rex"),
        PlainUnit(ImperialKnightsOverall, "Sir Hekhtur"),
        PlainUnit(ImperialKnightsOverall, "Skitarii Marshal"),
        PlainUnit(ImperialKnightsOverall, "Tech-Priest Dominus"),
        PlainUnit(ImperialKnightsOverall, "Tech-Priest Manipulus"),

        PlainUnit(ImperialKnightsOverall, "Skitarii Rangers"),
        PlainUnit(ImperialKnightsOverall, "Skitarii Vanguard"),

        PlainUnit(ImperialKnightsOverall, "Knight Destrier"),
        PlainUnit(ImperialKnightsOverall, "Knight Castellan"),
        PlainUnit(ImperialKnightsOverall, "Knight Crusader"),
        PlainUnit(ImperialKnightsOverall, "Knight Errant"),
        PlainUnit(ImperialKnightsOverall, "Knight Gallant"),
        PlainUnit(ImperialKnightsOverall, "Knight Paladin"),
        PlainUnit(ImperialKnightsOverall, "Knight Preceptor"),
        PlainUnit(ImperialKnightsOverall, "Knight Valiant"),
        PlainUnit(ImperialKnightsOverall, "Knight Warden"),
        PlainUnit(ImperialKnightsOverall, "Armiger Helverin"),
        PlainUnit(ImperialKnightsOverall, "Armiger Warglaive"),
        PlainUnit(ImperialKnightsOverall, "Armiger Moirax"),
        PlainUnit(ImperialKnightsOverall, "Acastus Knight Asterius"),
        PlainUnit(ImperialKnightsOverall, "Acastus Knight Porphyrion"),
        PlainUnit(ImperialKnightsOverall, "Cerastus Knight Acheron"),
        PlainUnit(ImperialKnightsOverall, "Cerastus Knight Atrapos"),
        PlainUnit(ImperialKnightsOverall, "Cerastus Knight Castigator"),
        PlainUnit(ImperialKnightsOverall, "Cerastus Knight Lancer"),
        PlainUnit(ImperialKnightsOverall, "Questoris Knight Magaera"),
        PlainUnit(ImperialKnightsOverall, "Questoris Knight Styrix"),
    ]);
}
