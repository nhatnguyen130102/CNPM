using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QLKhachSan.Models
{
    public class DbConnection
    {
        string conn;
        public DbConnection()
        {
            conn = ConfigurationManager.ConnectionStrings["DbQLKS"].ConnectionString;
        }
        public SqlConnection getConnection()
        {
            return new SqlConnection(conn);
        }
    }
}