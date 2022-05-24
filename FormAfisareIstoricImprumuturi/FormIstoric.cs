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
using System.IO;
using ClasaPersoana;
using ClasaCarte;

namespace FormAfisareIstoricImprumuturi
{
    public partial class FormIstoric : Form
    {
        public FormIstoric()
        {
            InitializeComponent();
            dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            dataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            dataGridView1.Columns[4].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

            using (StreamReader sr = new StreamReader(Imprumut.pathIstoric))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] lineSplit = line.Split(';');
                    if (lineSplit.Length == 5)
                        dataGridView1.Rows.Add(lineSplit[0], ClasaPersoana.Persoana.SearchID(Convert.ToInt32(lineSplit[2])), ClasaCarte.Carte.SearchID(Convert.ToInt32(lineSplit[1])), lineSplit[3], lineSplit[4]);
                    else
                        dataGridView1.Rows.Add(lineSplit[0], ClasaPersoana.Persoana.SearchID(Convert.ToInt32(lineSplit[2])), ClasaCarte.Carte.SearchID(Convert.ToInt32(lineSplit[1])), lineSplit[3], "-----");
                }
            }
        }
    }
}
