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
            string query = String.Format("insert into Products values ('{0}','{1}','{2}','{3}')",  p.Name,  p.Quantity,p.Price,p.Description);
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

                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                    Price= (float)reader.GetDouble(reader.GetOrdinal("Price")),
                    Description = reader.GetString(reader.GetOrdinal("Description"))

                };
                products.Add(s);
            }

            conn.Close();
            return products;
        }
        public Product Get(int id)
        {
            conn.Open();
            string query = String.Format("Select * from  Products where Id={0}", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Product s = null;
            while (reader.Read())
            {
                s = new Product()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),                   
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                    Price = (float)reader.GetDouble(reader.GetOrdinal("Price")),
                    Description = reader.GetString(reader.GetOrdinal("Description"))
                };
            }
            conn.Close();
            return s;
        }
        public int Update(Product p)
        {
            conn.Open();
            string query = String.Format("update Products set Name='{0}', Quantity={1}, Price={2}, Description='{3}' where Id={4}", p.Name, p.Quantity, p.Price, p.Description, p.Id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return r;
        }
        public int Delete(int id)
        {
            conn.Open();
            string query = String.Format("Delete from Products where Id={0}", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return r;
        }


    }
}