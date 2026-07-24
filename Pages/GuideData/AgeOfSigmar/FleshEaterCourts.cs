namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> FleshEaterCourtsOverall =
    [
        new("Corpse-Pale Skin",
        [
            new("Basecoat", "Rakarth Flesh"),
            new("Shade", "Athonian Camoshade", "sickly, corpse-like undertone"),
            new("Highlight", "Screaming Skull"),
        ]),
        new("Regal Robes & Cloth",
        [
            new("Basecoat", "Xereus Purple"),
            new("Shade", "Druchii Violet"),
            new("Highlight", "Genestealer Purple"),
        ]),
        new("Gold Armour & Regalia",
        [
            new("Basecoat", "Retributor Armour"),
            new("Shade", "Reikland Fleshshade"),
            new("Highlight", "Auric Armour Gold"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Astrogranite Debris", "drybrushed with Screaming Skull for scattered bone scraps"),
        ]),
    ];

    private static FactionGuide BuildFleshEaterCourts() => new("Flesh-eater Courts",
    [
        new("Default Scheme", "The default and most iconic Flesh-eater Courts palette — regal purple and gold finery as the delusional ghouls perceive themselves, draped over corpse-pale, sickly flesh. Keep the purple and gold rich and noble on the trim, while the skin stays cold and unhealthy — the contrast is the whole point of the faction's delusion.", FleshEaterCourtsOverall, IsScheme: true),

        new("Abhorrant Ghoul King", "The delusional monarch of a Flesh-eater Court, believing himself a true and noble king — a striking centrepiece model in ragged finery his subjects perceive as royal regalia. Push the gold and purple further than on rank-and-file ghouls to reflect his exalted (if imagined) status.",
        [
            new("Corpse-Pale Skin",
            [
                new("Basecoat", "Rakarth Flesh"),
                new("Shade", "Athonian Camoshade"),
                new("Highlight", "Screaming Skull"),
            ]),
            new("Regal Robes & Cloak",
            [
                new("Basecoat", "Xereus Purple"),
                new("Shade", "Druchii Violet"),
                new("Highlight", "Genestealer Purple"),
            ]),
            new("Gold Crown & Regalia",
            [
                new("Basecoat", "Retributor Armour"),
                new("Shade", "Reikland Fleshshade"),
                new("Highlight", "Auric Armour Gold"),
            ]),
            new("Base / Rims",
            [
                new("Rim", "Abaddon Black"),
                new("Basing", "Astrogranite Debris", "drybrushed with Screaming Skull"),
            ]),
        ]),

        FactionUnit(FleshEaterCourtsOverall, "Crypt Ghouls", "Unit-Specific Details",
        [
            new("Claws & Fangs", "Screaming Skull", "as skin highlight"),
            new("Ragged Wrappings", "Xereus Purple", "as Regal Robes scheme, the ghouls' delusion of finery"),
        ]),

        FactionUnit(FleshEaterCourtsOverall, "Crypt Horrors", "Unit-Specific Details",
        [
            new("Bloated Flesh", "Rakarth Flesh", "as Corpse-Pale Skin scheme"),
            new("Claws", "Screaming Skull"),
        ]),

        FactionUnit(FleshEaterCourtsOverall, "Crypt Flayers", "Unit-Specific Details",
        [
            new("Wing Membrane", "Druchii Violet", "thinned glaze over Rakarth Flesh base"),
            new("Claws & Talons", "Screaming Skull"),
        ]),

        FactionUnit(FleshEaterCourtsOverall, "Royal Terrorgheist", "Beast-Specific Details",
        [
            new("Leathery Hide", "Dryad Bark", "Agrax Earthshade wash"),
            new("Wing Membrane", "Druchii Violet", "thinned glaze"),
            new("Exposed Ribs & Fangs", "Screaming Skull", "as skin scheme"),
        ]),

        FactionUnit(FleshEaterCourtsOverall, "Varghulf Courtier", "Beast-Specific Details",
        [
            new("Hide", "Rakarth Flesh", "as Corpse-Pale Skin scheme"),
            new("Claws & Talons", "Screaming Skull"),
            new("Torn Cloak Remnants", "Xereus Purple", "as Regal Robes scheme"),
        ]),
    ], Category: GuideCategory.Death, Game: Game.AgeOfSigmar);
}
