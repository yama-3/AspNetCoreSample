using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

public static class BookContextSeeder {
  public static void SeedData(this IApplicationBuilder app) {
    var context = app.ApplicationServices.GetService<BookStoreContext>();
    context.Books.Add(new Book {Id=1, Title="Mastering ASP.NET Core MVC", Author="John Doe"});
    context.Books.Add(new Book {Id=2, Title="ASP.NET Core MVC in Action", Author="Jane Doe"});
    context.SaveChanges();
  } 
}