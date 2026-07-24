namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> AdeptusMechanicusOverall =
    [
        new("Armour / Robes",
        [
            new("Basecoat", "Doombull Brown"),
            new("Shade", "Agrax Earthshade"),
            new("Layer", "Evil Sunz Scarlet"),
            new("Edge Highlight", "Wild Rider Red"),
        ]),
        new("Trim & Metal",
        [
            new("Basecoat", "Hashut Copper"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Warplock Bronze"),
            new("Basing", "Mournfang Brown", "Ryza Rust Red + Typhus Corrosion"),
        ]),
    ];

    // Four of the major Forge Worlds each field their own canon colour scheme — selectable
    // alongside the default Mars red Overall above; unit entries below stay on the default.
    private static readonly List<Section> ForgeWorldLucius =
    [
        new("Robes (Orange)",
        [
            new("Basecoat", "Troll Slayer Orange"),
            new("Recess Shade", "Fuegan Orange", "thinned wash into folds"),
            new("Layer", "Fire Dragon Bright"),
            new("Edge Highlight", "Yriel Yellow"),
        ]),
        new("Trim & Metal (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Eshin Grey"),
            new("Metal", "Leadbelcher", "Nuln Oil shade, Runefang Steel edge"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Warplock Bronze"),
            new("Basing", "Mournfang Brown", "Ryza Rust Red + Typhus Corrosion"),
        ]),
    ];

    private static readonly List<Section> ForgeWorldRyza =
    [
        new("Robes (Maroon)",
        [
            new("Basecoat", "Khorne Red"),
            new("Recess Shade", "Carroburg Crimson"),
            new("Layer", "Mephiston Red"),
            new("Edge Highlight", "Evil Sunz Scarlet"),
        ]),
        new("Trim & Metal (Black & Brass)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Eshin Grey"),
            new("Brass Details", "Warplock Bronze", "Agrax Earthshade shade, Sycorax Bronze edge"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Warplock Bronze"),
            new("Basing", "Mournfang Brown", "Ryza Rust Red + Typhus Corrosion"),
        ]),
    ];

    private static readonly List<Section> ForgeWorldMetalica =
    [
        new("Metal Body (Chrome)",
        [
            new("Basecoat", "Leadbelcher"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer", "Ironbreaker"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Robe Accents (Red)",
        [
            new("Basecoat", "Khorne Red"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Evil Sunz Scarlet"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Warplock Bronze"),
            new("Basing", "Mournfang Brown", "Ryza Rust Red + Typhus Corrosion"),
        ]),
    ];

    private static readonly List<Section> ForgeWorldStygiesVIII =
    [
        new("Robes (Turquoise)",
        [
            new("Basecoat", "Sotek Green"),
            new("Recess Shade", "Coelia Greenshade"),
            new("Layer", "Temple Guard Blue"),
            new("Edge Highlight", "Baharroth Blue"),
        ]),
        new("Trim & Metal (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Eshin Grey"),
            new("Metal", "Leadbelcher", "Nuln Oil shade, Runefang Steel edge"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Warplock Bronze"),
            new("Basing", "Mournfang Brown", "Ryza Rust Red + Typhus Corrosion"),
        ]),
    ];

    private static FactionGuide BuildAdeptusMechanicus() => new("Adeptus Mechanicus",
    [
        new("Forge World Mars", "The default and most common Forge World — deep red robes, copper and bronze metal.", AdeptusMechanicusOverall, IsScheme: true),

        new("Forge World Lucius", "One of the major Adeptus Mechanicus Forge Worlds — orange/red-orange robes, black trim; famed for skitarii hunter cadres and orange rad-suits.", ForgeWorldLucius, IsScheme: true),
        new("Forge World Ryza", "One of the major Adeptus Mechanicus Forge Worlds — deep maroon robes, black and brass trim; a manufacturing world known for skilled weapon-smiths.", ForgeWorldRyza, IsScheme: true),
        new("Forge World Metalica", "One of the major Adeptus Mechanicus Forge Worlds — silver/chrome metal bodies with dark red robe accents; heavy machine-worship, the most cybernetic of the Forge Worlds.", ForgeWorldMetalica, IsScheme: true),
        new("Forge World Stygies VIII", "One of the major Adeptus Mechanicus Forge Worlds — turquoise/teal robes, black trim; masters of camouflage and stealth doctrine.", ForgeWorldStygiesVIII, IsScheme: true),

        PlainUnit(AdeptusMechanicusOverall, "Belisarius Cawl"),
        PlainUnit(AdeptusMechanicusOverall, "Cybernetica Datasmith"),
        PlainUnit(AdeptusMechanicusOverall, "Skitarii Marshal"),
        PlainUnit(AdeptusMechanicusOverall, "Sydonian Skatros"),
        PlainUnit(AdeptusMechanicusOverall, "Tech-Priest Dominus"),
        PlainUnit(AdeptusMechanicusOverall, "Tech-Priest Enginseer"),
        PlainUnit(AdeptusMechanicusOverall, "Tech-Priest Manipulus"),
        PlainUnit(AdeptusMechanicusOverall, "Technoarcheologist"),
        PlainUnit(AdeptusMechanicusOverall, "Thulia Ghuld"),

        PlainUnit(AdeptusMechanicusOverall, "Skitarii Rangers"),
        PlainUnit(AdeptusMechanicusOverall, "Skitarii Vanguard"),

        PlainUnit(AdeptusMechanicusOverall, "Hastarii Exterminators"),
        PlainUnit(AdeptusMechanicusOverall, "Hastarii Fusiliers"),
        PlainUnit(AdeptusMechanicusOverall, "Corpuscarii Electro-Priests"),
        PlainUnit(AdeptusMechanicusOverall, "Fulgurite Electro-Priests"),
        PlainUnit(AdeptusMechanicusOverall, "Sicarian Infiltrators"),
        PlainUnit(AdeptusMechanicusOverall, "Sicarian Ruststalkers"),
        PlainUnit(AdeptusMechanicusOverall, "Pteraxii Skystalkers"),
        PlainUnit(AdeptusMechanicusOverall, "Pteraxii Sterylizors"),
        PlainUnit(AdeptusMechanicusOverall, "Serberys Raiders"),
        PlainUnit(AdeptusMechanicusOverall, "Serberys Sulphurhounds"),
        PlainUnit(AdeptusMechanicusOverall, "Servitor Battleclade"),

        PlainUnit(AdeptusMechanicusOverall, "Archaeopter Fusilave"),
        PlainUnit(AdeptusMechanicusOverall, "Archaeopter Stratoraptor"),
        PlainUnit(AdeptusMechanicusOverall, "Archaeopter Transvector"),
        PlainUnit(AdeptusMechanicusOverall, "Ironstrider Ballistarii"),
        PlainUnit(AdeptusMechanicusOverall, "Kastelan Robots"),
        PlainUnit(AdeptusMechanicusOverall, "Kataphron Breachers"),
        PlainUnit(AdeptusMechanicusOverall, "Kataphron Destroyers"),
        PlainUnit(AdeptusMechanicusOverall, "Onager Dunecrawler"),
        PlainUnit(AdeptusMechanicusOverall, "Skorpius Disintegrator"),
        PlainUnit(AdeptusMechanicusOverall, "Sydonian Dragoons with Radium Jezzails"),
        PlainUnit(AdeptusMechanicusOverall, "Sydonian Dragoons with Taser Lances"),
        PlainUnit(AdeptusMechanicusOverall, "Skorpius Dunerider"),
    ]);
}
