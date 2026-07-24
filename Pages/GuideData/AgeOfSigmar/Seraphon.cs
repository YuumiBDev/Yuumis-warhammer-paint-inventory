namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> SeraphonOverall =
    [
        new("Scales (Blue)",
        [
            new("Basecoat", "Kantor Blue"),
            new("Recess Shade", "Drakenhof Nightshade"),
            new("Layer", "Macragge Blue"),
            new("Edge Highlight", "Baharroth Blue"),
        ]),
        new("Underbelly & Accents (Gold)",
        [
            new("Basecoat", "Auric Armour Gold"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Liberator Gold"),
        ]),
        new("Details (Eyes & Glow)",
        [
            new("Eyes", "Yriel Yellow", "small dot"),
            new("Celestial Glow", "Moot Green", "thin glaze on weapon crystals and markings"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Auric Armour Gold"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildSeraphon() => new("Seraphon",
    [
        new("Starlight Blue", "The default and most iconic Seraphon palette — deep blue scales with gilded underbelly and weapon accents, evoking the celestial magic of the Great Plan.", SeraphonOverall, IsScheme: true),

        FactionUnit(SeraphonOverall, "Saurus Warriors", "Unit-Specific Details",
        [
            new("Clubs & Blades", "Auric Armour Gold", "as Underbelly & Accents scheme"),
            new("Shields", "Kantor Blue", "as Scales scheme"),
        ]),

        FactionUnit(SeraphonOverall, "Saurus Knights", "Mount-Specific Details",
        [
            new("Cold One Hide", "Straken Green", "Biel-Tan Green wash for a scaly reptilian tone"),
            new("Lance", "Auric Armour Gold", "as Underbelly & Accents scheme"),
        ]),

        FactionUnit(SeraphonOverall, "Skinks", "Unit-Specific Details",
        [
            new("Smaller Scales", "Straken Green", "Biel-Tan Green wash, distinguishes Skinks from Saurus"),
            new("Javelin / Blowpipe", "Auric Armour Gold", "as Underbelly & Accents scheme"),
        ]),

        FactionUnit(SeraphonOverall, "Kroxigor", "Unit-Specific Details",
        [
            new("Hulking Scales", "Kantor Blue", "as Scales scheme, heavier drybrush for bulk"),
            new("Maul / Weapon", "Leadbelcher", "Nuln Oil wash"),
        ]),

        FactionUnit(SeraphonOverall, "Salamanders", "Unit-Specific Details",
        [
            new("Hide", "Mephiston Red", "Carroburg Crimson wash, distinguishes the fire-breathing hunting beasts"),
            new("Flame Breath Glow", "Troll Slayer Orange", "Fire Dragon Bright highlight"),
        ]),

        FactionUnit(SeraphonOverall, "Slann Starmaster", "Unit-Specific Details",
        [
            new("Palanquin", "Auric Armour Gold", "as Underbelly & Accents scheme"),
            new("Celestial Glow", "Moot Green", "heavier glaze across the palanquin's arcane geometry"),
        ]),

        FactionUnit(SeraphonOverall, "Astrolith Bearer", "Unit-Specific Details",
        [
            new("Astrolith Icon", "Auric Armour Gold", "as Underbelly & Accents scheme"),
            new("Celestial Glow", "Moot Green", "thin glaze radiating from the icon"),
        ]),
    ], Category: GuideCategory.Order, Game: Game.AgeOfSigmar);
}
