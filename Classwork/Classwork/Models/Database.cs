using Classwork.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Classwork.Models
{
    public class Database
    {
        SqlConnection conn;

        
        public Products Products{ get; set; }
       
        public Database()
        {
            string connString = @"Data Source=DESKTOP-SGI1TQE;Initial Catalog=connectdb;Persist Security Info=True;User ID=sa;Password=P@ssword";
            conn = new SqlConnection(connString);       
            Products = new Products(conn);
            

        }
    }
}