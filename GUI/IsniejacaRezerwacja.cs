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
    public partial class IsniejacaRezerwacja : Form
    {
        ZarzadGoscmi zarzadGoscmi = new ZarzadGoscmi();
        ZarzadzaniePracownikow zarzadPracownikow = new ZarzadzaniePracownikow();
        IFileService<Feedback> filefeedback = new XmlFileService<Feedback>();
        public IsniejacaRezerwacja()
        {
            InitializeComponent();
        }

        private void button_wyszukaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox_numer.Text))
                {
                    throw new InvalidDataException("Numer dokumentu musi być podany.");
                }
                Gosc gosc = zarzadGoscmi.OdszukajGoscia(textBox_numer.Text);
                if (gosc == null)
                {
                    MessageBox.Show("Zły numer dokumentu");
                }
                else
                {
                    MessageBox.Show(zarzadPracownikow.InformacjaDlaGoscia(gosc));
                }
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_feedback_Click(object sender, EventArgs e)
        {
            TextBox textBox_feedback = new TextBox();
            textBox_feedback.Multiline = true;
            textBox_feedback.AcceptsReturn = true;
            textBox_feedback.Height = 200;
            textBox_feedback.KeyPress += TextBox_feedback_KeyPress;

            Form feedbackForm = new Form();
            feedbackForm.Controls.Add(textBox_feedback);
            feedbackForm.ShowDialog();
        
        }
        private void TextBox_feedback_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox_numer.Text))
                {
                    throw new InvalidDataException("Numer dokumentu nie jest podany.");
                }
                else
                {
                    Gosc gosc = zarzadGoscmi.OdszukajGoscia(textBox_numer.Text);
                    if (gosc == null)
                    {
                        MessageBox.Show("Podany zły numer dokumentu");
                    }
                    else
                    {
                        if (e.KeyChar == (char)Keys.Enter)
                        {
                            TextBox textBox = (TextBox)sender;
                            Feedback feedback = new Feedback(textBox.Text, DateTime.Today, gosc);

                            zarzadGoscmi.DodajFeedback(feedback);

                            Form parentForm = textBox.Parent as Form;
                            parentForm?.Close();
                            filefeedback.SaveData(ConfigData.FeedbackPath, zarzadGoscmi.Listafeedback);
                        }
                    }
                }
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_cofnij_Click(object sender, EventArgs e)
        {
            Sprawdz okienko = new Sprawdz();
            this.Visible = false;
            okienko.ShowDialog();
        }
    }
}
