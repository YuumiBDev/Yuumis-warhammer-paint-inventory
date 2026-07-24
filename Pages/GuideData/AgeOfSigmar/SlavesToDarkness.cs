namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    // Slaves to Darkness field warbands under any of the four Chaos Gods, or march
    // undivided under no single banner — the Undivided steel/silver scheme below is
    // the default and most common colour scheme, with the four godly alignments
    // selectable alongside it; unit entries below stay on whichever scheme is selected.
    private static readonly List<Section> SlavesToDarknessUndivided =
    [
        new("Armour (Steel)",
        [
            new("Basecoat", "Leadbelcher"),
            new("Recess Shade", "Nuln Oil"),
            new("Layer", "Runefang Steel"),
            new("Edge Highlight", "Stormhost Silver"),
        ]),
        new("Leather & Straps",
        [
            new("Basecoat", "Mournfang Brown"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Doombull Brown"),
        ]),
        new("Trim & Icons (Bronze)",
        [
            new("Basecoat", "Warplock Bronze"),
            new("Shade", "Reikland Fleshshade"),
            new("Edge Highlight", "Sycorax Bronze"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Warplock Bronze"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static readonly List<Section> SlavesToDarknessKhorne =
    [
        new("Armour (Red)",
        [
            new("Basecoat", "Khorne Red"),
            new("Recess Shade", "Carroburg Crimson"),
            new("Layer", "Evil Sunz Scarlet"),
            new("Edge Highlight", "Wazdakka Red"),
        ]),
        new("Trim & Horns (Brass)",
        [
            new("Basecoat", "Hashut Copper"),
            new("Shade", "Agrax Earthshade"),
            new("Edge Highlight", "Sycorax Bronze"),
        ]),
        new("Details",
        [
            new("Leather", "Abaddon Black"),
            new("Skulls", "Ushabti Bone", "Agrax Earthshade wash"),
            new("Blood Effects", "Blood for the Blood God", "technical paint on blades and bases"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Balthasar Gold"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static readonly List<Section> SlavesToDarknessTzeentch =
    [
        new("Armour (Blue)",
        [
            new("Basecoat", "Kantor Blue"),
            new("Recess Shade", "Drakenhof Nightshade"),
            new("Layer", "Teclis Blue"),
            new("Edge Highlight", "Lothern Blue"),
        ]),
        new("Trim & Gold",
        [
            new("Basecoat", "Auric Armour Gold"),
            new("Shade", "Reikland Fleshshade"),
            new("Edge Highlight", "Sycorax Bronze"),
        ]),
        new("Sorcerous Details (Pink)",
        [
            new("Flames / Script", "Screamer Pink", "thin glaze over gold trim for an arcane glow"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Auric Armour Gold"),
            new("Basing", "Astrogranite Debris"),
        ]),
    ];

    private static readonly List<Section> SlavesToDarknessNurgle =
    [
        new("Armour (Sickly Green)",
        [
            new("Basecoat", "Elysian Green"),
            new("Recess Shade", "Biel-Tan Green", "thinned wash for a diseased tint"),
            new("Layer", "Nurgling Green"),
            new("Edge Highlight", "Pallid Wych Flesh"),
        ]),
        new("Rusted Metal",
        [
            new("Basecoat", "Rhinox Hide"),
            new("Rust Texture", "Typhus Corrosion", "technical paint stippled onto edges and rivets"),
            new("Edge Highlight", "Runefang Steel"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Typhus Corrosion"),
            new("Basing", "Astrogranite Debris", "with Nurgle's Rot technical paint for slime"),
        ]),
    ];

    private static readonly List<Section> SlavesToDarknessSlaanesh =
    [
        new("Armour (Purple)",
        [
            new("Basecoat", "Xereus Purple"),
            new("Recess Shade", "Druchii Violet"),
            new("Layer", "Genestealer Purple"),
            new("Edge Highlight", "Screamer Pink"),
        ]),
        new("Trim & Gold",
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

    private static FactionGuide BuildSlavesToDarkness() => new("Slaves to Darkness",
    [
        new("Undivided", "The default and most common Slaves to Darkness colour scheme — dull steel plate armour, dark leather and bronze trim, marching under no single Chaos God's banner.", SlavesToDarknessUndivided, IsScheme: true),
        new("Khorne-Aligned", "A warband devoted to the Blood God — deep red armour, brass trim and skull icons, blood-slicked blades.", SlavesToDarknessKhorne, IsScheme: true),
        new("Tzeentch-Aligned", "A warband devoted to the Great Conspirator — blue armour, gilded trim and pink sorcerous script for an arcane, ever-shifting look.", SlavesToDarknessTzeentch, IsScheme: true),
        new("Nurgle-Aligned", "A warband devoted to the Plague God — sickly green armour over rusted, corroded metal, thoroughly diseased and decaying.", SlavesToDarknessNurgle, IsScheme: true),
        new("Slaanesh-Aligned", "A warband devoted to the Dark Prince — rich purple armour with pastel-pink highlights and gilded trim for a decadent, excessive look.", SlavesToDarknessSlaanesh, IsScheme: true),

        FactionUnit(SlavesToDarknessUndivided, "Chaos Warriors", "Unit-Specific Details",
        [
            new("Shield Face", "Warplock Bronze", "or paint a freehand icon of your chosen god"),
            new("Blade Edge", "Stormhost Silver"),
        ]),

        FactionUnit(SlavesToDarknessUndivided, "Chaos Knights", "Unit-Specific Details",
        [
            new("Steed Barding", "Leadbelcher", "as body armour scheme"),
            new("Daemonic Hooves / Fangs", "Ushabti Bone", "Agrax Earthshade wash"),
            new("Steed Hide", "Rhinox Hide", "Agrax Earthshade wash, Doombull Brown drybrush"),
        ]),

        FactionUnit(SlavesToDarknessUndivided, "Chaos Chosen", "Unit-Specific Details",
        [
            new("Additional Trophies", "Ushabti Bone", "Agrax Earthshade wash for veteran trophy racks"),
            new("Extra Gilding", "Auric Armour Gold", "extra edge pass to mark these as elite champions"),
        ]),

        FactionUnit(SlavesToDarknessUndivided, "Varanguard", "Unit-Specific Details",
        [
            new("Dorghar Steed Hide", "Rhinox Hide", "Agrax Earthshade wash, drybrush highlight"),
            new("Steed Barding", "Leadbelcher", "as rider armour scheme"),
            new("Weapon Runes", "Screamer Pink", "or a god-appropriate glow colour"),
        ]),

        FactionUnit(SlavesToDarknessUndivided, "Chaos Sorcerer Lord", "Unit-Specific Details",
        [
            new("Staff Head", "Leadbelcher", "Nuln Oil wash, Stormhost Silver edge"),
            new("Arcane Glow", "Screamer Pink", "thin glaze on staff head and tome pages"),
            new("Tome / Grimoire", "Mournfang Brown", "Agrax Earthshade wash"),
        ]),

        FactionUnit(SlavesToDarknessUndivided, "Archaon the Everchosen", "Unit-Specific Details",
        [
            new("Armour", "Abaddon Black", "the Everchosen's own bespoke black-and-gold scheme, distinct from the warband Overall"),
            new("Gilded Trim", "Auric Armour Gold", "Reikland Fleshshade wash, Sycorax Bronze edge"),
            new("Slayer of Kings Blade", "Runefang Steel", "Nuln Oil recess, Stormhost Silver edge"),
            new("Dorghar's Three Heads", "Rhinox Hide", "Agrax Earthshade wash, bone-white fangs"),
        ]),

        FactionUnit(SlavesToDarknessUndivided, "Gorebeast Chariot", "Vehicle-Specific Details",
        [
            new("Chariot Hull", "Leadbelcher", "as Overall armour scheme"),
            new("Gorebeast Hide", "Rhinox Hide", "Agrax Earthshade wash, Doombull Brown drybrush highlight"),
            new("Gorebeast Horns / Tusks", "Ushabti Bone", "Agrax Earthshade wash"),
        ]),
    ], Category: GuideCategory.Chaos, Game: Game.AgeOfSigmar);
}
