using Microsoft.AspNet.Identity.EntityFramework;
using Twitter.Data.Model;

namespace Twitter.Data
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
    }
}