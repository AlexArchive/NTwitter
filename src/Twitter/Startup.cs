using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Identity;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.DependencyInjection;
using Twitter.Data;
using Twitter.Data.Model;

namespace Twitter
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<ApplicationContext>();
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationContext>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseIdentity();
            app.UseMvc();
        }
    }
}
