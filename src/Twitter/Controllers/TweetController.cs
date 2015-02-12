using Microsoft.AspNet.Mvc;

namespace Twitter.Controllers
{
    public class TweetController : Controller
    {
        public IActionResult Index() => View();
    }
}