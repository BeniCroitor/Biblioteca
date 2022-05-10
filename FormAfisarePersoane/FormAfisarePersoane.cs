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

namespace FormAfisarePersoane
{
    public partial class FormAfisarePersoane : Form
    {
        public FormAfisarePersoane()
        {
            InitializeComponent();

            List<Persoana> listaPersoane = Persoana.ReturnPersoane();
            foreach (Persoana persoana in listaPersoane)
            {
                string[] elem = new string[7];
                elem[0] = Convert.ToString(persoana.ID);
                elem[1] = persoana.nume;
                elem[2] = persoana.prenume;
                elem[3] = persoana.CNP;
                elem[4] = persoana.serieCI;
                elem[5] = Convert.ToString(persoana.nrCI);
                elem[6] = Convert.ToString(persoana.nrCartiImprumutate);


                ListViewItem item = new ListViewItem(elem);
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
