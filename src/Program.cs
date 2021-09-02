using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DITest {
    class Program {
        public static async Task Main() {
            var host = new HostBuilder()
                .ConfigureServices(ConfigureService)
                .UseConsoleLifetime()
                .Build();

            await host.RunAsync();
        }

        private static void ConfigureService(HostBuilderContext context, IServiceCollection services) {
            services
                .AddSingleton<ShipService>()
                .AddHostedService<MyService>();
            
        }
    }
}
