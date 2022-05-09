namespace Form_Afisare
{
    partial class FormAfisareCarti
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListaCarti = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Titlu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Editura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnulAparitiei = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NrExemplare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Museo Sans 700", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(581, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista Cartilor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ListaCarti
            // 
            this.ListaCarti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Titlu,
            this.Autor,
            this.Editura,
            this.ISBN,
            this.AnulAparitiei,
            this.NrExemplare});
            this.ListaCarti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaCarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaCarti.GridLines = true;
            this.ListaCarti.HideSelection = false;
            this.ListaCarti.Location = new System.Drawing.Point(10, 10);
            this.ListaCarti.Name = "ListaCarti";
            this.ListaCarti.Size = new System.Drawing.Size(1450, 586);
            this.ListaCarti.TabIndex = 1;
            this.ListaCarti.UseCompatibleStateImageBehavior = false;
            this.ListaCarti.View = System.Windows.Forms.View.Details;
            this.ListaCarti.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // Titlu
            // 
            this.Titlu.Text = "Titlu";
            this.Titlu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Titlu.Width = 200;
            // 
            // Autor
            // 
            this.Autor.Text = "Autor";
            this.Autor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Autor.Width = 200;
            // 
            // Editura
            // 
            this.Editura.Text = "Editura";
            this.Editura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Editura.Width = 200;
            // 
            // ISBN
            // 
            this.ISBN.Text = "ISBN";
            this.ISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ISBN.Width = 300;
            // 
            // AnulAparitiei
            // 
            this.AnulAparitiei.Text = "Anul Aparitiei";
            this.AnulAparitiei.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AnulAparitiei.Width = 200;
            // 
            // NrExemplare
            // 
            this.NrExemplare.Text = "Nr Exemplare";
            this.NrExemplare.Width = 206;
            // 
            // FormAfisareCarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1470, 606);
            this.Controls.Add(this.ListaCarti);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormAfisareCarti";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Carti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListaCarti;
        private System.Windows.Forms.ColumnHeader Titlu;
        private System.Windows.Forms.ColumnHeader Autor;
        private System.Windows.Forms.ColumnHeader Editura;
        private System.Windows.Forms.ColumnHeader ISBN;
        private System.Windows.Forms.ColumnHeader AnulAparitiei;
        private System.Windows.Forms.ColumnHeader NrExemplare;
        private System.Windows.Forms.ColumnHeader ID;
    }
}

