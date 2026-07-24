namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> ChaosCultOverall =
    [
        new("Robes & Cloth (Corrupted Red)",
        [
            new("Basecoat", "Khorne Red"),
            new("Shade", "Nuln Oil"),
            new("Highlight", "Evil Sunz Scarlet"),
        ]),
        new("Diseased Skin",
        [
            new("Basecoat", "Kislev Flesh"),
            new("Shade", "Carroburg Crimson"),
            new("Highlight", "Flayed One Flesh"),
        ]),
        new("Corrupted Brass & Metal",
        [
            new("Basecoat", "Warplock Bronze"),
            new("Shade", "Agrax Earthshade"),
            new("Highlight", "Brass Scorpion"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Balthasar Gold"),
            new("Basing", "Stirland Mud", "with Blood for the Blood God for corruption"),
        ]),
    ];

    private static FactionGuide BuildChaosCult() => new("Chaos Cult",
    [
        new("Overall (Head-to-Toe)", "Corrupted underhivers in blood-dark red robes and diseased, mutating flesh, bound together with tarnished brass icons — a cult quietly rotting the underhive from within.", ChaosCultOverall, IsScheme: true),

        FactionUnit(ChaosCultOverall, "Cultist", "Unit-Specific Details",
        [
            new("Improvised Weapon", "Warplock Bronze"),
            new("Robe Trim", "Evil Sunz Scarlet"),
        ]),

        FactionUnit(ChaosCultOverall, "Cult Champion", "Unit-Specific Details",
        [
            new("Chaos Icon", "Brass Scorpion"),
            new("Mutated Flesh", "Flayed One Flesh"),
            new("Blade Edge", "Runefang Steel"),
        ]),

        FactionUnit(ChaosCultOverall, "Chaos Familiar", "Unit-Specific Details",
        [
            new("Hide / Carapace", "Kislev Flesh", "Carroburg Crimson wash"),
            new("Claws & Teeth", "Screaming Skull"),
        ]),

        FactionUnit(ChaosCultOverall, "Cult Leader", "Unit-Specific Details",
        [
            new("Ritual Robes", "Khorne Red", "Nuln Oil recess shade"),
            new("Cult Icon", "Balthasar Gold"),
            new("Command Weapon Casing", "Warplock Bronze"),
        ]),

        FactionUnit(ChaosCultOverall, "Chaos Spawn", "Unit-Specific Details",
        [
            new("Mutated Hide", "Kislev Flesh", "Carroburg Crimson wash"),
            new("Chitin Plates", "Warplock Bronze"),
            new("Maw / Claws", "Screaming Skull"),
        ]),
    ], Category: GuideCategory.Gangs, Game: Game.Necromunda);
}
