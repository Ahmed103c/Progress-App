using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using BackendApi.Models;

namespace BackendApi.Data
{
    public class UserContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public UserContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("progressApiUsers"));
        }
        public DbSet<User> Users { get; set; }

    }
}

