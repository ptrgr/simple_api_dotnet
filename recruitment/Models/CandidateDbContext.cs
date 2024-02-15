using System;
using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.EntityFrameworkCore;

namespace recruitment.Models
{
    public class CandidateDbContext : DbContext
    {
        private string _connectionString = "Server=(loccaldb)\\mssqllocaldb;Database=CandidateDb;Trusted_Connection=True;";
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Skill> Skills { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Candidate>()
                .Property(c => c.Name)
                .IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(_connectionString);

        }
    }
}