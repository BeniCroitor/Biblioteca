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

namespace FormAdaugarePersoana
{
    public partial class FormAdaugarePersoana : Form
    {
        private static Dictionary<int, string> seriiBuletin = new Dictionary<int, string>()
        {
            {0, "AX" },
            {1, "TR" },
            {2, "AR" },
            {3, "ZR" },
            {4, "XC" },
            {5, "ZC" },
            {6, "MM" },
            {7, "XM" },
            {8, "XB" },
            {9, "XT" },
            {10, "BV" },
            {11, "ZV" },
            {12, "XR" },
            {13, "DP" },
            {14, "DR" },
            {15, "DT" },
            {16, "DX" },
            {17, "RD" },
            {18, "RR" },
            {19, "RT" },
            {20, "RX" },
            {21, "RK" },
            {22, "IF" },
            {23, "XZ" },
            {24, "KL" },
            {25, "KX" },
            {26, "CJ" },
            {27, "KT" },
            {28, "KZ" },
            {29, "DX" },
            {30, "DZ" },
            {31, "HD" },
            {32, "XD" },
            {33, "VN" },
            {34, "GL" },
            {35, "ZL" },
            {36, "GG" },
            {37, "MX" },
            {38, "MZ" },
            {39, "IZ" },
            {40, "MH" },
            {41, "HR" },
            {42, "XH" },
            {43, "ZH" },
            {44, "NT" },
            {45, "AS" },
            {46, "AZ" },
            {47, "PH" },
            {48, "PX" },
            {49, "KS" },
            {50, "VX" },
            {51, "SM" },
            {52, "KV" },
            {53, "SB" },
            {54, "OT" },
            {55, "SZ" },
            {56, "SV" },
            {57, "XV" },
            {58, "TM" },
            {59, "TZ" },
            {60, "DD" },
            {61, "GZ" },
            {62, "ZS" },
            {63, "MS" },
            {64, "TC" },
            {65, "VS" },
            {66, "SX" }
        };
        


        public FormAdaugarePersoana()
        {
            this.CenterToScreen();
            InitializeComponent();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            txtCNP.Clear();
            txtNr.Clear();
            txtNume.Clear();
            txtPrenume.Clear();
            txtSerie.Clear();
            lblEroareNume.Visible = false;
            lblEroarePrenume.Visible = false;
            lblEroareCNP.Visible = false;
            lblEroareSerie.Visible = false;
            lblEroareNr.Visible = false;
        }

        private void btnAdaug_Click(object sender, EventArgs e)
        {
            if (txtCNP.Text == string.Empty || txtNr.Text == string.Empty || txtNume.Text == string.Empty || txtPrenume.Text == string.Empty || txtSerie.Text == string.Empty)
            {
                DialogResult res = MessageBox.Show("Cel putin un camp este gol", "EROARE", MessageBoxButtons.OK);
            }
            else
            {
                if (lblEroareNume.Visible == true || lblEroarePrenume.Visible == true || lblEroareCNP.Visible == true || lblEroareSerie.Visible == true || lblEroareNr.Visible == true)
                { DialogResult eroare = MessageBox.Show("Completati toate campurile corect", "EROARE", MessageBoxButtons.OK); }
                else
                {
                    int.TryParse(txtNr.Text, out int nr);
                    ClasaPersoana.Persoana persoana = new Persoana(-1, txtNume.Text, txtPrenume.Text, txtCNP.Text, txtSerie.Text, nr);
                    persoana.SalvarePersoana();
                }
            }
                
            
        }

        private void FormAdaugarePersoana_Load(object sender, EventArgs e)
        {

        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {

        }


        // Validari campuri text ========================================================
        private void txtNume_Validating(object sender, CancelEventArgs e)
        {
            if (!txtNume.Text.All(char.IsLetter))
                lblEroareNume.Visible = true;
            else
                lblEroareNume.Visible = false;
            if (txtNume.Text == string.Empty)
                lblEroareNr.Visible = false;
                        
        }

        private void txtPrenume_Validating(object sender, CancelEventArgs e)
        {
            if (!txtPrenume.Text.All(char.IsLetter))
                lblEroarePrenume.Visible = true;
            else
                lblEroarePrenume.Visible = false;
            if (txtPrenume.Text == string.Empty)
                lblEroarePrenume.Visible = false;
        }

        private void txtSerie_Validating(object sender, CancelEventArgs e)
        {
            int val = 0;
            for (int i = 0; i <= 66; i++)
                if (txtSerie.Text == seriiBuletin[i])
                {
                    val = 1;
                    break;
                }
            if(val == 0)
                lblEroareSerie.Visible = true;
            else lblEroareSerie.Visible = false;

            if (txtSerie.Text == string.Empty)
                lblEroareSerie.Visible = false;

        }

        private void txtCNP_Validating(object sender, CancelEventArgs e)
        {
            if ( txtCNP.Text.Length != 13 || !txtCNP.Text.All(char.IsDigit))
                lblEroareCNP.Visible = true;
            else
                lblEroareCNP.Visible = false;

            if (txtCNP.Text == string.Empty)
                lblEroareCNP.Visible = false;
        }

        private void txtNr_Validating(object sender, CancelEventArgs e)
        {
            if ( txtNr.Text.Length != 6 || !txtNr.Text.All(char.IsDigit))
                lblEroareNr.Visible = true;
            else
                 lblEroareNr.Visible = false;

            if (txtNr.Text == string.Empty)
                lblEroareNr.Visible = false;
        }
        // =============================================================================
    }
}
