using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login_MVC_.Models;
using System.Data.SqlClient;
using Login_MVC_.Controllers;
namespace Login_MVC_.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Account
        [HttpGet]
        public ActionResult Registro()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "Data Source=DESKTOP-U30MH31; Initial Catalog=Registro; Integrated Security=True;";


        }
        [HttpPost]
        public ActionResult Verify(Account acc)

        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT* FROM Usuarios Where Usuario='" + acc.Nombre + " 'and Contraseña='" + acc.Contraseña + "'";
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                con.Close();
                return View("Create");
            }
            else {
                con.Close();
                return View("Error");
            }
           
        }
        // GET: Account/Details/5


    }

    }