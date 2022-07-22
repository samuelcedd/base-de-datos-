using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace SISTEMAS_INTEGRADOS
{
    /// <summary>
    /// Descripción breve de WebServiceBD
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceBD : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public DataSet Wslistado()
         {
        SqlConnection conn = new  SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-U30MH31; Initial Catalog=Registro; Integrated Security=True;";
            SqlDataAdapter da  = new SqlDataAdapter("SELECT * FROM Usuarios;",conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        [WebMethod]
        public DataSet Wsbuscar(string usuario, string contraseña)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-U30MH31; Initial Catalog=Registro; Integrated Security=True;";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Usuarios;", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

    }

}
