using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Hosting;
using Microsoft.Framework.ConfigurationModel;
using AngularBookstore.Models;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
using System;
using Microsoft.Data.Entity.SqlServer;
using System.Collections.Generic;
using System.Security.Claims;

namespace AngularBookstore
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IHostingEnvironment environment)
        {
            Configuration = new Configuration()
                .AddJsonFile("config.json")
                .AddEnvironmentVariables();
        }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddEntityFramework(Configuration)
                .AddSqlServer()
                .AddDbContext<BooksDb>();

            services.AddIdentity<ApplicationUser, IdentityRole>(Configuration)
                .AddEntityFrameworkStores<BooksDb>();

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseIdentity();
            app.UseMvc();
            CreateSampleData(app.ApplicationServices).Wait();
        }

        private static async Task CreateSampleData(IServiceProvider applicationServices)
        {
            using (var context = applicationServices.GetService<BooksDb>())
            {
                var sqlServerDatabase = context.Database as SqlServerDatabase;
                if (sqlServerDatabase != null)
                {
                    // Create database in user root (c:\users\your name)
                    if (await sqlServerDatabase.EnsureCreatedAsync())
                    {
                        // add some movies
                        var movies = new List<Book>
                        {
                            new Book {Title="Elizabeth is Missing", Author="Emma Healey"},
                            new Book {Title="The Miniaturist", Author="Jessie Burton"},
                            new Book {Title="Station Eleven", Author="Emily St. John Mandel"}
                        };
                        movies.ForEach(m => context.Books.AddAsync(m));

                        // add some users
                        var userManager = applicationServices.GetService<UserManager<ApplicationUser>>();

                        // add editor user
                        var stephen = new ApplicationUser
                        {
                            UserName = "Stephen"
                        };
                        var result = await userManager.CreateAsync(stephen, "P@ssw0rd");
                        await userManager.AddClaimAsync(stephen, new Claim("CanEdit", "true"));

                        // add normal user
                        var bob = new ApplicationUser
                        {
                            UserName = "Bob"
                        };
                        await userManager.CreateAsync(bob, "P@ssw0rd");
                    }
                }
            }
        }

    }
}