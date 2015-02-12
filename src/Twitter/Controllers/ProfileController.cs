using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Twitter.Data;
using Twitter.Models;

namespace Twitter.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ApplicationContext context;

        public ProfileController(ApplicationContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index(string userName)
        {
            var user = await context.Users
                .Include(u => u.Tweets)
                .SingleOrDefaultAsync(u => u.UserName == userName);
            if (user == null)
            {
                return HttpNotFound();
            }
            else
            {
                var model = new Profile
                {
                    UserName = user.UserName,
                    Tweets = user.Tweets
                        .OrderByDescending(t => t.CreatedAt)
                        .AsEnumerable()
                };
                return View(model);
            }
        }
    }
}