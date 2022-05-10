
namespace FormAfisarePersoane
{
    partial class FormAfisarePersoane
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Serie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NrCI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NrCartiImpr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nume,
            this.Prenume,
            this.CNP,
            this.Serie,
            this.NrCI,
            this.NrCartiImpr});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(549, 393);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 26;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nume.Width = 88;
            // 
            // Prenume
            // 
            this.Prenume.Text = "Prenume";
            this.Prenume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Prenume.Width = 99;
            // 
            // CNP
            // 
            this.CNP.Text = "CNP";
            this.CNP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CNP.Width = 137;
            // 
            // Serie
            // 
            this.Serie.Text = "Serie CI";
            this.Serie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Serie.Width = 59;
            // 
            // NrCI
            // 
            this.NrCI.Text = "Nr CI";
            this.NrCI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NrCI.Width = 74;
            // 
            // NrCartiImpr
            // 
            this.NrCartiImpr.Text = "Nr carti";
            this.NrCartiImpr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAfisarePersoane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Name = "FormAfisarePersoane";
            this.Padding = new System.Windows.Forms.Padding(7, 50, 7, 7);
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Prenume;
        private System.Windows.Forms.ColumnHeader CNP;
        private System.Windows.Forms.ColumnHeader Serie;
        private System.Windows.Forms.ColumnHeader NrCI;
        private System.Windows.Forms.ColumnHeader NrCartiImpr;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

