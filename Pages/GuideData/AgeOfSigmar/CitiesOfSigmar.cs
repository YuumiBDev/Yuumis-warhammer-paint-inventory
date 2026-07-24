namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> CitiesOfSigmarOverall =
    [
        new("Coats & Cloth (Freeguild Blue)",
        [
            new("Basecoat", "Kantor Blue"),
            new("Recess Shade", "Drakenhof Nightshade"),
            new("Layer", "Macragge Blue"),
            new("Edge Highlight", "Teclis Blue"),
        ]),
        new("Armour & Steel",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Leather & Straps",
        [
            new("Basecoat", "Dryad Bark"),
            new("Highlight", "Mournfang Brown"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildCitiesOfSigmar() => new("Cities of Sigmar",
    [
        new("Freeguild Blue", "The default and most common Cities of Sigmar palette — steel-blue coats and cloth over gunmetal armour, worn by the human regiments who make up the bulk of most Cities armies.", CitiesOfSigmarOverall, IsScheme: true),

        FactionUnit(CitiesOfSigmarOverall, "Freeguild Fusiliers", "Unit-Specific Details",
        [
            new("Handgun Barrel", "Leadbelcher", "Nuln Oil wash"),
            new("Powder Horn & Straps", "Dryad Bark"),
        ]),

        FactionUnit(CitiesOfSigmarOverall, "Freeguild Cavaliers", "Mount-Specific Details",
        [
            new("Horse Coat", "Rhinox Hide", "Agrax Earthshade wash, Baneblade Brown highlight"),
            new("Sabre Blade", "Runefang Steel", "edge highlight"),
            new("Barding", "Kantor Blue", "as Coats & Cloth scheme"),
        ]),

        FactionUnit(CitiesOfSigmarOverall, "Darkshards", "Unit-Specific Details",
        [
            new("Repeater Crossbow", "Abaddon Black"),
            new("Armour Plates", "Naggaroth Night", "distinguishes the Dark Aelf allies from the Freeguild"),
        ]),

        FactionUnit(CitiesOfSigmarOverall, "Phoenix Guard", "Unit-Specific Details",
        [
            new("Halberd Blade", "Runefang Steel", "edge highlight"),
            new("Feathered Crest", "Mephiston Red", "Carroburg Crimson wash, Wild Rider Red edge"),
            new("Armour", "Auric Armour Gold", "gilded aelf plate"),
        ]),

        FactionUnit(CitiesOfSigmarOverall, "Dispossessed Ironbreakers", "Unit-Specific Details",
        [
            new("Gromril Armour", "Leadbelcher", "Nuln Oil wash, Runefang Steel edge"),
            new("Beard", "Ushabti Bone", "Agrax Earthshade wash, Screaming Skull highlight"),
        ]),

        FactionUnit(CitiesOfSigmarOverall, "Sword of Judgement", "Unit-Specific Details",
        [
            new("Blade", "Runefang Steel", "edge highlight along the full length"),
            new("Hilt & Regalia", "Auric Armour Gold"),
        ]),

        FactionUnit(CitiesOfSigmarOverall, "Fulminators", "Mount-Specific Details",
        [
            new("Drakesworn Scales", "Kantor Blue", "Macragge Blue layer, Teclis Blue edge"),
            new("Lance", "Runefang Steel", "edge highlight"),
        ]),

        FactionUnit(CitiesOfSigmarOverall, "Steam Tank", "Vehicle-Specific Details",
        [
            new("Boiler & Pipework", "Leadbelcher", "Nuln Oil wash, Runefang Steel edge"),
            new("Hull Panels", "Kantor Blue", "as Coats & Cloth scheme"),
            new("Rivets & Trim", "Auric Armour Gold"),
        ]),
    ], Category: GuideCategory.Order, Game: Game.AgeOfSigmar);
}
