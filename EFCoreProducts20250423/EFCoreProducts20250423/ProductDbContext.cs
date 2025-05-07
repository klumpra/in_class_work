using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCoreProducts20250423 {
    internal class ProductDbContext: DbContext {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=rvlsu105--13047; Initial Catalog=ExampleDB20250423;Integrated Security=True;Pooling=False;Encrypt=False");
        }
    }
}
