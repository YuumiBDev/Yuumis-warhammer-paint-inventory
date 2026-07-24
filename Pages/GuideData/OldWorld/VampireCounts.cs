namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> VampireCountsOverall =
    [
        new("Armour & Cloth (Black)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Layer", "Eshin Grey", "drybrush"),
            new("Edge Highlight", "Dawnstone"),
        ]),
        new("Accent (Purple)",
        [
            new("Basecoat", "Xereus Purple"),
            new("Shade", "Druchii Violet"),
            new("Edge Highlight", "Genestealer Purple"),
        ]),
        new("Bone & Undead Flesh",
        [
            new("Basecoat", "Ushabti Bone"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Screaming Skull"),
        ]),
        new("Metal & Trim",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Runefang Steel"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static FactionGuide BuildVampireCounts() => new("Vampire Counts",
    [
        new("Gothic Black & Purple", "The default and most iconic look — funereal black armour and cloth with a deep purple accent, worn over bleached bone and rotting flesh raised from the grave.", VampireCountsOverall, IsScheme: true),

        FactionUnit(VampireCountsOverall, "Zombies", "Unit-Specific Details",
        [
            new("Rotting Flesh", "Death Guard Green", "Agrax Earthshade wash"),
            new("Tattered Grave Clothes", "Dryad Bark"),
        ]),

        FactionUnit(VampireCountsOverall, "Skeleton Warriors", "Unit-Specific Details",
        [
            new("Bone", "Ushabti Bone", "as Overall"),
            new("Ancient Weapon", "Leadbelcher", "Nuln Oil wash"),
        ]),

        FactionUnit(VampireCountsOverall, "Grave Guard", "Unit-Specific Details",
        [
            new("Heavy Armour", "Abaddon Black", "Eshin Grey drybrush, as Overall"),
            new("Halberd Blade", "Runefang Steel"),
        ]),

        FactionUnit(VampireCountsOverall, "Black Knights", "Mount-Specific Details",
        [
            new("Barded Skeletal Steed", "Ushabti Bone", "Agrax Earthshade wash"),
            new("Lance", "Runefang Steel"),
        ]),

        FactionUnit(VampireCountsOverall, "Vampire Lord", "Unit-Specific Details",
        [
            new("Cloak", "Xereus Purple", "Genestealer Purple edge"),
            new("Armour", "Abaddon Black", "Dawnstone highlight"),
            new("Blade", "Runefang Steel"),
        ]),

        FactionUnit(VampireCountsOverall, "Necromancer", "Unit-Specific Details",
        [
            new("Robes", "Xereus Purple", "Druchii Violet shade"),
            new("Staff Head Glow", "Sybarite Green"),
        ]),

        FactionUnit(VampireCountsOverall, "Varghulf", "Unit-Specific Details",
        [
            new("Hide", "Dryad Bark", "Agrax Earthshade wash"),
            new("Claws & Fangs", "Ushabti Bone", "Screaming Skull highlight"),
        ]),
    ], Category: GuideCategory.All, Game: Game.OldWorld);
}
