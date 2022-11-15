using Microsoft.EntityFrameworkCore;
using Sneakerz.Entity;

namespace Sneakerz
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=localhost\\SQLExpress;Initial Catalog=Store;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            
        }
    }
}
