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

namespace FormAdaugareCarte
{
    public partial class FormAdaugareCarte : Form
    {
        Carte carte;
        public FormAdaugareCarte()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            numericUpDown1.Value = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox5.Text, out int anApar);
            this.carte = new Carte(textBox1.Text , textBox2.Text , textBox3.Text , textBox4.Text , anApar  , Convert.ToInt32(numericUpDown1.Value));
            carte.SalvareCarte();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
