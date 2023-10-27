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
    public partial class Haslo : Form
    {
        ZarzadzaniePracownikow zarzad = new ZarzadzaniePracownikow();
        public Haslo()
        {
            InitializeComponent();
        }

        private void button_haslo_Click(object sender, EventArgs e)
        {
            Pracownik pracownik = zarzad.SprawdzHaslo(textBox_haslo.Text, textBox_mail.Text);
            if (pracownik != null)
            {
                InformacjaRezerwacja okienko = new InformacjaRezerwacja();
                this.Visible = false;
                okienko.ShowDialog();
            }
            else
            {
                MessageBox.Show("niepoprawne dane, try again");
            }

        }
    }
}
