namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> StormcastEternalsOverall =
    [
        new("Armour (Sigmarite Gold)",
        [
            new("Basecoat", "Retributor Armour"),
            new("Recess Shade", "Agrax Earthshade"),
            new("Layer", "Auric Armour Gold"),
            new("Edge Highlight", "Liberator Gold"),
        ]),
        new("Robes & Cloth (Blue)",
        [
            new("Basecoat", "Kantor Blue"),
            new("Layer", "Macragge Blue"),
            new("Edge Highlight", "Teclis Blue"),
        ]),
        new("Trim & Metal",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Auric Armour Gold"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    // The major Stormhosts each field their own canon colour scheme — selectable
    // alongside the default gold/blue Overall above (which is itself the Hammers of Sigmar);
    // unit entries below stay on whichever scheme is currently selected.
    private static readonly List<Section> ChamberAstralTemplars =
    [
        new("Armour (Teal)",
        [
            new("Basecoat", "Temple Guard Blue"),
            new("Recess Shade", "Coelia Greenshade"),
            new("Layer", "Sotek Green"),
            new("Edge Highlight", "Sybarite Green"),
        ]),
        new("Trim & Metal (Black & Gold)",
        [
            new("Cloth Basecoat", "Abaddon Black"),
            new("Gold Trim", "Retributor Armour"),
            new("Gold Edge Highlight", "Auric Armour Gold"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Runefang Steel"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static readonly List<Section> ChamberAnvilsOfTheHeldenhammer =
    [
        new("Armour (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Layer", "Eshin Grey"),
            new("Edge Highlight", "Dawnstone"),
        ]),
        new("Trim & Metal (Gold)",
        [
            new("Basecoat", "Retributor Armour"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Auric Armour Gold"),
        ]),
        new("Rune Details (Orange)",
        [
            new("Basecoat", "Troll Slayer Orange"),
            new("Glaze", "Fire Dragon Bright", "thin glaze over runic etchings"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Retributor Armour"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildStormcastEternals() => new("Stormcast Eternals",
    [
        new("Hammers of Sigmar", "The default and most iconic Stormhost — burnished gold Sigmarite armour over deep blue cloth. Build the gold up from a warm Retributor Armour basecoat with a sharp Liberator Gold edge highlight so the armour reads as bright, divine metal rather than flat brass.", StormcastEternalsOverall, IsScheme: true),
        new("Astral Templars", "One of the major Stormhosts — teal armour with black cloth and gold trim. Known for their aggressive, close-quarters fighting style.", ChamberAstralTemplars, IsScheme: true),
        new("Anvils of the Heldenhammer", "One of the major Stormhosts — black armour with gold trim and glowing orange rune details. The most heavily armoured and defensively minded of the Stormhosts.", ChamberAnvilsOfTheHeldenhammer, IsScheme: true),

        FactionUnit(StormcastEternalsOverall, "Liberators", "Unit-Specific Details",
        [
            new("Warhammer / Warblade", "Runefang Steel", "edge highlight"),
            new("Shield Sigmarite Icon", "Retributor Armour", "Agrax Earthshade wash"),
        ]),

        FactionUnit(StormcastEternalsOverall, "Judicators", "Unit-Specific Details",
        [
            new("Boltstorm Crossbow / Skybolt Bow", "Leadbelcher", "Nuln Oil wash"),
            new("Fletching", "Kantor Blue", "Teclis Blue edge"),
        ]),

        FactionUnit(StormcastEternalsOverall, "Vindictors", "Unit-Specific Details",
        [
            new("Greatmace / Stormsword", "Runefang Steel", "edge highlight"),
            new("Shield Trim", "Auric Armour Gold"),
        ]),

        FactionUnit(StormcastEternalsOverall, "Vanguard-Palladors", "Mount-Specific Details",
        [
            new("Gryph-Charger Feathers", "Ushabti Bone", "Agrax Earthshade wash, Screaming Skull highlight"),
            new("Gryph-Charger Beak & Claws", "Troll Slayer Orange"),
            new("Boltstorm Pistol", "Leadbelcher", "Nuln Oil wash"),
        ]),

        FactionUnit(StormcastEternalsOverall, "Annihilators", "Unit-Specific Details",
        [
            new("Meteoric Grandhammer Head", "Leadbelcher", "Nuln Oil wash, Runefang Steel edge"),
            new("Heavier Armour Plates", "Auric Armour Gold", "extra edge highlight pass for bulk"),
        ]),

        FactionUnit(StormcastEternalsOverall, "Lord-Celestant", "Unit-Specific Details",
        [
            new("Warhammer / Sigmarite Blade", "Runefang Steel", "edge highlight"),
            new("Cape & Heraldry", "Kantor Blue", "Teclis Blue edge"),
            new("Command Regalia", "Auric Armour Gold", "gilded accents distinguish rank"),
        ]),

        FactionUnit(StormcastEternalsOverall, "Knight-Vexillor", "Unit-Specific Details",
        [
            new("Meteoric Standard Pole", "Leadbelcher", "Nuln Oil wash"),
            new("Standard Cloth", "Kantor Blue", "Teclis Blue edge"),
        ]),

        FactionUnit(StormcastEternalsOverall, "Gryph-Hounds", "Unit-Specific Details",
        [
            new("Feathered Hide", "Ushabti Bone", "Agrax Earthshade wash, Screaming Skull highlight"),
            new("Beak & Claws", "Troll Slayer Orange"),
        ]),

        FactionUnit(StormcastEternalsOverall, "Dracothian Guard", "Mount-Specific Details",
        [
            new("Drakesworn Scales", "Kantor Blue", "Macragge Blue layer, Teclis Blue edge"),
            new("Lance / Warblade", "Runefang Steel", "edge highlight"),
            new("Barding", "Auric Armour Gold"),
        ]),

        FactionUnit(StormcastEternalsOverall, "Stormdrake Guard", "Mount-Specific Details",
        [
            new("Stormdrake Scales", "Kantor Blue", "Macragge Blue layer, Teclis Blue edge"),
            new("Drakerider Lance", "Runefang Steel", "edge highlight"),
            new("Wing Membrane", "Naggaroth Night", "Druchii Violet glaze"),
        ]),
    ], Category: GuideCategory.Order, Game: Game.AgeOfSigmar);
}
