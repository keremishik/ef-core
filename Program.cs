using Microsoft.EntityFrameworkCore;
using LearningEFCore.DatabaseFirst.DAL;

namespace LearningEFCore.DatabaseFirst
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Initialize DbContextOptions
            DbContextInitializer.Build();
            // DbContext instance for database operations and querying
            using (var _context = new AppDbContext(DbContextInitializer.OptionsBuilder.Options))
            {
                // Querying products from the database
                var products = await _context.Products.ToListAsync();
                products.ForEach(p => 
                {
                    Console.WriteLine( $"Id: {p.Id} Name: {p.Name} Price: {p.Price}"); 
                });
            }
        }
    }
}
