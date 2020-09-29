using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SmartSaver
{
    public class UserAuth
    {
        public static bool Registration(string email, string pass)
        {
            using (var db = new DatabaseContext())
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
            using (var db = new DatabaseContext())
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
