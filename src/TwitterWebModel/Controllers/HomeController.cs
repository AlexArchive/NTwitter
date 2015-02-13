using Microsoft.AspNet.Mvc;

namespace Twitter.WebModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Register","Account");
            }
        }
    }
}