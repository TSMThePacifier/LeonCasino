using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Connection
/// </summary>
public class Connection
{

    public static double BALANCE;
    public static string USUARIO ="";

    public static SqlConnection conexion = new SqlConnection("Server=tcp:casinocloud.database.windows.net,1433;Initial Catalog=DBCasinoCloud;Persist Security Info=False;" +
                                                             "User ID=CloudLogin;Password=Aguacate01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"); //catalog= bd_demo


    public Connection()
    {
        
        
    }



    public void conectar()
    {
        

    }

    public void AbrirKey()
    {
        String sql;
        SqlCommand com;

        conexion.Close();
        conexion.Open();
        sql = "OPEN SYMMETRIC KEY SymmetricKey1 DECRYPTION BY CERTIFICATE Certificate1;";
        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.ExecuteNonQuery();

        //conexion.Close();

    }

    public void CerrarKey()
    {
        String sql;
        SqlCommand com;

      //  conexion.Close();
       // conexion.Open();
        sql = "CLOSE SYMMETRIC KEY SymmetricKey1;";
        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.ExecuteNonQuery();

        conexion.Close();

    }

    public void IngresarUSUARIO(int balance, string password, string name, string lastname, string usuario, string email)
    {
        String sql;
        SqlCommand com;

        //conexion.Close();
        conexion.Open();

        //AbrirKey();

        sql = "INSERT INTO usuario VALUES( " +
            " '" + usuario + "', " +
            " '" + password + "' , " +
            " " + balance + ", " +
            " '" + name + "', " +
            " '" + lastname + "'," +
            " '" + email + "');";
        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.ExecuteNonQuery();

        //CerrarKey();

        conexion.Close();
    }

    public void IngresarHistorial(int codigo, int cartas_usuario, int cartas_casino, double apuesta, string resultado, double ganancia, string usuario)
    {
        String sql;
        SqlCommand com;

        conexion.Close();
        conexion.Open();
        sql = "INSERT INTO historial VALUES( " + cartas_usuario + "," + cartas_casino + ",'" + apuesta + "', '" + resultado + "', '" + ganancia + "', '" + usuario + "', getdate());";
        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.ExecuteNonQuery();

        conexion.Close();
    }

    public void UpdateBalance (double balance, string usuario)
    {
        String sql;
        SqlCommand com;

        conexion.Close();
        conexion.Open();
        //AbrirKey();

        sql = "UPDATE usuario SET saldo = " + balance + "  WHERE nombre_usuario = '" + usuario + "';";
        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.ExecuteNonQuery();

        //CerrarKey();
        conexion.Close();
    }

    public void IngresarDineroGratis(string usuario)
    {
        String sql;
        SqlCommand com;

        conexion.Close();
        conexion.Open();
        sql = "INSERT INTO dinero_gratis VALUES( getdate(), '" + usuario + "');";
        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.ExecuteNonQuery();

        conexion.Close();
    }

    public void AgregarTokens(string user)
    {
        String sql;
        SqlCommand com;

        conexion.Open();
        sql = "INSERT INTO Coin VALUES( '" + user + "', cast(GETDATE() as date));";
        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.ExecuteNonQuery();

        conexion.Close();

    }

    public void SumaTokens( int tokens)
    {
        BALANCE = BALANCE + tokens;
        String sql;
        SqlCommand com;

        conexion.Open();
        sql = "UPDATE usuario SET BALANCE = " + BALANCE + " WHERE usuario = '" + USUARIO + "';";
        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.ExecuteNonQuery();

        

        conexion.Close();
    }

    


}