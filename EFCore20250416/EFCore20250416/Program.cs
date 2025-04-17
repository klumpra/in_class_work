namespace EFCore20250416
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product prod1 = new Product(0, "Cheerios", "Tasteless Circles", 6.49, "CHE");
            Product prod2 = new Product(0, "Lucky Charms", "Irish Cereal", 5.59, "LKC");
            // create a ProductDbContext to talk with the db
            using (ProductDbContext pdb = new ProductDbContext()) {
                pdb.Products.Add(prod1);
                pdb.Products.Add(prod2);
                pdb.SaveChanges();
                List<Product> products = pdb.Products.ToList();
                List<Product> filtered = pdb.Products.Where<Product>(p => p.Name == "Cheerios").ToList<Product>();
                foreach (Product product in products) {
                    Console.WriteLine(product);
                }
                foreach (Product product in filtered) {
                    Console.WriteLine(product);
                }
            }
        }
    }
}
