namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> GloomspiteGitzOverall =
    [
        new("Skin (Moon-Pale)",
        [
            new("Basecoat", "Warboss Green"),
            new("Shade", "Biel-Tan Green", "thin wash"),
            new("Layer", "Skarsnik Green"),
            new("Highlight", "Moot Green", "bright edges for a sickly moonlit pallor"),
        ]),
        new("Ragged Cloth & Robes",
        [
            new("Basecoat", "Steel Legion Drab"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Zandri Dust"),
        ]),
        new("Fungus & Toadstools",
        [
            new("Cap Basecoat", "Mephiston Red"),
            new("Cap Shade", "Druchii Violet", "recesses"),
            new("Spots", "Pallid Wych Flesh", "small dabbed spots on the caps"),
        ]),
        new("Squigs",
        [
            new("Fur / Hide", "Squig Orange"),
            new("Teeth & Claws", "Ushabti Bone"),
        ]),
        new("Metal & Crude Blades",
        [
            new("Basecoat", "Leadbelcher"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Ironbreaker"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Rhinox Hide"),
            new("Basing", "Stirland Mud", "with a few tufts of static grass and fungus growths"),
        ]),
    ];

    private static FactionGuide BuildGloomspiteGitz() => new("Gloomspite Gitz",
    [
        new("Overall (Head-to-Toe)", "The default scheme for the Bad Moon's own Gitz — moon-pale green skin, ragged fungal robes and mottled toadstool accents, all skulking under the glow of the Bad Moon.", GloomspiteGitzOverall, IsScheme: true),

        PlainUnit(GloomspiteGitzOverall, "Stabbas"),
        PlainUnit(GloomspiteGitzOverall, "Shootas"),

        FactionUnit(GloomspiteGitzOverall, "Squig Hoppers", "Unit-Specific Details",
        [
            new("Squig Body", "Squig Orange", "as Overall Squigs section"),
            new("Saddle & Reins", "Rhinox Hide", "Agrax Earthshade wash"),
        ]),

        PlainUnit(GloomspiteGitzOverall, "Squig Herd"),

        FactionUnit(GloomspiteGitzOverall, "Loonboss", "Unit-Specific Details",
        [
            new("Moonclan Icon / Totem", "Leadbelcher", "Nuln Oil shade, Ironbreaker edge highlight"),
            new("Cave Moss Trim", "Warboss Green", "Biel-Tan Green wash for a glowing fungal accent"),
        ]),

        FactionUnit(GloomspiteGitzOverall, "Fungoid Cave-Shaman", "Unit-Specific Details",
        [
            new("Mystic Fungus Staff Topper", "Mephiston Red", "Druchii Violet shade, Pallid Wych Flesh spots as Overall fungus section"),
            new("Spore Cloud", "Warpstone Glow", "thin glaze around the staff head"),
        ]),

        FactionUnit(GloomspiteGitzOverall, "Troggoths", "Unit-Specific Details",
        [
            new("Hide", "Rhinox Hide", "Agrax Earthshade wash, Tallarn Sand drybrush highlight"),
            new("Regenerating Wounds", "Mephiston Red", "wet-look glaze for fresh, sickly-glistening scars"),
        ]),

        FactionUnit(GloomspiteGitzOverall, "Mangler Squigs", "Unit-Specific Details",
        [
            new("Squig Bodies", "Squig Orange", "as Overall Squigs section"),
            new("Chains & Cage", "Leadbelcher", "Nuln Oil shade, Ironbreaker edge highlight"),
        ]),
    ], Category: GuideCategory.Destruction, Game: Game.AgeOfSigmar);
}
