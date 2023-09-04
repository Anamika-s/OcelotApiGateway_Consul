using Microsoft.Extensions.Configuration;
using Serilog;
using System.Reflection;

namespace ProductService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var log4netRepository = log4net.LogManager.GetRepository(Assembly.GetEntryAssembly());
            log4net.Config.XmlConfigurator.Configure(log4netRepository, new FileInfo("log4net.config"));

            // Add services to the container.
            //builder.Logging.AddConfiguration();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddConsulConfig(builder.Configuration); ;
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();
            app.UseConsul(builder.Configuration);
            app.Run();
        }
    }
}