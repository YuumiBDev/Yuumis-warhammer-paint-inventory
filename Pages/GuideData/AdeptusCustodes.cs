namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> AdeptusCustodesOverall =
    [
        new("Armour",
        [
            new("Basecoat", "Balthasar Gold"),
            new("Shade", "Reikland Fleshshade Gloss"),
            new("Layer", "Auric Armour Gold"),
            new("Edge Highlight", "Sycorax Bronze"),
        ]),
        new("Trim & Robes",
        [
            new("Trim Basecoat", "Abaddon Black"),
            new("Trim Edge Highlight", "Dawnstone"),
            new("Robes Basecoat", "Mephiston Red"),
            new("Robes Shade", "Nuln Oil"),
            new("Robes Highlight", "Evil Sunz Scarlet"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Auric Armour Gold"),
            new("Basing", "Mournfang Brown", "with Ryza Rust Red"),
        ]),
    ];

    private static FactionGuide BuildAdeptusCustodes() => new("Adeptus Custodes",
    [
        new("Overall (Head-to-Toe)", null, AdeptusCustodesOverall, IsScheme: true),

        PlainUnit(AdeptusCustodesOverall, "Aleya"),
        PlainUnit(AdeptusCustodesOverall, "Blade Champion"),
        PlainUnit(AdeptusCustodesOverall, "Knight-Centura"),
        PlainUnit(AdeptusCustodesOverall, "Shield-Captain"),
        PlainUnit(AdeptusCustodesOverall, "Shield-Captain in Allarus Terminator Armour"),
        PlainUnit(AdeptusCustodesOverall, "Shield-Captain on Dawneagle Jetbike"),
        PlainUnit(AdeptusCustodesOverall, "Trajann Valoris"),
        PlainUnit(AdeptusCustodesOverall, "Valerian"),

        PlainUnit(AdeptusCustodesOverall, "Custodian Guard"),

        PlainUnit(AdeptusCustodesOverall, "Allarus Custodians"),
        PlainUnit(AdeptusCustodesOverall, "Custodian Wardens"),
        PlainUnit(AdeptusCustodesOverall, "Prosecutors"),
        PlainUnit(AdeptusCustodesOverall, "Vigilators"),
        PlainUnit(AdeptusCustodesOverall, "Witchseekers"),
        PlainUnit(AdeptusCustodesOverall, "Agamatus Custodians"),
        PlainUnit(AdeptusCustodesOverall, "Aquilon Custodians"),
        PlainUnit(AdeptusCustodesOverall, "Sagittarum Custodians"),
        PlainUnit(AdeptusCustodesOverall, "Venatari Custodians"),

        PlainUnit(AdeptusCustodesOverall, "Venerable Land Raider"),
        PlainUnit(AdeptusCustodesOverall, "Venerable Contemptor Dreadnought"),
        PlainUnit(AdeptusCustodesOverall, "Vertus Praetors"),
        PlainUnit(AdeptusCustodesOverall, "Ares Gunship"),
        PlainUnit(AdeptusCustodesOverall, "Caladius Grav-Tank"),
        PlainUnit(AdeptusCustodesOverall, "Contemptor-Achillus Dreadnought"),
        PlainUnit(AdeptusCustodesOverall, "Contemptor-Galatus Dreadnought"),
        PlainUnit(AdeptusCustodesOverall, "Coronus Grav-Carrier"),
        PlainUnit(AdeptusCustodesOverall, "Orion Assault Dropship"),
        PlainUnit(AdeptusCustodesOverall, "Pallas Grav-Attack"),
        PlainUnit(AdeptusCustodesOverall, "Telemon Heavy Dreadnought"),
    ]);
}
