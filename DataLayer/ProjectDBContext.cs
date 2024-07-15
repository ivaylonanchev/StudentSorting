using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext() : base()
        {

        }

        public ProjectDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-FE75MLC\\SQLEXPRESS;Database=StudentSorting;TrustServerCertificate=true; Integrated Security=True;");
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>()
            .HasIndex(u => u.Email)
            .IsUnique();
            modelBuilder.Entity<Profile>()
            .HasIndex(u => u.EGN)
            .IsUnique();

        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Application> Applications { get; set; }


    }
}
