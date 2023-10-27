using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.model
{
    [Serializable]
    public class Serwisy
    {
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }
        public DateTime DataRezerwacjiSerwisu { get; set; }
        public Serwisy(string nazwa, DateTime dataRezerwacjiSerwisu)
        {
            Nazwa = nazwa;
            Cena = 50;
            DataRezerwacjiSerwisu = dataRezerwacjiSerwisu;
        }
        public Serwisy() { }
    }
}
