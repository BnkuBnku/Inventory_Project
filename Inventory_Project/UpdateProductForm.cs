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
    public partial class UpdateProductForm : Form
    {
        private Product product;

        public UpdateProductForm()
        {
            InitializeComponent();
        }

        public UpdateProductForm(Product product) : this()
        {
            this.product = product;
        }

        private void UP_clearButton_Click(object sender, EventArgs e)
        {
            tb_PN.Clear();
            tb_M.Clear();
            tb_B.Clear();
            tb_AT.Clear();
            tb_PN.Focus();
        }

        private void UP_updateButton_Click(object sender, EventArgs e)
        {
            Product p = new Product(
                tb_PN.Text,
                Convert.ToInt32(lbl_productid.Text),
                tb_M.Text,
                tb_B.Text,
                tb_AT.Text
                );

            

            if (PRestClient.UpdateProduct(p).Equals("success"))
            {
                MessageBox.Show("Product is sucessfully updated.");
            }

            this.Hide();
            Inventory list = new Inventory();
            list.Show();
        }

        private void UP_cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory cancel = new Inventory();
            cancel.Show();
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            tb_PN.Text = product.Productname;
            lbl_productid.Text = Convert.ToString(product.Productid);
            tb_M.Text = product.Model;
            tb_B.Text = product.Brand;
            tb_AT.Text = product.Attributes;
        }
    }
}
