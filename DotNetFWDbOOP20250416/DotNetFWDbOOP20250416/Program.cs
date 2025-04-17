using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFWDbOOP20250416 {
    internal class Program {

        static ProductDb GetNewProductDb() {
            string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
            DbConnection connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            ProductDb pdb = new ProductDb(connection);
            return pdb;
        }
        static void Main(string[] args) {
            ProductDb pdb = GetNewProductDb();
            List<Product> products = pdb.GetProducts();
            ProductWriter.WriteToScreen(products);
            Console.WriteLine();
            pdb.AddProduct("CHX", "Chex", "Really really bland tasteless crap.");
            products = pdb.GetProducts();
            ProductWriter.WriteToScreen(products);
        }
    }
}
