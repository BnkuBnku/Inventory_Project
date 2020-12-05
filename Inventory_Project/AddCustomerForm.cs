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
    public partial class AddCustomerForm : Form
    {
       
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void ACI_addButton_Click(object sender, EventArgs e)
        {
            Customer c = new Customer(
                -1,
                tb_CN.Text,
                tb_IB.Text,
                tb_Date.Text);

            string response = CRestClient.InsertCustomerInfo(c);

            if (response.Equals("success"))
            {
                MessageBox.Show("Customer is sucessfully added.");
            }

            this.Hide();
            Inventory list = new Inventory();
            list.Show();
        }

        private void ACI_cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory cancel = new Inventory();
            cancel.Show();
        }

        private void ACI_deleteButton_Click(object sender, EventArgs e)
        {
            tb_CN.Clear();
            tb_IB.Clear();
            tb_Date.Clear();
            tb_CN.Focus();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
