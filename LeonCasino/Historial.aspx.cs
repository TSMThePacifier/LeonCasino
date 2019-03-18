using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Historial : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    Connection conexion1 = new Connection();

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        BuscarHistorial();
        //GridView1.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";

    }

    public void BuscarHistorial() //Busca a los asistentes registrados en la base de datos a partir de caracteres en su nombre o apellido
    {
        //string str = " SELECT cedula, nombre, apellido, telefono, estado_civil FROM asistente WHERE (nombre LIKE '%' + @buscar + '%') OR (apellido LIKE '%' + @buscar + '%') OR (estado_civil LIKE '%' + @buscar + '%')";

        string str = "SELECT usuario_nombre_usuario AS 'Nombre de Usuario', cartas_usuario AS 'Cartas Usuario', cartas_casino AS 'Cartas Casino',apuesta AS 'Apuesta', " +
            "resultado AS 'Resultado', ganancia AS 'Ganancia', Convert(varchar(20),fecha,101) as 'Fecha' " +
            "FROM historial " +
            "WHERE usuario_nombre_usuario = '"+ Connection.USUARIO +"';";

        Connection.conexion.Close();

        SqlCommand comando = new SqlCommand(str, Connection.conexion);

        Connection.conexion.Open();
        comando.ExecuteNonQuery();

        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = comando;

        DataSet ds = new DataSet();

        da.Fill(ds, "nombre");
        GridView1.DataSource = ds;
        GridView1.DataBind();

        Connection.conexion.Close();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)//Cuando el usuario selecciona un asistente, le asigna el valor a las variables para poder registrarlo
    {

        // lblRetornar.Text = "Cedula: " + GridView1.SelectedRow.Cells[1].Text;
        // lblNombre.Text = "Nombre: " + GridView1.SelectedRow.Cells[2].Text;
        // lblApellido.Text = " " + GridView1.SelectedRow.Cells[3].Text;



    }

    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)//Intento fallido del metodo anterior
    {
        // txtSeleccion.Text = GridView1.SelectedRow.ToString();
    }
}