using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using AddressBook.Services;

namespace AddressBook 
{
    public class Startup 
    {
        public void ConfigureServices(IServiceCollection services) 
        {
            // add configuration services for MVC
            services.AddMvc();
            services.AddSingleton<IContactRepository, 
                InMemoryContactRepository>();
        }
        public void Configure(IApplicationBuilder app,
            IHostingEnvironment env) 
        {
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