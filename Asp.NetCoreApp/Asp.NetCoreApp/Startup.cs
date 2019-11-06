using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Asp.NetCoreApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            RouteBuilder routeBuilder = new RouteBuilder(app);

            routeBuilder.MapRoute("{controller}", async (context) =>
            {
                await context.Response.WriteAsync(context.GetRouteValue("controller").ToString());
            });

            routeBuilder.MapRoute("{value1}/{value2}", async (context) =>
            {
                int num1, num2;
                int.TryParse(context.GetRouteValue("value1").ToString(), out num1);
                int.TryParse(context.GetRouteValue("value2").ToString(), out num2);
                await context.Response.WriteAsync($"{num1 * num2}");
            });

            app.UseRouter(routeBuilder.Build());

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Default page");
            });
        }
    }
}
