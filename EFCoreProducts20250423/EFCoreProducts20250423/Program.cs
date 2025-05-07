using Microsoft.EntityFrameworkCore;
namespace EFCoreProducts20250423
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (ProductDbContext pdb = new ProductDbContext()) {
                Product p1 = new Product(0, "Lucky Charms", "Sugar Goodness", 4.69, "LCK");
                Product p2 = new Product(0, "Chex", "Tasteless and Mushy", 3.79, "CHX");
                pdb.Products.AddRange(p1, p2);
                await pdb.SaveChangesAsync();
                Console.WriteLine("Now going to retrieve: ");
                List<Product> retrieved = await pdb.Products.ToListAsync<Product>();
                foreach (Product p in retrieved) {
                    Console.WriteLine(p);
                }
            }
        }
    }
}
