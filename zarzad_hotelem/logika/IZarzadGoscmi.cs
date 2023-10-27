using MyLibrary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zarzad_hotelem.logika
{
    public interface IZarzadGoscmi
    {
        void DodajGoscia(Gosc gosc);
        Gosc OdszukajGoscia(string numerdokuentu);
        void DodajFeedback(Feedback feedback);
        void WygenerujGosci();
        List<string> PobierzObywatelstwa();
        List<string> PobierzTypyDokuntu();
        int CzyJestNaLiscie(string numerdokumentu);
    }
}
