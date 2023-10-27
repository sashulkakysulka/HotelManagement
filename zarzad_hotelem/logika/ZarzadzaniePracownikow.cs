using GUI;
using MyLibrary.fileservice;
using MyLibrary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace zarzad_hotelem.logika
{
    public class ZarzadzaniePracownikow : IZarzadzaniePracownikow
    {
        public List<Pracownik> ListaPracownikow = new List<Pracownik>();
        IFileService<Pracownik> fileService= new XmlFileService<Pracownik>();
        ZarzadGoscmi zarzadGoscmi = new ZarzadGoscmi();
        ZarzadPokojmi zarzadPokojmi = new ZarzadPokojmi();
        public ZarzadzaniePracownikow()
        {
            WygeneryjPracownikow();
        }
        public Pracownik SprawdzHaslo(string podanehaslo, string podanymail)
        {
            Pracownik pracownik = ListaPracownikow.FirstOrDefault(p => p.Mail == podanymail);
            if (pracownik != null)
            {
                if (podanehaslo == pracownik.Password)
                {
                    return pracownik;
                }
            }
            return null;
        }
        public void WygeneryjPracownikow()
        {
            if(ListaPracownikow.Count == 0)
            {
                ListaPracownikow = fileService.ReadData(ConfigData.PracownikPath);
            }
        }
        public Reservation RezerwacjaDoUsuniecia(string mes, Gosc gosc)
        {
            foreach (Room pokoj in gosc.ListaPokoji)
            {
                foreach (Reservation rezerwacja in gosc.Rezerwacja)
                {
                    if (string.Format("Pokoj nr.{0}: {1} - {2}, {3} zł.",
                        pokoj.NumerPokoju.ToString(),
                        rezerwacja.DzienPrzyjazdu.Date.ToShortDateString(),
                        rezerwacja.DzienOdjazdu.Date.ToShortDateString(),
                        rezerwacja.KosztCalkowity.ToString()) == mes)
                    {
                        return rezerwacja;
                    }

                }
            }
            return null;
        }
        public List<string> InformacjaORezerwacji(Gosc gosc)
        {
            List<string> mesList = new List<string>();
            foreach (Room pokoj in gosc.ListaPokoji)
            {
                foreach (Reservation rezerwacja in gosc.Rezerwacja)
                {
                    string mes = string.Format("Pokoj nr.{0}: {1} - {2}, {3} zł.",
                        pokoj.NumerPokoju.ToString(),
                        rezerwacja.DzienPrzyjazdu.Date.ToShortDateString(),
                        rezerwacja.DzienOdjazdu.Date.ToShortDateString(),
                        rezerwacja.KosztCalkowity.ToString());
                    mesList.Add(mes);
                }
            }
            return mesList;
        }

        public string InformacjaOGosciu(Gosc gosc)
        {
            StringBuilder komentarzBuilder = new StringBuilder();
            komentarzBuilder.AppendLine($"Imię: {gosc.Imie}");
            komentarzBuilder.AppendLine($"Nazwisko: {gosc.Nazwisko}");
            komentarzBuilder.AppendLine($"{gosc.TypDokumentu}: {gosc.NumerDokumentu}");
            komentarzBuilder.AppendLine($"Obywatelstwo: {gosc.Obywatelstwo}");
            komentarzBuilder.AppendLine($"Urodziny: {gosc.DataUrodzenia.Date.ToShortDateString()}");
            komentarzBuilder.AppendLine($"Dodatkowe informacje: {gosc.Notatki}");
            return komentarzBuilder.ToString();
        }

        public string InformacjaOSerwisach(List<Serwisy> serwisy)
        {
            StringBuilder komentarzBuilder = new StringBuilder();
            komentarzBuilder.AppendLine("Zamówione serwisy:");
            foreach (Serwisy serwis in serwisy)
            {
                komentarzBuilder.AppendLine(serwis.Nazwa);
            }
            return komentarzBuilder.ToString();
        }

        public string InformacjaDlaGoscia(Gosc gosc)
        {
            StringBuilder komentarzBuilder = new StringBuilder();
            komentarzBuilder.AppendLine($"Imię: {gosc.Imie}");
            komentarzBuilder.AppendLine($"Nazwisko: {gosc.Nazwisko}");
            komentarzBuilder.AppendLine($"{gosc.TypDokumentu}: {gosc.NumerDokumentu}");

            foreach (Room pokoj in gosc.ListaPokoji)
            {
                foreach (Reservation rezerwacja in gosc.Rezerwacja)
                {
                    komentarzBuilder.AppendLine($"Pokoj nr.{pokoj.NumerPokoju}:");
                    komentarzBuilder.AppendLine($"- Przyjazd: {rezerwacja.DzienPrzyjazdu.Date.ToShortDateString()}");
                    komentarzBuilder.AppendLine($"- Odjazd: {rezerwacja.DzienOdjazdu.Date.ToShortDateString()}");
                    komentarzBuilder.AppendLine($"- Koszt: {rezerwacja.KosztCalkowity} zł");

                    if (rezerwacja.ListaSerwisow.Count > 0)
                    {
                        komentarzBuilder.AppendLine(InformacjaOSerwisach(rezerwacja.ListaSerwisow));
                    }
                }
            }
            return komentarzBuilder.ToString();
        }
        public void UsunRezerwacje(DateTime dataPrzyjazdu, DateTime dataOdjazdu, List<Gosc> goscie, List<Room> pokoje)
        {
            foreach (Gosc gosc in goscie)
            {
                Reservation rezerwacja = gosc.Rezerwacja.FirstOrDefault(r =>
                    r.DzienPrzyjazdu == dataPrzyjazdu && r.DzienOdjazdu == dataOdjazdu);
                for(int i =0;i<gosc.ListaPokoji.Count;i++) 
                {
                    Room pokoj = gosc.ListaPokoji[i];
                    Reservation rezerwacjadlapokoju = pokoj.ListaRezerwacji.FirstOrDefault(r =>
                    r.DzienPrzyjazdu == dataPrzyjazdu && r.DzienOdjazdu == dataOdjazdu);
                    if(rezerwacjadlapokoju != null)
                    {
                        pokoj.ListaRezerwacji.Remove(rezerwacjadlapokoju);
                        gosc.ListaPokoji.Remove(pokoj);
                        i--;
                    }                 
                }
                if(rezerwacja != null)
                {
                    gosc.Rezerwacja.Remove(rezerwacja);
                }
            }
            foreach (Room pokoj in pokoje)
            {
                Reservation rezerwacja = pokoj.ListaRezerwacji.FirstOrDefault(r =>
                    r.DzienPrzyjazdu == dataPrzyjazdu && r.DzienOdjazdu == dataOdjazdu);
                if (rezerwacja != null)
                {
                    pokoj.ListaRezerwacji.Remove(rezerwacja);
                }
            }
        }
        public string RaportFeedback()
        {
            StringBuilder builder = new StringBuilder();

            foreach (Feedback f in zarzadGoscmi.Listafeedback)
            {
                builder.AppendLine($"Nadawca: {f.NadawcaFeedbacku.Imie} {f.NadawcaFeedbacku.Nazwisko}");
                builder.AppendLine($"Feedback: {f.FeedbackTekst}");
                builder.AppendLine($"Data wpisu: {f.DataWpisu.ToShortDateString()}");
                builder.AppendLine();
            }

            return builder.ToString();
        }
    }
}

