using Microsoft.AspNet.Mvc;

namespace Twitter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.WelcomeMessage = "Hello, all.";
            return View();
        }
    }
}