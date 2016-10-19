using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace AddressBook 
{
    public class Startup 
    {
        public void ConfigureServices(IServiceCollection services) 
        {
            // add configuration services for MVC
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) 
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else 
            {
                app.UseExceptionHandler("Home/Error");
            }

            // app.UseDefaultFiles();
            app.UseStaticFiles();
            // app.UseFileServer(); 

            // Add functionality for MVC

            // default route
            app.UseMvcWithDefaultRoute();

            // specified route with lamda anonymous fn
            app.UseMvc( routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=HOME}/{action=Inde}/{id?}"

                );
            });

        }
    }
}