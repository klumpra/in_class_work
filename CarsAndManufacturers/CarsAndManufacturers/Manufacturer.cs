using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndManufacturers {
    internal class Manufacturer {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearFounded { get; set; }
        // navigation property - easily follow foreign-key relationships
        public List<Car> Cars;
        public override string ToString() {
            return $"{Id}\t{Name}\t{YearFounded}";
        }
    }
}
