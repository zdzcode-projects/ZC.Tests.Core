using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace MainProjectAPI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
                webBuilder.ConfigureKestrel((context, serverOptions) =>
                {
                    serverOptions.ConfigureEndpointDefaults(x =>
                    {
                        x.Protocols = HttpProtocols.Http1AndHttp2;
                    });
                });
            }).Build().RunAsync();
        }
    }
}