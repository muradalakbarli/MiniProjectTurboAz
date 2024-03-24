using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;


namespace TurboAz
{
    public class YourDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Announcement> Announcements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database connection
            optionsBuilder.UseSqlServer("Server=localhost;Database=TurboAz;User Id=sa;Password=! Dquery20@3;");

        }
    }
}

