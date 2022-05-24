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

namespace Form_Imprumut
{
    public partial class Form_Imprumut : Form
    {
        public Form_Imprumut()
        {
            InitializeComponent();
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

            Imprumut imprumut = new Imprumut(ClasaCarte.Carte.SearchTitlu(comboBox_Carte.Text), ClasaPersoana.Persoana.SearchNume(comboBox_Pers.Text));

            imprumut.SalvareImprumut();
        }
    }
}
