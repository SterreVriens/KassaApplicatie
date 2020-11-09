namespace KassaSysteem_v1._0
{
    partial class d
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
            this.components = new System.ComponentModel.Container();
            this.advertisementTimer = new System.Windows.Forms.Timer(this.components);
            this.bonKnop = new System.Windows.Forms.Button();
            this.klantenScherm = new System.Windows.Forms.DataGridView();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.beschrijving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aantal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prijs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reclameScherm = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.klantenScherm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reclameScherm)).BeginInit();
            this.SuspendLayout();
            // 
            // advertisementTimer
            // 
            this.advertisementTimer.Tick += new System.EventHandler(this.advertisementTimer_Tick);
            // 
            // bonKnop
            // 
            this.bonKnop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bonKnop.Location = new System.Drawing.Point(764, 651);
            this.bonKnop.Name = "bonKnop";
            this.bonKnop.Size = new System.Drawing.Size(149, 63);
            this.bonKnop.TabIndex = 0;
            this.bonKnop.Text = "Bon";
            this.bonKnop.UseVisualStyleBackColor = true;
            this.bonKnop.Click += new System.EventHandler(this.BonKnop_Click);
            // 
            // klantenScherm
            // 
            this.klantenScherm.AllowUserToAddRows = false;
            this.klantenScherm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klantenScherm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Foto,
            this.beschrijving,
            this.aantal,
            this.Prijs});
            this.klantenScherm.Location = new System.Drawing.Point(12, 22);
            this.klantenScherm.Name = "klantenScherm";
            this.klantenScherm.RowHeadersWidth = 51;
            this.klantenScherm.RowTemplate.Height = 24;
            this.klantenScherm.Size = new System.Drawing.Size(719, 771);
            this.klantenScherm.TabIndex = 2;
            this.klantenScherm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.MinimumWidth = 6;
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Foto.Width = 125;
            // 
            // beschrijving
            // 
            this.beschrijving.HeaderText = "Beschrijving";
            this.beschrijving.MinimumWidth = 6;
            this.beschrijving.Name = "beschrijving";
            this.beschrijving.ReadOnly = true;
            this.beschrijving.Width = 125;
            // 
            // aantal
            // 
            this.aantal.HeaderText = "Aantal";
            this.aantal.MinimumWidth = 6;
            this.aantal.Name = "aantal";
            this.aantal.ReadOnly = true;
            this.aantal.Width = 125;
            // 
            // Prijs
            // 
            this.Prijs.HeaderText = "Prijs";
            this.Prijs.MinimumWidth = 6;
            this.Prijs.Name = "Prijs";
            this.Prijs.ReadOnly = true;
            this.Prijs.Width = 125;
            // 
            // reclameScherm
            // 
            this.reclameScherm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reclameScherm.Location = new System.Drawing.Point(764, 12);
            this.reclameScherm.Name = "reclameScherm";
            this.reclameScherm.Size = new System.Drawing.Size(709, 610);
            this.reclameScherm.TabIndex = 1;
            this.reclameScherm.TabStop = false;
            this.reclameScherm.Click += new System.EventHandler(this.ReclameScherm_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1309, 771);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // d
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 805);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.klantenScherm);
            this.Controls.Add(this.reclameScherm);
            this.Controls.Add(this.bonKnop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "d";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.D_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klantenScherm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reclameScherm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer advertisementTimer;
        private System.Windows.Forms.Button bonKnop;
        private System.Windows.Forms.PictureBox reclameScherm;
        private System.Windows.Forms.DataGridView klantenScherm;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn beschrijving;
        private System.Windows.Forms.DataGridViewTextBoxColumn aantal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prijs;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}