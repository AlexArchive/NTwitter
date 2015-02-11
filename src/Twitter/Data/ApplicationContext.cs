using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Twitter.Data.Model;

namespace Twitter.Data
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnConfiguring(DbContextOptions options) =>
            options.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Twitter;Trusted_Connection=True;MultipleActiveResultSets=true");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>().OneToMany(u => u.Tweets);
        }
    }
}