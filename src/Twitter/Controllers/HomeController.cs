using Microsoft.AspNet.Mvc;

namespace Twitter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}