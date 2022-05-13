using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ZC.Tests.Core;

namespace MainProjectAPI.Tests
{
    public class Startup : ZCStartupIntegrationTest<MainProjectAPI.Startup>
    {
        public override void Configure(IApplicationBuilder app)
        {

        }

        public override void ConfigureAppConfiguration(WebHostBuilderContext hostingContext, IConfigurationBuilder configurationBuilder)
        {

        }

        public override void ConfigureTestServices(IServiceCollection services)
        {

        }
    }
}
