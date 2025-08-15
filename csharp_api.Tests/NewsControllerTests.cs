using Xunit;
using csharp_api.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace csharp_api.Tests
{
    public class NewsControllerTests
    {
        [Fact]
        public async Task GetFullList_NoApiKey_ReturnsUnauthorized()
        {
            // Arrange
            var controller = new NewsController();
            controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext()
            };

            // Act
            var result = await controller.GetFullList("mql5");

            // Assert
            Assert.IsType<UnauthorizedObjectResult>(result);
        }
    }
}
