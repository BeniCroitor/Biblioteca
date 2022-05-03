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

        private Label txtTitlu;
        private Label txtAutor;
        private Label txtEditura;
        private Label txtISBN;
        private Label txtAnApar;
        private Label txtAnEdit;
        private Label txtNrExempl;




        private Label[] lblsTitlu;
        private Label[] lblsAutor;
        private Label[] lblsEditura;
        private Label[] lblsISBN;
        private Label[] lblsAnApar;
        private Label[] lblsAnEdit;
        private Label[] lblsNrExempl;

        public FormAfisareCarti()
        {
            InitializeComponent();


            txtTitlu = new Label();
            txtTitlu.Width = LATIME_CONTROL;
            txtTitlu.Text = "Titlu";
            txtTitlu.Top = DIMENSIUNE_PAS_Y * 2;
            txtTitlu.Left = DIMENSIUNE_PAS_X;
            txtTitlu.ForeColor = Color.DarkGreen;
            this.Controls.Add(txtTitlu);

            txtAutor = new Label();
            txtAutor.Width = LATIME_CONTROL;
            txtAutor.Text = "Autor";
            txtAutor.Top = DIMENSIUNE_PAS_Y * 2;
            txtAutor.Left = DIMENSIUNE_PAS_X*2;
            txtAutor.ForeColor = Color.DarkGreen;
            this.Controls.Add(txtAutor);

            txtEditura = new Label();
            txtEditura.Width = LATIME_CONTROL;
            txtEditura.Text = "Editura";
            txtEditura.Top = DIMENSIUNE_PAS_Y * 2;
            txtEditura.Left = DIMENSIUNE_PAS_X * 3;
            txtEditura.ForeColor = Color.DarkGreen;
            this.Controls.Add(txtEditura);

            txtISBN = new Label();
            txtISBN.Width = LATIME_CONTROL;
            txtISBN.Text = "ISBN";
            txtISBN.Top = DIMENSIUNE_PAS_Y * 2;
            txtISBN.Left = DIMENSIUNE_PAS_X * 4;
            txtISBN.ForeColor = Color.DarkGreen;
            this.Controls.Add(txtISBN);

            txtAnApar = new Label();
            txtAnApar.Width = LATIME_CONTROL;
            txtAnApar.Text = "Anul Aparitiei";
            txtAnApar.Top = DIMENSIUNE_PAS_Y * 2;
            txtAnApar.Left = DIMENSIUNE_PAS_X * 5;
            txtAnApar.ForeColor = Color.DarkGreen;
            this.Controls.Add(txtAnApar);

            txtAnEdit = new Label();
            txtAnEdit.Width = LATIME_CONTROL;
            txtAnEdit.Text = "Anul Editiei";
            txtAnEdit.Top = DIMENSIUNE_PAS_Y * 2;
            txtAnEdit.Left = DIMENSIUNE_PAS_X * 6;
            txtAnEdit.ForeColor = Color.DarkGreen;
            this.Controls.Add(txtAnEdit);

            txtNrExempl = new Label();
            txtNrExempl.Width = LATIME_CONTROL;
            txtNrExempl.Text = "NR de exemplare";
            txtNrExempl.Top = DIMENSIUNE_PAS_Y * 2;
            txtNrExempl.Left = DIMENSIUNE_PAS_X * 7;
            txtNrExempl.ForeColor = Color.DarkGreen;
            this.Controls.Add(txtNrExempl);
        }


        private void FormAfisareCarti_Load(object sender, EventArgs e)
        {
            AfisareCarti();
        }

        private void AfisareCarti()
        {
            var lineCount = File.ReadLines(Carte.path).Count();

             Label[] lblsTitlu = new Label[lineCount];
             Label[] lblsAutor = new Label[lineCount];
             Label[] lblsEditura    = new Label[lineCount];
             Label[] lblsISBN = new Label[lineCount];
             Label[] lblsAnApar = new Label[lineCount];
             Label[] lblsAnEdit = new Label[lineCount];
            Label[] lblsNrExempl = new Label[lineCount];

             int i = 0;

            foreach(Carte carte in ClasaCarte.Carte.ReturnCarti())
            {
                if (carte != null)
                {
                    lblsTitlu[i] = new Label();
                    lblsTitlu[i].Width = LATIME_CONTROL;
                    lblsTitlu[i].Text = carte.Nume;
                    lblsTitlu[i].Top = DIMENSIUNE_PAS_Y * (i + 3);
                    lblsTitlu[i].Left = DIMENSIUNE_PAS_X;
                    this.Controls.Add(lblsTitlu[i]);

                    lblsAutor[i] = new Label();
                    lblsAutor[i].Width = LATIME_CONTROL;
                    lblsAutor[i].Text = carte.Autor;
                    lblsAutor[i].Top = DIMENSIUNE_PAS_Y * (i + 3);
                    lblsAutor[i].Left = DIMENSIUNE_PAS_X * 2;
                    this.Controls.Add(lblsAutor[i]);

                    lblsEditura[i] = new Label();
                    lblsEditura[i].Width = LATIME_CONTROL;
                    lblsEditura[i].Text = carte.Editura;
                    lblsEditura[i].Top = DIMENSIUNE_PAS_Y * (i + 3);
                    lblsEditura[i].Left = DIMENSIUNE_PAS_X * 3;
                    this.Controls.Add( lblsEditura[i]);

                    lblsISBN[i] = new Label();
                    lblsISBN[i].Width = LATIME_CONTROL;
                    lblsISBN[i].Text = carte.ISBN;
                    lblsISBN[i].Top = DIMENSIUNE_PAS_Y * (i + 3);
                    lblsISBN[i].Left = DIMENSIUNE_PAS_X * 4;
                    this.Controls.Add(lblsISBN[i]);

                    lblsAnApar[i] = new Label();
                    lblsAnApar[i].Width = LATIME_CONTROL;
                    lblsAnApar[i].Text = Convert.ToString(carte.anAparitie);
                    lblsAnApar[i].Top = DIMENSIUNE_PAS_Y * (i + 3);
                    lblsAnApar[i].Left = DIMENSIUNE_PAS_X * 5;
                    this.Controls.Add(lblsAnApar[i]);

                    lblsAnEdit[i] = new Label();
                    lblsAnEdit[i].Width = LATIME_CONTROL;
                    lblsAnEdit[i].Text = Convert.ToString(carte.anEditie);
                    lblsAnEdit[i].Top = DIMENSIUNE_PAS_Y * (i + 3);
                    lblsAnEdit[i].Left = DIMENSIUNE_PAS_X * 6;
                    this.Controls.Add(lblsAnEdit[i]);

                    lblsNrExempl[i] = new Label();
                    lblsNrExempl[i].Width = LATIME_CONTROL;
                    lblsNrExempl[i].Text = Convert.ToString(carte.nrExemplare);
                    lblsNrExempl[i].Top = DIMENSIUNE_PAS_Y * (i + 3);
                    lblsNrExempl[i].Left = DIMENSIUNE_PAS_X * 7;
                    this.Controls.Add(lblsNrExempl[i]);

                    i++;
                }
                else
                    break;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
