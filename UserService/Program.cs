using BAL;
using Microsoft.EntityFrameworkCore;
using UserService.Context;
using UserService.IRepo;
using UserService.Repo;

namespace UserService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<UserS>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddDbContext<UserDBContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("MyConnectionString")));
            builder.Services.AddConsulConfig(builder.Configuration); ;

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.UseConsul(builder.Configuration);
            app.MapControllers();

            app.Run();
        }
    }
}