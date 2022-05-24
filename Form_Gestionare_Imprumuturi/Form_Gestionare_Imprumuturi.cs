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
            dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            dataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            List<Imprumut> imprumuturi = Imprumut.ReturnImprumuturi();
            foreach (Imprumut imprumut in imprumuturi)
                dataGridView1.Rows.Add(Convert.ToString(imprumut.idImprumut), Persoana.SearchID(imprumut.idPers), Carte.SearchID(imprumut.idCarte) , imprumut.Date_out);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConfirmRetur_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
                {
                int idCarte = Carte.SearchTitlu(dataGridView1.CurrentRow.Cells["Titlu"].Value.ToString());
                int idPers = Persoana.SearchNume(dataGridView1.CurrentRow.Cells["Nume"].Value.ToString());
                int idImprumut = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                Imprumut.ReturnCarte(idImprumut, idCarte, idPers, dataGridView1.CurrentRow.Cells["Data"].Value.ToString());
                dataGridView1.CurrentRow.Visible = false;
                Imprumut.SalvareReturnare(idCarte, idPers, idImprumut);
                }
            
        }
    }
}
