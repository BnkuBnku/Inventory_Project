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
    public partial class UpdateCustomerForm : Form
    {
        private Customer customer;

        public UpdateCustomerForm()
        {
            InitializeComponent();
        }

        public UpdateCustomerForm(Customer customer) : this()
        {
            this.customer = customer;
        }

        private void UCI_updateButton_Click(object sender, EventArgs e)
        {
            Customer c = new Customer(
               Convert.ToInt32(lbl_customerid.Text),
               tb_CN.Text,
               tb_Date.Text,
               tb_IB.Text
                );



            if (CRestClient.UpdateCustomer(c).Equals("success"))
            {
                MessageBox.Show("Customer is sucessfully updated.");
            }

            this.Hide();
            Inventory list = new Inventory();
            list.Closed += (s, args) => this.Close();
            list.Show();
        }

        private void UCI_cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory cancel = new Inventory();
            cancel.Show();
        }

        private void UCI_deleteButton_Click(object sender, EventArgs e)
        {
            tb_CN.Clear();
            tb_IB.Clear();
            tb_Date.Clear();
            tb_CN.Focus();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            lbl_customerid.Text = Convert.ToString(customer.Customerid);
            tb_CN.Text = customer.Customername;
            tb_IB.Text = customer.Itembrought;
            tb_Date.Text = customer.Datebrought;
        }
    }
}
