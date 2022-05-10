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
using System.IO;

namespace Form_Afisare
{
    public partial class FormAfisareCarti : Form
    {

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;

        

        public FormAfisareCarti()
        {
            this.CenterToScreen();
            InitializeComponent();

            List<Carte> listaCarti = Carte.ReturnCarti();
            foreach(Carte carte in listaCarti)
            {
                string[] elem = new string[7];
                elem[0] = Convert.ToString(carte.id);
                elem[1] = carte.Titlu;
                elem[2] = carte.Autor;
                elem[3] = carte.Editura;
                elem[4] = carte.ISBN;
                elem[5] = Convert.ToString(carte.anAparitie);
                elem[6] = Convert.ToString(carte.nrExemplare);


                ListViewItem item = new ListViewItem(elem);
                ListaCarti.Items.Add(item);
            }

            this.Size = new System.Drawing.Size(ListaCarti.Width + 300, ListaCarti.Height + 300);
            
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
