namespace WarhamerPaintInventoryWeb.Pages;

public partial class Guides
{
    private static readonly List<Section> IronWarriorsHHOverall =
    [
        new("Armour (Steel-Grey)",
        [
            new("Basecoat", "Leadbelcher"),
            new("Recess Shade", "Nuln Oil"),
            new("Edge Highlight", "Ironbreaker"),
        ]),
        new("Trim (Hazard Stripes)",
        [
            new("Basecoat", "Abaddon Black"),
            new("Stripe", "Averland Sunset"),
            new("Stripe Edge", "Yriel Yellow"),
        ]),
        new("Details",
        [
            new("Legion Icon", "Ironbreaker", "Nuln Oil recess shade"),
        ]),
        new("Base / Rims",
        [
            new("Rim", "Leadbelcher"),
            new("Basing", "Astrogranite Debris", "with Agrellan Earth cracked texture"),
        ]),
    ];

    private static FactionGuide BuildIronWarriorsLegion() => new("Iron Warriors",
    [
        new("Iron Warriors", "The IV Legion — masters of siege warfare under Perturabo. Their armour was gunmetal steel, marked with black and yellow hazard stripes on shoulder plates and helms.", IronWarriorsHHOverall, IsScheme: true),

        PlainUnit(IronWarriorsHHOverall, "Legion Tactical Squad"),
        PlainUnit(IronWarriorsHHOverall, "Legion Terminator Squad"),
        PlainUnit(IronWarriorsHHOverall, "Legion Command Squad"),
        PlainUnit(IronWarriorsHHOverall, "Legion Rhino"),
        PlainUnit(IronWarriorsHHOverall, "Legion Dreadnought"),
        PlainUnit(IronWarriorsHHOverall, "Legion Praetor"),
    ], Category: GuideCategory.Traitor, Game: Game.HorusHeresy);
}
