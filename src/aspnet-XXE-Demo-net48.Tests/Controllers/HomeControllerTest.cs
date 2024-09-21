using aspnet_XXE_Demo_net48;
using aspnet_XXE_Demo_net48.Controllers;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;

namespace aspnet_XXE_Demo_net48.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
