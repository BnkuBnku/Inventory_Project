using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Project
{
    public partial class AddProductForm : Form
    {
        
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AP_clearButton_Click(object sender, EventArgs e)
        {
            tb_PN.Clear();
            tb_M.Clear();
            tb_B.Clear();
            tb_AT.Clear();
            tb_PN.Focus();
        }

        private void AP_addButton_Click(object sender, EventArgs e)
        {
            Product p = new Product(
                tb_PN.Text,
                -1,
                tb_M.Text,
                tb_B.Text,
                tb_AT.Text);

            string response = PRestClient.InsertProduct(p);

            if (response.Equals("success"))
            {
                MessageBox.Show("Product is sucessfully added.");
            }

            this.Hide();
            Inventory list = new Inventory();
            list.Show();
        }

        private void AP_cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory cancel = new Inventory();
            cancel.Show();
        }
    }
}
