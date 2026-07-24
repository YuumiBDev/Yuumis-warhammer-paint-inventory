namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> BladesOfKhorneOverall =
    [
        new("Skin / Flesh (Red)",
        [
            new("Basecoat", "Mephiston Red"),
            new("Recess Shade", "Carroburg Crimson"),
            new("Layer", "Wild Rider Red"),
            new("Edge Highlight", "Wazdakka Red"),
        ]),
        new("Armour & Trim (Brass)",
        [
            new("Basecoat", "Hashut Copper"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Sycorax Bronze"),
        ]),
        new("Weapons & Blood Effects",
        [
            new("Blade Edge", "Runefang Steel", "Nuln Oil recess"),
            new("Blood Effects", "Blood for the Blood God", "technical paint on axes, horns and bases"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Balthasar Gold"),
            new("Basing", "Astrogranite Debris", "with Blood for the Blood God technical splatter"),
        ]),
    ];

    private static FactionGuide BuildBladesOfKhorne() => new("Blades of Khorne",
    [
        new("Overall (Head-to-Toe)", "The default Blades of Khorne colour scheme — bloody red flesh, brass armour and weapons, finished with technical blood-effect paint. The Blood God accepts no half-measures.", BladesOfKhorneOverall, IsScheme: true),

        FactionUnit(BladesOfKhorneOverall, "Bloodletters", "Unit-Specific Details",
        [
            new("Hellblade", "Runefang Steel", "Nuln Oil recess, Stormhost Silver edge"),
            new("Horns", "Ushabti Bone", "Agrax Earthshade wash"),
        ]),

        FactionUnit(BladesOfKhorneOverall, "Bloodreavers", "Unit-Specific Details",
        [
            new("Fur Trophies", "Mournfang Brown", "Agrax Earthshade wash"),
            new("Reaver Blades", "Leadbelcher", "Nuln Oil wash"),
        ]),

        FactionUnit(BladesOfKhorneOverall, "Blood Warriors", "Unit-Specific Details",
        [
            new("Heavy Armour Plates", "Hashut Copper", "as Overall trim scheme"),
            new("Goreglaive Edge", "Runefang Steel", "Stormhost Silver edge highlight"),
        ]),

        FactionUnit(BladesOfKhorneOverall, "Skullreapers", "Unit-Specific Details",
        [
            new("Ensorcelled Weapons", "Runefang Steel", "Nuln Oil recess"),
            new("Skull Trophies", "Ushabti Bone", "Agrax Earthshade wash, Screaming Skull edge"),
        ]),

        FactionUnit(BladesOfKhorneOverall, "Wrath Of Khorne Bloodthirster", "Unit-Specific Details",
        [
            new("Wings", "Abaddon Black", "Mephiston Red membrane between the bones"),
            new("Axe / Whip", "Runefang Steel", "Nuln Oil recess, Stormhost Silver edge"),
            new("Brass Chains", "Hashut Copper", "as Overall trim scheme"),
        ]),

        FactionUnit(BladesOfKhorneOverall, "Skarr Bloodwrath", "Unit-Specific Details",
        [
            new("Axe of Khorne", "Runefang Steel", "Nuln Oil recess, Stormhost Silver edge"),
            new("Chain Leash", "Leadbelcher", "Nuln Oil wash"),
        ]),

        FactionUnit(BladesOfKhorneOverall, "Mighty Lord Of Khorne", "Unit-Specific Details",
        [
            new("Wargear", "Hashut Copper", "extra gilded trim for a champion of the Blood God"),
            new("Runeblade", "Runefang Steel", "Stormhost Silver edge, thin Blood for the Blood God on the edge"),
        ]),

        FactionUnit(BladesOfKhorneOverall, "Khorgoraths", "Unit-Specific Details",
        [
            new("Fused Flesh", "Mephiston Red", "as Overall skin scheme, patchy and uneven"),
            new("Bone Growths", "Ushabti Bone", "Agrax Earthshade wash"),
            new("Exposed Muscle", "Carroburg Crimson", "deep glaze in torn areas"),
        ]),
    ], Category: GuideCategory.Chaos, Game: Game.AgeOfSigmar);
}
