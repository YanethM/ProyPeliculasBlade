using System.Collections.Immutable;
using System.Net.Security;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ProyBaseMuestra.Client.Services;

namespace ProyBaseMuestra.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            ConfigureServices(builder.Services);
            await builder.Build().RunAsync();
        }
        /* Mètodo que nos permite configurar el sistema de inyección de dependencias  */
        private static void ConfigureServices(IServiceCollection services){
            services.AddSingleton<IServiceMovie, ServiceMovie>();
            services.AddSingleton<IServiceActor, ServiceActor>();
        }
    }
}
