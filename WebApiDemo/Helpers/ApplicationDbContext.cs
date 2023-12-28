﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApiDemo.Entities;

namespace WebApiDemo.Helpers
{
    public class ApplicationDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));

            // in memory database used for simplicity, change to a real db for production applications
            //options.UseInMemoryDatabase("InMemoryDb");
        }

        public DbSet<User> Users { get; set; }
    }
}
