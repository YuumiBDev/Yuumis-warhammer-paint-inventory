namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> ThousandSonsOverall =
    [
        new("Armour",
        [
            new("Basecoat", "Thousand Sons Blue"),
            new("Recess Shade", "Drakenhof Nightshade"),
            new("Layer", "Fenrisian Grey"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Trim & Metal",
        [
            new("Basecoat", "Retributor Armour"),
            new("Shade", "Reikland Fleshshade"),
            new("Edge Highlight", "Gehenna's Gold"),
        ]),
        new("Details",
        [
            new("Bronze Scarabs", "Balthasar Gold", "Ryza Rust technical weathering"),
            new("Warp Flame Glow", "Fenrisian Grey", "thin edge for a psychic glow"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Balthasar Gold"),
            new("Basing", "Astrogranite Debris", "with Mournfang Brown"),
        ]),
    ];

    private static FactionGuide BuildThousandSons() => new("Thousand Sons",
    [
        new("Overall (Head-to-Toe)", null, ThousandSonsOverall, IsScheme: true),

        PlainUnit(ThousandSonsOverall, "Ahriman"),
        PlainUnit(ThousandSonsOverall, "Daemon Prince of Tzeentch"),
        PlainUnit(ThousandSonsOverall, "Daemon Prince of Tzeentch with Wings"),
        PlainUnit(ThousandSonsOverall, "Exalted Sorcerer"),
        PlainUnit(ThousandSonsOverall, "Exalted Sorcerer on Disc of Tzeentch"),
        PlainUnit(ThousandSonsOverall, "Infernal Master"),
        PlainUnit(ThousandSonsOverall, "Kairos Fateweaver"),
        PlainUnit(ThousandSonsOverall, "Lord of Change"),
        PlainUnit(ThousandSonsOverall, "Magnus The Red"),
        PlainUnit(ThousandSonsOverall, "Sorcerer"),
        PlainUnit(ThousandSonsOverall, "Sorcerer In Terminator Armour"),
        PlainUnit(ThousandSonsOverall, "Tzaangor Shaman"),

        PlainUnit(ThousandSonsOverall, "Blue Horrors"),
        PlainUnit(ThousandSonsOverall, "Pink Horrors"),
        PlainUnit(ThousandSonsOverall, "Rubric Marines"),

        PlainUnit(ThousandSonsOverall, "Flamers"),
        PlainUnit(ThousandSonsOverall, "Scarab Occult Terminators"),
        PlainUnit(ThousandSonsOverall, "Screamers"),
        PlainUnit(ThousandSonsOverall, "Sekhetar Robots"),
        PlainUnit(ThousandSonsOverall, "Tzaangor Enlightened"),
        PlainUnit(ThousandSonsOverall, "Tzaangor Enlightened with Fatecaster Greatbows"),
        PlainUnit(ThousandSonsOverall, "Tzaangors"),

        PlainUnit(ThousandSonsOverall, "Chaos Land Raider"),
        PlainUnit(ThousandSonsOverall, "Chaos Predator Annihilator"),
        PlainUnit(ThousandSonsOverall, "Chaos Predator Destructor"),
        PlainUnit(ThousandSonsOverall, "Chaos Vindicator"),
        PlainUnit(ThousandSonsOverall, "Heldrake"),

        PlainUnit(ThousandSonsOverall, "Chaos Spawn"),
        PlainUnit(ThousandSonsOverall, "Defiler"),
        PlainUnit(ThousandSonsOverall, "Forgefiend"),
        PlainUnit(ThousandSonsOverall, "Helbrute"),
        PlainUnit(ThousandSonsOverall, "Maulerfiend"),
        PlainUnit(ThousandSonsOverall, "Mutalith Vortex Beast"),

        PlainUnit(ThousandSonsOverall, "Chaos Rhino"),
    ], Category: GuideCategory.Chaos);
}
