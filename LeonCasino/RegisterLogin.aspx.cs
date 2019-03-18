using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _RegisterLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Connection.USUARIO = "";
    }

    Connection conexion1 = new Connection();

    protected void btnCreateAccount_Click(object sender, EventArgs e)
    {

        if (txtRegisterName.Text != "" && txtRegisterLastName.Text != "" && txtRegisterEmail.Text != "" && txtRegisterUser.Text != "" && txtRegisterPassword.Text != "")
        {
            if (checkboxmas18.Checked && checkboxTerms.Checked)
            {

                conexion1.IngresarUSUARIO(20000,txtRegisterPassword.Text,txtRegisterName.Text,txtRegisterLastName.Text,txtRegisterUser.Text,txtRegisterEmail.Text);

                btnCreateAccount.Text = "Done";

                txtRegisterEmail.Text = "";
                txtRegisterLastName.Text = "";
                txtRegisterName.Text = "";
                txtRegisterPassword.Text = "";
                txtRegisterUser.Text = "";

            }
        }
        else
        {
            
        }

    }

    
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if(txtLoginUser.Text != "" && txtLoginPassword.Text != "")
        {
            String sql;
            SqlCommand com;
            SqlDataReader rs;

            conexion1.AbrirKey();

           // Connection.conexion.Close();
           // Connection.conexion.Open();
            sql =   "select " +
                    "CONVERT(int, DecryptByKey(saldo))" + 
                    ",nombre_usuario " +
                    "from usuario " +
                    "WHERE nombre_usuario = '" + txtLoginUser.Text + "'" +
                    "AND (CONVERT(varchar, DecryptByKey(clave)) = '" + txtLoginPassword.Text + "')";

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
                //Connection.conexion.Close();

                Response.Redirect("Default.aspx");



            }
            else
            {
                rs.Close();
                conexion1.CerrarKey();
                //Connection.conexion.Close();
            }
        }else
        {

        }

        
        



    }

}