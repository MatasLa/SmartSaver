using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using ePiggy.DataBase;
using ePiggy.DataBase.Models;

namespace ePiggy.Authentication
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

        public static bool ChangePassword(string email, string pass)
        {
            using (var db = new DatabaseContext())
            {
                var userInfo = db.Users.Where(a => a.Email == email).FirstOrDefault();

                if (userInfo != null)
                {
                    var salt = HashingProcessor.CreateSalt(20);
                    var passwordHash = HashingProcessor.GenerateHash(pass, salt);

                    userInfo.Password = passwordHash;
                    userInfo.Salt = salt;
                    db.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static int SendCode(string email)
        {
            using (var db = new DatabaseContext())
            {
                var userInfo = db.Users.Where(a => a.Email == email).FirstOrDefault();

                if (userInfo != null)
                {
                    string from, pass, messageBody;
                    Random rand = new Random();
                    int randomCode = rand.Next(999999);
                    MailMessage message = new MailMessage();
                    from = "smartsaverrecovery@gmail.com";
                    pass = "Smartsaver123456";
                    messageBody = "Your password recovery code is: " + randomCode;
                    message.To.Add(email);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Password Recovery";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);

                    smtp.Send(message);
                    return randomCode;
                }
                else return 0;
            }
        }

    }
}
