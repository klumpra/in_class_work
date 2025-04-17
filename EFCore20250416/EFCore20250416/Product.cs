using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore20250416 {
    internal class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public string Abbreviation { get; set; }
        public Product() {
            Id = 0;
            Name = "";
            Description = "";
            Cost = 0;
            Abbreviation = "";
        }
        public Product(int id, string name, string desc, double cost, string abbr) {
            Id = id;
            Name = name;
            Description = desc;
            Cost = cost;
            Abbreviation = abbr;
        }
        public override string ToString() {
            return $"{Id}\t{Name}\t{Description}\t{Cost:C}\t{Abbreviation}";
        }
    }
}
