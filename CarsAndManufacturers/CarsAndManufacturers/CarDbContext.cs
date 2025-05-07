using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarsAndManufacturers {
    internal class CarDbContext:DbContext {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=RVLSU105--13047;Initial Catalog=CarsAndManufacturers;Integrated Security=True;Encrypt=False");
        }
        // The OnModelCreating gives us a chance to describe the relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Manufacturer>()
                .HasMany(m => m.Cars)  // Cars is the navigation property for Manufacturer
                .WithOne(c => c.Manufacturer)  // Manufacturer is the navigation property for Car
                .HasForeignKey(c => c.ManufacturerId);  // the foreign key
        }
    }
}
