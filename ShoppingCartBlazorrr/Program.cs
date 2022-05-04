using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShoppingCartBlazorrr;
using ShoppingCartBlazorrr.Services;
using ShoppingCartBlazorrr.Services.Contract;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7147/") }); //access to api
builder.Services.AddScoped<IProductService, ProductService>();

await builder.Build().RunAsync();
