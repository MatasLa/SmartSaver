using System.Linq;
using ePiggy.DataBase;
using ePiggy.DataBase.Models;

namespace ePiggy.Auth
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
                    var salt = HashingProcessor.CreateSalt(20);
                    var passwordHash = HashingProcessor.GenerateHash(pass, salt);

                    var user = new User { Email = email, Password = passwordHash, Salt = salt };
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
                var userInfo = db.Users.Where(a => a.Email == email).FirstOrDefault(); //Find user and pass in db and check if matches

                if (userInfo != null)
                {
                    if (HashingProcessor.AreEqual(pass, userInfo.Password, userInfo.Salt))
                    {
                        Handler.UserId = userInfo.Id;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
