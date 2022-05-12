using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ZC.Tests.Core.Tests
{
    public class Startup : ZCStartupUnitTest
    {
        public override string EnvironmentName => Microsoft.Extensions.Hosting.Environments.Staging;

        public override void Configure(IApplicationBuilder app)
        {

        }

        public override void ConfigureAppConfiguration(HostBuilderContext hostingContext, IConfigurationBuilder configurationBuilder)
        {

        }

        public override void ConfigureTestServices(IServiceCollection services)
        {
            services.AddTransient<IDependency, DependencyClass>();
        }

    }

    public interface IDependency
    {
        int Value { get; }
    }

    internal class DependencyClass : IDependency
    {
        public int Value => 1;
    }


}
