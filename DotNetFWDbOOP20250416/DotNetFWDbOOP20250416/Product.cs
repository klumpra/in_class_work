using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFWDbOOP20250416 {
    internal class Product {
        public string Id { get; set; }
        public string Name { get; set; }    
        public string Description  { get; set; }
        public Product() {
            Id = "ABC";
            Name = "Generic";
            Description = "Boring";
        }
        public Product(string id, string name, string desc) {
            Id = id;
            Name = name;
            Description = desc;
        }
        public override string ToString() {
            return $"{Id}\t{Name}\t{Description}";
        }
    }
}
