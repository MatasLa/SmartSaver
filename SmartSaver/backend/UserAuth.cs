using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;

namespace EPiggy
{
    public class UserAuth
    {
        public static bool Registration(string email, string pass)
        {
            using (var db = new DatabaseContext())
            {
                var data = db.Users.Where(a => a.Email == email).FirstOrDefault(); //Find if email is in db
                if (data == null)
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
            using (var db = new DatabaseContext())
            {
                var data = db.Users.Where(a => a.Email == email && a.Password == pass).FirstOrDefault(); //Find user and pass in db and check if matches

                if (data != null)
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
