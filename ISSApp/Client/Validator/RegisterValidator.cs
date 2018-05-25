using ISSApp.Exceptions;
using System.Text.RegularExpressions;

namespace Client.Validator
{
    public static class RegisterValidator
    {
        public static void ValidateCnp(string cnp)
        {
            var regex = new Regex("^[0-9]+$");
            if (!regex.IsMatch(cnp))
                throw new ValidationException("CNP must only contain digits.");
            if (cnp.Length != 13 || (cnp[0] != '1' && cnp[0] != '2' && cnp[0] != '5' && cnp[0] != '6') || int.Parse(cnp.Substring(3, 2)) > 12 || int.Parse(cnp.Substring(3, 2)) < 1 || int.Parse(cnp.Substring(5, 2)) < 1 || int.Parse(cnp.Substring(5, 2)) > 31)
                throw new ValidationException("Invalid CNP.");
        }

        public static void ValidateFirstName(string firstname)
        {
            var regex = new Regex("^[a-zA-Z]+$");
            if (!regex.IsMatch(firstname))
                throw new ValidationException("First name must not contain digits.");
        }

        public static void ValidateLastName(string lastname)
        {
            var regex = new Regex("^[a-zA-Z]+$");
            if (!regex.IsMatch(lastname))
                throw new ValidationException("Last name must not contain digits.");
        }

        public static void ValidateUsername(string username)
        {
            if (username.Length < 5)
                throw new ValidationException("Username must be at least 5 characters long.");
        }

        public static void ValidatePassword(string password)
        {
            if (password.Length < 5)
                throw new ValidationException("Password must be at least 5 characters long.");
        }
    }
}
