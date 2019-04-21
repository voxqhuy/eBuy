using Dapper;
using eBuy.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace eBuy.Utils
{
    public static class DbUtils
    {
        private static SqlConnection OpenConnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["eBuy"].ToString();
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            return con;
        }

        public static List<ProductType> GetCategories()
        {
            using (IDbConnection db = OpenConnection())
            {
                return db.Query<ProductType>
                ("SELECT * FROM ProductType").ToList();
            }
        }
        
        public static List<Product> GetAllProducts()
        {
            using (IDbConnection db = OpenConnection())
            {
                return db.Query<Product>
                ("SELECT * FROM Product").ToList();
            }
        }

        public static List<Product> SearchBy(string text, string categoryId)
        {
            var sqlStatement = "SELECT * FROM Product WHERE product_name LIKE '%" + text + "%'";
            if (categoryId != "")
            {
                sqlStatement += "AND product_type_id=" + categoryId;
            }
            using (IDbConnection db = OpenConnection())
            {
                return db.Query<Product>
                    (sqlStatement).ToList();
            }
        }
    }
}