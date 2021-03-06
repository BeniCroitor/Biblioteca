namespace FormAdaugareCarte
{
    partial class FormAdaugareCarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdaugareCarte));
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblEditura = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblAn = new System.Windows.Forms.Label();
            this.textBoxTitlu = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxEditura = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxAn = new System.Windows.Forms.TextBox();
            this.ButonSterge = new System.Windows.Forms.Button();
            this.ButonAdauga = new System.Windows.Forms.Button();
            this.lblNrExemplare = new System.Windows.Forms.Label();
            this.numericUpDownNrExemplare = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEroareAn = new System.Windows.Forms.Label();
            this.lblEroareISBN = new System.Windows.Forms.Label();
            this.lblEroareEditura = new System.Windows.Forms.Label();
            this.lblEroareAutor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNrExemplare)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.Location = new System.Drawing.Point(30, 36);
            this.lblTitlu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(51, 22);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Titlu";
            this.lblTitlu.Click += new System.EventHandler(this.Titlu_Click);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(30, 92);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(61, 22);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor";
            this.lblAutor.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEditura
            // 
            this.lblEditura.AutoSize = true;
            this.lblEditura.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditura.Location = new System.Drawing.Point(30, 148);
            this.lblEditura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditura.Name = "lblEditura";
            this.lblEditura.Size = new System.Drawing.Size(77, 22);
            this.lblEditura.TabIndex = 1;
            this.lblEditura.Text = "Editură";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(30, 203);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(55, 22);
            this.lblISBN.TabIndex = 1;
            this.lblISBN.Text = "ISBN";
            this.lblISBN.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAn.Location = new System.Drawing.Point(32, 259);
            this.lblAn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(131, 22);
            this.lblAn.TabIndex = 2;
            this.lblAn.Text = "Anul apariției";
            // 
            // textBoxTitlu
            // 
            this.textBoxTitlu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitlu.Location = new System.Drawing.Point(106, 33);
            this.textBoxTitlu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTitlu.Name = "textBoxTitlu";
            this.textBoxTitlu.Size = new System.Drawing.Size(152, 29);
            this.textBoxTitlu.TabIndex = 1;
            this.textBoxTitlu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxTitlu.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAutor.Location = new System.Drawing.Point(106, 89);
            this.textBoxAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(152, 29);
            this.textBoxAutor.TabIndex = 2;
            this.textBoxAutor.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // textBoxEditura
            // 
            this.textBoxEditura.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditura.Location = new System.Drawing.Point(126, 145);
            this.textBoxEditura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEditura.Name = "textBoxEditura";
            this.textBoxEditura.Size = new System.Drawing.Size(132, 29);
            this.textBoxEditura.TabIndex = 3;
            this.textBoxEditura.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxISBN.Location = new System.Drawing.Point(106, 202);
            this.textBoxISBN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(152, 29);
            this.textBoxISBN.TabIndex = 4;
            this.textBoxISBN.Validating += new System.ComponentModel.CancelEventHandler(this.textBox4_Validating);
            // 
            // textBoxAn
            // 
            this.textBoxAn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAn.Location = new System.Drawing.Point(185, 258);
            this.textBoxAn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAn.Name = "textBoxAn";
            this.textBoxAn.Size = new System.Drawing.Size(56, 29);
            this.textBoxAn.TabIndex = 5;
            this.textBoxAn.Validating += new System.ComponentModel.CancelEventHandler(this.textBox5_Validating);
            // 
            // ButonSterge
            // 
            this.ButonSterge.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonSterge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButonSterge.Location = new System.Drawing.Point(23, 381);
            this.ButonSterge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ButonSterge.Name = "ButonSterge";
            this.ButonSterge.Size = new System.Drawing.Size(112, 28);
            this.ButonSterge.TabIndex = 8;
            this.ButonSterge.Text = "Șterge";
            this.ButonSterge.UseVisualStyleBackColor = true;
            this.ButonSterge.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButonAdauga
            // 
            this.ButonAdauga.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonAdauga.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButonAdauga.Location = new System.Drawing.Point(163, 381);
            this.ButonAdauga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ButonAdauga.Name = "ButonAdauga";
            this.ButonAdauga.Size = new System.Drawing.Size(112, 28);
            this.ButonAdauga.TabIndex = 7;
            this.ButonAdauga.Text = "Adaugă Carte";
            this.ButonAdauga.UseVisualStyleBackColor = true;
            this.ButonAdauga.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNrExemplare
            // 
            this.lblNrExemplare.AutoSize = true;
            this.lblNrExemplare.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrExemplare.Location = new System.Drawing.Point(32, 314);
            this.lblNrExemplare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNrExemplare.Name = "lblNrExemplare";
            this.lblNrExemplare.Size = new System.Drawing.Size(166, 22);
            this.lblNrExemplare.TabIndex = 3;
            this.lblNrExemplare.Text = "NR de exemplare";
            // 
            // numericUpDownNrExemplare
            // 
            this.numericUpDownNrExemplare.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNrExemplare.Location = new System.Drawing.Point(212, 314);
            this.numericUpDownNrExemplare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownNrExemplare.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownNrExemplare.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNrExemplare.Name = "numericUpDownNrExemplare";
            this.numericUpDownNrExemplare.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownNrExemplare.Size = new System.Drawing.Size(46, 26);
            this.numericUpDownNrExemplare.TabIndex = 6;
            this.numericUpDownNrExemplare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownNrExemplare.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblEroareAn);
            this.panel1.Controls.Add(this.lblEroareISBN);
            this.panel1.Controls.Add(this.lblEroareEditura);
            this.panel1.Controls.Add(this.lblEroareAutor);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 347);
            this.panel1.TabIndex = 7;
            // 
            // lblEroareAn
            // 
            this.lblEroareAn.AutoSize = true;
            this.lblEroareAn.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEroareAn.ForeColor = System.Drawing.Color.Red;
            this.lblEroareAn.Location = new System.Drawing.Point(169, 273);
            this.lblEroareAn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEroareAn.Name = "lblEroareAn";
            this.lblEroareAn.Size = new System.Drawing.Size(62, 13);
            this.lblEroareAn.TabIndex = 0;
            this.lblEroareAn.Text = "*An invalid!";
            this.lblEroareAn.Visible = false;
            // 
            // lblEroareISBN
            // 
            this.lblEroareISBN.AutoSize = true;
            this.lblEroareISBN.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEroareISBN.ForeColor = System.Drawing.Color.Red;
            this.lblEroareISBN.Location = new System.Drawing.Point(89, 218);
            this.lblEroareISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEroareISBN.Name = "lblEroareISBN";
            this.lblEroareISBN.Size = new System.Drawing.Size(73, 13);
            this.lblEroareISBN.TabIndex = 0;
            this.lblEroareISBN.Text = "*ISBN invalid!";
            this.lblEroareISBN.Visible = false;
            // 
            // lblEroareEditura
            // 
            this.lblEroareEditura.AutoSize = true;
            this.lblEroareEditura.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEroareEditura.ForeColor = System.Drawing.Color.Red;
            this.lblEroareEditura.Location = new System.Drawing.Point(110, 159);
            this.lblEroareEditura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEroareEditura.Name = "lblEroareEditura";
            this.lblEroareEditura.Size = new System.Drawing.Size(144, 13);
            this.lblEroareEditura.TabIndex = 0;
            this.lblEroareEditura.Text = "*Numele editurii este invalid!";
            this.lblEroareEditura.Visible = false;
            // 
            // lblEroareAutor
            // 
            this.lblEroareAutor.AutoSize = true;
            this.lblEroareAutor.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEroareAutor.ForeColor = System.Drawing.Color.Red;
            this.lblEroareAutor.Location = new System.Drawing.Point(89, 103);
            this.lblEroareAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEroareAutor.Name = "lblEroareAutor";
            this.lblEroareAutor.Size = new System.Drawing.Size(153, 13);
            this.lblEroareAutor.TabIndex = 0;
            this.lblEroareAutor.Text = "*Numele autorului este invalid!";
            this.lblEroareAutor.Visible = false;
            this.lblEroareAutor.Click += new System.EventHandler(this.lblEroareAutor_Click);
            // 
            // FormAdaugareCarte
            // 
            this.AcceptButton = this.ButonAdauga;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 428);
            this.Controls.Add(this.numericUpDownNrExemplare);
            this.Controls.Add(this.ButonAdauga);
            this.Controls.Add(this.ButonSterge);
            this.Controls.Add(this.textBoxAn);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.textBoxEditura);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.lblNrExemplare);
            this.Controls.Add(this.textBoxTitlu);
            this.Controls.Add(this.lblAn);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblEditura);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(312, 467);
            this.MinimumSize = new System.Drawing.Size(312, 406);
            this.Name = "FormAdaugareCarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adaugă carte";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNrExemplare)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEditura;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.TextBox textBoxTitlu;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxEditura;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxAn;
        private System.Windows.Forms.Button ButonSterge;
        private System.Windows.Forms.Button ButonAdauga;
        private System.Windows.Forms.Label lblNrExemplare;
        private System.Windows.Forms.NumericUpDown numericUpDownNrExemplare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEroareAutor;
        private System.Windows.Forms.Label lblEroareEditura;
        private System.Windows.Forms.Label lblEroareAn;
        private System.Windows.Forms.Label lblEroareISBN;
    }
}

