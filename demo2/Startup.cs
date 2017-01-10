

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

public class Startup {


    public void Configure(IApplicationBuilder app,IHostingEnvironment env, ILoggerFactory loggerFactory  ){
        app.Run(async context => await context.Response.WriteAsync("Hello World!") );
    }


    public void ConfigureServices(IServiceCollection serviceCollection){

    }


}