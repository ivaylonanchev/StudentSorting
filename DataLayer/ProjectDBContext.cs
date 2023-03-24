using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using Renci.SshNet.Messages;
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
            optionsBuilder.UseMySQL("Server=127.0.0.1;Database=SchoolDb3;Uid=root;Pwd=123456789;");
            /*optionsBuilder.UseInMemoryDatabase("SchoolDb");*/


            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<CompetitionScore>()
                .HasOne(cs => cs.StudentEGN)
                .WithMany(s => s.CompetitionScores)
                .HasForeignKey(cs => cs.StudentEGN);*/

        }



        public DbSet<Student> Students{ get; set; }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Competition> Competitions { get; set; }

        public DbSet<CompetitionScore> CompetitionScores { get; set; }
    }
}
