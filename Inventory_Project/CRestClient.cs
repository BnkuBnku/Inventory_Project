using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Inventory_Project
{
    public static class CRestClient
    {
        public static string GetAllCustomer()
        {
            var client = new RestClient("http://localhost/db_inventory/DisplayCustomerInfo.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AlwaysMultipartFormData = true;
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public static string DeleteCustomerInfo(int id)
        {
            var client = new RestClient("http://localhost/db_inventory/deleteCustomerInfo.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("CustomerID", id);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
        public static string InsertCustomerInfo(Customer customer)
        {
            var client = new RestClient("http://localhost/db_inventory/insertCustomerInfo.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("CustomerName", customer.Customername);
            request.AddParameter("ItemBrought", customer.Itembrought);
            request.AddParameter("DateBrought", customer.Datebrought);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public static string UpdateCustomer(Customer customer)
        {
            var client = new RestClient("http://localhost/db_inventory/UpdateCustomer.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("CustomerID", customer.Customerid);
            request.AddParameter("CustomerName", customer.Customername);
            request.AddParameter("ItemBrought", customer.Itembrought);
            request.AddParameter("DateBrought", customer.Datebrought);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
