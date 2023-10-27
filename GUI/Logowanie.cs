using MyLibrary.fileservice;
using MyLibrary.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zarzad_hotelem.logika;

namespace GUI
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void button_gosc_Click(object sender, EventArgs e)
        {
            Sprawdz sprawdz = new Sprawdz();
            this.Visible=false;
            sprawdz.ShowDialog();
           
        }
    }
}
