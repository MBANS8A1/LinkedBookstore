using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Sean.LinkedBookStore
{
    public class Startup
    {
        //This method gets called at runtime. Use this method to add services to the container
        //
        public void ConfigureServices(IServiceCollection services) //for dependencies used in the application are defined here
        {
            services.AddControllersWithViews();
        }

        //This method gers called at runtime. Use this method to configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) //for the http applications and using environment of the //application
        {
            //
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.Use(async (context,next) =>
            //{
            //    await context.Response.WriteAsync("A welcome from my first middleware.\n\n");
            //    await next();
            //    await context.Response.WriteAsync("A welcome from my first middleware response.\n\n");

            //});

            //app.Use(async (context,next) =>
            //{
            //    await context.Response.WriteAsync("A welcome from my second middleware.\n\n");
            //    await next();
            //    await context.Response.WriteAsync("A welcome from my second middleware response.\n\n");
            //});

            //app.Use(async (context,next) =>
            //{
            //    await context.Response.WriteAsync("A welcome from my third middleware.\n\n");
            //    await next();
            //    await context.Response.WriteAsync("A welcome from my third middleware response.\n\n");
            //});

            app.UseRouting(); //to enable routing and to map a URL to a particular resource
            app.UseEndpoints(endpoints =>   //for setting up the default routing
            {
                endpoints.MapControllerRoute(
                     name: "default",
                     pattern: "{controller=Home}/{action=Index}/{id?}"
                 );

                //endpoints.MapDefaultControllerRoute(); 
            });
            //app.UseEndpoints(endpoints =>   //for setting up the route to pages
            //{      //Map maps the url "/pages"
            //    endpoints.Map("/pages", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello pages\n\n");
            //    });
            //});
        }
    }
}
   
