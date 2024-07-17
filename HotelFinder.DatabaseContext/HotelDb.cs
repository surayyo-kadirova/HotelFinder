using System;
using System.Collections.Generic;
using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelFinder.DatabaseContext
{
    public class HotelDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=sql-server8541.database.windows.net, 1433;Database=HotelDb;User ID=surayyo;Password=Mesut@8541");
        }

        public DbSet<Hotel> Hotels { get; set; }
    }
}

