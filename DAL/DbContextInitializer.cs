﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LearningEFCore.DatabaseFirst.DAL
{

    internal class DbContextInitializer
    {
        // for reading connection string from appsettings.json
        public static IConfigurationRoot Configuration;

        // for building DbContextOptions
        public static DbContextOptionsBuilder<AppDbContext> OptionsBuilder;
        
        public static void Build()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
            OptionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            OptionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlCon"));

        }
    }
}
