using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;
using System.Net.Http;
using Xunit;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;

namespace MainProjectAPI.Tests
{
    public class WeatherForecastControllerTests
    {
        private readonly HttpClient _httpClient;

        public WeatherForecastControllerTests(IHost host)
        {
            _httpClient = host.GetTestClient();
        }

        [Fact]
        public async Task Get()
        {
            IEnumerable<WeatherForecast> result = await _httpClient.GetFromJsonAsync<IEnumerable<WeatherForecast>>("/WeatherForecast");

            result.Should().HaveCountGreaterThan(0);
        }
    }
}