using Microsoft.EntityFrameworkCore;
using LearningEFCore.DatabaseFirst.DAL;

namespace LearningEFCore.DatabaseFirst
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // DbContext instance for database operations and querying
            using (var _context = new AppDbContext())
            {
                // Querying products from the database
                var products = await _context.Products.ToListAsync();
                products.ForEach(p => { Console.WriteLine( $"Id: {p.Id} Name: {p.Name} Price: {p.Price}"); });
            }
        }
    }
}
