using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace banger.Models
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {
            var builder = new ConfigurationBuilder().SetBasePath
               (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var configuration = builder.Build();
        }

        public DbSet<Users> Users { get; set; }

        public DbSet<Vehicle> Vehicle { get; set; }

        public DbSet<AddOns> AddOns { get; set; }

        public DbSet<Bookings> Bookings { get; set; }

    }
}