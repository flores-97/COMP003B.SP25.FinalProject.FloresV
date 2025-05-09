//Author: Victor Flores
//Course: COMP-003B: ASP.NET Core
//Instructor: Jonathon Cruz
//Purpose: Final Project synthesizing MVC, Web API, EF Core, and middleware

using COMP003B.SP25.FinalProject.FloresV.Data;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.SP25.FinalProject.FloresV
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<WebDevAcademyContext>(options => options.UseSqlServer("Name=ConnectionStrings:DefaultConnection"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseMiddleware<COMP003B.SP25.FinalProject.FloresV.Middleware.RequestTimingMiddleware>();

            app.UseWelcomePage("/welcome");

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
