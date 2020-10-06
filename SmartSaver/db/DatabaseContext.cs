using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DataBases
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Expenses> Expenses { get; set; }
        public DbSet<Incomes> Incomes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=51.75.187.147;Database=SmartSaver;User Id=usern;Password=123456789;");
        }
    }
}
