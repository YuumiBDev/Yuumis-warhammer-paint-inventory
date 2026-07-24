namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> MoriaGoblinsOverall =
    [
        new("Skin",
        [
            new("Basecoat", "Rakarth Flesh"),
            new("Shade", "Biel-Tan Green", "thinned"),
            new("Highlight", "Screaming Skull"),
        ]),
        new("Ragged Cloth",
        [
            new("Basecoat", "Dryad Bark"),
            new("Shade", "Agrax Earthshade"),
        ]),
        new("Weapons & Trim",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil", "heavy rust look"),
            new("Highlight", "Ironbreaker", "sparse"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Dryad Bark"),
            new("Basing", "Astrogranite", "cave-rock rubble"),
        ]),
    ];

    private static FactionGuide BuildMoriaGoblins() => new("Moria Goblins",
    [
        new("Moria Goblins", "The teeming swarm beneath the mountains — pale, sickly green-grey skin, filthy ragged clothing, and crude rusted weapons in overwhelming numbers.", MoriaGoblinsOverall, IsScheme: true),

        FactionUnit(MoriaGoblinsOverall, "Moria Goblin Prowlers", "Unit-Specific Details",
        [
            new("Camouflage Rags", "Dryad Bark"),
            new("Blowpipe", "Rhinox Hide"),
        ]),

        FactionUnit(MoriaGoblinsOverall, "Cave Troll", "Unit-Specific Details",
        [
            new("Hide", "Rhinox Hide"),
            new("Hide Shade", "Agrax Earthshade"),
            new("Hide Highlight", "Doombull Brown"),
            new("Chains", "Leadbelcher"),
        ]),

        FactionUnit(MoriaGoblinsOverall, "The Goblin King", "Unit-Specific Details",
        [
            new("Bloated Flesh", "Rakarth Flesh", "as Overall skin scheme"),
            new("Flesh Shade", "Carroburg Crimson", "sickly, swollen look"),
            new("Jewelry", "Auric Armour Gold"),
            new("Robes", "Dryad Bark"),
        ]),
    ], Category: GuideCategory.Evil, Game: Game.MiddleEarth);
}
