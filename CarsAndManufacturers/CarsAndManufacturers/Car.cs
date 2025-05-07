using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndManufacturers {
    internal class Car {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }

        public int ManufacturerId { get; set; } //foreign key
        // navigation property - easy to navigate to the related object
        public Manufacturer Manufacturer { get; set; }
        public override string ToString() {
            return $"{Id}\t{Make}\t{Model}\t{Year}\t{Price,0:C}\t{Color}\t{ManufacturerId}";
        }
    }
}
