namespace FormAdaugarePersoana
{
    partial class FormAdaugarePersoana
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdaugarePersoana));
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblCNP = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblNr = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.txtNr = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEroareNr = new System.Windows.Forms.Label();
            this.lblEroareCNP = new System.Windows.Forms.Label();
            this.lblEroareSerie = new System.Windows.Forms.Label();
            this.lblEroarePrenume = new System.Windows.Forms.Label();
            this.lblEroareNume = new System.Windows.Forms.Label();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnAdaug = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(15, 22);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(83, 27);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume:";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenume.Location = new System.Drawing.Point(311, 23);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(118, 27);
            this.lblPrenume.TabIndex = 0;
            this.lblPrenume.Text = "Prenume:";
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNP.Location = new System.Drawing.Point(15, 110);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(68, 27);
            this.lblCNP.TabIndex = 0;
            this.lblCNP.Text = "CNP:";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(13, 186);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(104, 27);
            this.lblSerie.TabIndex = 0;
            this.lblSerie.Text = "Serie CI:";
            // 
            // lblNr
            // 
            this.lblNr.AutoSize = true;
            this.lblNr.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNr.Location = new System.Drawing.Point(236, 185);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(73, 27);
            this.lblNr.TabIndex = 0;
            this.lblNr.Text = "Nr CI:";
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.Location = new System.Drawing.Point(113, 18);
            this.txtNume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(159, 34);
            this.txtNume.TabIndex = 1;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            this.txtNume.Validating += new System.ComponentModel.CancelEventHandler(this.txtNume_Validating);
            // 
            // txtPrenume
            // 
            this.txtPrenume.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenume.Location = new System.Drawing.Point(452, 20);
            this.txtPrenume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(159, 34);
            this.txtPrenume.TabIndex = 2;
            this.txtPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrenume_Validating);
            // 
            // txtCNP
            // 
            this.txtCNP.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNP.Location = new System.Drawing.Point(100, 107);
            this.txtCNP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(233, 34);
            this.txtCNP.TabIndex = 3;
            this.txtCNP.Validating += new System.ComponentModel.CancelEventHandler(this.txtCNP_Validating);
            // 
            // txtNr
            // 
            this.txtNr.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNr.Location = new System.Drawing.Point(316, 181);
            this.txtNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNr.Name = "txtNr";
            this.txtNr.Size = new System.Drawing.Size(113, 34);
            this.txtNr.TabIndex = 5;
            this.txtNr.Validating += new System.ComponentModel.CancelEventHandler(this.txtNr_Validating);
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(133, 181);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(47, 34);
            this.txtSerie.TabIndex = 4;
            this.txtSerie.Validating += new System.ComponentModel.CancelEventHandler(this.txtSerie_Validating);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblEroareNr);
            this.panel1.Controls.Add(this.lblEroareCNP);
            this.panel1.Controls.Add(this.lblEroareSerie);
            this.panel1.Controls.Add(this.lblEroarePrenume);
            this.panel1.Controls.Add(this.lblEroareNume);
            this.panel1.Controls.Add(this.txtSerie);
            this.panel1.Controls.Add(this.txtNr);
            this.panel1.Controls.Add(this.txtCNP);
            this.panel1.Controls.Add(this.txtPrenume);
            this.panel1.Controls.Add(this.txtNume);
            this.panel1.Controls.Add(this.lblNr);
            this.panel1.Controls.Add(this.lblSerie);
            this.panel1.Controls.Add(this.lblCNP);
            this.panel1.Controls.Add(this.lblPrenume);
            this.panel1.Controls.Add(this.lblNume);
            this.panel1.Location = new System.Drawing.Point(13, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 253);
            this.panel1.TabIndex = 2;
            // 
            // lblEroareNr
            // 
            this.lblEroareNr.AutoSize = true;
            this.lblEroareNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEroareNr.ForeColor = System.Drawing.Color.Red;
            this.lblEroareNr.Location = new System.Drawing.Point(316, 217);
            this.lblEroareNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEroareNr.Name = "lblEroareNr";
            this.lblEroareNr.Size = new System.Drawing.Size(88, 15);
            this.lblEroareNr.TabIndex = 7;
            this.lblEroareNr.Text = "*Număr invalid";
            this.lblEroareNr.Visible = false;
            // 
            // lblEroareCNP
            // 
            this.lblEroareCNP.AutoSize = true;
            this.lblEroareCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEroareCNP.ForeColor = System.Drawing.Color.Red;
            this.lblEroareCNP.Location = new System.Drawing.Point(97, 143);
            this.lblEroareCNP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEroareCNP.Name = "lblEroareCNP";
            this.lblEroareCNP.Size = new System.Drawing.Size(75, 15);
            this.lblEroareCNP.TabIndex = 7;
            this.lblEroareCNP.Text = "*CNP invalid";
            this.lblEroareCNP.Visible = false;
            // 
            // lblEroareSerie
            // 
            this.lblEroareSerie.AutoSize = true;
            this.lblEroareSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEroareSerie.ForeColor = System.Drawing.Color.Red;
            this.lblEroareSerie.Location = new System.Drawing.Point(131, 217);
            this.lblEroareSerie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEroareSerie.Name = "lblEroareSerie";
            this.lblEroareSerie.Size = new System.Drawing.Size(86, 15);
            this.lblEroareSerie.TabIndex = 7;
            this.lblEroareSerie.Text = "*Serie invalidă";
            this.lblEroareSerie.Visible = false;
            // 
            // lblEroarePrenume
            // 
            this.lblEroarePrenume.AutoSize = true;
            this.lblEroarePrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEroarePrenume.ForeColor = System.Drawing.Color.Red;
            this.lblEroarePrenume.Location = new System.Drawing.Point(449, 57);
            this.lblEroarePrenume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEroarePrenume.Name = "lblEroarePrenume";
            this.lblEroarePrenume.Size = new System.Drawing.Size(168, 30);
            this.lblEroarePrenume.TabIndex = 6;
            this.lblEroarePrenume.Text = "*Prenumele nu poate contine\r\ncifre, spații sau alte simboluri!";
            this.lblEroarePrenume.Visible = false;
            // 
            // lblEroareNume
            // 
            this.lblEroareNume.AutoSize = true;
            this.lblEroareNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEroareNume.ForeColor = System.Drawing.Color.Red;
            this.lblEroareNume.Location = new System.Drawing.Point(109, 57);
            this.lblEroareNume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEroareNume.Name = "lblEroareNume";
            this.lblEroareNume.Size = new System.Drawing.Size(168, 30);
            this.lblEroareNume.TabIndex = 6;
            this.lblEroareNume.Text = "*Numele nu poate contine\r\ncifre, spații sau alte simboluri!";
            this.lblEroareNume.Visible = false;
            // 
            // btnSterge
            // 
            this.btnSterge.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterge.Location = new System.Drawing.Point(365, 292);
            this.btnSterge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(123, 41);
            this.btnSterge.TabIndex = 6;
            this.btnSterge.Text = "Șterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnAdaug
            // 
            this.btnAdaug.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaug.Location = new System.Drawing.Point(531, 292);
            this.btnAdaug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdaug.Name = "btnAdaug";
            this.btnAdaug.Size = new System.Drawing.Size(123, 41);
            this.btnAdaug.TabIndex = 7;
            this.btnAdaug.Text = "Adaugă";
            this.btnAdaug.UseVisualStyleBackColor = true;
            this.btnAdaug.Click += new System.EventHandler(this.btnAdaug_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // FormAdaugarePersoana
            // 
            this.AcceptButton = this.btnAdaug;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 350);
            this.Controls.Add(this.btnAdaug);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(690, 397);
            this.MinimumSize = new System.Drawing.Size(690, 397);
            this.Name = "FormAdaugarePersoana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Înregistrează persoană";
            this.Load += new System.EventHandler(this.FormAdaugarePersoana_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblNr;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.TextBox txtNr;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnAdaug;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label lblEroareNume;
        private System.Windows.Forms.Label lblEroarePrenume;
        private System.Windows.Forms.Label lblEroareSerie;
        private System.Windows.Forms.Label lblEroareNr;
        private System.Windows.Forms.Label lblEroareCNP;
    }
}

