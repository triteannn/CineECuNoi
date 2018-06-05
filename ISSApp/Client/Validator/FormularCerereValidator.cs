using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ISSApp.Exceptions;

namespace Client.Validator
{
    public static class FormularCerereValidator
    {
        public static void ValidareNume(string nume)
        {
            var regex = new Regex("^[a-zA-Z]+(\\s[a-zA-Z]+)+$");
            if (!regex.IsMatch(nume))
                throw new ValidationException("Numele invalid.");
        }

        public static void ValidareGrupa(string grupa)
        {
            bool ok = false;

            var regex = new Regex("^[aA][bB]?$");
            if (regex.IsMatch(grupa))
                ok = true;

            regex = new Regex("^[bB]$");
            if (regex.IsMatch(grupa))
                ok = true;

            regex = new Regex("^0$");
            if (regex.IsMatch(grupa))
                ok = true;

            if (!ok)
                throw new ValidationException("Grupa invalida.");
        }

        public static void ValidareRh(string rh)
        {
            if (!(rh.Equals("negative") || rh.Equals("positive") || rh.Equals("Negative") || rh.Equals("Positive")))
                throw new ValidationException("Rh-ul invalid.");
        }

        //cansideram ca trebuie sa avem cantitate minima de 100 ml
        public static void ValidarePlasma(string plasma)
        {
            var regex = new Regex("^[1-9][0-9]{2,}$");
            if(!regex.IsMatch(plasma))
                throw new ValidationException("Cantitatea de plasma invalida.");
        }

        public static void ValidareGlobule(string globule)
        {
            var regex = new Regex("^[1-9][0-9]{2,}$");
            if (!regex.IsMatch(globule))
                throw new ValidationException("Cantitatea de globule invalida.");
        }

        public static void ValidareTrombocite(string trombocite)
        {
            var regex = new Regex("^[1-9][0-9]{2,}$");
            if (!regex.IsMatch(trombocite))
                throw new ValidationException("Cantitatea de trombocite invalida.");
        }


    }
}
