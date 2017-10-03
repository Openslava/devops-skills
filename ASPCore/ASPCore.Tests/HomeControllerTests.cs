using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASPCore.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ASPCore.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Index()
        {
            var controller = new HomeController();

            var result = controller.Index();
            var viewstate = result as ViewResult;

            Assert.AreEqual(null, viewstate.ViewData["Message"]);
        }

        [TestMethod]
        public void Contact()
        {
            var controller = new HomeController();

            var result = controller.Contact();
            var viewstate = result as ViewResult;

            Assert.AreEqual("DevOps Skills", viewstate.ViewData["Message"]);
        }

        [TestMethod]
        public void About()
        {
            var controller = new HomeController();

            var result = controller.About();
            var viewstate = result as ViewResult;

            Assert.AreEqual("Openslava 2017", viewstate.ViewData["Message"]);
        }

        [TestMethod]
        public void Error()
        {
            var controller = new HomeController();

            var result = controller.Error();
            var viewstate = result as ViewResult;

            Assert.AreEqual(null, viewstate.ViewData["Message"]);
        }
    }
}
