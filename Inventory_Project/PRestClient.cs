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
    public static class PRestClient
    {
        public static string GetAllProduct()
        {
            var client = new RestClient("http://localhost/db_inventory/DisplayProduct.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AlwaysMultipartFormData = true;
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
        

        public static string DeleteProduct(int id)
        {
            var client = new RestClient("http://localhost/db_inventory/deleteProduct.php?");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("ProductID", id);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public static string InsertProduct(Product product)
        {
            var client = new RestClient("http://localhost/db_inventory/insertProduct.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("ProductName", product.Productname);
            request.AddParameter("Model", product.Model);
            request.AddParameter("Brand", product.Brand);
            request.AddParameter("Attributes", product.Attributes);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public static string UpdateProduct(Product product)
        {
            var client = new RestClient("http://localhost/db_inventory/UpdateProduct.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("ProductName", product.Productname);
            request.AddParameter("ProductID", product.Productid);
            request.AddParameter("Model", product.Model);
            request.AddParameter("Brand", product.Brand);
            request.AddParameter("Attributes", product.Attributes);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
