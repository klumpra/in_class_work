using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFWDbOOP20250416 {
    internal class ProductWriter {
        public static void WriteToScreen(List<Product> products) {
            foreach (Product product in products) {
                Console.WriteLine(product);
            }
        }
    }
}
