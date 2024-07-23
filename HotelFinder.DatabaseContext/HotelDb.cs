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
            optionsBuilder.UseMySQL("Server=localhost, 3306;Database=HotelFinderDb;User ID=root;Password=Mesut@8541");
        }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Room> Rooms { get; set; }

       

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelRoom>()
                .Property(r => r.Price)
                .HasPrecision(18, 2); // or use .HasColumnType("decimal(18,2)")

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Address>()
                .HasKey(h => h.Id );

            modelBuilder.Entity<Hotel>()
                .HasOne(h => h.Address)
                .WithOne(a => a.Hotel)
                .HasForeignKey<Address>(a => a.Id);

            modelBuilder.Entity<HotelRoom>()
                .HasKey(hr => new { hr.HotelId, hr.RoomId });

            modelBuilder.Entity<HotelRoom>()
                .HasOne(hr => hr.Hotel)
                .WithMany(h => h.Rooms)
                .HasForeignKey(hr => hr.HotelId);



            modelBuilder.Entity<HotelRoom>()
                .HasOne(hr => hr.Room)
                .WithMany(r => r.Hotels)
                .HasForeignKey(hr => hr.RoomId);


        }*/
    }
}






