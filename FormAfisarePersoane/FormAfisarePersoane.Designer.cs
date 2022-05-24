
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAfisarePersoane));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Serie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NrCI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NrCartiImpr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SwearchBox = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
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
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 62);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(754, 620);
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
            this.Serie.Width = 76;
            // 
            // NrCI
            // 
            this.NrCI.Text = "Nr CI";
            this.NrCI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NrCI.Width = 74;
            // 
            // NrCartiImpr
            // 
            this.NrCartiImpr.Text = "Nr cărți";
            this.NrCartiImpr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SwearchBox
            // 
            this.SwearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwearchBox.Location = new System.Drawing.Point(9, 18);
            this.SwearchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SwearchBox.Name = "SwearchBox";
            this.SwearchBox.Size = new System.Drawing.Size(241, 24);
            this.SwearchBox.TabIndex = 1;
            this.SwearchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSearch.Location = new System.Drawing.Point(287, 16);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 28);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // FormAfisarePersoane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 691);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.SwearchBox);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(790, 1920);
            this.Name = "FormAfisarePersoane";
            this.Padding = new System.Windows.Forms.Padding(9, 62, 9, 9);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista Persoane";
            this.Load += new System.EventHandler(this.FormAfisarePersoane_Load);
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
        private System.Windows.Forms.TextBox SwearchBox;
        private System.Windows.Forms.Button buttonSearch;
    }
}

