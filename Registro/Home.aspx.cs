using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registro
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WSDB.WebServiceBDSoapClient WS = new WSDB.WebServiceBDSoapClient();
            DataSet ds = WS.GetData();
            GridView.DataSource = ds.Tables[0];
            GridView.DataBind();
        }
    }
}