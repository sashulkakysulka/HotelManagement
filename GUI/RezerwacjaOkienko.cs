using MyLibrary.fileservice;
using MyLibrary.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zarzad_hotelem.logika;

namespace GUI
{
    public partial class RezerwacjaOkienko : Form
    {
        public List<Room> PokojeDoRezerwacji;
        public DateTime Check_in { get; set; }
        public DateTime Check_out { get; set; }
        public decimal KosztCalkowity{ get; set; }
        ZarzadPokojmi zarzadPokojmi = new ZarzadPokojmi();
        ZarzadGoscmi zarzadGoscmi=new ZarzadGoscmi();
        List<Serwisy> serwisy = new List<Serwisy>();
        IFileService<Gosc> fileServiceGoscie = new XmlFileService<Gosc>();
        IFileService<Room> fileServicePokoje = new XmlFileService<Room>();
        public RezerwacjaOkienko(List<Room> pokojeDoRezerwacji, DateTime check_in, DateTime check_out, decimal kosztCalkowity)
        {
            InitializeComponent();
            PokojeDoRezerwacji = pokojeDoRezerwacji;
            Check_in = check_in;
            Check_out = check_out;
            KosztCalkowity = kosztCalkowity;
            foreach (string obw in zarzadGoscmi.PobierzObywatelstwa())
            {
                comboBox_obywatelstwo.Items.Add(obw);
            }
            foreach (string typ in zarzadGoscmi.PobierzTypyDokuntu())
            {
                comboBox_typ.Items.Add(typ);
            }
            foreach (string ser in zarzadPokojmi.PobierzTypySerwisow())
            {
                comboBox_serwisy.Items.Add(ser);
            }   
        }

        private void button_zarwierdz_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox_numer.Text))
                {
                    throw new InvalidDataException("Numer dokumentu jest wymagany.");
                }

                int numergoscia = zarzadGoscmi.CzyJestNaLiscie(textBox_numer.Text);

                if (string.IsNullOrWhiteSpace(textBox_imie.Text) || string.IsNullOrWhiteSpace(textBox_nazwisko.Text))
                {
                    throw new InvalidDataException("Imię i nazwisko są wymagane.");
                }
                if(dateTimePicker_data.Value > DateTime.Now.AddYears(-18))
                {
                    throw new InvalidDataException("Osoba rezerwująca pokój musi mieć powyżej osiemnastu lat");
                }

                Reservation rezerwacja = new Reservation(Check_in, Check_out, serwisy,KosztCalkowity);
                List<Room> pokoje = new List<Room>();
                foreach (Room p in PokojeDoRezerwacji)
                {
                    pokoje.Add(p);
                }

                string notatki = textBox_notatki.Text;
                if (notatki == "wazne infornacje(alergii, choroby, tp.)")
                {
                    notatki = null;
                }
                foreach (Room p in zarzadPokojmi.Pokoje)
                {
                    for (int i = 0; i < pokoje.Count; i++)
                    {
                        if (p.NumerPokoju == pokoje[i].NumerPokoju)
                        {
                            p.ListaRezerwacji.Add(rezerwacja);
                        }
                    }
                }

                if (numergoscia == -1)
                {
                    List<Reservation> rezerwacje = new List<Reservation>();
                    rezerwacje.Add(rezerwacja);

                    Gosc gosc = new Gosc(textBox_imie.Text, textBox_nazwisko.Text, comboBox_obywatelstwo.SelectedItem.ToString(),
                                         dateTimePicker_data.Value, comboBox_typ.SelectedItem.ToString(), textBox_numer.Text,
                                         notatki, pokoje, rezerwacje);

                    zarzadGoscmi.DodajGoscia(gosc);
                    Zapisz();
                }
                else
                {
                    zarzadGoscmi.ListaGosci[numergoscia].Rezerwacja.Add(rezerwacja);
                    foreach (Room p in PokojeDoRezerwacji)
                    {
                        zarzadGoscmi.ListaGosci[numergoscia].ListaPokoji.Add(zarzadPokojmi.ZwrocPokojPoNumerze(p.NumerPokoju));
                    }
                    Zapisz();
                }

                Zapisz();
                MessageBox.Show("Rezerwacje złożono, \ncałkowity koszt: " + KosztCalkowity + " zł");
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show( ex.Message);
            }
        }
        private void button_serwis_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_typ.SelectedIndex == -1)
                {
                    throw new InvalidDataException("Nie wybrano zadnego serwisy");
                }
                if (zarzadPokojmi.DataSerwisu(dateTimePicker_serwis.Value, Check_in, Check_out) == false)
                {
                    throw new InvalidDataException("Serwis moze byc wykonany tylko w czas zamieszkamia w hotelu");
                }
                else
                {
                    Serwisy serwis = new Serwisy(comboBox_serwisy.SelectedItem.ToString(), dateTimePicker_serwis.Value);
                    serwisy.Add(serwis);
                    KosztCalkowity += serwis.Cena;
                    MessageBox.Show("serwis dodano");
                }
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_cofnij_Click(object sender, EventArgs e)
        {
            Wyszukiwanie okienko = new Wyszukiwanie(Check_in,Check_out);
            this.Visible = false;
            okienko.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox_numer.Text))
            {
                throw new InvalidDataException("Musisz podac numer dokumentu.");
            }
            Gosc gosc = zarzadGoscmi.OdszukajGoscia(textBox_numer.Text);
            if(gosc == null)
            {
                MessageBox.Show("Nie odnaleziono w bazie");
            }
            else
            {
                textBox_imie.Text = gosc.Imie;
                textBox_nazwisko.Text = gosc.Nazwisko;
                dateTimePicker_data.Value = gosc.DataUrodzenia;
                comboBox_obywatelstwo.SelectedItem = gosc.Obywatelstwo;
                comboBox_typ.SelectedItem = gosc.TypDokumentu;
                textBox_numer.Text = gosc.NumerDokumentu;
                textBox_notatki.Text = gosc.Notatki;
            }
        }
        public void Zapisz()
        {
            fileServicePokoje.SaveData(ConfigData.PokojPath, zarzadPokojmi.Pokoje);
            fileServiceGoscie.SaveData(ConfigData.GoscPath, zarzadGoscmi.ListaGosci);
        }
    }
}
