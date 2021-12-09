using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZC.Service.AppEnviroment;

namespace ZC.Tests.Core
{
    public abstract class ZCStartupUnitTest : ZCStartupTestBase
    {
        public void ConfigureHost(IHostBuilder hostBuilder)
        {
            hostBuilder
                .ConfigureHostConfiguration(builder =>
                {
                    AppEnviromentService.LoadLaunchSettingsIntoEnvVariables("Properties/launchSettings.json");
                })
                .ConfigureAppConfiguration((context, builder) =>
                {
                    var env = context.HostingEnvironment;

                    builder
                       .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                       .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                       .AddEnvironmentVariables();

                    ConfigureAppConfiguration(context, builder);
                })
                .ConfigureServices(services => ConfigureTestServices(services));
        }

        public abstract void ConfigureAppConfiguration(HostBuilderContext hostingContext, IConfigurationBuilder configurationBuilder);

    }

}
