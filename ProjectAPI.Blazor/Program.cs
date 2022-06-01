using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectWebAPI.Blazor.Services;
using ProjectWebAPI.SharedClasses;
using System;
using System.Threading.Tasks;


namespace ProjectWebAPI.Blazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddHttpClient<IService<Product>, ProductService>(
                (sp, optionsHttpClient) =>
                   optionsHttpClient.BaseAddress =
                   new Uri(sp.GetRequiredService<IConfiguration>()["Ip"])
                );
            builder.Services.AddHttpClient<IService<Category>, CategoryService>(
                (sp, optionsHttpClient) =>
                   optionsHttpClient.BaseAddress =
                   new Uri(sp.GetRequiredService<IConfiguration>()["Ip"])
                );
            await builder.Build().RunAsync();
        }
    }
}
