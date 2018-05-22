using Dasi.Rd.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dasi.Rd.Data.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Synoda> Synodas { get; set; }
        public DbSet<Fitandremana> Fitandremanas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Synoda>().ToTable("Synoda");
            modelBuilder.Entity<Fitandremana>().ToTable("Fitandremana");
        }
    }
}