
using ECom.Persistence.Data;
using ECom.Persistence.Interfaces;
using ECom.Persistence.Repositories;
using ECom.Service.Mappings;
using ECom.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StackExchange.Redis;

namespace ECom.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //inject db
            if (builder.Environment.IsProduction())
            {
                builder.Services.AddDbContext<EComDbContext>(options =>
                       options.UseNpgsql(builder.Configuration.GetConnectionString("EComConnectionStrings")));
            }
            else
            {
                builder.Services.AddDbContext<EComDbContext>(options =>
                    options.UseInMemoryDatabase(databaseName: "EComDb"));
            }



            // inject repository
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IProductService, ProductService>();

            //caching
            builder.Services.AddMemoryCache();



            // inject automapper
            builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
                app.UseSwagger();
                app.UseSwaggerUI();
            //}

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
