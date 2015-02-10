using Microsoft.AspNet.Mvc;
using Twitter.Controllers;
using Xunit;

namespace Twitter.UnitTest
{
    public class HomeControllerFacts
    {
        [Fact]
        public void SutIsController()
        {
            var sut = new HomeController();
            Assert.IsAssignableFrom<Controller>(sut);
        }

        [Fact]
        public void IndexReturnsCorrectView()
        {
            var sut = new HomeController();
            var actual = (ViewResult) sut.Index();
            Assert.Null(actual.ViewName);
        }
    }
}