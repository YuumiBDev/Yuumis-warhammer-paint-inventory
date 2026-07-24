namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> DwarfOverall =
    [
        new("Steel Armour",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Ironbreaker"),
        ]),
        new("Gold Trim",
        [
            new("Basecoat", "Retributor Armour"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Auric Armour Gold"),
        ]),
        new("Beard & Skin",
        [
            new("Skin", "Cadian Fleshtone", "Reikland Fleshshade wash"),
            new("Beard Basecoat", "Ushabti Bone"),
            new("Beard Shade", "Agrax Earthshade"),
            new("Beard Highlight", "Screaming Skull"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildDwarf() => new("Dwarf",
    [
        new("Dwarf", "Gold-trimmed steel plate over a stubborn, defensive line — slow across the pitch but nearly impossible to knock down or wear out over a long game.", DwarfOverall, IsScheme: true),

        FactionUnit(DwarfOverall, "Lineman (Dwarf Blocker)", "Unit-Specific Details",
        [
            new("Helmet", "Leadbelcher", "as Overall steel armour scheme"),
            new("Team Number", "Auric Armour Gold"),
        ]),

        FactionUnit(DwarfOverall, "Blitzer", "Unit-Specific Details",
        [
            new("Reinforced Gauntlets", "Leadbelcher", "Nuln Oil recess"),
            new("Gold Trim Panel", "Auric Armour Gold", "wider trim band than Blockers"),
        ]),

        FactionUnit(DwarfOverall, "Runner", "Unit-Specific Details",
        [
            new("Lightweight Leather Vest", "Rhinox Hide", "less plate than Blockers, built for mobility"),
            new("Beard", "Ushabti Bone", "as Overall beard scheme"),
        ]),

        FactionUnit(DwarfOverall, "Troll Slayer", "Unit-Specific Details",
        [
            new("Bare Torso", "Cadian Fleshtone", "Reikland Fleshshade wash, no armour worn by tradition"),
            new("Wild Crest / Dyed Hair", "Wazdakka Red"),
            new("Tattoos", "Abaddon Black"),
        ]),

        FactionUnit(DwarfOverall, "Deathroller", "Vehicle-Specific Details",
        [
            new("Steam Boiler Housing", "Leadbelcher", "Nuln Oil wash, Ironbreaker highlight"),
            new("Rivets & Plating", "Retributor Armour", "as Overall gold trim scheme"),
            new("Crushing Roller", "Abaddon Black", "Typhus Corrosion rust streaks"),
        ]),
    ], Category: GuideCategory.Teams, Game: Game.BloodBowl);
}
