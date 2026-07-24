namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> SoulblightGravelordsOverall =
    [
        new("Bone & Skeletal Troops",
        [
            new("Basecoat", "Ushabti Bone"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Screaming Skull"),
        ]),
        new("Vampiric Robes & Armour",
        [
            new("Basecoat", "Abaddon Black"),
            new("Panel Layer", "Mephiston Red"),
            new("Glaze", "Carroburg Crimson", "deepens the red into the recesses"),
            new("Highlight", "Evil Sunz Scarlet"),
        ]),
        new("Metal Trim & Weapons",
        [
            new("Basecoat", "Leadbelcher"),
            new("Wash", "Nuln Oil"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildSoulblightGravelords() => new("Soulblight Gravelords",
    [
        new("Default Scheme", "The default and most iconic Soulblight palette — pale bone-white deathrattle troops serving alongside blood-red and black vampiric nobility. The deep red is built up from black rather than white, keeping the whole scheme dark, rich, and gothic.", SoulblightGravelordsOverall, IsScheme: true),

        new("Neferata, Mortarch of Blood", "The first vampire and Nagash's eternal rival — a striking centrepiece model dressed in regal dark reds and black with pale, deathly skin and ornate gold jewellery befitting a queen. Keep her skin noticeably paler and cooler than her mortal thralls to set her apart as an ancient, undying power.",
        [
            new("Pale Vampiric Skin",
            [
                new("Basecoat", "Rakarth Flesh"),
                new("Shade", "Druchii Violet", "thinned, cool undertone"),
                new("Highlight", "Pallid Wych Flesh"),
            ]),
            new("Regal Robes & Cloak",
            [
                new("Basecoat", "Abaddon Black"),
                new("Panel Layer", "Mephiston Red"),
                new("Glaze", "Carroburg Crimson"),
                new("Highlight", "Evil Sunz Scarlet"),
            ]),
            new("Gold Jewellery & Regalia",
            [
                new("Basecoat", "Retributor Armour"),
                new("Shade", "Reikland Fleshshade"),
                new("Highlight", "Auric Armour Gold"),
            ]),
            new("Base / Rims",
            [
                new("Rim", "Abaddon Black"),
                new("Basing", "Astrogranite Debris"),
            ]),
        ]),

        FactionUnit(SoulblightGravelordsOverall, "Skeleton Warriors", "Unit-Specific Details",
        [
            new("Weapon Blade", "Runefang Steel", "edge highlight"),
            new("Shield Rim", "Mephiston Red", "as Vampiric Robes scheme"),
        ]),

        FactionUnit(SoulblightGravelordsOverall, "Deadwalker Zombies", "Unit-Specific Details",
        [
            new("Rotten Flesh", "Rakarth Flesh", "Athonian Camoshade wash for a sickly, decaying tone"),
            new("Tattered Rags", "Dryad Bark"),
        ]),

        FactionUnit(SoulblightGravelordsOverall, "Grave Guard", "Unit-Specific Details",
        [
            new("Ancient Blade", "Runefang Steel", "edge highlight"),
            new("Banner", "Mephiston Red", "as Vampiric Robes scheme"),
        ]),

        FactionUnit(SoulblightGravelordsOverall, "Vargheists", "Unit-Specific Details",
        [
            new("Leathery Hide", "Dryad Bark", "Agrax Earthshade wash"),
            new("Claws & Fangs", "Screaming Skull", "as Bone scheme"),
        ]),

        FactionUnit(SoulblightGravelordsOverall, "Vampire Lord", "Unit-Specific Details",
        [
            new("Cloak & Armour", "Mephiston Red", "as Vampiric Robes scheme"),
            new("Blade", "Runefang Steel", "edge highlight"),
            new("Pale Skin", "Rakarth Flesh", "Druchii Violet wash"),
        ]),

        FactionUnit(SoulblightGravelordsOverall, "Blood Knights", "Mount-Specific Details",
        [
            new("Barded Steed", "Ushabti Bone", "as Bone & Skeletal Troops scheme"),
            new("Lance & Armour", "Runefang Steel", "edge highlight"),
            new("Cloak & Caparison", "Mephiston Red", "as Vampiric Robes scheme"),
        ]),
    ], Category: GuideCategory.Death, Game: Game.AgeOfSigmar);
}
