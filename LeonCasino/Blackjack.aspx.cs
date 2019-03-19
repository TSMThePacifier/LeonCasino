using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Blackjack : System.Web.UI.Page
{
    Connection conexion1 = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Connection.USUARIO == "")
        {
            Response.Redirect("Default.aspx");
        }
        imgCarta1Dealer.Visible = false;
        imgCarta2Dealer.Visible = false;
        imgCarta3Dealer.Visible = false;
        imgCarta4Dealer.Visible = false;
        imgCarta5Dealer.Visible = false;
        imgCarta1Usuario.Visible = false;
        imgCarta2Usuario.Visible = false;
        imgCarta3Usuario.Visible = false;
        imgCarta4Usuario.Visible = false;
        imgCarta5Usuario.Visible = false;
        BtnDelear.Visible = false;
        btnPEDIRSINI.Visible = false;
        btnQuedarse.Visible = false;
        btnDouble.Visible = false;
        btnVolverAJugar.Visible = false;
        lblName.Text = "User: " + Connection.USUARIO + ".";
        lblMonto.Text = "Amount: " + Connection.BALANCE.ToString() + ".";
        imgProfile.Visible = true;


    }

    Random rnd = new Random();
    public static int pedir = 0, dealerPedir = 0;
    public static int salir = 0;
    public static Double ApuestaBlackjack = 0, CuantoDineros = 0;
    Listas listas = new Listas();
    public static List<int> ListaRandom;

    BlackJackClass blackJack = new BlackJackClass();

    public int codiguito()
    {
        int CodigoPa = 0;
        String sql;
        SqlCommand com;
        SqlDataReader rs;

        Connection.conexion.Close();
        Connection.conexion.Open();
        sql = "select MAX(codigo) FROM historial;";
        com = Connection.conexion.CreateCommand();
        com.CommandText = sql;
        rs = com.ExecuteReader(); //solo para comando select

        if (rs.Read())
        {
            Session["codigo"] = rs[0];


            CodigoPa = Convert.ToInt32(rs[0].ToString());
            Connection.conexion.Close();

            CodigoPa += 1;

            return CodigoPa;



        }
        else
        {
            Connection.conexion.Close();
            return CodigoPa;
        }
    }

    public void Actualizacion(string usuario)
    {
        String sql;
        SqlCommand com;
        SqlDataReader rs;

        //conexion1.AbrirKey();

        Connection.conexion.Close();
        Connection.conexion.Open();
        sql = "select " +
              " saldo" +
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
            Connection.conexion.Close();
            //conexion1.CerrarKey();

            //  conexion1.UpdateBalance(Connection.BALANCE, Connection.USUARIO);
        }
        else
        {
            rs.Close();
            Connection.conexion.Close();
            //conexion1.CerrarKey();
            //Connection.conexion.Close();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        imgBtnApostar10.Visible = false;
        imgBtnApostar50.Visible = false;
        imgBtnApostar100.Visible = false;
        imgBtnApostar500.Visible = false;
        imgBtnApostar1000.Visible = false;

        blackJack.DealCards();



        BtnDelear.Visible = false;

        imgCarta1Usuario.Visible = true;
        imgCarta1Usuario.ImageUrl = BlackJackClass.CartaUsuario1;

        imgCarta1Dealer.Visible = true;
        imgCarta1Dealer.ImageUrl = BlackJackClass.CartaDealer1;

        imgCarta2Usuario.Visible = true;
        imgCarta2Usuario.ImageUrl = BlackJackClass.CartaUsuario2;


        imgCarta2Dealer.Visible = true;
        imgCarta2Dealer.ImageUrl = "~/Cartas/CartaVolteada.png";
        lblAgregar.Text = BlackJackClass.CartaDealer2;


        btnQuedarse.Visible = true;
        btnPEDIRSINI.Visible = true;
        btnDouble.Visible = true;
        lbLINFO.Text = " Total usuario: " + BlackJackClass.SumatoriaUsuario.ToString();

        if (BlackJackClass.SumatoriaUsuario == 21)
        {
            btnDouble.Visible = false;
            imgCarta2Dealer.ImageUrl = BlackJackClass.CartaDealer2;
            blackJack.JugadaDealer();

            imgCarta3Dealer.Visible = true;
            imgCarta3Dealer.ImageUrl = BlackJackClass.CartaDealer3;

            imgCarta4Dealer.Visible = true;
            imgCarta4Dealer.ImageUrl = BlackJackClass.CartaDealer4;

            lbLINFO.Text = "total dealer: " + BlackJackClass.SumatoriaDealer.ToString() + " total usuario: " + BlackJackClass.SumatoriaUsuario.ToString();


            if ((BlackJackClass.SumatoriaDealer < BlackJackClass.SumatoriaUsuario && BlackJackClass.SumatoriaUsuario <= 21) || BlackJackClass.SumatoriaDealer > 21 && BlackJackClass.SumatoriaUsuario < 22)
            {
                lbLINFO.Text = "Total dealer: " + BlackJackClass.SumatoriaDealer.ToString() + " total usuario: " + BlackJackClass.SumatoriaUsuario.ToString() + ". ¡¡¡ HAS GANADO " + (ApuestaBlackjack * 2.5).ToString();

                conexion1.IngresarHistorial(codiguito(), BlackJackClass.SumatoriaUsuario, BlackJackClass.SumatoriaDealer,
                    ApuestaBlackjack, "GANADOR", (ApuestaBlackjack * 2.5), Connection.USUARIO);

                Connection.BALANCE += (ApuestaBlackjack * 2.5);

                conexion1.UpdateBalance(Connection.BALANCE, Connection.USUARIO);

                Actualizacion(Connection.USUARIO);

                btnQuedarse.Visible = false;
                btnPEDIRSINI.Visible = false;
                btnVolverAJugar.Visible = true;

                UsuarioCasino usuario = new UsuarioCasino();
                // usuario.SumarDinero(UsuarioCasino.User, (ApuestaBlackjack * 2.5));

            }
            else
            {
                lbLINFO.Text = "Total dealer: " + BlackJackClass.SumatoriaDealer.ToString() + " total usuario: " + BlackJackClass.SumatoriaUsuario.ToString() + ". La casa gana :(";

                conexion1.IngresarHistorial(codiguito(), BlackJackClass.SumatoriaUsuario, BlackJackClass.SumatoriaDealer,
    ApuestaBlackjack, "PERDEDOR", (ApuestaBlackjack * 0), Connection.USUARIO);

                btnQuedarse.Visible = false;
                btnPEDIRSINI.Visible = false;
                btnVolverAJugar.Visible = true;
            }
            if (BlackJackClass.SumatoriaDealer == BlackJackClass.SumatoriaUsuario)
            {
                lbLINFO.Text = "Total dealer: " + BlackJackClass.SumatoriaDealer.ToString() + " total usuario: " + BlackJackClass.SumatoriaUsuario.ToString() + ". Empate.";

                conexion1.IngresarHistorial(codiguito(), BlackJackClass.SumatoriaUsuario, BlackJackClass.SumatoriaDealer,
    ApuestaBlackjack, "EMPATE", (ApuestaBlackjack * 1), Connection.USUARIO);

                Connection.BALANCE += (ApuestaBlackjack * 1);

                conexion1.UpdateBalance(Connection.BALANCE, Connection.USUARIO);

                Actualizacion(Connection.USUARIO);

                btnQuedarse.Visible = false;
                btnPEDIRSINI.Visible = false;
                btnVolverAJugar.Visible = true;

                UsuarioCasino usuario = new UsuarioCasino();
                // usuario.SumarDinero(UsuarioCasino.User, (ApuestaBlackjack));

            }
        }



    }


    protected void btnPEDIRSINI_Click(object sender, EventArgs e)
    {
        BtnDelear.Visible = false;
        btnDouble.Visible = false;
        imgCarta1Dealer.Visible = true;
        imgCarta2Dealer.Visible = true;
        imgCarta1Usuario.Visible = true;
        imgCarta2Usuario.Visible = true;
        imgCarta4Usuario.Visible = true;
        imgCarta3Usuario.Visible = true;
        btnPEDIRSINI.Visible = true;
        btnQuedarse.Visible = true;



        if (pedir == 0)
        {
            blackJack.Pedir1();

            imgCarta3Usuario.Visible = true;
            imgCarta3Usuario.ImageUrl = BlackJackClass.CartaUsuario3;


            lbLINFO.Text = " Total usuario: " + BlackJackClass.SumatoriaUsuario.ToString();


            if (BlackJackClass.SumatoriaUsuario > 21)
            {

                btnQuedarse.Visible = false;
                btnPEDIRSINI.Visible = false;
                btnVolverAJugar.Visible = true;
                lbLINFO.Text = "Total usuario: " + BlackJackClass.SumatoriaUsuario.ToString() + ". La casa gana :(";

                conexion1.IngresarHistorial(codiguito(), BlackJackClass.SumatoriaUsuario, BlackJackClass.SumatoriaDealer,
    ApuestaBlackjack, "PERDEDOR", (ApuestaBlackjack * 0), Connection.USUARIO);
            }
        }


        if (pedir == 1)
        {
            blackJack.Pedir2();

            imgCarta4Usuario.Visible = true;
            imgCarta4Usuario.ImageUrl = BlackJackClass.CartaUsuario4;

            pedir = 2;
            lbLINFO.Text = "Total usuario: " + BlackJackClass.SumatoriaUsuario.ToString();



            if (BlackJackClass.SumatoriaUsuario > 21)
            {

                btnQuedarse.Visible = false;
                btnPEDIRSINI.Visible = false;
                btnVolverAJugar.Visible = true;
                lbLINFO.Text = "Total dealer: " + BlackJackClass.SumatoriaDealer.ToString() + " total usuario: " + BlackJackClass.SumatoriaUsuario.ToString() + ". La casa gana :(";

                conexion1.IngresarHistorial(codiguito(), BlackJackClass.SumatoriaUsuario, BlackJackClass.SumatoriaDealer,
ApuestaBlackjack, "PERDEDOR", (ApuestaBlackjack * 0), Connection.USUARIO);
            }

        }

        pedir = 1;

    }


    protected void Button1_Click1(object sender, EventArgs e)
    {
        btnVolverAJugar.Visible = true;
        imgCarta1Dealer.Visible = true;
        imgCarta2Dealer.Visible = true;
        imgCarta3Dealer.Visible = true;
        imgCarta1Usuario.Visible = true;
        imgCarta2Usuario.Visible = true;
        imgCarta3Usuario.Visible = true;
        imgCarta4Usuario.Visible = true;
        BtnDelear.Visible = false;
        btnPEDIRSINI.Visible = true;
        btnQuedarse.Visible = true;
        btnDouble.Visible = false;

        lbLINFO.Text = "Total usuario: " + BlackJackClass.SumatoriaUsuario.ToString();
        imgCarta2Dealer.ImageUrl = BlackJackClass.CartaDealer2;

        blackJack.JugadaDealer();

        imgCarta3Dealer.Visible = true;
        imgCarta3Dealer.ImageUrl = BlackJackClass.CartaDealer3;

        imgCarta4Dealer.Visible = true;
        imgCarta4Dealer.ImageUrl = BlackJackClass.CartaDealer4;

        lbLINFO.Text = "total dealer: " + BlackJackClass.SumatoriaDealer.ToString() + " total usuario: " + BlackJackClass.SumatoriaUsuario.ToString();


        if ((BlackJackClass.SumatoriaDealer < BlackJackClass.SumatoriaUsuario && BlackJackClass.SumatoriaUsuario <= 21) || BlackJackClass.SumatoriaDealer > 21 && BlackJackClass.SumatoriaUsuario < 22)
        {
            lbLINFO.Text = "Total dealer: " + BlackJackClass.SumatoriaDealer.ToString() + " total usuario: " + BlackJackClass.SumatoriaUsuario.ToString() + ". ¡¡¡ HAS GANADO " + (ApuestaBlackjack * 2).ToString();

            conexion1.IngresarHistorial(codiguito(), BlackJackClass.SumatoriaUsuario, BlackJackClass.SumatoriaDealer,
ApuestaBlackjack, "GANADOR", (ApuestaBlackjack * 2), Connection.USUARIO);

            Connection.BALANCE += (ApuestaBlackjack * 2);

            conexion1.UpdateBalance(Connection.BALANCE, Connection.USUARIO);

            Actualizacion(Connection.USUARIO);

            btnQuedarse.Visible = false;
            btnPEDIRSINI.Visible = false;
            btnVolverAJugar.Visible = true;

            UsuarioCasino usuario = new UsuarioCasino();
            //usuario.SumarDinero(UsuarioCasino.User, (ApuestaBlackjack * 2));

        }
        else
        {
            lbLINFO.Text = "Total dealer: " + BlackJackClass.SumatoriaDealer.ToString() + " total usuario: " + BlackJackClass.SumatoriaUsuario.ToString() + ". La casa gana :(";

            conexion1.IngresarHistorial(codiguito(), BlackJackClass.SumatoriaUsuario, BlackJackClass.SumatoriaDealer,
ApuestaBlackjack, "PERDEDOR", (ApuestaBlackjack * 0), Connection.USUARIO);

            btnQuedarse.Visible = false;
            btnPEDIRSINI.Visible = false;
            btnVolverAJugar.Visible = true;
        }
        if (BlackJackClass.SumatoriaDealer == BlackJackClass.SumatoriaUsuario)
        {
            lbLINFO.Text = "Total dealer: " + BlackJackClass.SumatoriaDealer.ToString() + " total usuario: " + BlackJackClass.SumatoriaUsuario.ToString() + ". Empate.";

            conexion1.IngresarHistorial(codiguito(), BlackJackClass.SumatoriaUsuario, BlackJackClass.SumatoriaDealer,
ApuestaBlackjack, "EMPATE", (ApuestaBlackjack * 1), Connection.USUARIO);

            Connection.BALANCE += (ApuestaBlackjack * 1);

            conexion1.UpdateBalance(Connection.BALANCE, Connection.USUARIO);

            Actualizacion(Connection.USUARIO);

            btnQuedarse.Visible = false;
            btnPEDIRSINI.Visible = false;
            btnVolverAJugar.Visible = true;

            UsuarioCasino usuario = new UsuarioCasino();
            // usuario.SumarDinero(UsuarioCasino.User, (ApuestaBlackjack));

        }
    }

    protected void btnVolverAJugar_Click(object sender, EventArgs e)
    {
        BlackJackClass.CartaDealer1 = "";
        BlackJackClass.CartaDealer2 = "";
        BlackJackClass.CartaDealer3 = "";
        BlackJackClass.CartaDealer4 = "";

        BlackJackClass.CartaUsuario1 = "";
        BlackJackClass.CartaUsuario2 = "";
        BlackJackClass.CartaUsuario3 = "";
        BlackJackClass.CartaUsuario4 = "";

        BlackJackClass.SumatoriaDealer = 0;
        BlackJackClass.SumatoriaUsuario = 0;

        BlackJackClass.ValorCartaDealer1 = 0;
        BlackJackClass.ValorCartaDealer2 = 0;
        BlackJackClass.ValorCartaDealer3 = 0;
        BlackJackClass.ValorCartaDealer4 = 0;

        BlackJackClass.ValorCartaUsuario1 = 0;
        BlackJackClass.ValorCartaUsuario2 = 0;
        BlackJackClass.ValorCartaUsuario3 = 0;
        BlackJackClass.ValorCartaUsuario4 = 0;
        pedir = 0;
        ApuestaBlackjack = 0;
        Response.Redirect("Blackjack.aspx");

    }

    protected void btnDouble_Click(object sender, EventArgs e)
    {
        btnQuedarse.Visible = false;
        BtnDelear.Visible = false;
        btnDouble.Visible = false;
        btnPEDIRSINI.Visible = false;
        btnVolverAJugar.Visible = true;
        imgCarta1Dealer.Visible = true;
        imgCarta2Dealer.Visible = true;
        imgCarta3Dealer.Visible = true;
        imgCarta4Dealer.Visible = true;
        imgCarta1Usuario.Visible = true;
        imgCarta2Usuario.Visible = true;
        imgCarta3Usuario.Visible = true;
        imgCarta4Usuario.Visible = true;

        UsuarioCasino usuario = new UsuarioCasino();
        // usuario.RestarDinero(UsuarioCasino.User, (ApuestaBlackjack))

        Connection.BALANCE -= ApuestaBlackjack;

        conexion1.UpdateBalance(Connection.BALANCE, Connection.USUARIO);

        Actualizacion(Connection.USUARIO); ;

        ApuestaBlackjack = ApuestaBlackjack * 2;
        lblApuesta.Text = "Te Doblaste, Apuesta del Usuario: " + ApuestaBlackjack.ToString();

        blackJack.Pedir1();

        imgCarta3Usuario.Visible = true;
        imgCarta3Usuario.ImageUrl = BlackJackClass.CartaUsuario3;

        imgCarta2Dealer.ImageUrl = BlackJackClass.CartaDealer2;

        blackJack.JugadaDealer();

        lbLINFO.Text = "Total usuario: " + BlackJackClass.SumatoriaUsuario.ToString();


        if (BlackJackClass.SumatoriaUsuario > 21)
        {

            btnQuedarse.Visible = false;
            btnPEDIRSINI.Visible = false;
            btnVolverAJugar.Visible = true;
            lbLINFO.Text = "Total dealer: " + BlackJackClass.SumatoriaDealer.ToString() + " total usuario: " + BlackJackClass.SumatoriaUsuario.ToString() + ". La casa gana :(";

            conexion1.IngresarHistorial(codiguito(), BlackJackClass.SumatoriaUsuario, BlackJackClass.SumatoriaDealer,
ApuestaBlackjack, "PERDEDOR", (ApuestaBlackjack * 0), Connection.USUARIO);

        }

        blackJack.JugadaDealer();

        imgCarta3Dealer.Visible = true;
        imgCarta3Dealer.ImageUrl = BlackJackClass.CartaDealer3;

        imgCarta4Dealer.Visible = true;
        imgCarta4Dealer.ImageUrl = BlackJackClass.CartaDealer4;

        lbLINFO.Text = "total dealer: " + BlackJackClass.SumatoriaDealer.ToString() + " total usuario: " + BlackJackClass.SumatoriaUsuario.ToString();


        if ((BlackJackClass.SumatoriaDealer < BlackJackClass.SumatoriaUsuario && BlackJackClass.SumatoriaUsuario <= 21) || BlackJackClass.SumatoriaDealer > 21 && BlackJackClass.SumatoriaUsuario < 22)
        {
            lbLINFO.Text = "Total dealer: " + BlackJackClass.SumatoriaDealer.ToString() + " total usuario: " + BlackJackClass.SumatoriaUsuario.ToString() + ". ¡¡¡ HAS GANADO " + (ApuestaBlackjack * 2).ToString();

            conexion1.IngresarHistorial(codiguito(), BlackJackClass.SumatoriaUsuario, BlackJackClass.SumatoriaDealer,
ApuestaBlackjack, "GANADOR", (ApuestaBlackjack * 2), Connection.USUARIO);
            btnQuedarse.Visible = false;
            btnPEDIRSINI.Visible = false;
            btnVolverAJugar.Visible = true;

            Connection.BALANCE += (ApuestaBlackjack * 2);

            conexion1.UpdateBalance(Connection.BALANCE, Connection.USUARIO);

            Actualizacion(Connection.USUARIO);

            //  usuario.SumarDinero(UsuarioCasino.User, (ApuestaBlackjack * 2));

        }
        else
        {
            lbLINFO.Text = "Total dealer: " + BlackJackClass.SumatoriaDealer.ToString() + " total usuario: " + BlackJackClass.SumatoriaUsuario.ToString() + ". La casa gana :(";

            conexion1.IngresarHistorial(codiguito(), BlackJackClass.SumatoriaUsuario, BlackJackClass.SumatoriaDealer,
ApuestaBlackjack, "PERDEDOR", (ApuestaBlackjack * 0), Connection.USUARIO);

            btnQuedarse.Visible = false;
            btnPEDIRSINI.Visible = false;
            btnVolverAJugar.Visible = true;
        }
        if (BlackJackClass.SumatoriaDealer == BlackJackClass.SumatoriaUsuario)
        {
            lbLINFO.Text = "Total dealer: " + BlackJackClass.SumatoriaDealer.ToString() + " total usuario: " + BlackJackClass.SumatoriaUsuario.ToString() + ". Empate.";

            conexion1.IngresarHistorial(codiguito(), BlackJackClass.SumatoriaUsuario, BlackJackClass.SumatoriaDealer,
ApuestaBlackjack, "EMPATE", (ApuestaBlackjack * 1), Connection.USUARIO);

            Connection.BALANCE += (ApuestaBlackjack * 1);

            conexion1.UpdateBalance(Connection.BALANCE, Connection.USUARIO);

            Actualizacion(Connection.USUARIO);

            btnQuedarse.Visible = false;
            btnPEDIRSINI.Visible = false;
            btnVolverAJugar.Visible = true;

            // usuario.SumarDinero(UsuarioCasino.User, (ApuestaBlackjack));

        }
    }


    protected void imgBtnApostar10_Click(object sender, ImageClickEventArgs e)
    {
        UsuarioCasino usuario = new UsuarioCasino();

        //  CuantoDineros = usuario.CuantoDinero(UsuarioCasino.User);

        ApuestaBlackjack = ApuestaBlackjack + 10;

        if (Connection.BALANCE >= 10)
        {
            Connection.BALANCE -= 10;

            conexion1.UpdateBalance(Connection.BALANCE, Connection.USUARIO);

            Actualizacion(Connection.USUARIO);
            lblApuesta.Text = "Apuesta del Usuario: " + ApuestaBlackjack.ToString();
            BtnDelear.Visible = true;
        }
        else
        {
            ApuestaBlackjack = ApuestaBlackjack - 10;
        }

        if (ApuestaBlackjack > 0)
        {
            BtnDelear.Visible = true;
        }

    }

    protected void imgBtnApostar50_Click(object sender, ImageClickEventArgs e)
    {
        UsuarioCasino usuario = new UsuarioCasino();

        ApuestaBlackjack = ApuestaBlackjack + 50;

        if (Connection.BALANCE >= 50)
        {
            Connection.BALANCE -= 50;

            conexion1.UpdateBalance(Connection.BALANCE, Connection.USUARIO);

            Actualizacion(Connection.USUARIO);
            lblApuesta.Text = "Apuesta del Usuario: " + ApuestaBlackjack.ToString();
            BtnDelear.Visible = true;
        }
        else
        {
            ApuestaBlackjack = ApuestaBlackjack - 50;
        }

        if (ApuestaBlackjack > 0)
        {
            BtnDelear.Visible = true;
        }
    }

    protected void imgBtnApostar100_Click(object sender, ImageClickEventArgs e)
    {
        UsuarioCasino usuario = new UsuarioCasino();

        ApuestaBlackjack = ApuestaBlackjack + 100;

        if (Connection.BALANCE >= 100)
        {
            Connection.BALANCE -= 100;

            conexion1.UpdateBalance(Connection.BALANCE, Connection.USUARIO);

            Actualizacion(Connection.USUARIO);
            lblApuesta.Text = "Apuesta del Usuario: " + ApuestaBlackjack.ToString();
            BtnDelear.Visible = true;
        }
        else
        {
            ApuestaBlackjack = ApuestaBlackjack - 100;
        }

        if (ApuestaBlackjack > 0)
        {
            BtnDelear.Visible = true;
        }
    }

    protected void imgBtnApostar500_Click(object sender, ImageClickEventArgs e)
    {
        UsuarioCasino usuario = new UsuarioCasino();

        ApuestaBlackjack = ApuestaBlackjack + 500;

        if (Connection.BALANCE >= 500)
        {
            Connection.BALANCE -= 500;

            conexion1.UpdateBalance(Connection.BALANCE, Connection.USUARIO);

            Actualizacion(Connection.USUARIO);
            lblApuesta.Text = "Apuesta del Usuario: " + ApuestaBlackjack.ToString();
            BtnDelear.Visible = true;
        }
        else
        {
            ApuestaBlackjack = ApuestaBlackjack - 500;
        }

        if (ApuestaBlackjack > 0)
        {
            BtnDelear.Visible = true;
        }

    }

    protected void imgBtnApostar1000_Click(object sender, ImageClickEventArgs e)
    {
        UsuarioCasino usuario = new UsuarioCasino();

        ApuestaBlackjack = ApuestaBlackjack + 1000;

        if (Connection.BALANCE >= 1000)
        {
            Connection.BALANCE -= 1000;

            conexion1.UpdateBalance(Connection.BALANCE, Connection.USUARIO);

            Actualizacion(Connection.USUARIO);
            lblApuesta.Text = "Apuesta del Usuario: " + ApuestaBlackjack.ToString();
            BtnDelear.Visible = true;
        }
        else
        {
            ApuestaBlackjack = ApuestaBlackjack - 1000;
        }

        if (ApuestaBlackjack > 0)
        {
            BtnDelear.Visible = true;
        }
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        BlackJackClass.CartaDealer1 = "";
        BlackJackClass.CartaDealer2 = "";
        BlackJackClass.CartaDealer3 = "";
        BlackJackClass.CartaDealer4 = "";

        BlackJackClass.CartaUsuario1 = "";
        BlackJackClass.CartaUsuario2 = "";
        BlackJackClass.CartaUsuario3 = "";
        BlackJackClass.CartaUsuario4 = "";

        BlackJackClass.SumatoriaDealer = 0;
        BlackJackClass.SumatoriaUsuario = 0;

        BlackJackClass.ValorCartaDealer1 = 0;
        BlackJackClass.ValorCartaDealer2 = 0;
        BlackJackClass.ValorCartaDealer3 = 0;
        BlackJackClass.ValorCartaDealer4 = 0;

        BlackJackClass.ValorCartaUsuario1 = 0;
        BlackJackClass.ValorCartaUsuario2 = 0;
        BlackJackClass.ValorCartaUsuario3 = 0;
        BlackJackClass.ValorCartaUsuario4 = 0;
        pedir = 0;
        ApuestaBlackjack = 0;
        Response.Redirect("Default.aspx");
    }
}



