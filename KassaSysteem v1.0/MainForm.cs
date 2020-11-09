using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KassaSysteem_v1._0
{
    public partial class MainForm : Form
    {
        d customerForm = new d();
        public MainForm()
        {
            InitializeComponent();

         
        }

        private void getData()
        /*
         * with this method the global arrays with article information is filles with data
         * This data can be used within the program.
        */
        {
            Program.articleDescription[0] = "Tauge";
            Program.articleDescription[1] = "Paksoi";
            Program.articleDescription[2] = "Blokjes tomaat in tomatensap";
            Program.articleDescription[3] = "Kikkererwten";
            Program.articleDescription[4] = "Boemboe Java";
            Program.articleDescription[5] = "Arachide olie";
            Program.articleDescription[6] = "Warmgerookte zalmstukken";
            Program.articleDescription[7] = "Bieslook";
            Program.articleDescription[8] = "Kippenbouillon";
            Program.articleDescription[9] = "Olijfolie mild";
            Program.articleDescription[10] = "Prei";
            Program.articleDescription[11] = "Iets kruimige aardappel";
            Program.articleDescription[12] = "Middelgrote uien";
            Program.articleDescription[13] = "Kleine krieltjes";
            Program.articleDescription[14] = "Knoflook";
            Program.articleDescription[15] = "Platte peterselie";
            Program.articleDescription[16] = "Mandarijnen net";
            Program.articleDescription[17] = "Witlof";
            Program.articleDescription[18] = "Blanke rozijnen";
            Program.articleDescription[19] = "Yoghurt kruiden dressing";
            Program.articleDescription[20] = "Spitskool (gesneden)";
            Program.articleDescription[21] = "Gerookte amandelen";
            Program.articleDescription[22] = "Kaasschnitzel";

            Program.articlePrice[0] = 1f;
            Program.articlePrice[1] = 1.49f;
            Program.articlePrice[2] = 0.79f;
            Program.articlePrice[3] = 1.89f;
            Program.articlePrice[4] = 1.02f;
            Program.articlePrice[5] = 3.49f;
            Program.articlePrice[6] = 7.49f;
            Program.articlePrice[7] = 1.69f;
            Program.articlePrice[8] = 1.12f;
            Program.articlePrice[9] = 4.85f;
            Program.articlePrice[10] = 0.46f;
            Program.articlePrice[11] = 3.99f;
            Program.articlePrice[12] = 1.09f;
            Program.articlePrice[13] = 0.99f;
            Program.articlePrice[14] = 0.89f;
            Program.articlePrice[15] = 1.39f;
            Program.articlePrice[16] = 3.49f;
            Program.articlePrice[17] = 1.49f;
            Program.articlePrice[18] = 3.39f;
            Program.articlePrice[19] = 1.59f;
            Program.articlePrice[20] = 1.79f;
            Program.articlePrice[21] = 2.59f;
            Program.articlePrice[22] = 1.24f;

            Program.articlePicture[0] = @".\img\0.jpg";
            Program.articlePicture[1] = @".\img\1.jpg";
            Program.articlePicture[2] = @".\img\2.jpg";
            Program.articlePicture[3] = @".\img\3.jpg";
            Program.articlePicture[4] = @".\img\4.jpg";
            Program.articlePicture[5] = @".\img\5.jpg";
            Program.articlePicture[6] = @".\img\6.jpg";
            Program.articlePicture[7] = @".\img\7.jpg";
            Program.articlePicture[8] = @".\img\8.jpg";
            Program.articlePicture[9] = @".\img\9.jpg";
            Program.articlePicture[10] = @".\img\10.jpg";
            Program.articlePicture[11] = @".\img\11.jpg";
            Program.articlePicture[12] = @".\img\12.jpg";
            Program.articlePicture[13] = @".\img\13.jpg";
            Program.articlePicture[14] = @".\img\14.jpg";
            Program.articlePicture[15] = @".\img\15.jpg";
            Program.articlePicture[16] = @".\img\16.jpg";
            Program.articlePicture[17] = @".\img\17.jpg";
            Program.articlePicture[18] = @".\img\18.jpg";
            Program.articlePicture[19] = @".\img\19.jpg";
            Program.articlePicture[20] = @".\img\20.jpg";
            Program.articlePicture[21] = @".\img\21.jpg";
            Program.articlePicture[22] = @".\img\22.jpg";

            Program.articleNumber[0] = "4590";
            Program.articleNumber[1] = "4483";
            Program.articleNumber[2] = "2434";
            Program.articleNumber[3] = "7636";
            Program.articleNumber[4] = "5220";
            Program.articleNumber[5] = "4048";
            Program.articleNumber[6] = "6377";
            Program.articleNumber[7] = "8701";
            Program.articleNumber[8] = "1741";
            Program.articleNumber[9] = "5608";
            Program.articleNumber[10] = "8781";
            Program.articleNumber[11] = "3601";
            Program.articleNumber[12] = "4000";
            Program.articleNumber[13] = "2507";
            Program.articleNumber[14] = "2025";
            Program.articleNumber[15] = "5548";
            Program.articleNumber[16] = "5010";
            Program.articleNumber[17] = "8537";
            Program.articleNumber[18] = "8133";
            Program.articleNumber[19] = "7505";
            Program.articleNumber[20] = "6418";
            Program.articleNumber[21] = "8677";
            Program.articleNumber[22] = "5947";

        }
       
        private void addNumberToArticleNumber(string number)
        /*
         * adds a number to the acticlenumber textbox
         */
        {

        }

        private int articleSearch(string articleNumber)
        /*
         * this method searches in the articlenumber array and checks if the
         * number is present in the array
         * if the articlenumber is found in the array it returns the array index
         * if the articlenumber cannot be found it returns -1
         */
        {
            for (int i = 0; i < Program.articleNumber.Count(); i++)
            {
                if(articleNumber == Program.articleNumber[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public float calculateTotalprice(int[] receiptArticleNumbers)
        {

            float totalprice = 0.0f;

            // receiptArticleNumbers = mederwerkerScherm.SelectedRows; .Value;

            if (receiptArticleNumbers.Length > 0)
            {
                for (int i = 0; i < receiptArticleNumbers.Length; i++)
                {
                    if (receiptArticleNumbers[i] != 0)
                    {
                        int articleIndex = receiptArticleNumbers[i];
                        totalprice += Program.articlePrice[articleIndex];
                    }                 
                }
                return totalprice;
            }

            else
            {
                return -1;
            }
        }

        private void setupScreen()
        /*
         * setup the different screens
         */
        {
            customerForm.Show();

            // zorg ervoor dat bij het starten alle schermen op een vaste positie komen
            // dus het scherm van de kassiere en klant
            // het programma moet uiteindelijk zonder dat de gebruiker iets hoeft te doen
            // gereed staan, klaar voor gebruikt
        }

        public void numpad (string number)
        {
            articleBox.Text = articleBox.Text + number;
        }
        
        private void MainForm_Load(object sender, EventArgs e)
         /*
          * 
          * methods for preparing the program
          */
        {
            getData();
            setupScreen();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            int articleIndex = articleSearch(articleBox.Text);
            //customerForm.re

            if (articleIndex != -1)
            {
                Image productImage = Image.FromFile(Program.articlePicture[articleIndex]);
                mederwerkerScherm.Rows.Add(productImage, Program.articleDescription[articleIndex], "1", Program.articlePrice[articleIndex]);

                if (Program.receiptArticleNumber.Length > 0)
                {
                    for (int i = 0; i < Program.receiptArticleNumber.Length; i++)
                    {
                        if (Program.receiptArticleNumber[i] == 0)
                        {
                            Program.receiptArticleNumber[i] = articleIndex;
                            break;
                        }
                    }
                }


                showTotalPrice.Text = calculateTotalprice(Program.receiptArticleNumber).ToString();

            }
            else
            {
                MessageBox.Show("Dit product staat niet in de database");
                articleBox.Clear();
            }
            if (Program.receiptArticleNumber.Length > 0)
            {
                for (int i = 0; i < Program.receiptArticleNumber.Length; i++)
                {
                    if (Program.receiptArticleNumber[i] == 0)
                    {
                        Program.receiptArticleNumber[i] = articleIndex;
                        break;
                    }
                }
            }

            showTotalPrice.Text = calculateTotalprice(Program.receiptArticleNumber).ToString();
            
            int LowestEmptyIndex = Array.IndexOf(Program.receiptArticleAmount, 0);
            Console.WriteLine("Laagste, lege index: " + LowestEmptyIndex);
            Program.receiptArticleNumber[LowestEmptyIndex] = articleIndex;
            Program.receiptArticleAmount[LowestEmptyIndex] = 1;

            for (int i = 0; i < Program.receiptArticleNumber.Length; i++)
            {
                Console.WriteLine(Program.receiptArticleNumber[i]);
            }

            customerForm.UpdateDataGrid(LowestEmptyIndex);
        }





       


        private void EnterChangeMoney_Click(object sender, EventArgs e)
        {
            float givenMoney = 0;
            float totalPriceShown = 0;
            float showChangeMoneyInt = 0;

            //Int32.TryParse(showChangeMoney.Text, out showChangeMoneyInt);
            float.TryParse(moneyInput.Text, out givenMoney);
            float.TryParse(showTotalPrice.Text, out totalPriceShown);
            showChangeMoneyInt = givenMoney - totalPriceShown;

            showChangeMoney.Text = showChangeMoneyInt.ToString();
        }

        private void MederwerkerScherm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("wil je dit product verwijderen?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int deletedRow = mederwerkerScherm.CurrentCell.RowIndex;
                mederwerkerScherm.Rows.RemoveAt(deletedRow);

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

   

        private void ZeroButton_Click_1(object sender, EventArgs e)
        {
            numpad("0");
        }

        private void OneButton_Click_1(object sender, EventArgs e)
        {
            numpad("1");
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            numpad("2");
        }

        private void ThreeButton_Click_1(object sender, EventArgs e)
        {
            numpad("3");
        }

        private void FourButton_Click_1(object sender, EventArgs e)
        {
            numpad("4");
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            numpad("5");
        }

        private void SixButton_Click_1(object sender, EventArgs e)
        {
            numpad("6");
        }

        private void SevenButton_Click_1(object sender, EventArgs e)
        {
            numpad("7");
        }

        private void EightButton_Click_1(object sender, EventArgs e)
        {
            numpad("8");
        }

        private void NineButton_Click_1(object sender, EventArgs e)
        {
            numpad("9");
        }

        private void CommaKnop_Click_1(object sender, EventArgs e)
        {
            numpad(",");
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            articleBox.Clear();
        }

        private void BonUitprint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bon wordt uitgeprint en gegevens worden verwijderd");
            mederwerkerScherm.Rows.Clear();
            mederwerkerScherm.Refresh();
            showChangeMoney.Text = "";
            showTotalPrice.Text = "";
            articleBox.Clear();
            moneyInput.Clear();
        }

        private void ProductSearchButton_Click(object sender, EventArgs e)
        {

        }
    }
}

