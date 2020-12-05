using Newtonsoft.Json;
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
    public partial class Inventory : Form
    { 
  
        public Inventory()
        {
            InitializeComponent();
        }

        private void AP_addButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProductForm add = new AddProductForm();
            add.Show();
        }

        private void Inventory_Load(object sender, EventArgs e)
        { 

            CLoadList();
            PLoadList();
        }

        private void CLoadList()
        {
            string result = CRestClient.GetAllCustomer();
            List<Customer> customer = JsonConvert.DeserializeObject<List<Customer>>(result);
            foreach (var c in customer)
            {
                C_datagrid.Rows.Add(
                c.Customerid,
                c.Customername,
                c.Itembrought,
                c.Datebrought
                );
            };
        }

        private void PLoadList()
        {
            
            string result = PRestClient.GetAllProduct();
            List<Product> product = JsonConvert.DeserializeObject<List<Product>>(result);
            foreach (var p in product)
            {
                P_datagrid.Rows.Add(
                p.Productname,
                p.Productid,
                p.Model,
                p.Brand,
                p.Attributes
                );
            };
        }

     
        private void C_deleteButton_Click(object sender, EventArgs e)
        {
            CRestClient.DeleteCustomerInfo(Convert.ToInt32(C_datagrid.CurrentRow.Cells[0].Value));
            C_datagrid.Rows.Clear();
            CLoadList();
        }

        private void C_addButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomerForm add = new AddCustomerForm();
            add.Show();
        }

        private void P_deleteButton_Click(object sender, EventArgs e)
        {
            PRestClient.DeleteProduct(Convert.ToInt32(P_datagrid.CurrentRow.Cells[1].Value));
            P_datagrid.Rows.Clear();
            PLoadList();
        }

        private void P_updateButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Product p = new Product(
            P_datagrid.CurrentRow.Cells[0].Value.ToString(),
            Convert.ToInt32(P_datagrid.CurrentRow.Cells[1].Value),
            P_datagrid.CurrentRow.Cells[2].Value.ToString(),
            P_datagrid.CurrentRow.Cells[3].Value.ToString(),
            P_datagrid.CurrentRow.Cells[4].Value.ToString()
            );

            UpdateProductForm update = new UpdateProductForm(p);
            update.Show();
        }

        private void C_updateButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Customer c = new Customer(
                Convert.ToInt32(C_datagrid.CurrentRow.Cells[0].Value),
                C_datagrid.CurrentRow.Cells[1].Value.ToString(),
                C_datagrid.CurrentRow.Cells[2].Value.ToString(),
                C_datagrid.CurrentRow.Cells[3].Value.ToString()
                );

            UpdateCustomerForm update = new UpdateCustomerForm(c);
            update.Show();
        }
    }
}
