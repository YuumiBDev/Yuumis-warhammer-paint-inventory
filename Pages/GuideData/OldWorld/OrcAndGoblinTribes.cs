namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> OrcAndGoblinTribesOverall =
    [
        new("Skin",
        [
            new("Basecoat", "Waaagh! Flesh"),
            new("Shade", "Biel-Tan Green", "recesses"),
            new("Layer", "Warboss Green / Skarsnik Green", "50/50 mix"),
            new("Highlight", "Skarsnik Green", "edges"),
        ]),
        new("Armour & Ramshackle Plate",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Mournfang Brown"),
        ]),
        new("Metal & Weapons",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Ironbreaker"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Rhinox Hide"),
            new("Basing", "Stirland Mud"),
        ]),
    ];

    private static FactionGuide BuildOrcAndGoblinTribes() => new("Orc & Goblin Tribes",
    [
        new("Waaagh! Green", "The default tribal look — mottled green skin over scavenged, ill-fitting armour plate, held together with rope, rivets and spite.", OrcAndGoblinTribesOverall, IsScheme: true),

        FactionUnit(OrcAndGoblinTribesOverall, "Orc Boyz", "Unit-Specific Details",
        [
            new("Choppa", "Leadbelcher", "Nuln Oil wash"),
            new("Ramshackle Armour", "Rhinox Hide", "Agrax Earthshade wash"),
        ]),

        FactionUnit(OrcAndGoblinTribesOverall, "Night Goblins", "Unit-Specific Details",
        [
            new("Pale Goblin Skin", "Nurgling Green", "Biel-Tan Green shade, distinguishes from Orc skin"),
            new("Hood & Robes", "Dryad Bark"),
        ]),

        FactionUnit(OrcAndGoblinTribesOverall, "Orc Boar Boyz", "Mount-Specific Details",
        [
            new("Boar Hide", "Rhinox Hide", "Agrax Earthshade wash"),
            new("Boar Tusks", "Screaming Skull"),
        ]),

        FactionUnit(OrcAndGoblinTribesOverall, "Black Orcs", "Unit-Specific Details",
        [
            new("Heavy Plate Armour", "Abaddon Black", "Eshin Grey drybrush, distinguishes elite status"),
            new("Plate Trim", "Leadbelcher"),
        ]),

        FactionUnit(OrcAndGoblinTribesOverall, "Troll", "Unit-Specific Details",
        [
            new("Hide", "Rhinox Hide", "Agrax Earthshade wash, Tallarn Sand highlight"),
            new("Warty Skin Accents", "Waaagh! Flesh"),
        ]),

        FactionUnit(OrcAndGoblinTribesOverall, "Orc Warboss", "Unit-Specific Details",
        [
            new("Trophy Cloak", "Mephiston Red"),
            new("Trophy Rack", "Screaming Skull", "bone"),
            new("Weapon & Armour", "Leadbelcher", "Ironbreaker edge"),
        ]),

        FactionUnit(OrcAndGoblinTribesOverall, "Doom Diver Catapult", "Vehicle-Specific Details",
        [
            new("Wooden Frame", "Rhinox Hide", "Agrax Earthshade wash"),
            new("Iron Fittings", "Leadbelcher", "Nuln Oil wash"),
        ]),
    ], Category: GuideCategory.All, Game: Game.OldWorld);
}
