using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using CSharpAcademy;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services
    .AddBlazorise(options =>
    {
    })
    .AddBootstrap5Providers()
    .AddFontAwesomeIcons();

builder.Services.AddSingleton(new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

builder.RootComponents.Add<App>("#app");

var host = builder.Build();

await host.RunAsync();