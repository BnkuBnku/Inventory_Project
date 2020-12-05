using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Project
{
    public class Customer
    {
        private int customerid;
        private string customername, itembrought, datebrought;

        public Customer(int customerid, string customername, string itembrought, string datebrought)
        {
            this.Customerid = customerid;
            this.Customername = customername;
            this.Itembrought = itembrought;
            this.Datebrought = datebrought;
        }

        public int Customerid { get => customerid; set => customerid = value; }
        public string Customername { get => customername; set => customername = value; }
        public string Itembrought { get => itembrought; set => itembrought = value; }
        public string Datebrought { get => datebrought; set => datebrought = value; }
    }
}
