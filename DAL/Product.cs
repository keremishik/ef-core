using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEFCore.DatabaseFirst.DAL
{
    // Entity classes are special classes that represent database tables
    // Unlike regular classes:
    // - Entities are mapped to database tables
    // - Their properties correspond to table columns
    // - They can have relationships with other entities
    // - They are tracked by Entity Framework for change detection
    // - They often include data annotations and configurations
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
