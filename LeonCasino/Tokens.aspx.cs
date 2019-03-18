using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class Tokens : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Connection.USUARIO == "")
        {
            Response.Redirect("Default.aspx");
        }
    }

    Connection conexion1 = new Connection();

    public void Actualizacion(string usuario)
    {
        String sql;
        SqlCommand com;
        SqlDataReader rs;

        conexion1.AbrirKey();

        //Connection.conexion.Close();
        //Connection.conexion.Open();
        sql = "select " +
              " CONVERT(int, DecryptByKey(saldo))" +
              ",nombre_usuario " +
              " from usuario " +
              " WHERE nombre_usuario = '" + usuario + "';";

        com = Connection.conexion.CreateCommand();
        com.CommandText = sql;
        rs = com.ExecuteReader(); //solo para comando select

        if (rs.Read())
        {
            Session["balance"] = rs[0];
            Session["usuario"] = rs[1];

            Connection.BALANCE = Convert.ToInt32(rs[0].ToString());
            Connection.USUARIO = rs[1].ToString();

            rs.Close();
            conexion1.CerrarKey();

            //  conexion1.UpdateBalance(Connection.BALANCE, Connection.USUARIO);
        }
        else
        {
            rs.Close();
            conexion1.CerrarKey();
            //Connection.conexion.Close();
        }
    }

    protected void imgBtnTokens_Click(object sender, EventArgs e)
    {
        String sql;
        SqlCommand com;
        SqlDataReader rs;

        Connection.conexion.Close();
        Connection.conexion.Open();
        sql = "Select * from dinero_gratis WHERE usuario_nombre_usuario = '" + Connection.USUARIO + "' AND fecha  = cast (getdate() as date)";
        com = Connection.conexion.CreateCommand();
        com.CommandText = sql;
        rs = com.ExecuteReader(); //solo para comando select

        if (rs.Read())
        {

            Connection.conexion.Close();
            lblAnuncio.Text = "You alredy have added your free daily Tokens, comeback tomorrow";

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You alredy have added your free daily Tokens, comeback tomorrow');", true);
        }
        else
        {

            conexion1.IngresarDineroGratis(Connection.USUARIO);

            Connection.conexion.Close();
            Connection.BALANCE += 5000;

            conexion1.UpdateBalance(Connection.BALANCE, Connection.USUARIO);

            Actualizacion(Connection.USUARIO);

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Go and play with this +5000, Good Luck');", true);

        }

    }

}