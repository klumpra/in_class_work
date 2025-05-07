using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using GuitarManager.Models;

namespace GuitarManager.Database
{
    public class GuitarDbContext : DbContext
    {
        public DbSet<Guitar> Guitars { get; set; }
        public GuitarDbContext(DbContextOptions<GuitarDbContext> options) : base(options) { }

    }
}
