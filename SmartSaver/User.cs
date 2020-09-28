using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace SmartSaver
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=51.75.187.147;Database=SmartSaver;User Id=usern;Password=123456789;");
        }

    }

    public class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Password { get; set; }

        public static bool Registration(string email, string pass)
        {
            using (var db = new UserContext())
            {
                var data = db.Users.Where(a => a.Email == email).ToList();

                if (data.Equals(null))
                {
                    db.Add(new User { Email = email, Password = pass });
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool Login(string email, string pass)
        {
            using (var db = new UserContext())
            {
                var data = db.Users.Where(a => a.Email == email && a.Password == pass).ToList();

                if (!data.Equals(null))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }


}