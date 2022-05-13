using FluentAssertions;
using Xunit;

namespace MainProjectClassLibrary.Tests
{
    public class MainServiceTests
    {
        private readonly MainService _mainService;

        public MainServiceTests(MainService mainService)
        {
            _mainService = mainService;
        }

        [Theory]
        [InlineData("test@email.com", "&#^SJSI")]
        public void SignTest(string email, string password)
        {
            var result = _mainService.Sign(email, password);

            result.Should().BeTrue("Email and password is correct.");
        }
    }
}