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
        public void Configure(IApplicationBuilder app) 
        {
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