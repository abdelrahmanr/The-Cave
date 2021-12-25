using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WinFormsApp5;

namespace TheCave
{
    public class Repo : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite("Data Source = theCave.db");
        }

        public DbSet<Room> rooms { get; set; }
        public DbSet<User> users { get; set; }

        public DbSet<Client> clients { get; set; }

        public DbSet<Booking> bookings { get; set; }

        public DbSet<order> orders { get; set; }

        public DbSet<Product> products { get; set; }
        public DbSet<RoomType> roomTypes { get; set; }




    }
}