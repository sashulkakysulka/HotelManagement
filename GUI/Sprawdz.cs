using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Sprawdz : Form
    {
        public Sprawdz()
        {
            InitializeComponent();
        }

        private void button_wyszukaj_Click(object sender, EventArgs e)
        {
            if (dateTimePicker_przyjazd.Value < DateTime.Today)
                MessageBox.Show("Dzien przyjazdu musi być dzisiaj lub późniejszy.");
            if (dateTimePicker_wyjazd.Value <= dateTimePicker_przyjazd.Value)
                MessageBox.Show("Dzien odjazdu musi być późniejszy niż dzien przyjazdu.");
            else
            {
                Wyszukiwanie okienko_wyszukaj = new Wyszukiwanie(dateTimePicker_przyjazd.Value, dateTimePicker_wyjazd.Value);
                this.Visible = false;
                okienko_wyszukaj.ShowDialog();
            }
        }

        private void button_sprawdzrezerwacje_Click(object sender, EventArgs e)
        {
            IsniejacaRezerwacja okienko = new IsniejacaRezerwacja();
            this.Visible = false;
            okienko.ShowDialog();
        }
    }
}
