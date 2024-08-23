using Microsoft.EntityFrameworkCore;
using MyWinFormsApp.Models;
using System.Collections.Generic;

namespace MyWinFormsApp.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

         public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=maktab;Username=postgres;Password=h9311240246N");
            }
        }
    }
}
