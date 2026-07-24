namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static FactionGuide BuildSkinToneGuide() => new("Skin Tone Guide",
    [
        new("Guide", "Seraphim Sepia is the workhorse shade for every skin tone below. Bugman's Glow is a great universal base — darker skin starts and stays there, lighter skin uses it as an undercoat. Contrast paints work fastest over a white or grey primer. Keep highlights to the highest points only (nose tip, brow, cheekbones, chin), and thin paints slightly for smoother blending.", [], IsScheme: true),

        new("Fair / Pale (e.g. Stormcast, Norse)", null,
        [
            new("Recipe",
            [
                new("Base", "Kislev Flesh"),
                new("Shade", "Seraphim Sepia", "keep thin, recesses only, for a pale effect"),
                new("Highlight", "Ungor Flesh"),
            ]),
        ]),

        new("Mid / Caucasian (e.g. Empire soldiers, generic humans)", null,
        [
            new("Recipe",
            [
                new("Base", "Bugman's Glow", "or Ungor Flesh"),
                new("Shade", "Seraphim Sepia"),
                new("Layer", "Bestigor Flesh", "→ Kislev Flesh highlight"),
                new("Contrast Option", "Guilliman Flesh", "over a light base — fastest route, one coat over white primer"),
            ]),
        ]),

        new("Olive / Mediterranean / Asian (e.g. Azyrite humans, Cathayan-inspired)", null,
        [
            new("Recipe",
            [
                new("Base", "Bugman's Glow"),
                new("Shade", "Seraphim Sepia"),
                new("Layer", "Bestigor Flesh"),
                new("Highlight", "Ungor Flesh", "keep subtle, limited to raised areas like cheekbones and brow"),
            ]),
        ]),

        new("Brown / South Asian / Latino (e.g. Aqshyan, Xhosa-inspired)", null,
        [
            new("Recipe",
            [
                new("Base", "Bugman's Glow"),
                new("Shade", "Seraphim Sepia", "heavier coat"),
                new("Layer", "Knight-Questor Flesh"),
                new("Contrast Option", "Darkoath Flesh", "over mid-brown primer — works brilliantly here"),
            ]),
        ]),

        new("Dark / African (e.g. Kharadron, Orruks with dark flesh)", null,
        [
            new("Recipe",
            [
                new("Base", "Bugman's Glow"),
                new("Shade", "Seraphim Sepia", "heavy coat"),
                new("Highlight", "Darkoath Flesh", "or Fyreslayer Flesh; keep minimal and localised to the highest points"),
            ]),
        ]),
    ], Category: GuideCategory.General);
}
