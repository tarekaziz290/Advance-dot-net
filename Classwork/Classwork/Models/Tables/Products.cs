using Classwork.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Classwork.Models.Tables
{
    public class Products
    {
        SqlConnection conn;
        public Products(SqlConnection conn)
        {
            this.conn = conn;
        }

        public void Create(Product p)
        {

            conn.Open();
            string query = String.Format("insert into Products values ('{0}','{1}','{2}','{3}','{4}')", p.Name, p.Id, p.Quantity,p.Price,p.Description);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Product> Get()
        {
            conn.Open();
            string query = "select * from  Products";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product s = new Product()
                {

                    
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Id = reader.GetString(reader.GetOrdinal("Id")),
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                    Price= (float)reader.GetDouble(reader.GetOrdinal("Price")),
                    Description = reader.GetString(reader.GetOrdinal("Description"))

                };
                products.Add(s);
            }

            conn.Close();
            return products;
        }
        public Product Get(string name)
        {
            conn.Open();
            string query = String.Format("Select * from  Products where Name={0}", name);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Product s = null;
            while (reader.Read())
            {
                s = new Product()
                {
                    
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Id = reader.GetString(reader.GetOrdinal("Id")),
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                    Price = (float)reader.GetDouble(reader.GetOrdinal("Price")),
                    Description = reader.GetString(reader.GetOrdinal("Description"))
                };
            }
            conn.Close();
            return s;
        }

    }
}