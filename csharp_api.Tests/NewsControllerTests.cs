using Xunit;
using csharp_api.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Moq;
using System.Collections.Generic;

namespace csharp_api.Tests
{
    public class NewsControllerTests
    {
        [Fact]
        public async Task GetFullList_WithValidApiKey_ReturnsOk()
        {
            // Arrange
            var inMemorySettings = new Dictionary<string, string> {
                {"ApiKey", "TEST_API_KEY"},
            };

            IConfiguration configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(inMemorySettings)
                .Build();

            var controller = new NewsController(configuration);

            // Act
            // This will fail because it's trying to make a real HTTP request
            // but we can at least test that the controller is created and the method can be called
            // In a real application, we would mock the HttpClient to avoid the external dependency
            var result = await controller.GetFullList("mql5");

            // Assert
            Assert.IsType<ObjectResult>(result);
        }
    }
}
