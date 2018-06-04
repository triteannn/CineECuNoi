using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Serializable]
    [Table("Accounts")]
    public class Account
    {
        public Account() { }

        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public Account(int id, string username, string password, int idD, int idM, int idAc)
        {
            Id = id;
            Username = username;
            Password = password;
            IdD = idD;
            IdM = idM;
            IdAc = idAc;
        }

        public Account(int id, string username, string password, int? idD, int? idM, int? idAc)
        {
            Id = id;
            Username = username;
            Password = password;
            IdD = idD;
            IdM = idM;
            IdAc = idAc;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public int? IdD { get; set; }
        public int? IdM { get; set; }
        public int? IdAc { get; set; }

        public virtual Donator Donator { get; set; }
        public virtual Medic Medic { get; set; }
        public virtual AngajatCentru AngajatCentru { get; set; }
    }
}