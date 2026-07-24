namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> HouseVanSaarOverall =
    [
        new("Hazard Suits (White)",
        [
            new("Basecoat", "Corax White"),
            new("Recess Shade", "Drakenhof Nightshade", "thinned"),
            new("Layer", "Corax White", "reapplied to raised panels"),
            new("Edge Highlight", "White Scar"),
        ]),
        new("Pale Blue Accents & Lenses",
        [
            new("Basecoat", "Teclis Blue"),
            new("Highlight", "Lothern Blue"),
        ]),
        new("Trim & Tech",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Auric Armour Gold"),
            new("Basing", "Astrogranite Debris", "sterile, high-tech ground"),
        ]),
    ];

    private static FactionGuide BuildHouseVanSaar() => new("House Van Saar",
    [
        new("Overall (Head-to-Toe)", "Pristine white hazard suits with pale blue tech accents mark Van Saar out as the underhive's most advanced House — clean, clinical, and unmistakably high-tech.", HouseVanSaarOverall, IsScheme: true),

        FactionUnit(HouseVanSaarOverall, "Van Saar Ganger", "Unit-Specific Details",
        [
            new("Weapon Coils", "Teclis Blue", "Lothern Blue highlight"),
            new("Suit Piping", "Runefang Steel"),
        ]),

        FactionUnit(HouseVanSaarOverall, "Van Saar Juve", "Unit-Specific Details",
        [
            new("Suit", "Corax White", "less weathering than veterans"),
            new("Visor", "Teclis Blue"),
        ]),

        FactionUnit(HouseVanSaarOverall, "Van Saar Champion", "Unit-Specific Details",
        [
            new("Targeting Array", "Teclis Blue", "Lothern Blue edge highlight"),
            new("Suit Trim", "Auric Armour Gold"),
            new("Weapon Casing", "Leadbelcher"),
        ]),

        FactionUnit(HouseVanSaarOverall, "Van Saar Leader (Chief)", "Unit-Specific Details",
        [
            new("Cloak / Trailing Cable", "Teclis Blue", "Nuln Oil recess shade"),
            new("House Icon", "Auric Armour Gold"),
            new("Command Weapon Casing", "Leadbelcher"),
        ]),

        FactionUnit(HouseVanSaarOverall, "Van Saar Heavy", "Unit-Specific Details",
        [
            new("Heavy Weapon Housing", "Corax White"),
            new("Weapon Coils", "Teclis Blue"),
            new("Ammo Feed", "Runefang Steel"),
        ]),
    ], Category: GuideCategory.Gangs, Game: Game.Necromunda);
}
