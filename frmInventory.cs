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
        public frmInventory()
        {
            InitializeComponent();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPage(new ucProductListing());
        }

        private void ShowPage(UserControl page) {
            pnlContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPage(new ucHomePage());
        }
    }
}
