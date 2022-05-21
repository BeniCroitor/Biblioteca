using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasaCarte;
using ClasaPersoana;
using ClasaImprumut;

namespace Form_Gestionare_Imprumuturi
{
    public partial class Form_Gestionare_Imprumuturi : Form
    {
        public Form_Gestionare_Imprumuturi()
        {
            InitializeComponent();
            List<Imprumut> imprumuturi = Imprumut.ReturnImprumuturi();
            foreach (Imprumut imprumut in imprumuturi)
                dataGridView1.Rows.Add(Carte.SearchID(imprumut.idCarte), Persoana.SearchID(imprumut.idPers), imprumut.Date_out);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
