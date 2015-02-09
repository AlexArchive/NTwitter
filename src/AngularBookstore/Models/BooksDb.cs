using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace AngularBookstore.Models
{
    public class BooksDb : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Book> Books { get; set; }
    }
}