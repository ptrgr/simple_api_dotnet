using System;
using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.EntityFrameworkCore;

namespace recruitment.Models
{
    public class CandidateDbContext : DbContext
    {
      
            public CandidateDbContext(DbContextOptions<CandidateDbContext> options) : base(options)
            { 
            }
          
            public DbSet<Candidate> Candidates { get; set; }
            public DbSet<Address> Addresses { get; set; }
            public DbSet<Position> Positionss { get; set; }
            public DbSet<Skill> Skills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Candidate>(eb =>
            {
                {
                    eb.Property(c => c.Name).IsRequired();
                    eb.Property(c => c.LastName).IsRequired();
                    eb.HasOne(c => c.Address)
                    .WithOne(a => a.Candidate)
                    .HasForeignKey<Address>(a => a.CandidateId);
                    eb.HasMany(c => c.Skills)
                    .WithMany(s => s.Candidates);
                }
            });
            modelBuilder.Entity<Address>(eb =>
            {
                {
                    eb.Property(c => c.City).IsRequired();
                 
                }
            });

            modelBuilder.Entity<Position>(eb =>
            {
                eb.HasMany(p => p.Candidates)
                .WithOne(c => c.Position)
                .HasForeignKey(c => c.PositionId);
            });
        }
    }
}