using Microsoft.EntityFrameworkCore;
using SwellSpot.Core;
using SwellSpot.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwellSpot.Data
{
    public class SwellSpotDbContext : DbContext
    {
        public SwellSpotDbContext(DbContextOptions<SwellSpotDbContext> options) : base (options)
        {

        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<SeatingPlan> SeatingPlans { get; set; }
        public DbSet<SpotSwell> Spots { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Visit> Visits { get; set; }

        public override int SaveChanges()
        {
            var entries = ChangeTracker
        .Entries()
        .Where(e => e.Entity is RichEntity && (
                e.State == EntityState.Added
                || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((RichEntity)entityEntry.Entity).LastUpdated = DateTime.Now.ToDateString();

                if (entityEntry.State == EntityState.Added)
                {
                    ((RichEntity)entityEntry.Entity).CreatedAt = DateTime.Now.ToDateString();
                }
            }
            return base.SaveChanges();
        }
    }
}
