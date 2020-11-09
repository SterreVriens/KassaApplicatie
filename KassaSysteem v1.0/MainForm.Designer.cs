namespace KassaSysteem_v1._0
{
    partial class MainForm
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
            this.mederwerkerScherm = new System.Windows.Forms.DataGridView();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.Beschrijving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aantal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prijs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterArticleSearch = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.articleBox = new System.Windows.Forms.TextBox();
            this.productSearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPriceShow = new System.Windows.Forms.Label();
            this.changeMoney = new System.Windows.Forms.Label();
            this.showChangeMoney = new System.Windows.Forms.Label();
            this.showTotalPrice = new System.Windows.Forms.Label();
            this.articleNumber = new System.Windows.Forms.Label();
            this.moneyInput = new System.Windows.Forms.TextBox();
            this.moneyInputDisplay = new System.Windows.Forms.Label();
            this.commaKnop = new System.Windows.Forms.Button();
            this.enterChangeMoney = new System.Windows.Forms.Button();
            this.bonUitprint = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.mederwerkerScherm)).BeginInit();
            this.SuspendLayout();
            // 
            // mederwerkerScherm
            // 
            this.mederwerkerScherm.AllowDrop = true;
            this.mederwerkerScherm.AllowUserToAddRows = false;
            this.mederwerkerScherm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mederwerkerScherm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mederwerkerScherm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mederwerkerScherm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Foto,
            this.Beschrijving,
            this.Aantal,
            this.Prijs});
            this.mederwerkerScherm.Location = new System.Drawing.Point(13, 13);
            this.mederwerkerScherm.Name = "mederwerkerScherm";
            this.mederwerkerScherm.RowHeadersWidth = 51;
            this.mederwerkerScherm.RowTemplate.Height = 24;
            this.mederwerkerScherm.Size = new System.Drawing.Size(874, 709);
            this.mederwerkerScherm.TabIndex = 0;
            this.mederwerkerScherm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MederwerkerScherm_CellClick);
            this.mederwerkerScherm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Foto
            // 
            this.Foto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Foto.HeaderText = "Foto";
            this.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Foto.MinimumWidth = 6;
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Beschrijving
            // 
            this.Beschrijving.HeaderText = "Beschrijving";
            this.Beschrijving.MinimumWidth = 6;
            this.Beschrijving.Name = "Beschrijving";
            this.Beschrijving.ReadOnly = true;
            // 
            // Aantal
            // 
            this.Aantal.HeaderText = "Aantal";
            this.Aantal.MinimumWidth = 6;
            this.Aantal.Name = "Aantal";
            this.Aantal.ReadOnly = true;
            // 
            // Prijs
            // 
            this.Prijs.HeaderText = "Prijs";
            this.Prijs.MinimumWidth = 6;
            this.Prijs.Name = "Prijs";
            this.Prijs.ReadOnly = true;
            // 
            // enterArticleSearch
            // 
            this.enterArticleSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterArticleSearch.Location = new System.Drawing.Point(1428, 5);
            this.enterArticleSearch.Name = "enterArticleSearch";
            this.enterArticleSearch.Size = new System.Drawing.Size(107, 53);
            this.enterArticleSearch.TabIndex = 1;
            this.enterArticleSearch.Text = "Enter";
            this.enterArticleSearch.UseVisualStyleBackColor = true;
            this.enterArticleSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroButton.Location = new System.Drawing.Point(1222, 420);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(84, 79);
            this.zeroButton.TabIndex = 2;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.ZeroButton_Click_1);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(1132, 420);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(84, 79);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "C";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // oneButton
            // 
            this.oneButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.Location = new System.Drawing.Point(1132, 335);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(84, 79);
            this.oneButton.TabIndex = 4;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.OneButton_Click_1);
            // 
            // twoButton
            // 
            this.twoButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoButton.Location = new System.Drawing.Point(1222, 335);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(84, 79);
            this.twoButton.TabIndex = 5;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeButton.Location = new System.Drawing.Point(1314, 335);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(84, 79);
            this.threeButton.TabIndex = 6;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.ThreeButton_Click_1);
            // 
            // fourButton
            // 
            this.fourButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourButton.Location = new System.Drawing.Point(1132, 250);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(84, 79);
            this.fourButton.TabIndex = 7;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.FourButton_Click_1);
            // 
            // fiveButton
            // 
            this.fiveButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.Location = new System.Drawing.Point(1222, 250);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(84, 79);
            this.fiveButton.TabIndex = 8;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButton.Location = new System.Drawing.Point(1314, 250);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(84, 79);
            this.sixButton.TabIndex = 9;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.SixButton_Click_1);
            // 
            // sevenButton
            // 
            this.sevenButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenButton.Location = new System.Drawing.Point(1132, 165);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(84, 79);
            this.sevenButton.TabIndex = 10;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.SevenButton_Click_1);
            // 
            // eightButton
            // 
            this.eightButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButton.Location = new System.Drawing.Point(1222, 165);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(84, 79);
            this.eightButton.TabIndex = 11;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.EightButton_Click_1);
            // 
            // nineButton
            // 
            this.nineButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineButton.Location = new System.Drawing.Point(1314, 165);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(84, 79);
            this.nineButton.TabIndex = 12;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.NineButton_Click_1);
            // 
            // articleBox
            // 
            this.articleBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleBox.ForeColor = System.Drawing.Color.Maroon;
            this.articleBox.Location = new System.Drawing.Point(1112, 13);
            this.articleBox.Name = "articleBox";
            this.articleBox.Size = new System.Drawing.Size(310, 34);
            this.articleBox.TabIndex = 16;
            // 
            // productSearchButton
            // 
            this.productSearchButton.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSearchButton.Location = new System.Drawing.Point(1132, 505);
            this.productSearchButton.Name = "productSearchButton";
            this.productSearchButton.Size = new System.Drawing.Size(123, 63);
            this.productSearchButton.TabIndex = 17;
            this.productSearchButton.Text = "🔍";
            this.productSearchButton.UseVisualStyleBackColor = true;
            this.productSearchButton.Click += new System.EventHandler(this.ProductSearchButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(916, 600);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 58);
            this.label1.TabIndex = 19;
            this.label1.Text = "Totaal: ";
            // 
            // totalPriceShow
            // 
            this.totalPriceShow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalPriceShow.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceShow.ForeColor = System.Drawing.Color.Maroon;
            this.totalPriceShow.Location = new System.Drawing.Point(1423, 958);
            this.totalPriceShow.Name = "totalPriceShow";
            this.totalPriceShow.Size = new System.Drawing.Size(239, 79);
            this.totalPriceShow.TabIndex = 20;
            // 
            // changeMoney
            // 
            this.changeMoney.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeMoney.Location = new System.Drawing.Point(1078, 600);
            this.changeMoney.Name = "changeMoney";
            this.changeMoney.Size = new System.Drawing.Size(177, 58);
            this.changeMoney.TabIndex = 22;
            this.changeMoney.Text = "Wisselgeld:";
            // 
            // showChangeMoney
            // 
            this.showChangeMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.showChangeMoney.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showChangeMoney.ForeColor = System.Drawing.Color.Maroon;
            this.showChangeMoney.Location = new System.Drawing.Point(1159, 643);
            this.showChangeMoney.Name = "showChangeMoney";
            this.showChangeMoney.Size = new System.Drawing.Size(239, 79);
            this.showChangeMoney.TabIndex = 23;
            // 
            // showTotalPrice
            // 
            this.showTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.showTotalPrice.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTotalPrice.ForeColor = System.Drawing.Color.Maroon;
            this.showTotalPrice.Location = new System.Drawing.Point(916, 643);
            this.showTotalPrice.Name = "showTotalPrice";
            this.showTotalPrice.Size = new System.Drawing.Size(239, 79);
            this.showTotalPrice.TabIndex = 24;
            // 
            // articleNumber
            // 
            this.articleNumber.AutoSize = true;
            this.articleNumber.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleNumber.Location = new System.Drawing.Point(917, 18);
            this.articleNumber.Name = "articleNumber";
            this.articleNumber.Size = new System.Drawing.Size(191, 29);
            this.articleNumber.TabIndex = 25;
            this.articleNumber.Text = "artikelnummer: ";
            // 
            // moneyInput
            // 
            this.moneyInput.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyInput.ForeColor = System.Drawing.Color.Maroon;
            this.moneyInput.Location = new System.Drawing.Point(1112, 80);
            this.moneyInput.Name = "moneyInput";
            this.moneyInput.Size = new System.Drawing.Size(310, 34);
            this.moneyInput.TabIndex = 26;
            // 
            // moneyInputDisplay
            // 
            this.moneyInputDisplay.AutoSize = true;
            this.moneyInputDisplay.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyInputDisplay.Location = new System.Drawing.Point(918, 83);
            this.moneyInputDisplay.Name = "moneyInputDisplay";
            this.moneyInputDisplay.Size = new System.Drawing.Size(192, 29);
            this.moneyInputDisplay.TabIndex = 27;
            this.moneyInputDisplay.Text = "Gegeven geld:  ";
            // 
            // commaKnop
            // 
            this.commaKnop.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commaKnop.Location = new System.Drawing.Point(1314, 420);
            this.commaKnop.Name = "commaKnop";
            this.commaKnop.Size = new System.Drawing.Size(84, 79);
            this.commaKnop.TabIndex = 28;
            this.commaKnop.Text = ",";
            this.commaKnop.UseVisualStyleBackColor = true;
            this.commaKnop.Click += new System.EventHandler(this.CommaKnop_Click_1);
            // 
            // enterChangeMoney
            // 
            this.enterChangeMoney.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterChangeMoney.Location = new System.Drawing.Point(1428, 72);
            this.enterChangeMoney.Name = "enterChangeMoney";
            this.enterChangeMoney.Size = new System.Drawing.Size(107, 53);
            this.enterChangeMoney.TabIndex = 29;
            this.enterChangeMoney.Text = "Enter";
            this.enterChangeMoney.UseVisualStyleBackColor = true;
            this.enterChangeMoney.Click += new System.EventHandler(this.EnterChangeMoney_Click);
            // 
            // bonUitprint
            // 
            this.bonUitprint.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonUitprint.Location = new System.Drawing.Point(1274, 505);
            this.bonUitprint.Name = "bonUitprint";
            this.bonUitprint.Size = new System.Drawing.Size(124, 63);
            this.bonUitprint.TabIndex = 30;
            this.bonUitprint.Text = "Bon uitprinten";
            this.bonUitprint.UseVisualStyleBackColor = true;
            this.bonUitprint.Click += new System.EventHandler(this.BonUitprint_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1299, 709);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 22);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1547, 734);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bonUitprint);
            this.Controls.Add(this.enterChangeMoney);
            this.Controls.Add(this.commaKnop);
            this.Controls.Add(this.moneyInputDisplay);
            this.Controls.Add(this.moneyInput);
            this.Controls.Add(this.articleNumber);
            this.Controls.Add(this.showTotalPrice);
            this.Controls.Add(this.showChangeMoney);
            this.Controls.Add(this.changeMoney);
            this.Controls.Add(this.totalPriceShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productSearchButton);
            this.Controls.Add(this.articleBox);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.enterArticleSearch);
            this.Controls.Add(this.mederwerkerScherm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mederwerkerScherm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mederwerkerScherm;
        private System.Windows.Forms.Button enterArticleSearch;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.TextBox articleBox;
        private System.Windows.Forms.Button productSearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalPriceShow;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beschrijving;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aantal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prijs;
        private System.Windows.Forms.Label changeMoney;
        private System.Windows.Forms.Label showChangeMoney;
        private System.Windows.Forms.Label showTotalPrice;
        private System.Windows.Forms.Label articleNumber;
        private System.Windows.Forms.TextBox moneyInput;
        private System.Windows.Forms.Label moneyInputDisplay;
        private System.Windows.Forms.Button commaKnop;
        private System.Windows.Forms.Button enterChangeMoney;
        private System.Windows.Forms.Button bonUitprint;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

