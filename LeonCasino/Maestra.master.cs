using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Maestra : System.Web.UI.MasterPage
{

    Connection conexion = new Connection();



    protected void Page_Load(object sender, EventArgs e)
    {
        lblUsuario.Visible = false;
        BotonazoLogin.Visible = true;
        imgUsuario.Visible = false;
        lblBalance.Visible = false;
        BotonazoSingOut.Visible = false;

        

        if (Connection.USUARIO != "")
        {
            lblUsuario.Visible = true;
            lblUsuario.Text = Connection.USUARIO;

            
            lblBalance.Visible = true;
            lblBalance.Text = "" + Connection.BALANCE + "$";

            imgUsuario.Visible = true;

            BotonazoLogin.Visible = false;
            BotonazoSingOut.Visible = true;

            
            

        }



    }

    //protected void btnRegisterLogin_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("RegisterLogin.aspx");
    //}



}
