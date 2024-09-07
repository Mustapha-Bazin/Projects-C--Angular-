
using BL.User;
using DAL.User;
using DB.Database;
using Interfaces.BL;
using Interfaces.DAL;
using Microsoft.EntityFrameworkCore;

namespace Library
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //DB
            builder.Services.AddDbContext<DbLibrary>(option=> option.UseMySql(
                builder.Configuration.GetConnectionString("DefaultConnection"),ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<IUserDAL, UserDAL>();
            builder.Services.AddTransient<IUserBL, UserBL>();

            builder.Services.AddCors();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(c=>c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            app.MapControllers();

            app.Run();
        }
    }
}
