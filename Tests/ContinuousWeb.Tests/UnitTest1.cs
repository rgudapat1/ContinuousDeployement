
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContinuousWeb.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ContinuousWeb.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void AboutPageTest()
        {
            var homecontroller=new HomeController();
            var result=homecontroller.About();
        }
    }
}
