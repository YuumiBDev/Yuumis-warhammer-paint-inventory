using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WarhamerPaintInventoryWeb;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Calls go to this app's own origin (/rest/v1/*), where a Cloudflare function
// proxies them to Supabase using the anon key (see functions/rest/v1/[[path]].js).
builder.Services.AddHttpClient("Supabase", client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

builder.Services.AddScoped<InventoryManager>();

await builder.Build().RunAsync();
