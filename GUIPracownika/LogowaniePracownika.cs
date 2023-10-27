using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIPracownika
{
    public partial class LogowaniePracownika : Form
    {
        public LogowaniePracownika()
        {
            InitializeComponent();
        }

        private void button_dopracy_Click(object sender, EventArgs e)
        {
            Haslo okienko = new Haslo();
            this.Visible = false;
            okienko.ShowDialog();
        }
    }
}
