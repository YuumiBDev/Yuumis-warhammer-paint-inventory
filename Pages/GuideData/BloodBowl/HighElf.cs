namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> HighElfOverall =
    [
        new("Kit (Jersey & Leggings)",
        [
            new("Basecoat", "Corax White"),
            new("Shade", "Drakenhof Nightshade", "thinned wash into recesses only"),
            new("Highlight", "White Scar", "edge highlight"),
        ]),
        new("Trim & Panels",
        [
            new("Basecoat", "Caledor Sky"),
            new("Shade", "Drakenhof Nightshade"),
            new("Highlight", "Teclis Blue"),
        ]),
        new("Gold Details",
        [
            new("Basecoat", "Auric Armour Gold"),
            new("Shade", "Agrax Earthshade"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildHighElf() => new("High Elf",
    [
        new("High Elf", "Pristine white-and-blue kit with fine gold trim — a fast, balanced roster built around agility and skill rather than brute force.", HighElfOverall, IsScheme: true),

        FactionUnit(HighElfOverall, "Lineman", "Unit-Specific Details",
        [
            new("Kit Panel", "Caledor Sky", "as Overall trim scheme"),
            new("Squad Number", "Auric Armour Gold"),
        ]),

        FactionUnit(HighElfOverall, "Thrower", "Unit-Specific Details",
        [
            new("Throwing Arm Wrap", "Teclis Blue", "as Overall trim highlight"),
            new("Ball Grip Glove", "Corax White", "as Overall kit scheme"),
        ]),

        FactionUnit(HighElfOverall, "Catcher", "Unit-Specific Details",
        [
            new("Lightweight Panels", "Teclis Blue", "trimmed-down kit built for speed"),
            new("Boots", "Caledor Sky"),
        ]),

        FactionUnit(HighElfOverall, "Blitzer", "Unit-Specific Details",
        [
            new("Reinforced Shoulder Guard", "Auric Armour Gold", "wider gold trim than Linemen"),
            new("Vambraces", "Caledor Sky", "as Overall trim scheme"),
        ]),

        FactionUnit(HighElfOverall, "Star Player", "Unit-Specific Details",
        [
            new("Ornate Cloak Lining", "Teclis Blue", "Nuln Oil recess for extra depth"),
            new("Gold Filigree", "Auric Armour Gold", "as Overall gold scheme, extra detailing"),
        ]),
    ], Category: GuideCategory.Teams, Game: Game.BloodBowl);
}
