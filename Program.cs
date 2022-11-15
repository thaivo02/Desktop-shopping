using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Sneakerz
{
    public class Program : Form
    {
        private static ApplicationDbContext? _dbContext;
        
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Lanscape());
        }

        protected override void OnLoad(EventArgs e)
        {   
            base.OnLoad(e);

            _dbContext = new ApplicationDbContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            _dbContext.Database.EnsureCreated();
            _dbContext.Items.Load();
        }
    }
}