using Forms;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Globalization;

namespace DataManager
{
    public static class AuthValidator
    {
        public static bool RegisterValidation(FormRegister form, string email, string pass, string passConfirm)
        {
            if (!IsValidEmail(email))
            {
                form.ChangeErrorText(0);
                return false;
            }
            if (!IsValidPassword(form, pass, passConfirm))
            {
                return false;
            }
            return true;
        }

        private static bool IsValidPassword(FormRegister form, string password, string confirmPass)
        {
            if (password.Length < 8)
            {
                form.ChangeErrorText(1);
                return false;
            }

            if (!IsPasswordComplex(password))
            {
                form.ChangeErrorText(3);
                return false;
            }

            if (!password.Equals(confirmPass))
            {
                form.ChangeErrorText(2);
                return false;
            }
            return true;
        }

        private static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private static bool IsPasswordComplex(string pass)
        {
            //var letters = 0;
            var digits = 0;
            var uppers = 0;
            var symbols = 0;
            foreach (var ch in pass)
            {
                /* if (char.IsLetter(ch))
                 {
                     letters++;
                     if (char.IsUpper(ch)) uppers++;
                 }*/
                if(char.IsUpper(ch)) uppers++;

                if (char.IsDigit(ch)) digits++;

                if (char.IsSymbol(ch))
                {
                    symbols++;
                }else if (char.IsPunctuation(ch)) symbols++;

            }

            if (uppers < 1) return false;
            if (digits < 1) return false;
            if (symbols < 1) return false;
            return true;
        }
    }
}
