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
    public partial class ArticleSearchForm : Form
    {

        public ArticleSearchForm()
        {
            InitializeComponent();
        }

        private void showArticles(string Letter)
        /*
         * This method shows all the articles that starts with the given Letter
         * it fills the datagridview with the found articles
         */
        {
            for (int i = 0; i < Program.articleDescription.Length; i++)
            {

            }
        }

        private void ArticleSearchForm_Load(object sender, EventArgs e)
        {
            //setup the screen to the right position (the center of the mainForm)
        }
    }
}
