using QLKhachSan.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLKhachSan.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        void connectionString()
        {
            con.ConnectionString = "Data Source=NHAT; database=QLKhachSan;Integrated Security=SSPI;";
        }
        [HttpPost]
        public ActionResult Verify_Account(AccountModel acc)
        {
            connectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from nguoidung where tendn= @name and matkhau =@password";
            var name = new SqlParameter("@name", acc.name);
            var password = new SqlParameter("@password", acc.password);
            cmd.Parameters.Add(name);
            cmd.Parameters.Add(password);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return RedirectToAction("DatPhong", "HomeAdmin", new { area = "Admin" });      
            }
            else
            {
                con.Close();
                return View("Login");
            }
        }
    }
}