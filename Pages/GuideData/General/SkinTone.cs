namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static GeneralGuide SkinToneGuide() => new("Skin Tone Painting Guide",
    [
        new(BlockKind.Text, Text: "This guide covers how to paint a range of skin tones using paints in the Citadel Colour range. Each recipe uses the same core paints — Bugman's Glow, Seraphim Sepia, and layer paints — adapted to represent different ethnicities on your models."),

        new(BlockKind.H2, Text: "Fair / Pale (e.g. Stormcast, Norse)"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint(s)"], TableRows:
        [
            ["Base", "Kislev Flesh"],
            ["Shade", "Seraphim Sepia"],
            ["Highlight", "Ungor Flesh"],
        ]),
        new(BlockKind.Text, Text: "Tip: Keep the shade thin and apply only to recesses for a pale effect."),

        new(BlockKind.H2, Text: "Mid / Caucasian (e.g. Empire soldiers, generic humans)"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint(s)"], TableRows:
        [
            ["Base", "Bugman's Glow or Ungor Flesh"],
            ["Shade", "Seraphim Sepia"],
            ["Layer", "Bestigor Flesh → Kislev Flesh highlight"],
            ["Contrast option", "Guilliman Flesh over a light base"],
        ]),
        new(BlockKind.Text, Text: "Tip: Guilliman Flesh contrast is the fastest route — one coat over white primer."),

        new(BlockKind.H2, Text: "Olive / Mediterranean / Asian (e.g. Azyrite humans, Cathayan-inspired)"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint(s)"], TableRows:
        [
            ["Base", "Bugman's Glow"],
            ["Shade", "Seraphim Sepia"],
            ["Layer", "Bestigor Flesh"],
            ["Highlight", "Ungor Flesh"],
        ]),
        new(BlockKind.Text, Text: "Tip: Keep highlights subtle and limited to raised areas like cheekbones and brow."),

        new(BlockKind.H2, Text: "Brown / South Asian / Latino (e.g. Aqshyan, Xhosa-inspired)"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint(s)"], TableRows:
        [
            ["Base", "Bugman's Glow"],
            ["Shade", "Seraphim Sepia (heavier)"],
            ["Layer", "Knight-Questor Flesh"],
            ["Contrast option", "Darkoath Flesh over mid-brown primer"],
        ]),
        new(BlockKind.Text, Text: "Tip: Darkoath Flesh contrast works brilliantly here — apply over a grey-brown primer."),

        new(BlockKind.H2, Text: "Dark / African (e.g. Kharadron, Orruks with dark flesh)"),
        new(BlockKind.Table, TableHeader: ["Step", "Paint(s)"], TableRows:
        [
            ["Base", "Bugman's Glow"],
            ["Shade", "Seraphim Sepia (heavy coat)"],
            ["Layer", "Darkoath Flesh or Fyreslayer Flesh for highlights"],
        ]),
        new(BlockKind.Text, Text: "Tip: Keep highlights minimal and very localised — just the very highest points."),

        new(BlockKind.H1, Text: "General Tips"),
        new(BlockKind.Bullets, Items:
        [
            "Seraphim Sepia is your workhorse shade for all skin tones — use it across every recipe.",
            "Bugman's Glow is a great universal base. Darker skin starts and stays there; lighter skin uses it as an undercoat.",
            "Contrast paints (Darkoath Flesh, Guilliman Flesh, Fyreslayer Flesh) work fastest over a white or grey primer.",
            "For realism, keep highlights to the highest points only — nose tip, brow, cheekbones, chin.",
            "Thin your paints slightly with water or medium for smoother blending between layers.",
        ]),
    ]);
}
