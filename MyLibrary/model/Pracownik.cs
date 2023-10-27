using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.model
{
    [Serializable]
    public class Pracownik : Osoba

    {
        public string Password { get; set; }
        public string Stanowisko { get; set; }
        public string Mail { get; set; }
        public Pracownik(string imie, string nazwisko, string obywatelstwo,
            DateTime dataUrodzenia, string typDokumentu, string numerDokumentu,string password, string stanowisko, string mail):
            base(imie, nazwisko,  obywatelstwo,
             dataUrodzenia,  typDokumentu, numerDokumentu)
        {
            Password = password;
            Stanowisko = stanowisko;
            Mail = mail;
        }
        public Pracownik() { }
    }
}
