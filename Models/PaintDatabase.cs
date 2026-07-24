public static class PaintDatabase
{
    // Paints in category order (Base → Layer → Contrast → Dry → Technical → Shade)
    // Within each category: alphabetical
    // Rack layout is configurable (see RackSettings) — defaults to 12 rows x 6 columns = 72 slots per rack
    // Fill order: Rack 1 Row 1 Col 1-N, Row 2 Col 1-N ... last row, then Rack 2, etc.

    private static readonly (string Name, PaintCategory Category)[] PaintList =
    [
        // ── BASE (57) ────────────────────────────────────────────────────────────
        ("Abaddon Black",            PaintCategory.Base),
        ("Averland Sunset",          PaintCategory.Base),
        ("Balthasar Gold",           PaintCategory.Base),
        ("Barak-Nar Burgundy",       PaintCategory.Base),
        ("Bugman's Glow",            PaintCategory.Base),
        ("Caledor Sky",              PaintCategory.Base),
        ("Caliban Green",            PaintCategory.Base),
        ("Castellan Green",          PaintCategory.Base),
        ("Catachan Flesh",           PaintCategory.Base),
        ("Celestra Grey",            PaintCategory.Base),
        ("Corax White",              PaintCategory.Base),
        ("Corvus Black",             PaintCategory.Base),
        ("Daemonette Hide",          PaintCategory.Base),
        ("Death Guard Green",        PaintCategory.Base),
        ("Death Korps Drab",         PaintCategory.Base),
        ("Deathworld Forest",        PaintCategory.Base),
        ("Dryad Bark",               PaintCategory.Base),
        ("Gal Vorbak Red",           PaintCategory.Base),
        ("Grey Knights Steel",       PaintCategory.Base),
        ("Grey Seer",                PaintCategory.Base),
        ("Hobgrot Hide",             PaintCategory.Base),
        ("Incubi Darkness",          PaintCategory.Base),
        ("Ionrach Skin",             PaintCategory.Base),
        ("Iron Hands Steel",         PaintCategory.Base),
        ("Iron Warriors",            PaintCategory.Base),
        ("Jokaero Orange",           PaintCategory.Base),
        ("Kantor Blue",              PaintCategory.Base),
        ("Khorne Red",               PaintCategory.Base),
        ("Leadbelcher",              PaintCategory.Base),
        ("Lupercal Green",           PaintCategory.Base),
        ("Macragge Blue",            PaintCategory.Base),
        ("Mechanicus Standard Grey", PaintCategory.Base),
        ("Mephiston Red",            PaintCategory.Base),
        ("Morghast Bone",            PaintCategory.Base),
        ("Mournfang Brown",          PaintCategory.Base),
        ("Naggaroth Night",          PaintCategory.Base),
        ("Night Lords Blue",         PaintCategory.Base),
        ("Nocturne Green",           PaintCategory.Base),
        ("Orruk Flesh",              PaintCategory.Base),
        ("Phoenician Purple",        PaintCategory.Base),
        ("Rakarth Flesh",            PaintCategory.Base),
        ("Ratskin Flesh",            PaintCategory.Base),
        ("Retributor Armour",        PaintCategory.Base),
        ("Rhinox Hide",              PaintCategory.Base),
        ("Runelord Brass",           PaintCategory.Base),
        ("Screamer Pink",            PaintCategory.Base),
        ("Screaming Bell",           PaintCategory.Base),
        ("Steel Legion Drab",        PaintCategory.Base),
        ("Stegadon Scale Green",     PaintCategory.Base),
        ("The Fang",                 PaintCategory.Base),
        ("Thondia Brown",            PaintCategory.Base),
        ("Thousand Sons Blue",       PaintCategory.Base),
        ("Waaagh! Flesh",            PaintCategory.Base),
        ("Warplock Bronze",          PaintCategory.Base),
        ("Wraithbone",               PaintCategory.Base),
        ("XV-88",                    PaintCategory.Base),
        ("Zandri Dust",              PaintCategory.Base),

        // ── LAYER (93) ───────────────────────────────────────────────────────────
        ("Administratum Grey",   PaintCategory.Layer),
        ("Ahriman Blue",         PaintCategory.Layer),
        ("Alaitoc Blue",         PaintCategory.Layer),
        ("Altdorf Guard Blue",   PaintCategory.Layer),
        ("Auric Armour Gold",    PaintCategory.Layer),
        ("Baharroth Blue",       PaintCategory.Layer),
        ("Balor Brown",          PaintCategory.Layer),
        ("Baneblade Brown",      PaintCategory.Layer),
        ("Bestigor Flesh",       PaintCategory.Layer),
        ("Bloodreaver Flesh",    PaintCategory.Layer),
        ("Blue Horror",          PaintCategory.Layer),
        ("Brass Scorpion",       PaintCategory.Layer),
        ("Cadian Fleshtone",     PaintCategory.Layer),
        ("Calgar Blue",          PaintCategory.Layer),
        ("Canoptek Alloy",       PaintCategory.Layer),
        ("Castellax Bronze",     PaintCategory.Layer),
        ("Dark Reaper",          PaintCategory.Layer),
        ("Dawnstone",            PaintCategory.Layer),
        ("Deathclaw Brown",      PaintCategory.Layer),
        ("Dechala Lilac",        PaintCategory.Layer),
        ("Deepkin Flesh",        PaintCategory.Layer),
        ("Doombull Brown",       PaintCategory.Layer),
        ("Dorn Yellow",          PaintCategory.Layer),
        ("Elysian Green",        PaintCategory.Layer),
        ("Emperor's Children",   PaintCategory.Layer),
        ("Eshin Grey",           PaintCategory.Layer),
        ("Evil Sunz Scarlet",    PaintCategory.Layer),
        ("Fenrisian Grey",       PaintCategory.Layer),
        ("Fire Dragon Bright",   PaintCategory.Layer),
        ("Flash Gitz Yellow",    PaintCategory.Layer),
        ("Flayed One Flesh",     PaintCategory.Layer),
        ("Fulgrim Pink",         PaintCategory.Layer),
        ("Fulgurite Copper",     PaintCategory.Layer),
        ("Gauss Blaster Green",  PaintCategory.Layer),
        ("Gehenna's Gold",       PaintCategory.Layer),
        ("Genestealer Purple",   PaintCategory.Layer),
        ("Gorthor Brown",        PaintCategory.Layer),
        ("Hashut Copper",        PaintCategory.Layer),
        ("Hoeth Blue",           PaintCategory.Layer),
        ("Ironbreaker",          PaintCategory.Layer),
        ("Kabalite Green",       PaintCategory.Layer),
        ("Kakophoni Purple",     PaintCategory.Layer),
        ("Karak Stone",          PaintCategory.Layer),
        ("Kislev Flesh",         PaintCategory.Layer),
        ("Knight-Questor Flesh", PaintCategory.Layer),
        ("Krieg Khaki",          PaintCategory.Layer),
        ("Liberator Gold",       PaintCategory.Layer),
        ("Loren Forest",         PaintCategory.Layer),
        ("Lothern Blue",         PaintCategory.Layer),
        ("Lugganath Orange",     PaintCategory.Layer),
        ("Moot Green",           PaintCategory.Layer),
        ("Nurgling Green",       PaintCategory.Layer),
        ("Ogryn Camo",           PaintCategory.Layer),
        ("Pallid Wych Flesh",    PaintCategory.Layer),
        ("Phalanx Yellow",       PaintCategory.Layer),
        ("Pink Horror",          PaintCategory.Layer),
        ("Runefang Steel",       PaintCategory.Layer),
        ("Russ Grey",            PaintCategory.Layer),
        ("Screaming Skull",      PaintCategory.Layer),
        ("Skarsnik Green",       PaintCategory.Layer),
        ("Skavenblight Dinge",   PaintCategory.Layer),
        ("Skrag Brown",          PaintCategory.Layer),
        ("Skullcrusher Brass",   PaintCategory.Layer),
        ("Slaanesh Grey",        PaintCategory.Layer),
        ("Sotek Green",          PaintCategory.Layer),
        ("Sons of Horus Green",  PaintCategory.Layer),
        ("Squig Orange",         PaintCategory.Layer),
        ("Stormhost Silver",     PaintCategory.Layer),
        ("Stormvermin Fur",      PaintCategory.Layer),
        ("Straken Green",        PaintCategory.Layer),
        ("Sybarite Green",       PaintCategory.Layer),
        ("Sycorax Bronze",       PaintCategory.Layer),
        ("Tallarn Sand",         PaintCategory.Layer),
        ("Tau Light Ochre",      PaintCategory.Layer),
        ("Teclis Blue",          PaintCategory.Layer),
        ("Temple Guard Blue",    PaintCategory.Layer),
        ("Thunderhawk Blue",     PaintCategory.Layer),
        ("Troll Slayer Orange",  PaintCategory.Layer),
        ("Tuskgor Fur",          PaintCategory.Layer),
        ("Ulthuan Grey",         PaintCategory.Layer),
        ("Ungor Flesh",          PaintCategory.Layer),
        ("Ushabti Bone",         PaintCategory.Layer),
        ("Vulkan Green",         PaintCategory.Layer),
        ("Warboss Green",        PaintCategory.Layer),
        ("Warpfiend Grey",       PaintCategory.Layer),
        ("Warpstone Glow",       PaintCategory.Layer),
        ("Wazdakka Red",         PaintCategory.Layer),
        ("White Scar",           PaintCategory.Layer),
        ("Wild Rider Red",       PaintCategory.Layer),
        ("Word Bearers Red",     PaintCategory.Layer),
        ("Xereus Purple",        PaintCategory.Layer),
        ("Yriel Yellow",         PaintCategory.Layer),
        ("Zamesi Desert",        PaintCategory.Layer),

        // ── CONTRAST (61) ────────────────────────────────────────────────────────
        ("Aeldari Emerald",          PaintCategory.Contrast),
        ("Aethermatic Blue",         PaintCategory.Contrast),
        ("Aggaros Dunes",            PaintCategory.Contrast),
        ("Akhelian Green",           PaintCategory.Contrast),
        ("Apothecary White",         PaintCategory.Contrast),
        ("Asurmen Blue",             PaintCategory.Contrast),
        ("Bad Moon Yellow",          PaintCategory.Contrast),
        ("Baal Red",                 PaintCategory.Contrast),
        ("Basilicanum Grey",         PaintCategory.Contrast),
        ("Black Legion",             PaintCategory.Contrast),
        ("Black Templar",            PaintCategory.Contrast),
        ("Blood Angels Red",         PaintCategory.Contrast),
        ("Briar Queen Chill",        PaintCategory.Contrast),
        ("Celestium Blue",           PaintCategory.Contrast),
        ("Creed Camo",               PaintCategory.Contrast),
        ("Cygor Brown",              PaintCategory.Contrast),
        ("Dark Angels Green",        PaintCategory.Contrast),
        ("Darkoath Flesh",           PaintCategory.Contrast),
        ("Doomfire Magenta",         PaintCategory.Contrast),
        ("Dreadful Visage",          PaintCategory.Contrast),
        ("Flesh Tearers Red",        PaintCategory.Contrast),
        ("Frostheart",               PaintCategory.Contrast),
        ("Fyreslayer Flesh",         PaintCategory.Contrast),
        ("Garaghak's Sewer",         PaintCategory.Contrast),
        ("Gore-Grunta Fur",          PaintCategory.Contrast),
        ("Gryph-Charger Grey",       PaintCategory.Contrast),
        ("Gryph-Hound Orange",       PaintCategory.Contrast),
        ("Guilliman Flesh",          PaintCategory.Contrast),
        ("Gutrippa Flesh",           PaintCategory.Contrast),
        ("Hexwraith Flame",          PaintCategory.Contrast),
        ("Imperial Fist",            PaintCategory.Contrast),
        ("Ironjawz Yellow",          PaintCategory.Contrast),
        ("Iyanden Yellow",           PaintCategory.Contrast),
        ("Karandras Green",          PaintCategory.Contrast),
        ("Kroxigor Scales",          PaintCategory.Contrast),
        ("Leviathan Purple",         PaintCategory.Contrast),
        ("Leviadon Blue",            PaintCategory.Contrast),
        ("Luxion Purple",            PaintCategory.Contrast),
        ("Magmadroth Flame",         PaintCategory.Contrast),
        ("Magos Purple",             PaintCategory.Contrast),
        ("Mantis Warriors Green",    PaintCategory.Contrast),
        ("Militarum Green",          PaintCategory.Contrast),
        ("Nazdreg Yellow",           PaintCategory.Contrast),
        ("Nighthaunt Gloom",         PaintCategory.Contrast),
        ("Ork Flesh",                PaintCategory.Contrast),
        ("Plaguebearer Flesh",       PaintCategory.Contrast),
        ("Pylar Glacier",            PaintCategory.Contrast),
        ("Ratling Grime",            PaintCategory.Contrast),
        ("Shyish Purple",            PaintCategory.Contrast),
        ("Sigvald Burgundy",         PaintCategory.Contrast),
        ("Skeleton Horde",           PaintCategory.Contrast),
        ("Snakebite Leather",        PaintCategory.Contrast),
        ("Space Wolves Grey",        PaintCategory.Contrast),
        ("Stormfiend",               PaintCategory.Contrast),
        ("Striking Scorpion Green",  PaintCategory.Contrast),
        ("Talassar Blue",            PaintCategory.Contrast),
        ("Terradon Turquoise",       PaintCategory.Contrast),
        ("Ultramarines Blue",        PaintCategory.Contrast),
        ("Volupus Pink",             PaintCategory.Contrast),
        ("Warp Lightning",           PaintCategory.Contrast),
        ("Wyldwood",                 PaintCategory.Contrast),

        // ── DRY (26) ─────────────────────────────────────────────────────────────
        ("Astorath Red",      PaintCategory.Dry),
        ("Changeling Pink",   PaintCategory.Dry),
        ("Chronus Blue",      PaintCategory.Dry),
        ("Eldar Flesh",       PaintCategory.Dry),
        ("Etherium Blue",     PaintCategory.Dry),
        ("Golden Griffon",    PaintCategory.Dry),
        ("Golgfag Brown",     PaintCategory.Dry),
        ("Hellion Green",     PaintCategory.Dry),
        ("Hexos Palesun",     PaintCategory.Dry),
        ("Imrik Blue",        PaintCategory.Dry),
        ("Kindleflame",       PaintCategory.Dry),
        ("Longbeard Grey",    PaintCategory.Dry),
        ("Lucius Lilac",      PaintCategory.Dry),
        ("Necron Compound",   PaintCategory.Dry),
        ("Niblet Green",      PaintCategory.Dry),
        ("Praxeti White",     PaintCategory.Dry),
        ("Ryza Rust",         PaintCategory.Dry),
        ("Sigmarite",         PaintCategory.Dry),
        ("Skink Blue",        PaintCategory.Dry),
        ("Stormfang",         PaintCategory.Dry),
        ("Sylvaneth Bark",    PaintCategory.Dry),
        ("Terminatus Stone",  PaintCategory.Dry),
        ("Tyrant Skull",      PaintCategory.Dry),
        ("Underhive Ash",     PaintCategory.Dry),
        ("Verminlord Hide",   PaintCategory.Dry),
        ("Wrack White",       PaintCategory.Dry),
        // These 3 share a name with an existing Layer paint (distinct product,
        // same name) — prefixed to avoid colliding with the Layer entry's row.
        ("Dry: Dawnstone",       PaintCategory.Dry),
        ("Dry: Hoeth Blue",      PaintCategory.Dry),
        ("Dry: Nurgling Green",  PaintCategory.Dry),

        // ── TECHNICAL (21) ───────────────────────────────────────────────────────
        ("'Ardcoat",                 PaintCategory.Technical),
        ("Agrellan Badland",         PaintCategory.Technical),
        ("Agrellan Earth",           PaintCategory.Technical),
        ("Armageddon Dust",          PaintCategory.Technical),
        ("Astrogranite",             PaintCategory.Technical),
        ("Blood for the Blood God",  PaintCategory.Technical),
        ("Contrast Medium",          PaintCategory.Technical),
        ("Lahmian Medium",           PaintCategory.Technical),
        ("Martian Ironcrust",        PaintCategory.Technical),
        ("Martian Ironearth",        PaintCategory.Technical),
        ("Mordant Earth",            PaintCategory.Technical),
        ("Nihilakh Oxide",           PaintCategory.Technical),
        ("Nurgle's Rot",             PaintCategory.Technical),
        ("Soulstone Blue",           PaintCategory.Technical),
        ("Spiritstone Red",          PaintCategory.Technical),
        ("Stirland Mud",             PaintCategory.Technical),
        ("Stormshield",              PaintCategory.Technical),
        ("Tesseract Glow",           PaintCategory.Technical),
        ("Typhus Corrosion",         PaintCategory.Technical),
        ("Valhallan Blizzard",       PaintCategory.Technical),
        ("Waystone Green",           PaintCategory.Technical),

        // ── SHADE (19) ───────────────────────────────────────────────────────────
        ("Agrax Earthshade",     PaintCategory.Shade),
        ("Athonian Camoshade",   PaintCategory.Shade),
        ("Berserker Bloodshade", PaintCategory.Shade),
        ("Biel-Tan Green",       PaintCategory.Shade),
        ("Carroburg Crimson",    PaintCategory.Shade),
        ("Casandora Yellow",     PaintCategory.Shade),
        ("Coelia Greenshade",    PaintCategory.Shade),
        ("Drakenhof Nightshade", PaintCategory.Shade),
        ("Druchii Violet",       PaintCategory.Shade),
        ("Fuegan Orange",        PaintCategory.Shade),
        ("Kroak Green",          PaintCategory.Shade),
        ("Mortarion Grime",      PaintCategory.Shade),
        ("Nuln Oil",             PaintCategory.Shade),
        ("Poxwalker",            PaintCategory.Shade),
        ("Reikland Fleshshade",  PaintCategory.Shade),
        ("Seraphim Sepia",       PaintCategory.Shade),
        ("Soulblight Grey",      PaintCategory.Shade),
        ("Targor Rageshade",     PaintCategory.Shade),
        ("Tyran Blue",           PaintCategory.Shade),

        // ── AIR (45) ─────────────────────────────────────────────────────────────
        // Many Air colours share a name with a Base/Layer paint but are a distinct
        // product (different bottle/finish) — prefixed with "Air: " throughout,
        // matching Citadel's own branding, so they never collide by name.
        ("Air: Abaddon Black",           PaintCategory.Air),
        ("Air: Administratum Grey",      PaintCategory.Air),
        ("Air: Air Caste Thinner",       PaintCategory.Air),
        ("Air: Angron Red Clear",        PaintCategory.Air),
        ("Air: Averland Sunset",         PaintCategory.Air),
        ("Air: Balthasar Gold",          PaintCategory.Air),
        ("Air: Baneblade Brown",         PaintCategory.Air),
        ("Air: Caliban Green",           PaintCategory.Air),
        ("Air: Calth Blue Clear",        PaintCategory.Air),
        ("Air: Castellan Green",         PaintCategory.Air),
        ("Air: Corvus Black",            PaintCategory.Air),
        ("Air: Dawnstone",               PaintCategory.Air),
        ("Air: Deathworld Forest",       PaintCategory.Air),
        ("Air: Eidolon Purple Clear",    PaintCategory.Air),
        ("Air: Elysian Green",           PaintCategory.Air),
        ("Air: Evil Sunz Scarlet",       PaintCategory.Air),
        ("Air: Fenrisian Grey",          PaintCategory.Air),
        ("Air: Flash Gitz Yellow",       PaintCategory.Air),
        ("Air: Grey Knights Steel",      PaintCategory.Air),
        ("Air: Kantor Blue",             PaintCategory.Air),
        ("Air: Khorne Red",              PaintCategory.Air),
        ("Air: Kislev Flesh",            PaintCategory.Air),
        ("Air: Leadbelcher",             PaintCategory.Air),
        ("Air: Lothern Blue",            PaintCategory.Air),
        ("Air: Macragge Blue",           PaintCategory.Air),
        ("Air: Mechanicus Standard Grey",PaintCategory.Air),
        ("Air: Mephiston Red",           PaintCategory.Air),
        ("Air: Moot Green",              PaintCategory.Air),
        ("Air: Mortarion Green Clear",   PaintCategory.Air),
        ("Air: Mournfang Brown",         PaintCategory.Air),
        ("Air: Night Lords Blue",        PaintCategory.Air),
        ("Air: Ogryn Camo",              PaintCategory.Air),
        ("Air: Phalanx Yellow",          PaintCategory.Air),
        ("Air: Phoenician Purple",       PaintCategory.Air),
        ("Air: Runefang Steel",          PaintCategory.Air),
        ("Air: Russ Grey",               PaintCategory.Air),
        ("Air: Temple Guard Blue",       PaintCategory.Air),
        ("Air: Thallax Gold",            PaintCategory.Air),
        ("Air: The Fang",                PaintCategory.Air),
        ("Air: Troll Slayer Orange",     PaintCategory.Air),
        ("Air: Typhon Ash",              PaintCategory.Air),
        ("Air: Ulthuan Grey",            PaintCategory.Air),
        ("Air: Ushabti Bone",            PaintCategory.Air),
        ("Air: White Scar",              PaintCategory.Air),
        ("Air: Zandri Dust",             PaintCategory.Air),

        // ── SPRAY (12) ───────────────────────────────────────────────────────────
        // Cans, not pots — excluded from rack packing (see BuildPaintList).
        // Prefixed with "Spray: " for the same name-collision reason as Air.
        ("Spray: Chaos Black",         PaintCategory.Spray),
        ("Spray: Death Guard Green",   PaintCategory.Spray),
        ("Spray: Grey Seer",           PaintCategory.Spray),
        ("Spray: Leadbelcher",         PaintCategory.Spray),
        ("Spray: Macragge Blue",       PaintCategory.Spray),
        ("Spray: Mechanicus Standard Grey", PaintCategory.Spray),
        ("Spray: Mephiston Red",       PaintCategory.Spray),
        ("Spray: Munitorum Varnish",   PaintCategory.Spray),
        ("Spray: Retributor Armour",   PaintCategory.Spray),
        ("Spray: White Scar",          PaintCategory.Spray),
        ("Spray: Wraithbone",          PaintCategory.Spray),
        ("Spray: Zandri Dust",         PaintCategory.Spray),
    ];

    /// Default category order/enabled state, used when no settings have been loaded yet.
    public static List<CategorySetting> DefaultCategorySettings() =>
        Enum.GetValues<PaintCategory>()
            .Select((cat, i) => new CategorySetting { Category = cat, Enabled = true, SortOrder = i + 1 })
            .ToList();

    /// Builds the paint list from the database-sourced master rows (source of
    /// truth). Locations are packed according to category settings: disabled
    /// categories are excluded (freeing their slots), and categories are filled
    /// in ascending SortOrder. Within a category, paints stay alphabetical.
    public static List<Paint> BuildPaintList(
        IEnumerable<(long Id, string Name, PaintCategory Category)> masterRows,
        IEnumerable<CategorySetting> categorySettings,
        RackSettings rackSettings)
    {
        var order = categorySettings
            .Where(s => s.Enabled)
            .OrderBy(s => s.SortOrder)
            .Select(s => s.Category)
            .ToList();

        var byCategory = masterRows.ToLookup(p => p.Category);

        var ordered = order
            .SelectMany(cat => byCategory[cat].OrderBy(p => p.Name, StringComparer.OrdinalIgnoreCase))
            .ToList();

        return PackPaints(ordered, rackSettings);
    }

    /// Builds the paint list from the hardcoded backup list. Used only when
    /// the database's master paint list can't be reached at startup, so the
    /// app still shows something instead of an empty page. Ids are negative
    /// sentinels — they don't correspond to real database rows, so owned/
    /// wishlist mutations can't be persisted while running on this fallback.
    public static List<Paint> BuildPaintListFallback(IEnumerable<CategorySetting> categorySettings, RackSettings rackSettings)
    {
        var order = categorySettings
            .Where(s => s.Enabled)
            .OrderBy(s => s.SortOrder)
            .Select(s => s.Category)
            .ToList();

        var byCategory = PaintList.ToLookup(p => p.Category);

        var ordered = order
            .SelectMany(cat => byCategory[cat])
            .Select((p, i) => ((long)-(i + 1), p.Name, p.Category))
            .ToList();

        return PackPaints(ordered, rackSettings);
    }

    private static List<Paint> PackPaints(IEnumerable<(long Id, string Name, PaintCategory Category)> ordered, RackSettings rackSettings)
    {
        var paints = new List<Paint>();
        int slotIndex = 0; // only advances for rackable (non-Spray) paints
        int slotsPerRack = rackSettings.SlotsPerRack;
        foreach (var (id, name, category) in ordered)
        {
            int rackNumber = 0, row = 0, col = 0;

            // Sprays are cans, not pots — they don't get a rack slot at all.
            if (category != PaintCategory.Spray)
            {
                int rackIndex = slotIndex / slotsPerRack;
                int posInRack = slotIndex % slotsPerRack;
                row        = posInRack / rackSettings.ColumnsPerRack + 1;
                col        = posInRack % rackSettings.ColumnsPerRack + 1;
                rackNumber = rackIndex + 1;
                slotIndex++;
            }

            paints.Add(new Paint
            {
                Id         = id,
                Name       = name,
                Category   = category,
                RackNumber = rackNumber,
                Row        = row,
                Column     = col,
                IsOwned    = false
            });
        }

        return paints;
    }
}
