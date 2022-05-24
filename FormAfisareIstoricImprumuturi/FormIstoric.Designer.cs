namespace FormAfisareIstoricImprumuturi
{
    partial class FormIstoric
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIstoric));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Persoana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Persoana,
            this.Titlu,
            this.Data_out,
            this.Data_in});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 578);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Persoana
            // 
            this.Persoana.HeaderText = "Persoană";
            this.Persoana.MinimumWidth = 6;
            this.Persoana.Name = "Persoana";
            this.Persoana.ReadOnly = true;
            this.Persoana.Width = 200;
            // 
            // Titlu
            // 
            this.Titlu.HeaderText = "Titlu";
            this.Titlu.MinimumWidth = 6;
            this.Titlu.Name = "Titlu";
            this.Titlu.ReadOnly = true;
            this.Titlu.Width = 200;
            // 
            // Data_out
            // 
            this.Data_out.HeaderText = "Data împrumutului";
            this.Data_out.MinimumWidth = 6;
            this.Data_out.Name = "Data_out";
            this.Data_out.ReadOnly = true;
            this.Data_out.Width = 125;
            // 
            // Data_in
            // 
            this.Data_in.HeaderText = "Data returnării";
            this.Data_in.MinimumWidth = 6;
            this.Data_in.Name = "Data_in";
            this.Data_in.ReadOnly = true;
            this.Data_in.Width = 125;
            // 
            // FormIstoric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 462);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1023, 1080);
            this.MinimumSize = new System.Drawing.Size(1023, 500);
            this.Name = "FormIstoric";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Istoric Împrumuturi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Persoana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_out;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_in;
    }
}

