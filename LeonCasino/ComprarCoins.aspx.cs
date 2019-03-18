using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class ComprarCoins : System.Web.UI.Page
{

    SqlConnection conexion = new SqlConnection("Server=tcp:servercasinoleon.database.windows.net,1433;" +
        "Initial Catalog=CasinoLeon;Persist Security Info=False;" +
        "User ID=Jeod22;Password=Alphabravo01;" +
        "MultipleActiveResultSets=False;" +
        "Encrypt=True;" +
        "TrustServerCertificate=False;" +
        "Connection Timeout=30;");



    //SqlConnection conexion = new SqlConnection("data source=servercasinoleon.database.windows.net;" +
    //    "initial catalog = CasinoLeon; user id= Jeod22; password= Alphabravo01;"); //catalog= bd_demo

   // Maestra maestrita = new Maestra();

    protected void Page_Load(object sender, EventArgs e)
    {
        lblMensaje.Text = "Aqui se conecta a la base de datos creada en AZURE y deberia devolver Raul Leon";

    }

    Estaticas estatica = new Estaticas();
    
    

    protected void btnTest_Click(object sender, EventArgs e)
    {
        String sql;
        SqlCommand com;
        SqlDataReader rs;

        conexion.Open();
        sql = "SELECT *  FROM prueba";
        com = conexion.CreateCommand();
        com.CommandText = sql;
        rs = com.ExecuteReader(); //solo para comando select


        if (rs.Read())
        {

            Session["nom"] = rs[0];
            Session["ap"] = rs[1];
            lblTest.Text = "Nombre: " + rs[0].ToString() + " Apellido: " + rs[1].ToString();


    

            
        }
        else
        {
            lblTest.Text = "Mamo";
        }


        conexion.Close();

       
    }
}