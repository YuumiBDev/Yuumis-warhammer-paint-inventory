namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> HeroesOfDarkwaterOverall =
    [
        new("Leather & Straps",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Mournfang Brown"),
        ]),
        new("Steel Fittings",
        [
            new("Basecoat", "Leadbelcher"),
            new("Wash", "Nuln Oil"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildHeroesOfDarkwater() => new("Heroes of Darkwater",
    [
        new("Adventuring Gear", "The shared leathers, straps and steel fittings common to every hero's kit before their own colours are added.", HeroesOfDarkwaterOverall, IsScheme: true),

        FactionUnit(HeroesOfDarkwaterOverall, "Sir Aldric the Knight", "Unit-Specific Details",
        [
            new("Plate Armour", "Runefang Steel", "as Overall steel scheme"),
            new("Heraldry", "Mephiston Red"),
            new("Cloak", "Caledor Sky", "Drakenhof Nightshade shade"),
        ]),

        FactionUnit(HeroesOfDarkwaterOverall, "Elowen the Mage", "Unit-Specific Details",
        [
            new("Robes", "Xereus Purple", "Druchii Violet shade"),
            new("Trim", "Retributor Gold", "Agrax Earthshade wash"),
            new("Staff Crystal", "Sotek Green", "glaze for an arcane glow"),
        ]),

        FactionUnit(HeroesOfDarkwaterOverall, "Rowan the Ranger", "Unit-Specific Details",
        [
            new("Cloak", "Straken Green", "Agrax Earthshade wash"),
            new("Hood & Leathers", "Dryad Bark", "as Overall leather scheme"),
            new("Bow", "Rhinox Hide", "as Overall leather scheme"),
        ]),

        FactionUnit(HeroesOfDarkwaterOverall, "Sister Maren the Priest", "Unit-Specific Details",
        [
            new("Robes", "Corax White", "Drakenhof Nightshade glaze"),
            new("Trim", "Retributor Gold", "as Overall steel scheme substitute"),
            new("Holy Symbol", "Balthasar Gold", "Agrax Earthshade wash"),
        ]),
    ], Category: GuideCategory.All, Game: Game.WarhammerQuestDarkwater);
}
