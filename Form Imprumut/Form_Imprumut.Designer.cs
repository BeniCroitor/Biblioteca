namespace Form_Imprumut
{
    partial class Form_Imprumut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Imprumut));
            this.comboBox_Pers = new System.Windows.Forms.ComboBox();
            this.comboBox_Carte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConfirmare = new System.Windows.Forms.Button();
            this.lblEroarePers = new System.Windows.Forms.Label();
            this.lblEroareCarte = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNrExVal = new System.Windows.Forms.Label();
            this.lblNrEx = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAnApar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEditura = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Pers
            // 
            this.comboBox_Pers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Pers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Pers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Pers.FormattingEnabled = true;
            this.comboBox_Pers.Location = new System.Drawing.Point(33, 63);
            this.comboBox_Pers.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Pers.Name = "comboBox_Pers";
            this.comboBox_Pers.Size = new System.Drawing.Size(351, 32);
            this.comboBox_Pers.TabIndex = 0;
            this.comboBox_Pers.SelectedIndexChanged += new System.EventHandler(this.comboBox_Pers_SelectedIndexChanged);
            this.comboBox_Pers.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Pers_Validating);
            // 
            // comboBox_Carte
            // 
            this.comboBox_Carte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Carte.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Carte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Carte.FormattingEnabled = true;
            this.comboBox_Carte.Location = new System.Drawing.Point(33, 162);
            this.comboBox_Carte.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Carte.Name = "comboBox_Carte";
            this.comboBox_Carte.Size = new System.Drawing.Size(351, 32);
            this.comboBox_Carte.TabIndex = 1;
            this.comboBox_Carte.SelectedValueChanged += new System.EventHandler(this.comboBox_Carte_SelectedValueChanged);
            this.comboBox_Carte.TextChanged += new System.EventHandler(this.comboBox_Carte_TextChanged);
            this.comboBox_Carte.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Carte_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Persoană";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carte";
            // 
            // buttonConfirmare
            // 
            this.buttonConfirmare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonConfirmare.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonConfirmare.Location = new System.Drawing.Point(32, 495);
            this.buttonConfirmare.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfirmare.Name = "buttonConfirmare";
            this.buttonConfirmare.Size = new System.Drawing.Size(161, 34);
            this.buttonConfirmare.TabIndex = 2;
            this.buttonConfirmare.Text = "Confirmă";
            this.buttonConfirmare.UseVisualStyleBackColor = true;
            this.buttonConfirmare.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEroarePers
            // 
            this.lblEroarePers.AutoSize = true;
            this.lblEroarePers.ForeColor = System.Drawing.Color.Red;
            this.lblEroarePers.Location = new System.Drawing.Point(32, 103);
            this.lblEroarePers.Name = "lblEroarePers";
            this.lblEroarePers.Size = new System.Drawing.Size(190, 16);
            this.lblEroarePers.TabIndex = 3;
            this.lblEroarePers.Text = "* Alegeți un nume valid din listă";
            this.lblEroarePers.Visible = false;
            // 
            // lblEroareCarte
            // 
            this.lblEroareCarte.AutoSize = true;
            this.lblEroareCarte.ForeColor = System.Drawing.Color.Red;
            this.lblEroareCarte.Location = new System.Drawing.Point(32, 202);
            this.lblEroareCarte.Name = "lblEroareCarte";
            this.lblEroareCarte.Size = new System.Drawing.Size(189, 16);
            this.lblEroareCarte.TabIndex = 3;
            this.lblEroareCarte.Text = "* Alegeți o carte validă din listă";
            this.lblEroareCarte.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNrExVal);
            this.groupBox1.Controls.Add(this.lblNrEx);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblAnApar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblISBN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblEditura);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Carte";
            this.groupBox1.Visible = false;
            // 
            // lblNrExVal
            // 
            this.lblNrExVal.AutoSize = true;
            this.lblNrExVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrExVal.Location = new System.Drawing.Point(198, 145);
            this.lblNrExVal.Name = "lblNrExVal";
            this.lblNrExVal.Size = new System.Drawing.Size(24, 18);
            this.lblNrExVal.TabIndex = 0;
            this.lblNrExVal.Text = "Nr";
            // 
            // lblNrEx
            // 
            this.lblNrEx.AutoSize = true;
            this.lblNrEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrEx.Location = new System.Drawing.Point(139, 118);
            this.lblNrEx.Name = "lblNrEx";
            this.lblNrEx.Size = new System.Drawing.Size(24, 18);
            this.lblNrEx.TabIndex = 0;
            this.lblNrEx.Text = "Nr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nr de exemplare valabile:";
            // 
            // lblAnApar
            // 
            this.lblAnApar.AutoSize = true;
            this.lblAnApar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnApar.Location = new System.Drawing.Point(114, 91);
            this.lblAnApar.Name = "lblAnApar";
            this.lblAnApar.Size = new System.Drawing.Size(69, 18);
            this.lblAnApar.TabIndex = 0;
            this.lblAnApar.Text = "lblAnApar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nr de exemplare:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(60, 64);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(56, 18);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "lblISBN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Anul apariției:";
            // 
            // lblEditura
            // 
            this.lblEditura.AutoSize = true;
            this.lblEditura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditura.Location = new System.Drawing.Point(72, 37);
            this.lblEditura.Name = "lblEditura";
            this.lblEditura.Size = new System.Drawing.Size(68, 18);
            this.lblEditura.TabIndex = 0;
            this.lblEditura.Text = "lblEditura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "ISBN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Editura:";
            // 
            // Form_Imprumut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 555);
            this.Controls.Add(this.buttonConfirmare);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEroareCarte);
            this.Controls.Add(this.lblEroarePers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Carte);
            this.Controls.Add(this.comboBox_Pers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(473, 602);
            this.Name = "Form_Imprumut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Împrumut nou";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Pers;
        private System.Windows.Forms.ComboBox comboBox_Carte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConfirmare;
        private System.Windows.Forms.Label lblEroarePers;
        private System.Windows.Forms.Label lblEroareCarte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNrExVal;
        private System.Windows.Forms.Label lblNrEx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAnApar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblEditura;
    }
}

