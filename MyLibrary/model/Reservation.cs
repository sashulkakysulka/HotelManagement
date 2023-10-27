using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyLibrary.model
{
    [Serializable]
    public class Reservation
    {
        public DateTime DzienPrzyjazdu { get; set; }
        public DateTime DzienOdjazdu { get; set; }
        public List<Serwisy> ListaSerwisow { get; set; }
        public decimal KosztCalkowity { get; set; }        
        public Reservation(DateTime dzienPrzyjazdu, DateTime dzienOdjazdu, List<Serwisy> listaSerwisow,decimal kosztcalkowity)
        {
            DzienPrzyjazdu = dzienPrzyjazdu;
            DzienOdjazdu = dzienOdjazdu;
            ListaSerwisow = listaSerwisow;
            KosztCalkowity = kosztcalkowity;
        }
        public Reservation() { }
    }
}

