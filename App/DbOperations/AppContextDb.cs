using Microsoft.EntityFrameworkCore;
using MyBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBusiness.DbOperations
{
    public class AppContextDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=BusinessDB;Trusted_Connection=true");
        }

        public DbSet<Admin> Admins { get; set; }

    }
}
