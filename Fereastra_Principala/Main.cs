using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormAdaugareCarte;
using FormAdaugarePersoana;
using FormAfisarePersoane;
using Form_Afisare;
using Form_Imprumut;
using Form_Gestionare_Imprumuturi;

namespace Fereastra_Principala
{
    public partial class Feresatra_Principala : Form
    {
        public Feresatra_Principala()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdaugareCarte.FormAdaugareCarte formAdaugareCarte = new FormAdaugareCarte.FormAdaugareCarte();
            formAdaugareCarte.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAfisareCarti formAfisareCarti = new FormAfisareCarti();
            formAfisareCarti.ShowDialog(this);
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAdaugarePersoana.FormAdaugarePersoana formAdaugarePersoana = new FormAdaugarePersoana.FormAdaugarePersoana();
            formAdaugarePersoana.ShowDialog(this);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAfisarePersoane.FormAfisarePersoane formAfisarePersoane = new FormAfisarePersoane.FormAfisarePersoane();
            formAfisarePersoane.ShowDialog(this);
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_Imprumut.Form_Imprumut formAdaugareImprumut = new Form_Imprumut.Form_Imprumut();
            formAdaugareImprumut.ShowDialog(this);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Gestionare_Imprumuturi.Form_Gestionare_Imprumuturi formAfisareImprumutur = new Form_Gestionare_Imprumuturi.Form_Gestionare_Imprumuturi();
            formAfisareImprumutur.ShowDialog(this);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormAfisareIstoricImprumuturi.FormIstoric formAfisareIstoric = new FormAfisareIstoricImprumuturi.FormIstoric();
            formAfisareIstoric.ShowDialog(this);
        }
    }
}
