namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> NighthauntOverall =
    [
        new("Ghostly Shrouds & Robes",
        [
            new("Basecoat", "Corax White"),
            new("Contrast", "Nighthaunt Gloom", "thinned further with Contrast Medium for a paler, more ethereal wash"),
            new("Recess Shade", "Drakenhof Nightshade", "into the deepest folds"),
            new("Edge Highlight", "White Scar", "fine highlights along hems and tatters"),
        ]),
        new("Bone & Skulls",
        [
            new("Basecoat", "Ushabti Bone"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Screaming Skull"),
        ]),
        new("Weapons & Chains",
        [
            new("Basecoat", "Leadbelcher"),
            new("Wash", "Nuln Oil"),
            new("Rust & Grime", "Typhus Corrosion", "technical paint stippled onto manacles and blades"),
            new("Edge Highlight", "Ironbreaker"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Abaddon Black"),
            new("Basing", "Stirland Mud", "technical paint texture, drybrushed with Terminatus Stone for a graveyard base"),
        ]),
    ];

    private static FactionGuide BuildNighthaunt() => new("Nighthaunt",
    [
        new("Default Scheme", "The default and most iconic Nighthaunt palette — translucent blue-white shrouds glazed over stark white robes, aged bone, and rusted chains. Build the Nighthaunt Gloom contrast up in thin, uneven passes so the ghostly effect stays patchy and ethereal rather than flat.", NighthauntOverall, IsScheme: true),

        new("Lady Olynder, Mortarch of Grief", "The Mortarch of Grief and a striking centrepiece model — a ghostly shroud atop a palanquin, dominated by the glowing witchfire lantern she carries. Paint the lantern glow last with thin glazes bleeding onto the nearby cloak and stonework to tie the model together.",
        [
            new("Robes & Shroud",
            [
                new("Basecoat", "Corax White"),
                new("Contrast", "Nighthaunt Gloom", "thinned with Contrast Medium"),
                new("Recess Shade", "Drakenhof Nightshade"),
                new("Edge Highlight", "White Scar"),
            ]),
            new("Withered Skin",
            [
                new("Basecoat", "Rakarth Flesh"),
                new("Shade", "Reikland Fleshshade", "thinned"),
                new("Highlight", "Pallid Wych Flesh"),
            ]),
            new("Lantern of Loss (Spectral Glow)",
            [
                new("Basecoat", "Kantor Blue"),
                new("Layer", "Alaitoc Blue"),
                new("Highlight", "Baharroth Blue"),
                new("Glow Glaze", "Guilliman Blue", "thinned glaze bleeding onto nearby robes and stone"),
            ]),
            new("Palanquin & Bone Fittings",
            [
                new("Basecoat", "Ushabti Bone"),
                new("Shade", "Agrax Earthshade"),
                new("Highlight", "Screaming Skull"),
            ]),
            new("Base / Rims",
            [
                new("Rim", "Abaddon Black"),
                new("Basing", "Stirland Mud", "drybrushed with Terminatus Stone"),
            ]),
        ]),

        FactionUnit(NighthauntOverall, "Chainrasp Horde", "Unit-Specific Details",
        [
            new("Rusted Manacles", "Typhus Corrosion", "stippled for corrosion"),
            new("Weapon Blade", "Ironbreaker", "edge highlight"),
        ]),

        FactionUnit(NighthauntOverall, "Grimghast Reapers", "Unit-Specific Details",
        [
            new("Scythe Blade", "White Scar", "sharp edge highlight along the whole blade"),
            new("Reaper Robes", "Nighthaunt Gloom", "extra glaze pass for deeper contrast, marking these as elite spirits"),
        ]),

        FactionUnit(NighthauntOverall, "Spirit Hosts", "Unit-Specific Details",
        [
            new("Ectoplasmic Mass", "Nighthaunt Gloom", "heavier, swirling glazes across the writhing form"),
            new("Embedded Skulls", "Ushabti Bone"),
        ]),

        FactionUnit(NighthauntOverall, "Bladegheist Revenants", "Unit-Specific Details",
        [
            new("Twin Blades", "White Scar", "edge highlight"),
            new("Ribbon Trails", "Nighthaunt Gloom", "thinned glaze trailing off the blades and robes"),
        ]),

        FactionUnit(NighthauntOverall, "Knight of Shrouds", "Unit-Specific Details",
        [
            new("Blade of Shrouds", "White Scar", "edge highlight along the blade"),
            new("Crown & Regalia", "Ushabti Bone", "Agrax Earthshade wash"),
        ]),

        FactionUnit(NighthauntOverall, "Dreadblade Harrow", "Mount-Specific Details",
        [
            new("Skeletal Steed", "Ushabti Bone", "as Bone & Skulls scheme"),
            new("Barding & Chain", "Leadbelcher", "Nuln Oil wash"),
            new("Trailing Shroud", "Nighthaunt Gloom", "thinned glaze"),
        ]),
    ], Category: GuideCategory.Death, Game: Game.AgeOfSigmar);
}
