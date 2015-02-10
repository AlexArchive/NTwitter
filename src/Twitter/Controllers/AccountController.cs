using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Mvc;
using Twitter.Data.Model;
using Twitter.Models;

namespace Twitter.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;

        public AccountController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var user   = new ApplicationUser { UserName = model.Username };
            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                ViewBag.Message = "Success";
                return View();
            }
            else
            {
                foreach (var error in result.Errors)
                    ModelState.AddModelError("", error);
            }
            return View(model);
        }
    }
}