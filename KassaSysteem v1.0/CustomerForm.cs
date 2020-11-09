using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KassaSysteem_v1._0
{
    public partial class d : Form
    {
        int pictureCounter = 0;
        string[] advertisementPictures = { @".\img\advertisement1.jpg", @".\img\advertisement2.jpg", @".\img\advertisement3.jpg" };
        
        public d()
        {
            InitializeComponent();
        }

        public void showTotalPriceExchange(float totalPrice, float exchange)
        {

        }

        private void advertisementTimer_Tick(object sender, EventArgs e)
        {
            if (pictureCounter < 3)
            {
                //additional code
                pictureCounter++;
            }
            else
            {
                pictureCounter = 0;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void D_Load(object sender, EventArgs e)
        {

            reclameScherm.Image = Properties.Resources._1;
            reclameScherm.SizeMode = PictureBoxSizeMode.StretchImage;
            Timer tm = new Timer();
            tm.Interval = 5000;
            tm.Tick += new EventHandler(changeImage);
            tm.Start();
        }

        private void changeImage(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources._1);
            b1.Add(Properties.Resources._2);
            b1.Add(Properties.Resources._3);
            int index = DateTime.Now.Second % b1.Count;
            reclameScherm.Image = b1[index];
        }

        private void BonKnop_Click(object sender, EventArgs e)
        {


        MessageBox.Show("De klant wilt een bonnetje.");
        }

        private void ReclameScherm_Click(object sender, EventArgs e)
        {
            
        }

        public void UpdateDataGrid(int index)
        {

            Image productImage = Image.FromFile(Program.articlePicture[Program.receiptArticleNumber[index]]);
            int currentRow = klantenScherm.Rows.Add();
            klantenScherm.Rows[currentRow].Cells[0].Value = productImage; // img
            klantenScherm.Rows[currentRow].Cells[1].Value = Program.articleDescription[Program.receiptArticleNumber[index]]; // description
            klantenScherm.Rows[currentRow].Cells[2].Value = "1";// description
            klantenScherm.Rows[currentRow].Cells[3].Value = Program.articlePrice[Program.receiptArticleNumber[index]];
        }

    }
}
