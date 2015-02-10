using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Twitter.Models;

namespace Twitter.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            throw new NotImplementedException();
        }

    }
}