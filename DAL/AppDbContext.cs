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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ISTNB0630\\SQLEXPRESS;Initial Catalog=LearningEFCore.DatabaseFirstDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
