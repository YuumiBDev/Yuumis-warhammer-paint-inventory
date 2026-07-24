namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static GeneralGuide NightbringerGuide() => new("C'tan Shard of the Nightbringer",
    [
        new(BlockKind.Text, Text: "Warhammer 40,000 | Necrons — one of the most iconic centrepiece models in the Necron range. This guide recreates the studio colour scheme using Citadel paints, broken down by area of the model."),

        new(BlockKind.H2, Text: "Primer"),
        new(BlockKind.Text, Text: "Chaos Black spray — apply a thin, even coat all over the model before painting."),

        new(BlockKind.H2, Text: "Necrodermis Body (Living Metal)"),
        new(BlockKind.Text, Text: "A shiny, cold metallic appearance with a blue-teal tint."),
        new(BlockKind.Bullets, Items:
        [
            "Basecoat: Leadbelcher",
            "Drybrush heavily: Runefang Steel (build up a strong shine)",
            "Shade recesses: Nuln Oil",
            "Blue-teal glaze: Aethermatic Blue or Nighthaunt Gloom (thinned with Lahmian Medium)",
            "Edge highlights: Stormhost Silver",
        ]),

        new(BlockKind.H2, Text: "Dark Robes & Cloak"),
        new(BlockKind.Text, Text: "Deep black with subtle highlights and a purple shimmer near the glowing energy areas."),
        new(BlockKind.Bullets, Items:
        [
            "Base: Abaddon Black",
            "Mid highlights: Skavenblight Dinge",
            "Upper highlights: Stormvermin Fur",
            "Purple OSL near energy zones: thinned Xereus Purple glaze",
        ]),

        new(BlockKind.H2, Text: "Glowing Green Energy (Cloak Fragments & Scarabs)"),
        new(BlockKind.Text, Text: "The signature feature of the model — bright, glowing green digitised fragments and scarab swarms."),
        new(BlockKind.Bullets, Items:
        [
            "Base: Caliban Green",
            "Layer: Warpstone Glow",
            "Highlight: Moot Green",
            "Brightest glow tips: Yriel Yellow or Flash Gitz Yellow",
            "Scarabs: Kabalite Green → Sybarite Green → White Scar reflection dot",
            "Vines/tendrils on base: Moot Green drybrushed over Abaddon Black",
        ]),

        new(BlockKind.H2, Text: "The Scythe"),
        new(BlockKind.Text, Text: "Dark, otherworldly metal with a cold teal gleam."),
        new(BlockKind.Bullets, Items:
        [
            "Base: Incubi Darkness",
            "Highlight: Kabalite Green → Sybarite Green",
            "Edge gleam: White Scar or Stormhost Silver along the blade",
        ]),

        new(BlockKind.H2, Text: "Face & Skull"),
        new(BlockKind.Text, Text: "A sunken, death-like visage with glowing eyes that radiate green light."),
        new(BlockKind.Bullets, Items:
        [
            "Base: Abaddon Black",
            "Highlight: The Fang → Fenrisian Grey",
            "Glowing eyes: Moot Green (base), Yriel Yellow (centre), thinned Warpstone Glow glazed outward",
        ]),

        new(BlockKind.H2, Text: "The Base"),
        new(BlockKind.Bullets, Items:
        [
            "Texture: Astrogranite Debris or Armageddon Dust",
            "Drybrush: Mechanicus Standard Grey → Administratum Grey",
            "Skulls: Zandri Dust → Screaming Skull",
            "Optional: static grass tufts for contrast against the dark model",
        ]),

        new(BlockKind.H2, Text: "Top Tips"),
        new(BlockKind.Bullets, Items:
        [
            "Paint the green OSL last — thin glazes of Moot Green bleeding onto nearby surfaces (cloak edges, base) ties the whole model together.",
            "Layer your greens thinly — multiple thin coats give a smoother, more luminous result than thick paint.",
            "Use Lahmian Medium to thin technical paints (like Aethermatic Blue) for smoother glazing.",
            "Drybrush the Runefang Steel boldly — the body should look almost mirror-bright to contrast the dark cloak.",
        ]),

        new(BlockKind.H2, Text: "Where to Find Reference Images"),
        new(BlockKind.Bullets, Items:
        [
            "Warhammer Community (warhammer-community.com) — search \"Nightbringer\" for official studio paint articles",
            "Citadel Colour App — free GW app with step-by-step guides for many models",
            "Reddit: r/Warhammer40k and r/minipainting — large community galleries",
            "Instagram — search #Nightbringer or #Necrons",
            "YouTube — search \"C'tan Nightbringer paint tutorial\" for video walkthroughs",
        ]),
    ]);
}
