using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ConsoleToWeb {
    class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(async endpoint =>
            {
                endpoint.MapGet("/", async context=> {
                    await context.Response.WriteAsync("Hello World!by Tony");
                });
            });
            app.Run();
        }
       

    }

}