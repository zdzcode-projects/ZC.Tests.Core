using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MainProjectClassLibrary.Tests
{
    public class FirstServiceTests
    {
        private readonly FirstService _firstService;

        public FirstServiceTests(FirstService firstService)
        {
            _firstService = firstService;
        }

        [Theory]
        [InlineData("test@email.com", "&#^SJSI")]
        public void SignTest(string email, string password)
        {
            var result = _firstService.IsValid(email, password);

            result.Should().BeTrue("Email and password is correct.");
        }
    }
}
