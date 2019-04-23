using Microsoft.AspNetCore.Mvc;
using TestJenkins.Controllers;
using Xunit;

namespace TestJenkins.Test
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index()
        {
            var controller = new HomeController();
            var actionResult = controller.Index();

            var viewResult = actionResult as ViewResult;
            Assert.NotNull(viewResult);
        }
    }
}