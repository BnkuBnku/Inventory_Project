using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Project
{
    public class Product
    {
        private string productname;
        private int productid;
        private string model, brand, attributes;

        public Product(string productname, int productid, string model, string brand, string attributes)
        {
            this.Productname = productname;
            this.Productid = productid;
            this.Model = model;
            this.Brand = brand;
            this.Attributes = attributes;
        }

        public string Productname { get => productname; set => productname = value; }
        public int Productid { get => productid; set => productid = value; }
        public string Model { get => model; set => model = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Attributes { get => attributes; set => attributes = value; }
    }
}
