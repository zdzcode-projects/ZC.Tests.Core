using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZC.Tests.Core.Tests
{
    public class Startup
    {
        public void ConfigureHost(IHostBuilder hostBuilder) =>
            hostBuilder.ConfigureWebHost(webHostBuilder => webHostBuilder
           .UseTestServer()
           .Configure(Configure)
           .ConfigureTestServices(services =>
           {
               services.AddRouting();
               services.AddControllers();

               services.AddTransient<IDependency, DependencyClass>();
           }));


        private void Configure(IApplicationBuilder app)
        {
            app.UseRouting().UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

            });
        }

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddTransient<IDependency, DependencyClass>();
        //}

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
