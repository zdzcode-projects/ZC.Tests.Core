using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZC.Tests.Core
{
    public abstract class ZCStartupTestBase
    {
        public abstract void Configure(IApplicationBuilder app);
        public abstract void ConfigureTestServices(IServiceCollection services);

    }
}
