using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCore20250416 {
    internal class ProductDbContext: DbContext {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=rvlsu105--13047; Initial Catalog=ExampleDB;Integrated Security=True;Pooling=False;Encrypt=False");
        }
    }
}
