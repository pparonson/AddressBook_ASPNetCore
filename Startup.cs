using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using AddressBook.Services;
using Microsoft.Extensions.Configuration;
using AddressBook.Data;
using Microsoft.EntityFrameworkCore;


namespace AddressBook 
{
    public class Startup 
    {
        public IConfigurationRoot Configuration {get;}
        public Startup(IHostingEnvironment env)
        {
            // create an external configuration files to load at startup
            var builder = new ConfigurationBuilder()
                // specify path to find file
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", 
                    optional: true, 
                    reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", 
                    optional: true);
            
            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }
        public void ConfigureServices(IServiceCollection services) 
        {
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlite(
                    Configuration.GetConnectionString("DefaultConnection"))
            );
                
            // add configuration services for MVC
            services.AddMvc();
            // services.AddSingleton<IContactRepository, 
            //     InMemoryContactRepository>();
            services.AddScoped<IContactRepository, DatabaseContactRepository>();
        }
        public void Configure(IApplicationBuilder app,
            IHostingEnvironment env) 
        {
            /*
             * Instead of hard-coding connection pool; use configuration files 
             * that specify environment (Development, Staging, Production, etc.)
             */
            if (env.IsDevelopment()) 
            {
                app.UseDeveloperExceptionPage();
            } else 
            {
                app.UseExceptionHandler("/Home/Error");
            }

            // app.UseDefaultFiles();
            app.UseStaticFiles();
            // app.UseFileServer(); 

            // default route
            // app.UseMvcWithDefaultRoute();

            // specified route with lamda anonymous fn
            app.UseMvc( routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=HOME}/{action=Index}/{id?}"

                );
            });

        }
    }
}