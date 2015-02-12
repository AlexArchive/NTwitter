using System;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Twitter.Models;

namespace Twitter.Controllers
{
    [Authorize]
    public class TweetController : Controller
    {
        private readonly ApplicationContext context;
        public TweetController(ApplicationContext context)
        {
            this.context = context;
        }

        public IActionResult Index() => View();

        [HttpPost]
        public async Task<IActionResult> Tweet(TweetInput model)
        {
            var user = await context.Users
                .SingleAsync(u => u.Id == User.Identity.GetUserId());
            var tweet = new Tweet
            {
                Author = user,
                CreatedAt = DateTime.Now,
                Text = model.TweetText
            };
            await context.Tweets.AddAsync(tweet);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "Profile", new { userName = user.UserName });
        }
    }
}