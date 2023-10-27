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
    public partial class Wyszukiwanie : Form
    {
        public DateTime Check_in { get; set; }
        public DateTime Check_out { get; set; }
        ZarzadPokojmi zarzad = new ZarzadPokojmi();
        List<Room> pokoi_koszyk = new List<Room>();
        decimal kosztpokoi = 0;

        public Wyszukiwanie(DateTime check_in, DateTime check_out)
        {
            InitializeComponent();

            Check_in = check_in;
            Check_out = check_out;

            foreach(Room pokoj in Filtr())
            {
                listBox_pokoj.Items.Add(zarzad.NumerPokojuCena(pokoj));
            }
            
            foreach (string filtr in zarzad.PobierzFiltry())
            {
                checkedListBox_filtruj.Items.Add(filtr);
            }
        }

        private void button_odfiltruj_Click(object sender, EventArgs e)
        {
            listBox_pokoj.Items.Clear();

            List<string> wybranefiltry = new List<string>();
            foreach (string wybranyatrybut in checkedListBox_filtruj.CheckedItems)
            {
                wybranefiltry.Add(wybranyatrybut);
            }

            foreach (Room pokoj in Filtr())
            {
                bool dopasowanyfiltr = true;
                foreach (string wybranyatrybut in wybranefiltry)
                {
                    bool pokojmaatrybut = zarzad.CzyPasujeFiltr(wybranyatrybut,pokoj);
                    if (pokojmaatrybut == false)
                    {
                        dopasowanyfiltr = false;
                        break;
                    }
                }
                if (dopasowanyfiltr)
                {
                   listBox_pokoj.Items.Add(zarzad.NumerPokojuCena(pokoj));
                }
            }
        }

        private void button_koszyk_Click(object sender, EventArgs e)
        {
            if (listBox_pokoj.SelectedIndex == -1)
            {
                MessageBox.Show("Nie wybrano zadnego pokoju z listy");
            }
            else
            {
                foreach (Room pokoj in zarzad.Pokoje)
                {
                    if (zarzad.NumerPokojuCena(pokoj) == listBox_pokoj.SelectedItem.ToString())
                    {
                        pokoi_koszyk.Add(pokoj);
                        kosztpokoi += pokoj.Cena;
                        listBox_pokoj.Items.Remove(listBox_pokoj.SelectedItem);
                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pokoi_koszyk.Count > 0)
            {
                RezerwacjaOkienko okienko = new RezerwacjaOkienko(pokoi_koszyk,Check_in,Check_out,kosztpokoi);
                MessageBox.Show(string.Format("W koszyku: {0} pokoi", pokoi_koszyk.Count()));
                this.Visible = false;
                okienko.ShowDialog();
            }
            else { MessageBox.Show("Żaden pokój nie był dodany do koszyka"); }
        }

        private void button_cofnij_Click(object sender, EventArgs e)
        {
            foreach (Room pokoj in Filtr())
            {
                listBox_pokoj.Items.Add(zarzad.NumerPokojuCena(pokoj));
            }
            for (int i = 0; i < checkedListBox_filtruj.Items.Count; i++)
            {
                checkedListBox_filtruj.SetItemChecked(i, false);
            }
        }
        public List<Room> Filtr()
        {
            List<Room> odfiltrowanepokoje = new List<Room>();
            foreach (Room pokoj in zarzad.Pokoje)
            {
                if (zarzad.CzyWolny(pokoj, Check_in, Check_out))
                {
                    bool pokojZnaleziony = false;
                    for (int i = 0; i < listBox_pokoj.Items.Count; i++)
                    {
                        if (zarzad.NumerPokojuCena(pokoj) == listBox_pokoj.Items[i].ToString())
                        {
                            pokojZnaleziony = true;
                            break;
                        }
                    }

                    if (!pokojZnaleziony)
                    {
                       odfiltrowanepokoje.Add(pokoj);
                    }
                }
            }
            return odfiltrowanepokoje;
        }

        private void button_cofniee_Click(object sender, EventArgs e)
        {
            Sprawdz okienko = new Sprawdz();
            this.Visible = false;
            okienko.ShowDialog();
        }
    }
}

