using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace aspnetcoreapp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            //app.Run(context =>
            //{
            //    return context.Response.WriteAsync("Hello from ASP.NET Core!");
            //});

	    app.UseMvc();
        }

	public void ConfigureServices(IServiceCollection services)
	{
	    services.AddMvc();
	}
    }
}
