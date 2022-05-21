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
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty || textBox5.Text == string.Empty)
                { DialogResult res = MessageBox.Show("Cel putin un camp este gol!", "EROARE", MessageBoxButtons.OK); }
            else
                if (lblEroareAn.Visible==true || lblEroareAutor.Visible ==true || lblEroareEditura.Visible == true)
            { DialogResult res = MessageBox.Show("Completati toate campurile corect!", "EROARE", MessageBoxButtons.OK); }
            else
            {
                int.TryParse(textBox5.Text, out int anApar);
                this.carte = new Carte(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, anApar, Convert.ToInt32(numericUpDown1.Value));
                if(carte.)
                carte.SalvareCarte();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Titlu_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text.Any(char.IsDigit) || textBox2.Text.Any(char.IsControl) || textBox2.Text.Any(char.IsNumber) || textBox2.Text.Any(char.IsPunctuation) || textBox2.Text.Any(char.IsSurrogate) || textBox2.Text.Any(char.IsSymbol))
                lblEroareAutor.Visible = true;
            else
                if (textBox2.Text.All(char.IsWhiteSpace))
                lblEroareAutor.Visible = true;
            else
                lblEroareAutor.Visible =false;
            if (textBox2.Text ==string.Empty)
                lblEroareAutor.Visible=false;
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text.Any(char.IsDigit) || textBox3.Text.Any(char.IsControl) || textBox3.Text.Any(char.IsNumber) || textBox3.Text.Any(char.IsPunctuation) || textBox3.Text.Any(char.IsSurrogate) || textBox3.Text.Any(char.IsSymbol))
                lblEroareEditura.Visible = true;
            else
                if (textBox3.Text.All(char.IsWhiteSpace))
                lblEroareEditura.Visible = true;
            else
                lblEroareEditura.Visible = false;
            if (textBox3.Text == string.Empty)
                lblEroareEditura.Visible = false;
        }

        private void lblEroareAutor_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            int.TryParse(textBox5.Text, out int value);
            if (!int.TryParse(textBox5.Text, out int x) || !(value >= 1000 && value <=DateTime.Now.Year))
                lblEroareAn.Visible = true;
            else
                lblEroareAn.Visible=false;
            if (textBox5.Text == string.Empty)
                lblEroareAn.Visible = false;
        }
    }
}
