using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasaPersoana;

namespace FormAdaugarePersoana
{
    public partial class FormAdaugarePersoana : Form
    {
        public FormAdaugarePersoana()
        {
            InitializeComponent();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            txtCNP.Clear();
            txtNr.Clear();
            txtNume.Clear();
            txtPrenume.Clear();
            txtSerie.Clear();
        }

        private void btnAdaug_Click(object sender, EventArgs e)
        {
            int.TryParse(txtNr.Text, out int nr);
            ClasaPersoana.Persoana persoana = new Persoana( -1 , txtNume.Text , txtPrenume.Text , txtCNP.Text , txtSerie.Text , nr );  
            persoana.SalvarePersoana();
        }
    }
}
