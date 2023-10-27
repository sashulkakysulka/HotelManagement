using MyLibrary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zarzad_hotelem.logika
{
    public interface IZarzadPokojmi
    {
        bool CzyWolny(Room pokoj, DateTime rezerwacjaP, DateTime rezerwacjaW);
        bool CzyKoliduje(Reservation NowaRezerwacja, Reservation rezerwacja);
        void WygenerujPokoje();
        List<string> PobierzFiltry();
        bool CzyPasujeFiltr(string atrybutDoPorownania, Room pokoj);
        List<string> PobierzTypySerwisow();
        bool DataSerwisu(DateTime dataSerwisu, DateTime dataPoczatku, DateTime dataKonca);
        string NumerPokojuCena(Room pokoj);
    }
}
