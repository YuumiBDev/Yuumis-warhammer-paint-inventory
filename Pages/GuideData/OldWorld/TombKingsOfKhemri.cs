namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> TombKingsOfKhemriOverall =
    [
        new("Bone",
        [
            new("Basecoat", "Zandri Dust"),
            new("Shade", "Agrax Earthshade"),
            new("Layer", "Ushabti Bone"),
            new("Highlight", "Screaming Skull"),
        ]),
        new("Wrappings & Cloth",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Tallarn Sand"),
        ]),
        new("Regalia & Trim (Gold)",
        [
            new("Basecoat", "Retributor Armour"),
            new("Shade", "Reikland Fleshshade"),
            new("Edge Highlight", "Auric Armour Gold"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Zandri Dust"),
            new("Basing", "Agrellan Earth", "cracked desert basing"),
        ]),
    ];

    private static FactionGuide BuildTombKingsOfKhemri() => new("Tomb Kings of Khemri",
    [
        new("Khemri Sands", "The default and most iconic look — sun-bleached bone rising from the desert, dressed in ancient gilded regalia that has not dulled in millennia of entombment.", TombKingsOfKhemriOverall, IsScheme: true),

        FactionUnit(TombKingsOfKhemriOverall, "Skeleton Warriors", "Unit-Specific Details",
        [
            new("Weapon & Shield", "Leadbelcher", "Nuln Oil wash"),
            new("Shield Icon", "Retributor Armour"),
        ]),

        FactionUnit(TombKingsOfKhemriOverall, "Skeleton Archers", "Unit-Specific Details",
        [
            new("Bow", "Zandri Dust", "Agrax Earthshade wash"),
            new("Fletching", "Screaming Skull"),
        ]),

        FactionUnit(TombKingsOfKhemriOverall, "Tomb Guard", "Unit-Specific Details",
        [
            new("Halberd Blade", "Leadbelcher", "Nuln Oil wash"),
            new("Ceremonial Trim", "Auric Armour Gold", "distinguishes the elite royal guard"),
        ]),

        FactionUnit(TombKingsOfKhemriOverall, "Ushabti", "Unit-Specific Details",
        [
            new("Stone-Carved Body", "Ushabti Bone", "Agrax Earthshade wash"),
            new("Weapon", "Retributor Armour", "gilded"),
        ]),

        FactionUnit(TombKingsOfKhemriOverall, "Tomb King", "Unit-Specific Details",
        [
            new("Crown & Regalia", "Auric Armour Gold"),
            new("Cloak", "Mephiston Red"),
            new("Sceptre Gem", "Genestealer Purple"),
        ]),

        FactionUnit(TombKingsOfKhemriOverall, "Liche Priest", "Unit-Specific Details",
        [
            new("Robes", "Rhinox Hide", "Agrax Earthshade wash"),
            new("Incantation Glow", "Sybarite Green"),
        ]),

        FactionUnit(TombKingsOfKhemriOverall, "Necropolis Knights", "Mount-Specific Details",
        [
            new("Skeletal Steed", "Zandri Dust", "Agrax Earthshade wash"),
            new("Lance", "Leadbelcher", "Nuln Oil wash"),
        ]),
    ], Category: GuideCategory.All, Game: Game.OldWorld);
}
