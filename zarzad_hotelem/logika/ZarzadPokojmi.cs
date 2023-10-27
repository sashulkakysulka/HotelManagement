using GUI;
using MyLibrary.fileservice;
using MyLibrary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace zarzad_hotelem.logika
{
    public class ZarzadPokojmi : IZarzadPokojmi
    {
        public List<Room> Pokoje = new List<Room>();
        IFileService<Room> fileService = new XmlFileService<Room>();
        public ZarzadPokojmi()
        {
            WygenerujPokoje();
        }

        public bool CzyKoliduje(Reservation NowaRezerwacja, Reservation rezerwacja)
        {
            return (rezerwacja.DzienOdjazdu >= NowaRezerwacja.DzienPrzyjazdu) ||
                (rezerwacja.DzienPrzyjazdu <= NowaRezerwacja.DzienOdjazdu);
        }

        public bool CzyWolny(Room pokoj, DateTime rezerwacjaP, DateTime rezerwacjaW)
        {
            if (pokoj.ListaRezerwacji == null || pokoj.ListaRezerwacji.Count == 0)
            {
                return true;
            }

            foreach (Reservation rezerwacja in pokoj.ListaRezerwacji)
            {
                if (!(rezerwacja.DzienOdjazdu <= rezerwacjaP || rezerwacja.DzienPrzyjazdu >= rezerwacjaW))
                {
                    return false;
                }
            }

            return true;
        }

        public List<string> PobierzFiltry()
        {
            List<string> filtry = new List<string>();
            filtry.Add("Standart");
            filtry.Add("Luxe");
            filtry.Add("Deluxe");
            filtry.Add("Pokój jednoosobowy");
            filtry.Add("Pokój dwuoosoby");
            filtry.Add("Pokój trójosobowy");
            filtry.Add("Dostępny dla palących");
            filtry.Add("Dostosowany dla niepelnosprawnych");
            filtry.Add("Dostępny z zwierzętami");
            filtry.Add("Dzieci");
            return filtry;
        }
        public bool CzyPasujeFiltr(string atrybutDoPorownania, Room pokoj)
        {
            return pokoj.KategoriaPokoju.Atrybuty.Any(pair => pair.Key == atrybutDoPorownania && pair.Value == true);
        }
        public List<string> PobierzTypySerwisow()
        {
            List<string> platneSerwisy = new List<string>()
            {
                "Room Service",
                "Spa i Centrum Wellness",
                "Usługi Concierge",
                "Centrum Biznesowe",
                "Transport z/na lotnisko"
            };
            return platneSerwisy;
        }
        public void WygenerujPokoje()
        {
            if (Pokoje.Count != 0)
            { 
                Pokoje.Clear(); 
            }
                Pokoje = fileService.ReadData(ConfigData.PokojPath);
        }
        public bool DataSerwisu(DateTime dataSerwisu, DateTime dataPoczatku, DateTime dataKonca)
        {
            if (dataSerwisu >= dataPoczatku && dataSerwisu <= dataKonca)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string NumerPokojuCena(Room pokoj)
        {
            string mes = "";
            mes += string.Format("Pokój nr. {0}, {1} zł", pokoj.NumerPokoju, pokoj.Cena);
            return mes;
        }
        public Room ZwrocPokojPoNumerze(int numer)
        {
            foreach(Room p in Pokoje)
            {
                if(p.NumerPokoju == numer)
                {
                    return p;
                }
            }
            return null;
        }

    }
}
