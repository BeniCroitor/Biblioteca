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
            this.Titlu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ButonSterge = new System.Windows.Forms.Button();
            this.ButonAdauga = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEroareAutor = new System.Windows.Forms.Label();
            this.lblEroareEditura = new System.Windows.Forms.Label();
            this.lblEroareAn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titlu
            // 
            this.Titlu.AutoSize = true;
            this.Titlu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlu.Location = new System.Drawing.Point(40, 44);
            this.Titlu.Name = "Titlu";
            this.Titlu.Size = new System.Drawing.Size(65, 29);
            this.Titlu.TabIndex = 0;
            this.Titlu.Text = "Titlu";
            this.Titlu.Click += new System.EventHandler(this.Titlu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Editura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "ISBN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Anul aparitiei";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(141, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 35);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(141, 110);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 35);
            this.textBox2.TabIndex = 4;
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(168, 179);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 35);
            this.textBox3.TabIndex = 4;
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(141, 248);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 35);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(247, 317);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(73, 35);
            this.textBox5.TabIndex = 4;
            this.textBox5.Validating += new System.ComponentModel.CancelEventHandler(this.textBox5_Validating);
            // 
            // ButonSterge
            // 
            this.ButonSterge.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonSterge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButonSterge.Location = new System.Drawing.Point(31, 469);
            this.ButonSterge.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ButonSterge.Name = "ButonSterge";
            this.ButonSterge.Size = new System.Drawing.Size(149, 34);
            this.ButonSterge.TabIndex = 5;
            this.ButonSterge.Text = "Sterge";
            this.ButonSterge.UseVisualStyleBackColor = true;
            this.ButonSterge.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButonAdauga
            // 
            this.ButonAdauga.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonAdauga.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButonAdauga.Location = new System.Drawing.Point(217, 469);
            this.ButonAdauga.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ButonAdauga.Name = "ButonAdauga";
            this.ButonAdauga.Size = new System.Drawing.Size(149, 34);
            this.ButonAdauga.TabIndex = 5;
            this.ButonAdauga.Text = "Adauga Carte";
            this.ButonAdauga.UseVisualStyleBackColor = true;
            this.ButonAdauga.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "NR de exemplare";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(283, 387);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown1.Size = new System.Drawing.Size(61, 30);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblEroareAn);
            this.panel1.Controls.Add(this.lblEroareEditura);
            this.panel1.Controls.Add(this.lblEroareAutor);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 426);
            this.panel1.TabIndex = 7;
            // 
            // lblEroareAutor
            // 
            this.lblEroareAutor.AutoSize = true;
            this.lblEroareAutor.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEroareAutor.ForeColor = System.Drawing.Color.Red;
            this.lblEroareAutor.Location = new System.Drawing.Point(119, 127);
            this.lblEroareAutor.Name = "lblEroareAutor";
            this.lblEroareAutor.Size = new System.Drawing.Size(175, 15);
            this.lblEroareAutor.TabIndex = 0;
            this.lblEroareAutor.Text = "*Numele autorului este invalid!";
            this.lblEroareAutor.Visible = false;
            this.lblEroareAutor.Click += new System.EventHandler(this.lblEroareAutor_Click);
            // 
            // lblEroareEditura
            // 
            this.lblEroareEditura.AutoSize = true;
            this.lblEroareEditura.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEroareEditura.ForeColor = System.Drawing.Color.Red;
            this.lblEroareEditura.Location = new System.Drawing.Point(146, 196);
            this.lblEroareEditura.Name = "lblEroareEditura";
            this.lblEroareEditura.Size = new System.Drawing.Size(164, 15);
            this.lblEroareEditura.TabIndex = 0;
            this.lblEroareEditura.Text = "*Numele editurii este invalid!";
            this.lblEroareEditura.Visible = false;
            // 
            // lblEroareAn
            // 
            this.lblEroareAn.AutoSize = true;
            this.lblEroareAn.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEroareAn.ForeColor = System.Drawing.Color.Red;
            this.lblEroareAn.Location = new System.Drawing.Point(225, 336);
            this.lblEroareAn.Name = "lblEroareAn";
            this.lblEroareAn.Size = new System.Drawing.Size(67, 15);
            this.lblEroareAn.TabIndex = 0;
            this.lblEroareAn.Text = "*An invalid!";
            this.lblEroareAn.Visible = false;
            // 
            // FormAdaugareCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 526);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ButonAdauga);
            this.Controls.Add(this.ButonSterge);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titlu);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(411, 493);
            this.Name = "FormAdaugareCarte";
            this.Text = "Adaugă carte";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button ButonSterge;
        private System.Windows.Forms.Button ButonAdauga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEroareAutor;
        private System.Windows.Forms.Label lblEroareEditura;
        private System.Windows.Forms.Label lblEroareAn;
    }
}

