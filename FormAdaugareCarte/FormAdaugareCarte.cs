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
            textBoxTitlu.Clear();
            textBoxAutor.Clear();
            textBoxEditura.Clear();
            textBoxISBN.Clear();
            textBoxAn.Clear();
            numericUpDownNrExemplare.Value = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxTitlu.Text == string.Empty || textBoxAutor.Text == string.Empty || textBoxEditura.Text == string.Empty || textBoxISBN.Text == string.Empty || textBoxAn.Text == string.Empty)
                { DialogResult res = MessageBox.Show("Cel putin un camp este gol!", "EROARE", MessageBoxButtons.OK); }
            else
                if (lblEroareAn.Visible==true || lblEroareAutor.Visible ==true || lblEroareEditura.Visible == true)
            { DialogResult res = MessageBox.Show("Completati toate campurile corect!", "EROARE", MessageBoxButtons.OK); }
            else
            {
                int.TryParse(textBoxAn.Text, out int anApar);
                this.carte = new Carte(textBoxTitlu.Text, textBoxAutor.Text, textBoxEditura.Text, textBoxISBN.Text, anApar, Convert.ToInt32(numericUpDownNrExemplare.Value));
                
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
            if (textBoxAutor.Text.Any(char.IsDigit) || textBoxAutor.Text.Any(char.IsControl) || textBoxAutor.Text.Any(char.IsNumber) || textBoxAutor.Text.Any(char.IsPunctuation) || textBoxAutor.Text.Any(char.IsSurrogate) || textBoxAutor.Text.Any(char.IsSymbol))
                lblEroareAutor.Visible = true;
            else
                if (textBoxAutor.Text.All(char.IsWhiteSpace))
                lblEroareAutor.Visible = true;
            else
                lblEroareAutor.Visible =false;
            if (textBoxAutor.Text ==string.Empty)
                lblEroareAutor.Visible=false;
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxEditura.Text.Any(char.IsDigit) || textBoxEditura.Text.Any(char.IsControl) || textBoxEditura.Text.Any(char.IsNumber) || textBoxEditura.Text.Any(char.IsPunctuation) || textBoxEditura.Text.Any(char.IsSurrogate) || textBoxEditura.Text.Any(char.IsSymbol))
                lblEroareEditura.Visible = true;
            else
                if (textBoxEditura.Text.All(char.IsWhiteSpace))
                lblEroareEditura.Visible = true;
            else
                lblEroareEditura.Visible = false;
            if (textBoxEditura.Text == string.Empty)
                lblEroareEditura.Visible = false;
        }

        private void lblEroareAutor_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            int.TryParse(textBoxAn.Text, out int value);
            if (!int.TryParse(textBoxAn.Text, out int x) || !(value >= 1000 && value <=DateTime.Now.Year))
                lblEroareAn.Visible = true;
            else
                lblEroareAn.Visible=false;
            if (textBoxAn.Text == string.Empty)
                lblEroareAn.Visible = false;
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxISBN.Text == string.Empty)
                lblEroareISBN.Visible = false;
            if (!textBoxISBN.Text.All(char.IsDigit))
                lblEroareISBN.Visible = true;
            if (textBoxISBN.Text.Length != 13 && textBoxISBN.Text.Length !=10)
                lblEroareISBN.Visible = true;
            else
                lblEroareISBN.Visible=false;
        }
    }
}
