using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ZC.Tests.Core.Tests
{

    public class MyAwesomeTests
    {
        private readonly IDependency _d;

        public MyAwesomeTests(IDependency d) => _d = d;

        [Fact]
        public void AssertThatWeDoStuff()
        {
            Assert.Equal(1, _d.Value);
        }
    }
}
