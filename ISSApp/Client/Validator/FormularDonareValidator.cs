using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ISSApp.Exceptions;

namespace Client.Validator
{
    public static class FormularDonareValidator
    {

        public static void ValidateAdresa(string adresa)
        {
            var regex = new Regex("^[a-zA-Z]+(\\s[a-zA-Z]+)*\\s[1-9][0-9]*[a-zA-Z]?$");
            if (!regex.IsMatch(adresa))
                throw new ValidationException("Adresa invalida.");
        }

        public static void ValidareOras(string oras)
        {
            var regex = new Regex("^[a-zA-Z]+(\\s[a-zA-Z]+)*$");
            if (!regex.IsMatch(oras))
                throw new ValidationException("Oras invalid.");
        }

        public static void ValidareTara(string tara)
        {
            var regex = new Regex("^[a-zA-Z]+(\\s[a-zA-Z]+)*$");
            if (!regex.IsMatch(tara))
                throw new ValidationException("Tara invalida.");
        }

        public static void ValidareEmail(string email)
        {
            var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)(\.(\w){2,3})$");
            if (!regex.IsMatch(email))
                throw new ValidationException("Email invalida.");
        }

        public static void ValidareTelefon(string telefon)
        {
            if(telefon.Length != 10)
                throw new ValidationException("Telefon invalid");
             
            var regex = new Regex("^0[1-9][0-9]{8,8}$");
            if (!regex.IsMatch(telefon))
                throw new ValidationException("Telefon invalid.");
        }

        public static void ValidareTarget(string target)
        {
            var regex = new Regex("^[a-zA-Z]+(\\s[a-zA-Z]+)+$");
            if (!regex.IsMatch(target))
                throw new ValidationException("Target invalid.");
        }

    }
}
