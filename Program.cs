using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sneakerz.Repository;
using Sneakerz.Services;

namespace Sneakerz
{
    public class Program : Form
    {
        private static ApplicationDbContext? _dbContext;

        public static IHost _host = Host.CreateDefaultBuilder()
        .ConfigureServices(services =>
        {
            services.AddDbContext<ApplicationDbContext>(c =>
            {
                c.UseSqlServer("Server=localhost;Database=Store;Trusted_Connection=True;Encrypt=False");
            });
            services.AddRepository();
            services.AddServices();
            services.AddTransient<Lanscape>();
            services.AddTransient<Info>();
        }).Build(); 
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            _host.Start();
            ApplicationConfiguration.Initialize();
            Application.Run(_host.Services.GetRequiredService<Lanscape>());
        }
    }
}