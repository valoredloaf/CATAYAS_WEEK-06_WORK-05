using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CATAYAS_WEEK_06_WORK_05
{
    public partial class ucProductListing : UserControl
    {
        public ucProductListing()
        {
            InitializeComponent();
        }

        string[] units = { "Piece", "Box", "Kilogram" };

        List<string> shopingList = new List<string>();
        private void cmboxAmount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucProductListing_Load(object sender, EventArgs e)
        {
            cmboxAmount.Items.AddRange(units);
            cmboxAmount.SelectedIndex = 0;

            lblboxItems.DataSource = shopingList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string item = txtboxDescription.Text;
            double amount = double.Parse(txtboxAmount.Text);
            string unit = cmboxAmount.SelectedText.ToString();

            if (!string.IsNullOrEmpty(unit) && !string.IsNullOrEmpty(item) && !string.IsNullOrEmpty(amount.ToString())) {
                string row = $"{item}\t\t {amount} {unit}";
                shopingList.Add(row);
                updateGUI();

                MessageBox.Show("Item Added");
                txtboxAmount.Clear();
                txtboxDescription.Clear();
                cmboxAmount.Refresh();
                txtboxDescription.Focus();
            }

        }
        private void updateGUI()
        {
            lblboxItems.DataSource = null;
            lblboxItems.DataSource = shopingList;
        }
    }
}