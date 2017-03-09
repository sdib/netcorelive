using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using netcorelive.Controllers.WheatherForecast;

namespace netcorelive
{
    public class Startup 
    {

        public Startup(IHostingEnvironment env)
        {
              HostingEnvironment = env;
        }
        public IHostingEnvironment HostingEnvironment { get; private set; }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory) 
        {
            loggerFactory.AddConsole();
            loggerFactory.AddDebug();
           
            // app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        public void ConfigureServices(IServiceCollection services) 
        {
            services.AddMvc();
            if(HostingEnvironment.IsDevelopment()){
                services.AddTransient<IDataService, MockDataService>();
            } else {
               services.AddTransient<IDataService, RealDataService>();
            }
        }

    }
}