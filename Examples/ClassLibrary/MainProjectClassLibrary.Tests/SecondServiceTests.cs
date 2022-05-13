using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MainProjectClassLibrary.Tests
{
    public class SecondServiceTests
    {
        private readonly SecondService _SecondService;

        public SecondServiceTests(SecondService SecondService)
        {
            _SecondService = SecondService;
        }

        [Theory]
        [InlineData("test@email.com")]
        public void SignTest(string email)
        {
            var result = _SecondService.IsValidEmail(email);

            result.Should().BeTrue("Email is correct.");
        }
    }
}
