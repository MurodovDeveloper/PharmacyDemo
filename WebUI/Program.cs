using Domain;
using Application;
using Infrastructure;
using WebUI.Middlewares;

namespace WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stream stream = new MemoryStream();
           
          
                AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
                var builder = WebApplication.CreateBuilder(args);
                IConfiguration configuration = builder.Configuration;

                builder.Services.AddInfrastructureServices(configuration);
                builder.Services.AddApplicationServices(configuration);

                builder.Services.AddDomainServices(configuration);
                builder.Services.AddUIServices(configuration);

                WebApplication app = builder.Build();
                app.UseExeptionHandling();

                if (app.Environment.IsDevelopment())
                {
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }

                app.UseHttpsRedirection();

                app.UseAuthentication();
                app.UseAuthorization();

                app.MapControllers();

                app.Run();

         
        }
    }
}