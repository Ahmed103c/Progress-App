using BackendApi.Models;
using Microsoft.EntityFrameworkCore;


namespace BackendApi.Data
{
 
    public class ProgressContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ProgressContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("progressApiTimeData"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Progress>()
                .HasKey(p => new { p.userId, p.DayOftheMonth });
        }
        public DbSet<Progress> Progress { get; set; }

    }
}
