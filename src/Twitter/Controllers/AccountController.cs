using System;
using Microsoft.AspNet.Mvc;

namespace Twitter.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}