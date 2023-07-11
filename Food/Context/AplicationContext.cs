using Microsoft.EntityFrameworkCore;
using Food.Model; 
namespace Food.Context
{
    public class AplicationContext : DbContext
    {
        public DbSet<Foods>? Food { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Food;Username=postgres;Password=djdj15929");
        }
    }
}
