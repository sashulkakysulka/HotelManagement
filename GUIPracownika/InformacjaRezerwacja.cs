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
    public partial class InformacjaRezerwacja : Form
    {
        ZarzadGoscmi zarzadGoscmi = new ZarzadGoscmi();
        ZarzadPokojmi zarzadPokojmi = new ZarzadPokojmi();
        ZarzadzaniePracownikow zarzadPracownikow = new ZarzadzaniePracownikow();
        IFileService<Gosc> fileServiceGoscie = new XmlFileService<Gosc>();
        IFileService<Room> fileServicePokoje = new XmlFileService<Room>();
        public InformacjaRezerwacja()
        {
            InitializeComponent();
        }

        private void button_odszukaj_Click(object sender, EventArgs e)
        {
            try
            {
                listBox_rezerwacja.Items.Clear();
                if (string.IsNullOrWhiteSpace(textBox_dokument.Text))
                {
                    throw new InvalidDataException("Numer dokumentu nie został podany.");
                }
                else
                {
                    OdswiezInformacjaORezerwacji();
                }
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show( ex.Message);
            }
        }
        public void OdswiezInformacjaORezerwacji()
        {
            Gosc gosc = zarzadGoscmi.OdszukajGoscia(textBox_dokument.Text);
            if (gosc == null)
            {
                MessageBox.Show("Nie odnaleziono gościa w bazie");
            }
            else
            {
                label_goscinf.Text = zarzadPracownikow.InformacjaOGosciu(gosc);
                foreach (string mes in zarzadPracownikow.InformacjaORezerwacji(gosc))
                {
                    listBox_rezerwacja.Items.Add(mes);
                }
            }
        }
        private void button_usun_Click(object sender, EventArgs e)
        {
            try
            {
                string rezerwacjaDoUsuniecia = string.Empty;
                if (string.IsNullOrWhiteSpace(textBox_dokument.Text))
                {
                    throw new InvalidDataException("Numer dokumentu został usunięty.");
                }
                Gosc gosc = zarzadGoscmi.OdszukajGoscia(textBox_dokument.Text);
                if (listBox_rezerwacja.SelectedItem == null)
                {
                    throw new InvalidDataException("Żadna rezerwacja nie była odznaczona");
                }

                foreach (string mes in zarzadPracownikow.InformacjaORezerwacji(gosc))
                {
                    if (mes == listBox_rezerwacja.SelectedItem.ToString())
                    {
                        rezerwacjaDoUsuniecia = mes;
                    }
                }
                Reservation rezerwacja = zarzadPracownikow.RezerwacjaDoUsuniecia(rezerwacjaDoUsuniecia, gosc);
                zarzadPracownikow.UsunRezerwacje(rezerwacja.DzienPrzyjazdu,rezerwacja.DzienOdjazdu,
                    zarzadGoscmi.ListaGosci,zarzadPokojmi.Pokoje);
                Zapisz();
                MessageBox.Show(string.Format("{0}\n rezerwacja usunięta", rezerwacjaDoUsuniecia.ToString()));
                listBox_rezerwacja.Items.Clear();
                OdswiezInformacjaORezerwacji();
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show( ex.Message);
            }
        }
        public void Zapisz()
        {
            fileServiceGoscie.SaveData(ConfigData.GoscPath, zarzadGoscmi.ListaGosci);
            fileServicePokoje.SaveData(ConfigData.PokojPath, zarzadPokojmi.Pokoje);
        }

        private void button_feed_Click(object sender, EventArgs e)
        {
            MessageBox.Show(zarzadPracownikow.RaportFeedback());
        }
    }
}
