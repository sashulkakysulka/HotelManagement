using MyLibrary.fileservice;
using MyLibrary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI;

namespace zarzad_hotelem.logika
{
    public class ZarzadGoscmi : IZarzadGoscmi
    {
        public List<Feedback> Listafeedback = new List<Feedback>();
        public List<Gosc> ListaGosci = new List<Gosc>();
        IFileService<Gosc> fileService = new XmlFileService<Gosc>();
        IFileService<Feedback> fileServiceFeedback = new XmlFileService<Feedback>();
        public ZarzadGoscmi()
        {
            WygenerujGosci();
            PobierzFeedback();
        }

        public void DodajGoscia(Gosc gosc)
        {
            ListaGosci.Add(gosc);
        }

        public Gosc OdszukajGoscia(string numerdokumentu)
        {
           foreach(Gosc gosc in ListaGosci)
            {
                if(gosc.NumerDokumentu == numerdokumentu)
                {
                    return gosc;
                }
            }
            return null;
        }
        public void DodajFeedback(Feedback feedback)
        {
            Listafeedback.Add(feedback);
        }
        public void WygenerujGosci()
        {
            if(ListaGosci.Count != 0)
            {
                ListaGosci.Clear();
            }
                ListaGosci = fileService.ReadData(ConfigData.GoscPath);
        }
        public void PobierzFeedback()
        {
            if(Listafeedback.Count != 0)
            {
                Listafeedback.Clear();
            }
            Listafeedback = fileServiceFeedback.ReadData(ConfigData.FeedbackPath);
        }
        public List<string> PobierzObywatelstwa()
        {
            List<string> obywatelstwa = new List<string>();
            obywatelstwa.Add("Austria");
            obywatelstwa.Add("Belgia");
            obywatelstwa.Add("Bułgaria");
            obywatelstwa.Add("Chorwacja");
            obywatelstwa.Add("Cypr");
            obywatelstwa.Add("Czechy");
            obywatelstwa.Add("Dania");
            obywatelstwa.Add("Estonia");
            obywatelstwa.Add("Finlandia");
            obywatelstwa.Add("Francja");
            obywatelstwa.Add("Grecja");
            obywatelstwa.Add("Hiszpania");
            obywatelstwa.Add("Irlandia");
            obywatelstwa.Add("Litwa");
            obywatelstwa.Add("Luksemburg");
            obywatelstwa.Add("Łotwa");
            obywatelstwa.Add("Malta");
            obywatelstwa.Add("Holandia");
            obywatelstwa.Add("Niemcy");
            obywatelstwa.Add("Polska");
            obywatelstwa.Add("Portugalia");
            obywatelstwa.Add("Rumunia");
            obywatelstwa.Add("Słowacja");
            obywatelstwa.Add("Słowenia");
            obywatelstwa.Add("Szwecja");
            obywatelstwa.Add("Węgry");
            obywatelstwa.Add("Włochy");
            return obywatelstwa;
        }
        public List<string> PobierzTypyDokuntu()
        {
            List<string> typyDokumentu = new List<string>();
            typyDokumentu.Add("Dowód osobisty");
            typyDokumentu.Add("Paszport");
            typyDokumentu.Add("Prawo jazdy");
            return typyDokumentu;
        }
        public int CzyJestNaLiscie(string numerdokumentu)
        {
            for (int i = 0; i < ListaGosci.Count; i++)
            {
                if (numerdokumentu == ListaGosci[i].NumerDokumentu)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
