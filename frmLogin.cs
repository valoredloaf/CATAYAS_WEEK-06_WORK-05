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
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtboxUsername_TextChanged(object sender, EventArgs e)
        {
            txtboxUsername.Focus();
            
        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxUsername.Text))
            {
                txtboxUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtboxPassword.Text))
            {
                txtboxPassword.Focus();
                return;
            }

            if (txtboxUsername.Text == "admin" && txtboxPassword.Text == "admin123") {
                MessageBox.Show("Login successful!");
                var inventoryForm = new frmInventory();
                inventoryForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }


            frmInventory inventory = new frmInventory();
            inventory.Show();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

        }
    }
}
