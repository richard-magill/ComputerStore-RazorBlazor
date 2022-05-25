using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Web;
using MagillStore.WebSite.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MagillStore.WebSite.Services
{
    public class DatabaseService
    {

        public SQLiteConnection myConnection;
        public DatabaseService()
        {

            myConnection = new SQLiteConnection("Data Source = store.db");
            if (!File.Exists("./store.db"))
            {
                SQLiteConnection.CreateFile("store.db");
            }
        }


        public void OpenConnection()
        {
            if (myConnection.State !=  System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if(myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }

        //public void AddProductCategory()
        //{
        //    Database dbObject = new Database();
        //    string query = "Insert into ProductCategory ('ProductCategoryName', 'ImageUrl') Values( @productCategoryName, @imageUrl)";
        //    SQLiteCommand myCommand = new SQLiteCommand(query, dbObject.myConnection);
        //    dbObject.OpenConnection();
        //    myCommand.Parameters.AddWithValue("@productCategoryName", "Desktop");
        //    myCommand.Parameters.AddWithValue("@imageUrl", "images/Desktop.PNG");
        //    myCommand.ExecuteNonQuery();
        //    dbObject.CloseConnection();
        //}

        //will redo this to get a List<ProductCategory>
        public List<ProductCategory> GetProductCategoryList()
        {
            DatabaseService dbObject = new DatabaseService();
            string query = "Select * from ProductCategory";
            SQLiteCommand myCommand = new SQLiteCommand(query, dbObject.myConnection);
            dbObject.OpenConnection();
            SQLiteDataReader result = myCommand.ExecuteReader();
            List<ProductCategory> productCategoryList = new List<ProductCategory>();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    //fill in the ProductCategory object
                    ProductCategory productCategory = new ProductCategory();
                    productCategory.ProductCategoryId = result.GetInt32(0);
                    productCategory.ProductCategoryName = result.GetString(1);
                    productCategory.ImageUrl = result.GetString(2);
                    productCategory.Page = result.GetString(3);
                    productCategoryList.Add(productCategory);
                }
            }
            dbObject.CloseConnection();
            return productCategoryList;
        }

        public List<Product> GetProductList()
        {
            DatabaseService dbObject = new DatabaseService();
            string query = "Select * from Product";
            SQLiteCommand myCommand = new SQLiteCommand(query, dbObject.myConnection);
            dbObject.OpenConnection();
            List<Product> productList = new List<Product>();
            try
            {
                SQLiteDataReader result = myCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        //fill in the Product object
                        Product product = new Product();
                        product.Name = result.GetString(0);
                        product.Description = result.GetString(1);
                        product.Brand = result.GetString(2);
                        product.Price = result.GetInt32(3);
                        product.Type = result.GetString(4);
                        productList.Add(product);
                    }
                }
            }
            catch(Exception ex)
            {
                //this is a nice catch, it doesn't do anything except writes exception details to the output.              
                Debug.WriteLine(ex);
                Console.WriteLine(ex);
            }
            finally
            {
                //Also,closes the connection with the finally statement
                dbObject.CloseConnection();
            }
            return productList;
        }

    }
}
