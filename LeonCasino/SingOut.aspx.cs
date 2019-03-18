using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SingOut : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Connection.USUARIO = "";
        Connection.BALANCE = 0;
        Response.Redirect("Default.aspx");

    }

    Connection conexion = new Connection();
}