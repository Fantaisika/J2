using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TPJ2
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();//ajout des controllers et views (1)
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();//(2)
            app.UseRouting();

           

            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "Ajouter/{valeur1}/{valeur2}",
                    defaults: new { controller = "Calculateur", action = "Ajouter" });
            });
            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(
                    name: "Calculer1",
                    pattern: "{action}/{valeur1}/{valeur2}",
                    defaults: new { controller = "Calculateur", action = "Multiplier" });

                endpoints.MapControllerRoute(
                    name: "Calculer2",
                    pattern: "Ajout/{valeur1}/{valeur2}",
                    defaults: new { controller = "Calculateur", action = "Ajouter" });
            });
            app.UseEndpoints(endpoints => //(3)
            {

                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}