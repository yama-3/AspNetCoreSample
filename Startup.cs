using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace aspnetcoreapp
{
    public class Startup
    {
	public void ConfigureServices(IServiceCollection services)
	{
	    services.AddMvc();

	    services.AddScoped<IBookStoreRepository, BookStoreRepository>();

	    services.AddDbContext<BookStoreContext>(_ => _.UseInMemoryDatabase());
	}

        public void Configure(IApplicationBuilder app)
        {
            //app.Run(context => { return context.Response.WriteAsync("Hello from ASP.NET Core!"); });
	    app.UseMvc();

	    app.SeedData();
        }
    }
}
