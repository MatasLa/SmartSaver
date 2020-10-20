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
        private static readonly string EmailAddress = "smartsaverrecovery@gmail.com";
        private static readonly string EmailPassword = "Smartsaver123456";
        private static readonly string RecoveryMessageSubject = "Password Recovery";
        private static readonly string RecoveryMessageBody = "Your password recovery code is: ";
        

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
                return false;
            }
        }

        public static bool Login(string email, string pass)
        {
            using (var db = new DatabaseContext())
            {
                var userInfo = db.Users.Where(a => a.Email == email).FirstOrDefault(); //Find user and pass in db and check if matches

                if (userInfo == null) return false;
                if (HashingProcessor.AreEqual(pass, userInfo.Password, userInfo.Salt))
                {
                    Handler.UserId = userInfo.Id;
                    return true;
                }
                return false;
            }
        }

        public static bool ChangePassword(string email, string pass)
        {
            using (var db = new DatabaseContext())
            {
                var userInfo = db.Users.Where(a => a.Email == email).FirstOrDefault();

                if (userInfo == null) return false;
                
                var salt = HashingProcessor.CreateSalt(20);
                var passwordHash = HashingProcessor.GenerateHash(pass, salt);

                userInfo.Password = passwordHash;
                userInfo.Salt = salt;
                db.SaveChanges();

                return true;
            }
        }

        public static int SendCode(string email)
        {
            using (var db = new DatabaseContext())
            {
                var userInfo = db.Users.Where(a => a.Email == email).FirstOrDefault();

                if (userInfo == null) return 0;

                Random rand = new Random();
                var randomCode = rand.Next(999999);

                var message = new MailMessage();
                message.To.Add(email);
                message.From = new MailAddress(EmailAddress);
                message.Body = RecoveryMessageBody + randomCode;
                message.Subject = RecoveryMessageSubject;

                var smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(EmailAddress, EmailPassword);
                smtp.Send(message);

                return randomCode;
            }
        }

    }
}
