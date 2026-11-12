using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CATAYAS_WEEK_06_WORK_05
{
    public partial class frmInventory : Form
    {
        private ucProductListing productPage = new ucProductListing();
        private ucHomePage homePage = new ucHomePage();

        public frmInventory()
        {
            InitializeComponent();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPage(homePage);
        }

        private void ShowPage(UserControl page)
        {
            pnlContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPage(productPage);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult userResponse = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (userResponse == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPage(new ucHomePage());
        }
    }
}
