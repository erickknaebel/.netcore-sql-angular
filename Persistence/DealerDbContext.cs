using DealerApp.Models;
using dotnetcore_sql_angular;
using dotnetcore_sql_angular.Models;
using Microsoft.EntityFrameworkCore;

namespace DealerApp.Persistence
{
    public class DealerDbContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }

        public DbSet<Model> Models { get; set; }

        public DbSet<Feature> Features { get; set;}

        public DbSet<Vehicle> Vehicles { get; set; }

        public DealerDbContext(DbContextOptions<DealerDbContext> options)
        : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleFeature>().HasKey(vf =>
                new { vf.VehicleId, vf.FeatureId });

        }
    }
}