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
        static List<Persoana> listaPersoane;
        public FormAfisarePersoane()
        {
            InitializeComponent();

            listView1.Font = new Font(listView1.Font, FontStyle.Bold);

            listaPersoane = Persoana.ReturnPersoane();
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
                item.Font = new Font(item.Font, FontStyle.Regular);
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            textBox1.Text = e.KeyCode.ToString();
            cautare_Persoana();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cautare_Persoana();
        }

        private void cautare_Persoana()
        {
            listView1.Items.Clear();
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

                if (elem[1].ToLower().Contains(textBox1.Text.ToLower()) || elem[2].ToLower().Contains(textBox1.Text.ToLower()))
                {
                    ListViewItem item = new ListViewItem(elem);
                    listView1.Items.Add(item);
                }

            }
        }

        private void FormAfisarePersoane_Load(object sender, EventArgs e)
        {

        }

        //private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    textBox1.Text = KeyEventHandler(object sender, )
            
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cautare_Persoana();
        }

        
    }
}
