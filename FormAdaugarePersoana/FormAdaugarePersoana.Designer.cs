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
            this.lblNume.Location = new System.Drawing.Point(11, 16);
            this.lblNume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(70, 22);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume:";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenume.Location = new System.Drawing.Point(233, 20);
            this.lblPrenume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(101, 22);
            this.lblPrenume.TabIndex = 0;
            this.lblPrenume.Text = "Prenume:";
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNP.Location = new System.Drawing.Point(11, 82);
            this.lblCNP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(57, 22);
            this.lblCNP.TabIndex = 0;
            this.lblCNP.Text = "CNP:";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(11, 148);
            this.lblSerie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(89, 22);
            this.lblSerie.TabIndex = 0;
            this.lblSerie.Text = "Serie CI:";
            // 
            // lblNr
            // 
            this.lblNr.AutoSize = true;
            this.lblNr.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNr.Location = new System.Drawing.Point(177, 148);
            this.lblNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(62, 22);
            this.lblNr.TabIndex = 0;
            this.lblNr.Text = "Nr CI:";
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.Location = new System.Drawing.Point(85, 15);
            this.txtNume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(120, 29);
            this.txtNume.TabIndex = 1;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenume.Location = new System.Drawing.Point(339, 16);
            this.txtPrenume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(120, 29);
            this.txtPrenume.TabIndex = 2;
            // 
            // txtCNP
            // 
            this.txtCNP.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNP.Location = new System.Drawing.Point(75, 80);
            this.txtCNP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(176, 29);
            this.txtCNP.TabIndex = 3;
            // 
            // txtNr
            // 
            this.txtNr.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNr.Location = new System.Drawing.Point(237, 146);
            this.txtNr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNr.Name = "txtNr";
            this.txtNr.Size = new System.Drawing.Size(86, 29);
            this.txtNr.TabIndex = 5;
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(100, 146);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(36, 29);
            this.txtSerie.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.panel1.Location = new System.Drawing.Point(10, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 211);
            this.panel1.TabIndex = 2;
            // 
            // btnSterge
            // 
            this.btnSterge.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterge.Location = new System.Drawing.Point(274, 253);
            this.btnSterge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(92, 33);
            this.btnSterge.TabIndex = 6;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnAdaug
            // 
            this.btnAdaug.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaug.Location = new System.Drawing.Point(398, 253);
            this.btnAdaug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdaug.Name = "btnAdaug";
            this.btnAdaug.Size = new System.Drawing.Size(92, 33);
            this.btnAdaug.TabIndex = 7;
            this.btnAdaug.Text = "Adauga";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 316);
            this.Controls.Add(this.btnAdaug);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAdaugarePersoana";
            this.Text = "Form1";
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
    }
}

