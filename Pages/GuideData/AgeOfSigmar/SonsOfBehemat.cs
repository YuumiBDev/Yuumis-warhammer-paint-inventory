namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> SonsOfBehematOverall =
    [
        new("Skin",
        [
            new("Basecoat", "Bugman's Glow"),
            new("Shade", "Reikland Fleshshade"),
            new("Highlight", "Kislev Flesh"),
        ]),
        new("Tattoos & War Paint",
        [
            new("Basecoat", "Alaitoc Blue", "thin tribal lines and swirls over bare skin"),
            new("Edge Highlight", "Baharroth Blue", "fine highlight along the tattoo lines"),
        ]),
        new("Furs & Ramshackle Cloth",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Tallarn Sand"),
        ]),
        new("Scrap Armour & Cage-Iron",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Ironbreaker"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Rhinox Hide"),
            new("Basing", "Astrogranite Debris", "or Stirland Mud with broken rubble and stonework"),
        ]),
    ];

    private static FactionGuide BuildSonsOfBehemat() => new("Sons of Behemat",
    [
        new("Overall (Head-to-Toe)", "The default scheme for a Mancrusher Clan Gargant — weathered ruddy skin under crude blue tribal tattoos, wrapped in furs and ramshackle scrap-iron armour scavenged from anything (and anyone) unlucky enough to be underfoot.", SonsOfBehematOverall, IsScheme: true),

        FactionUnit(SonsOfBehematOverall, "Mega-Gargant", "Unit-Specific Details",
        [
            new("Massive Club / Weapon", "Rhinox Hide", "Agrax Earthshade wash, Tallarn Sand highlight"),
            new("Trophy Rack", "Leadbelcher", "Nuln Oil shade, Ironbreaker edge highlight"),
        ]),

        FactionUnit(SonsOfBehematOverall, "Gatebreaker Gargant", "Unit-Specific Details",
        [
            new("Battering Ram / Door Shield", "Leadbelcher", "Nuln Oil shade, Ironbreaker edge highlight, scavenged fortress ironwork"),
        ]),

        FactionUnit(SonsOfBehematOverall, "Warstomper Gargant", "Unit-Specific Details",
        [
            new("Ballista / Siege Weapon", "Leadbelcher", "Nuln Oil shade, Ironbreaker edge highlight"),
            new("Rope & Rigging", "Zandri Dust", "Agrax Earthshade wash"),
        ]),

        FactionUnit(SonsOfBehematOverall, "Kraken-eater Gargant", "Unit-Specific Details",
        [
            new("Kraken Trophy / Tentacles", "Skavenblight Dinge", "Nuln Oil shade, Dawnstone drybrush highlight"),
            new("Netting", "Rhinox Hide", "Agrax Earthshade wash"),
        ]),

        PlainUnit(SonsOfBehematOverall, "Mancrusher Gargants"),
    ], Category: GuideCategory.Destruction, Game: Game.AgeOfSigmar);
}
