using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace DotNetFWDbOOP20250416 {
    internal class ProductDb {
        private DbConnection conn;
        private DbCommand cmd;
        public ProductDb(DbConnection conn) {
            this.conn = conn;
            cmd = conn.CreateCommand();
        }
        // list all the products
        public List<Product> GetProducts() {
            cmd.CommandText = "select * from Products";
            List<Product> products = new List<Product>();
            using (DbDataReader reader = cmd.ExecuteReader()) {
                string id, name, desc;
                Product aNewProd;
                while (reader.Read()) {
                    id = Convert.ToString(reader["Id"]);
                    name = Convert.ToString(reader["Name"]);
                    desc = Convert.ToString(reader["Description"]);
                    aNewProd = new Product(id, name, desc);
                    products.Add(aNewProd);
                }
            }
            return products;
        }
        // add a new product
        public bool AddProduct(string id, string name, string desc) {
            cmd.CommandText = $"insert into Products(Id, Name, Description) values ('{id}','{name}','{desc}')";
            int res = cmd.ExecuteNonQuery();
            if (res > 0) {
                return true;
            } else {
                return false;
            }
        }
        public bool AddProduct(Product product) {
            return AddProduct(product.Id, product.Name, product.Description);
        }
    }
}
