using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ISSApp.Exceptions;

namespace Client.Validator
{
    public static class AnalizaValidator
    {

        //se apeleaza pentru fiecare valoare
        public static void ValidareRezultat(string rezultat)
        {
            var regex = new Regex("^\\-?[0-9]{1,8}(\\.[0-9]{1,8})?$");
            if (!regex.IsMatch(rezultat))
                throw new ValidationException("Rezultat invalid.");
        }
    }
}
