namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> HedonitesOfSlaaneshOverall =
    [
        new("Skin (Pastel Flesh)",
        [
            new("Basecoat", "Pallid Wych Flesh"),
            new("Shade", "Druchii Violet", "very thin glaze for a cold pastel tint"),
            new("Highlight", "White Scar"),
        ]),
        new("Armour & Trim (Purple)",
        [
            new("Basecoat", "Xereus Purple"),
            new("Recess Shade", "Druchii Violet"),
            new("Layer", "Genestealer Purple"),
            new("Edge Highlight", "Screamer Pink"),
        ]),
        new("Gold Details",
        [
            new("Basecoat", "Auric Armour Gold"),
            new("Shade", "Reikland Fleshshade"),
            new("Edge Highlight", "Sycorax Bronze"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Auric Armour Gold"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildHedonitesOfSlaanesh() => new("Hedonites of Slaanesh",
    [
        new("Overall (Head-to-Toe)", "The default Hedonites of Slaanesh colour scheme — pale pastel flesh, rich purple armour and pink highlights, finished in gilded gold trim. A scheme built for decadent, excessive spectacle.", HedonitesOfSlaaneshOverall, IsScheme: true),

        FactionUnit(HedonitesOfSlaaneshOverall, "Daemonettes", "Unit-Specific Details",
        [
            new("Skin", "Pallid Wych Flesh", "as Overall skin scheme"),
            new("Claws", "Xereus Purple", "as Overall armour scheme"),
            new("Hair", "Screamer Pink"),
        ]),

        FactionUnit(HedonitesOfSlaaneshOverall, "Blissbarb Archers", "Unit-Specific Details",
        [
            new("Skin", "Pallid Wych Flesh", "as Overall skin scheme"),
            new("Bow / Barbs", "Auric Armour Gold", "as Overall gold scheme"),
            new("Robes", "Xereus Purple", "as Overall armour scheme"),
        ]),

        FactionUnit(HedonitesOfSlaaneshOverall, "Slickblade Seekers", "Unit-Specific Details",
        [
            new("Steed Hide", "Pallid Wych Flesh", "as Overall skin scheme"),
            new("Steed Barding", "Xereus Purple", "as Overall armour scheme"),
            new("Blades", "Runefang Steel", "Nuln Oil recess"),
        ]),

        FactionUnit(HedonitesOfSlaaneshOverall, "Keeper Of Secrets", "Unit-Specific Details",
        [
            new("Skin", "Pallid Wych Flesh", "as Overall skin scheme, largest surface for smooth blending"),
            new("Armour Plates", "Xereus Purple", "as Overall armour scheme"),
            new("Glaive", "Auric Armour Gold", "Reikland Fleshshade wash"),
        ]),

        FactionUnit(HedonitesOfSlaaneshOverall, "Shalaxi Helbane", "Unit-Specific Details",
        [
            new("Skin", "Pallid Wych Flesh", "as Overall skin scheme"),
            new("Armour", "Xereus Purple", "as Overall armour scheme"),
            new("Twin Blades", "Runefang Steel", "Nuln Oil recess, Stormhost Silver edge"),
        ]),

        FactionUnit(HedonitesOfSlaaneshOverall, "Fiends", "Unit-Specific Details",
        [
            new("Hide", "Pallid Wych Flesh", "as Overall skin scheme"),
            new("Tail Blades", "Xereus Purple", "as Overall armour scheme"),
            new("Claws", "Auric Armour Gold"),
        ]),

        FactionUnit(HedonitesOfSlaaneshOverall, "Contorted Epitome", "Unit-Specific Details",
        [
            new("Skin", "Pallid Wych Flesh", "as Overall skin scheme"),
            new("Mirror Shards", "Runefang Steel", "Stormhost Silver edge for a reflective finish"),
            new("Robes", "Xereus Purple", "as Overall armour scheme"),
        ]),
    ], Category: GuideCategory.Chaos, Game: Game.AgeOfSigmar);
}
