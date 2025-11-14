using BlazorTemplate.ApiClient;
using BlazorTemplate.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Register the generated API client and set BaseUrl
builder.Services.AddScoped<Client>(sp =>
{
    var http = sp.GetRequiredService<HttpClient>();
    var api = new Client(http);

    // Option 1: read from configuration (e.g. wwwroot/appsettings.json or environment)
    var configured = builder.Configuration["ApiBaseUrl"];
    if (!string.IsNullOrWhiteSpace(configured))
    {
        api.BaseUrl = configured; // trailing slash will be added by the property if needed
    }
    else if (http.BaseAddress != null)
    {
        api.BaseUrl = http.BaseAddress.ToString();
    }
    else
    {
        api.BaseUrl = "https://localhost:7265/"; // fallback
    }

    return api;
});

await builder.Build().RunAsync();
