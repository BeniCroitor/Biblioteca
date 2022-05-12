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
        private static List<Carte> listaCarti;
        private static int nrCartiFisier = 1;


        public FormAfisareCarti()
        {
            this.CenterToScreen();
            InitializeComponent();

            listaCarti = Carte.ReturnCarti();
            foreach(Carte carte in listaCarti)
            {
                nrCartiFisier++;
                string[] elem = new string[7];
                elem[0] = Convert.ToString(carte.id);
                elem[1] = carte.Titlu;
                elem[2] = carte.Autor;
                elem[3] = carte.Editura;
                elem[4] = carte.ISBN;
                elem[5] = Convert.ToString(carte.anAparitie);
                elem[6] = Convert.ToString(carte.nrExemplare);


                ListViewItem item = new ListViewItem(elem);
                listView1.Items.Add(item);
            }

            this.Width = 905;
        }

        private void cautare_Carte()
        {
            listView1.Items.Clear();
            foreach (Carte carte in listaCarti)
            {
                string[] elem = new string[7];
                elem[0] = Convert.ToString(carte.id);
                elem[1] = carte.Titlu;
                elem[2] = carte.Autor;
                elem[3] = carte.Editura;
                elem[4] = carte.ISBN;
                elem[5] = Convert.ToString(carte.anAparitie);
                elem[6] = Convert.ToString(carte.nrExemplare);

                if (elem[1].ToLower().Contains(textBox1.Text.ToLower()) || elem[2].ToLower().Contains(textBox1.Text.ToLower()) || elem[3].ToLower().Contains(textBox1.Text.ToLower()))
                {
                    ListViewItem item = new ListViewItem(elem);
                    listView1.Items.Add(item);
                }

            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cautare_Carte();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cautare_Carte();
        }
    }
}
