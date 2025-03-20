using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyTecCoursePWA;
using MyTecCoursePWA.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var apiBaseAddress = builder.Configuration["AppSettings:APIClient:BaseAddress"]
                     ?? builder.HostEnvironment.BaseAddress;

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiBaseAddress) });

builder.Services.AddSingleton<MockEducationService>();
builder.Services.AddSingleton<MockUserService>();
builder.Services.AddSingleton<MockEducationChoice>();
builder.Services.AddScoped<APIService>();

await builder.Build().RunAsync();
