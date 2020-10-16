using System;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Linq;
using ePiggy.forms;
using ePiggy.utilities;

namespace ePiggy.Authentication
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

            if (password.Equals(confirmPass)) return true;
            form.ChangeErrorText(2);
            return false;
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
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                ExceptionHandler.Log(e.ToString());
                return false;
            }
            catch (ArgumentException e)
            {
                ExceptionHandler.Log(e.ToString());
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
            var uppers = pass.Count(char.IsUpper);
            var digits = pass.Count(char.IsDigit);
            var symbols = pass.Count(char.IsSymbol);
            symbols += pass.Count(char.IsPunctuation);
            
            if (uppers < 1) return false;
            if (digits < 1) return false;
            if (symbols < 1) return false;
            return true;
        }
    }
}
