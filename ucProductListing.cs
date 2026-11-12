using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CATAYAS_WEEK_06_WORK_05
{
    public partial class ucProductListing : UserControl
    {
        string[] units = { "Piece", "Box", "Kilogram" };
        List<string> shopingList = new List<string>();

        public ucProductListing()
        {
            InitializeComponent();
            cmboxAmount.Items.AddRange(units);
            cmboxAmount.SelectedIndex = 0;
            cmboxAmount.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmboxAmount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucProductListing_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string item = txtboxDescription.Text.Trim();
            string unit = cmboxAmount.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(item) || string.IsNullOrEmpty(unit))
            {
                lblPrompt.Text = "Please enter a description and select a unit.";
                lblPrompt.Visible = true;
                return;
            }

            if (!double.TryParse(txtboxAmount.Text, out double amount) || amount <= 0)
            {
                lblPrompt.Text = "Please enter a valid amount.";
                lblPrompt.Visible = true;
                txtboxAmount.Focus();
                return;
            }

            string row = $"{item}\t\t {amount} {unit}";
            shopingList.Add(row);
            updateGUI();

            MessageBox.Show("Item Added");
            txtboxAmount.Clear();
            txtboxDescription.Clear();
            cmboxAmount.SelectedIndex = 0;
            lblPrompt.Visible = false;
            txtboxDescription.Focus();
        }

        private void updateGUI()
        {
            lblboxItems.DataSource = null;
            lblboxItems.DataSource = shopingList;
            lblboxItems.ClearSelected();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lblboxItems.SelectedIndex;

            if (index != -1)
            {
                DialogResult deleteMessage = MessageBox.Show(
                    "Are you sure you wanna delete?",
                    "Delete Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (deleteMessage == DialogResult.Yes)
                {
                    string deletedItem = shopingList[index];
                    shopingList.RemoveAt(index);
                    updateGUI();
                    MessageBox.Show(deletedItem + " deleted.");
                }
            }
            else
            {
                lblPrompt.Text = "Please select an item to delete.";
                lblPrompt.Visible = true;
            }
        }

        private void lblboxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPrompt.Text = " ";
            lblPrompt.Visible = false;
        }

        private void lblPrompt_Click(object sender, EventArgs e)
        {

        }
    }
}
