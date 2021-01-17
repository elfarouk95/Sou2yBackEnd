using System;
using Entitis.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Souqe.Extentions
{
    public static class ServiceExtention
    {
        public static void configreCors(this IServiceCollection services)
        {

            services.AddCors(optins =>
            {
                optins.AddPolicy("CorsPolicy", builder =>
               {
                   builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
               });
            });
        }

        public static void ConfigreDBContext (this IServiceCollection services , IConfiguration configuration)
        {

            services.AddDbContext<RepositoryContext>(option =>
            {
                 option.UseSqlite("Data Source=Database.db" , b=> {
                     b.MigrationsAssembly("Souqe");
                 });
        });
        }
    }
}
