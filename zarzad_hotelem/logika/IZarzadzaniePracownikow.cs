using MyLibrary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zarzad_hotelem.logika
{
    public interface IZarzadzaniePracownikow
    {
        Pracownik SprawdzHaslo(string podanehaslo, string podanymail);
        void WygeneryjPracownikow();
        string InformacjaOGosciu(Gosc gosc);
        List<string> InformacjaORezerwacji(Gosc gosc);
        string InformacjaDlaGoscia(Gosc gosc);
        Reservation RezerwacjaDoUsuniecia(string mes, Gosc gosc);
        void UsunRezerwacje(DateTime dataPrzyjazdu, DateTime dataOdjazdu, List<Gosc> goscie, List<Room> pokoje);
        string RaportFeedback();
    }
}
