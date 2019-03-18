using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PrincipalCasino2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnPerfil_Click(object sender, EventArgs e)
    {
        Response.Redirect("ComprarCoins.aspx");
    }

    protected void btnJugar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Cuenta.aspx");
    }

    protected void btnHistorial_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.asxp");
    }

    protected void btnReglas_Click(object sender, EventArgs e)
    {
      //  Response.Redirect("Default.asxp");
    }

    protected void btnTutorial_Click(object sender, EventArgs e)
    {
       // Response.Redirect("Default.asxp");
    }

    protected void btnOtraCosa_Click(object sender, EventArgs e)
    {
       // Response.Redirect("Default.asxp");
    }

}