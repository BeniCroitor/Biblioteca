using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasaImprumut;
using ClasaCarte;

namespace Form_Imprumut
{
    public partial class Form_Imprumut : Form
    {
        public Form_Imprumut()
        {
            InitializeComponent();
            this.Height = 300;
            foreach (string nume in ClasaPersoana.Persoana.ListaNumePersoane())
            {
                this.comboBox_Pers.Items.Add(nume);
            }

            foreach (string carte in ClasaCarte.Carte.ListaNumeCarti())
            {
                this.comboBox_Carte.Items.Add(carte);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblEroareCarte.Visible == true || lblEroarePers.Visible == true || comboBox_Carte.Text == string.Empty || comboBox_Pers.Text == string.Empty)
            { DialogResult res = MessageBox.Show("Alegeți o persoană și o carte validă!", "EROARE", MessageBoxButtons.OK); }
            else
            if(Imprumut.Available(Carte.SearchTitlu(comboBox_Carte.Text)) && !Imprumut.DepasitLimita(ClasaPersoana.Persoana.SearchNume(comboBox_Pers.Text)))
            {
                Imprumut imprumut = new Imprumut(ClasaCarte.Carte.SearchTitlu(comboBox_Carte.Text), ClasaPersoana.Persoana.SearchNume(comboBox_Pers.Text));

                imprumut.SalvareImprumut();
            }
            else
            if(!Imprumut.Available(Carte.SearchTitlu(comboBox_Carte.Text)))
            { DialogResult res = MessageBox.Show("Cartea nu este valabila momentan", "EROARE", MessageBoxButtons.OK); }
            else
                if(Imprumut.DepasitLimita(ClasaPersoana.Persoana.SearchNume(comboBox_Pers.Text)))
            { DialogResult res = MessageBox.Show("Persoana selectata a imprumutat deja 3 carti!", "EROARE", MessageBoxButtons.OK); }

        }

        private void comboBox_Pers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Pers_Validating(object sender, CancelEventArgs e)
        {
            if (!comboBox_Pers.Items.Contains(comboBox_Pers.Text))
                lblEroarePers.Visible = true;
            else
                lblEroarePers.Visible = false;
            if (comboBox_Pers.Text == string.Empty)
                lblEroarePers.Visible = false;

        }

        private void comboBox_Carte_Validating(object sender, CancelEventArgs e)
        {
            if (!comboBox_Carte.Items.Contains(comboBox_Carte.Text))
                lblEroareCarte.Visible = true;
            else
                lblEroareCarte.Visible= false;
            if (comboBox_Carte.Text == string.Empty)
                lblEroareCarte.Visible = false;
        }

        private void comboBox_Carte_SelectedValueChanged(object sender, EventArgs e)
        {
            this.Height = 500;

            Carte carte = new Carte();
            carte.ExtragereCarte(Convert.ToString(Carte.SearchTitlu(comboBox_Carte.Text)));

            lblAnApar.Text = Convert.ToString(carte.anAparitie);
            lblEditura.Text = carte.Editura;
            lblISBN.Text = carte.ISBN;
            lblNrEx.Text = Convert.ToString(carte.nrExemplare);
            lblNrExVal.Text = Convert.ToString(carte.nrExemplare - Imprumut.NrExempalreValabile(Carte.SearchTitlu(comboBox_Carte.Text)));

            groupBox1.Visible = true;
        }

        private void comboBox_Carte_TextChanged(object sender, EventArgs e)
        {
            this.Height = 300;
            groupBox1.Visible = false;
        }
    }
}
