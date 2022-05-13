using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZC.Tests.Core;

namespace MainProjectClassLibrary.Tests
{
    public class Startup : ZCStartupUnitTest
    {
        public override void Configure(IApplicationBuilder app)
        {

        }

        public override void ConfigureAppConfiguration(HostBuilderContext hostingContext, IConfigurationBuilder configurationBuilder)
        {

        }

        public override void ConfigureTestServices(IServiceCollection services)
        {

            services.AddScoped<SecondService>();
            services.AddScoped<FirstService>();
            services.AddScoped<MainService>();

            services.BuildServiceProvider();
        }
    }
}
