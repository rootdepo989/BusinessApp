using BusinessApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessApp.DbOperations
{
    public class AppContextDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=MYDB;Trusted_Connection=true");
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Rasim> SalesOfRasim { get; set; }
        public DbSet<Kamil> SalesOfKamil { get; set; }
        public DbSet<Xalid> SalesOfXalid { get; set; }
        public DbSet<Senuber> SalesOfSenuber { get; set; }
        public DbSet<Sebine> SalesOfSebine { get; set; }
        public DbSet<Credit> Credits { get; set; }

    }
}
