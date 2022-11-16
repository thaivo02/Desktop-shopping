using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sneakerz.Repository;

namespace Sneakerz
{
    public class Program : Form
    {
        private static ApplicationDbContext? _dbContext;

        private static readonly IHost _host = Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddDbContext<ApplicationDbContext>(c =>
                {
                    c.UseSqlServer("Server=localhost;Database=Store;Trusted_Connection=True;Encrypt=False");
                });
                services.AddRepository();
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
            Application.Run(new Lanscape());
        }
    }
}