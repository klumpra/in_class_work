using Microsoft.EntityFrameworkCore;
namespace CarsAndManufacturers
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (CarDbContext db = new CarDbContext()) {
                Manufacturer ford, toyota, honda;
                // see if there is any data in the database
                // specifically, see if there are any manufacturers
                if (!db.Manufacturers.Any()) {
                    // populate the table with three manufacturers
                    ford = new Manufacturer { Name = "Ford", YearFounded = 1903 };
                    toyota = new Manufacturer { Name = "Toyota", YearFounded = 1937 };
                    honda = new Manufacturer { Name = "Honda", YearFounded = 1948 };
                    db.Manufacturers.AddRange(ford, toyota, honda);
                    await db.SaveChangesAsync();
                    // now seed the Car data
                    List<Car> cars = new List<Car> {
                    new Car { Make = "Ford", Model = "Mustang", Year = 2020, Price = 35000, Color = "Red", ManufacturerId = ford.Id },
                    new Car { Make = "Ford", Model = "F-150", Year = 2022, Price = 40000, Color = "Blue", ManufacturerId = ford.Id },
                    new Car { Make = "Toyota", Model = "Camry", Year = 2021, Price = 25000, Color = "White", ManufacturerId = toyota.Id },
                    new Car { Make = "Toyota", Model = "Corolla", Year = 2020, Price = 22000, Color = "Gray", ManufacturerId = toyota.Id },
                    new Car { Make = "Toyota", Model = "RAV4", Year = 2022, Price = 30000, Color = "Black", ManufacturerId = toyota.Id },
                    new Car { Make = "Honda", Model = "Civic", Year = 2020, Price = 23000, Color = "Silver", ManufacturerId = honda.Id },
                    new Car { Make = "Honda", Model = "Accord", Year = 2021, Price = 27000, Color = "Blue", ManufacturerId = honda.Id },
                    new Car { Make = "Honda", Model = "CR-V", Year = 2022, Price = 32000, Color = "Green", ManufacturerId = honda.Id },
                    new Car { Make = "Ford", Model = "Explorer", Year = 2021, Price = 36000, Color = "Black", ManufacturerId = ford.Id },
                    new Car { Make = "Toyota", Model = "Tacoma", Year = 2022, Price = 33000, Color = "Red", ManufacturerId = toyota.Id }
                    };
                    db.Cars.AddRange(cars);
                    await db.SaveChangesAsync();
                } else { // data already exists - grab the manufacturers
                    // retrieve the three manufacturers from the database
                    honda = await db.Manufacturers.FirstOrDefaultAsync(m => m.Name == "Honda");
                    toyota = await db.Manufacturers.FirstOrDefaultAsync(m => m.Name == "Toyota");
                    ford = await db.Manufacturers.FirstOrDefaultAsync(m => m.Name == "Ford");
                }
                // run a bunch of queries to demonstrate getting data
                // 1. Get all the rows and all the columns
                List<Car> allCars = await db.Cars.ToListAsync();
                foreach (Car c in allCars) {
                    Console.WriteLine(c);
                }
                Console.WriteLine();
                // 2. Get all the rows, but only see the Make, Model, and Year of each car
                var majorDetails = await db.Cars.Select(c => new { c.Make, c.Model, c.Year })
                                        .ToListAsync();
                foreach (var md in majorDetails) {
                    Console.WriteLine($"{md.Make}\t{md.Model}\t{md.Year}");
                }
                Console.WriteLine();
                // 3. Grab manufacturer data with your car data
                var joinQueryResults = await db.Cars
                    .Select(c => new { ManufYearFounded = c.Manufacturer.YearFounded, c.Make, c.Model })
                    .ToListAsync();
                foreach (var  jqr in joinQueryResults) {
                    Console.WriteLine($"{jqr.ManufYearFounded}\t{jqr.Make}\t{jqr.Model}");
                }
                Console.WriteLine();
                // 4. Find the Car whose Id is 1
                Car firstCar = await db.Cars.FindAsync(1);
                if (firstCar == null) {
                    Console.WriteLine("There are no cars with id 1.");
                } else {
                    Console.WriteLine(firstCar);
                }
                Console.WriteLine();
                // 5. Find all cars that are either blue or a Honda
                List<Car> blueOrHonda = await db.Cars.Where(
                    c => c.Color == "Blue" || c.ManufacturerId == honda.Id)
                    .ToListAsync();
                foreach(Car boh in blueOrHonda) {
                    Console.WriteLine(boh);
                }
                Console.WriteLine();
                // 6. Return the make, model, and color for all blue cars or hondas
                var blueOrHondaSubset = await db.Cars.Where(
                    c => c.Color == "Blue" || c.ManufacturerId == honda.Id)
                    .Select(x => new { x.Make, x.Model, x.Color })
                    .ToListAsync();
                foreach (var bohs in blueOrHondaSubset) {
                    Console.WriteLine($"{bohs.Make}\t{bohs.Model}\t{bohs.Color}");
                }
                Console.WriteLine();
                // 7. Give me all the columns for the first blue car
                Car firstBlueCar = await db.Cars.FirstOrDefaultAsync(c => c.Color == "Blue");
                if (firstBlueCar == null) {
                    Console.WriteLine("There are no blue cars.");
                } else {
                    Console.WriteLine(firstBlueCar);
                }
                Console.WriteLine();
                // 8. Give me the first second and third Ford
                List<Car> firstTwoCars = await db.Cars.Where(c=>c.Make=="Ford")
                    .Skip(1).Take(2).ToListAsync();
                foreach (Car ftc in firstTwoCars) {
                    Console.WriteLine(ftc);
                }
                Console.WriteLine();
                // 9. Order the cars by year ascending and then by price in descending order
                var carsByPrice = await db.Cars.OrderBy(c => c.Year)
                    .ThenByDescending(c => c.Price)
                    .Select(x => new {x.Make,x.Model,x.Year,x.Price })
                    .ToListAsync();
                foreach (var cbp in carsByPrice) {
                    Console.WriteLine($"{cbp.Make}\t{cbp.Model}\t{cbp.Year}\t{cbp.Price,0:C}");
                }
                Console.WriteLine();
                // 10. Find the average cost by manufacturer
                var avgPriceByMaker = await db.Cars.GroupBy(c => c.Make)
                    .Select(g => new { Maker = g.Key, Avg = g.Average(c => c.Price) })
                    .OrderBy(x => x.Avg)
                    .ToListAsync();
                foreach (var apbm in avgPriceByMaker) {
                    Console.WriteLine($"{apbm.Maker}\t{apbm.Avg,0:C}");
                }
            }
        }
    }
}
