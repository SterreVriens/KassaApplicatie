namespace KassaSysteem_v1._0
{
    partial class ArticleSearchForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.alfabetButton = new System.Windows.Forms.Button();
            this.selectProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naam,
            this.foto,
            this.prijs});
            this.dataGridView1.Location = new System.Drawing.Point(23, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(427, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // naam
            // 
            this.naam.HeaderText = "Naam";
            this.naam.MinimumWidth = 6;
            this.naam.Name = "naam";
            this.naam.Width = 125;
            // 
            // foto
            // 
            this.foto.HeaderText = "Foto";
            this.foto.MinimumWidth = 6;
            this.foto.Name = "foto";
            this.foto.Width = 125;
            // 
            // prijs
            // 
            this.prijs.HeaderText = "Prijs";
            this.prijs.MinimumWidth = 6;
            this.prijs.Name = "prijs";
            this.prijs.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bell MT", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(515, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 23);
            this.textBox1.TabIndex = 1;
            // 
            // alfabetButton
            // 
            this.alfabetButton.Location = new System.Drawing.Point(688, 74);
            this.alfabetButton.Name = "alfabetButton";
            this.alfabetButton.Size = new System.Drawing.Size(91, 72);
            this.alfabetButton.TabIndex = 2;
            this.alfabetButton.Text = "Alfabet";
            this.alfabetButton.UseVisualStyleBackColor = true;
            // 
            // selectProductButton
            // 
            this.selectProductButton.Location = new System.Drawing.Point(456, 351);
            this.selectProductButton.Name = "selectProductButton";
            this.selectProductButton.Size = new System.Drawing.Size(91, 72);
            this.selectProductButton.TabIndex = 3;
            this.selectProductButton.Text = "Selecteer";
            this.selectProductButton.UseVisualStyleBackColor = true;
            // 
            // ArticleSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 479);
            this.Controls.Add(this.selectProductButton);
            this.Controls.Add(this.alfabetButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ArticleSearchForm";
            this.Text = "dat";
            this.Load += new System.EventHandler(this.ArticleSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijs;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button alfabetButton;
        private System.Windows.Forms.Button selectProductButton;
    }
}