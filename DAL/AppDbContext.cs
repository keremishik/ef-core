using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LearningEFCore.DatabaseFirst.DAL
{
    public class AppDbContext:DbContext
    {
        // DbSet properties represent database tables and allow querying/saving of entity instances
        // My Product Table Entity
        public DbSet<Product> Products { get; set; }

        //====================== CONSTRUCTORS ===================================//
        // Default constructor
        public AppDbContext() {}
        // Constructor with DbContextOptions
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
        //=======================================================================//
    }
}
