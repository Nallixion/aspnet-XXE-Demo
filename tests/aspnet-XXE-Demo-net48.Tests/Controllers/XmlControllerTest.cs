using aspnet_XXE_Demo_net48;
using aspnet_XXE_Demo_net48.Controllers;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace aspnet_XXE_Demo_net48.Tests.Controllers
{
    [TestClass]
    public class XmlControllerTest
    {
        [TestMethod]
        public void Post()
        {
            // Arrange
            XmlController controller = new XmlController();

            // Act
            controller.Post();

            // Assert
        }

        [TestMethod]
        public void vulninband()
        {
            // Arrange
            XmlController controller = new XmlController();

            // Act
            controller.vulninband();

            // Assert
        }
    }
}
