using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using DataManager;
using ePiggy;

namespace DataBases
{
    public class UserAuth
    {
        public static bool Registration(string email, string pass)
        {
            using (var db = new DatabaseContext())
            {
                var userInfo = db.Users.Where(a => a.Email == email).FirstOrDefault(); //Find if email is in db
                if (userInfo == null)
                {
                    var user = new User { Email = email, Password = pass };
                    db.Add(user);
                    db.SaveChanges();

                    Handler.UserId = user.Id;
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
                var userInfo = db.Users.Where(a => a.Email == email && a.Password == pass).FirstOrDefault(); //Find user and pass in db and check if matches

                if (userInfo != null)
                {
                    Handler.UserId = userInfo.Id;
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
