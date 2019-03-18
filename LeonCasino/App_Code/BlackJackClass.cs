using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BlackJackClass
/// </summary>
public class BlackJackClass
{
    public BlackJackClass()
    {

    }

    Random rnd = new Random();
    public int alazarUsuario1 = 0, alazarDealer1 = 0, alazarUsuario2 = 0, alazarDealer2 = 0, alazarUsuario3 = 0, alazarUsuario4 = 0, alazarDealer3 = 0, alazarDealer4 = 0;
    public int salir = 0;
    Listas listas = new Listas();
    public List<int> ListaRandom;

    public static int ValorCartaUsuario1;
    public static int ValorCartaUsuario2;
    public static int ValorCartaUsuario3;
    public static int ValorCartaUsuario4;

    public static int ValorCartaDealer1;
    public static int ValorCartaDealer2;
    public static int ValorCartaDealer3;
    public static int ValorCartaDealer4;

    public static int SumatoriaDealer;

    public static int SumatoriaUsuario;

    public static String CartaUsuario1;
    public static String CartaUsuario2;
    public static String CartaUsuario3;
    public static String CartaUsuario4;

    public static String CartaDealer1;
    public static String CartaDealer2;
    public static String CartaDealer3;
    public static String CartaDealer4;




    public void DealCards()
    {
        Listas listas = new Listas();
        ListaRandom = new List<int>();

        listas.agregar();

        salir = 0;

        while (salir == 0)
        {
            alazarUsuario1 = rnd.Next(0, 51);
            if (ListaRandom.Contains(alazarUsuario1))
            { }
            else
            {
                ListaRandom.Add(alazarUsuario1);
                Cartas cartas1 = listas.consultar(alazarUsuario1);
                salir = 1;
                CartaUsuario1 = cartas1.NAME;
                ValorCartaUsuario1 = cartas1.NUMBER;
                SumatoriaUsuario = ValorCartaUsuario1 + ValorCartaUsuario2 + ValorCartaUsuario3 + ValorCartaUsuario4;
            }
        }
        salir = 0;

        while (salir == 0)
        {
            alazarDealer1 = rnd.Next(0, 51);

            if (ListaRandom.Contains(alazarDealer1))
            { }
            else
            {
                ListaRandom.Add(alazarDealer1);
                Cartas cartas2 = listas.consultar(alazarDealer1);
                CartaDealer1 = cartas2.NAME;
                ValorCartaDealer1 = cartas2.NUMBER;
                salir = 1;

                SumatoriaDealer = ValorCartaDealer1 + ValorCartaDealer2 + ValorCartaDealer3 + ValorCartaDealer4;
            }
        }
        salir = 0;
        while (salir == 0)
        {
            alazarUsuario2 = rnd.Next(0, 51);

            if (ListaRandom.Contains(alazarUsuario2))
            {
            }
            else
            {
                ListaRandom.Add(alazarUsuario2);
                Cartas cartas3 = listas.consultar(alazarUsuario2);

                CartaUsuario2 = cartas3.NAME;
                ValorCartaUsuario2 = cartas3.NUMBER;
                salir = 1;
                if ((ValorCartaUsuario1 == 11 && ValorCartaUsuario2 == 11))
                {
                    ValorCartaUsuario1 = 1;
                }

                SumatoriaUsuario = ValorCartaUsuario1 + ValorCartaUsuario2 + ValorCartaUsuario3 + ValorCartaUsuario4;
            }
        }

        salir = 0;
        while (salir == 0)
        {
            alazarDealer2 = rnd.Next(0, 51);

            if (ListaRandom.Contains(alazarDealer2))
            { }
            else
            {
                ListaRandom.Add(alazarDealer2);

                Cartas cartas4 = listas.consultar(alazarDealer2);

                CartaDealer2 = cartas4.NAME;
                ValorCartaDealer2 = cartas4.NUMBER;
                if ((ValorCartaDealer1 == 11 && ValorCartaDealer2 == 11))
                {
                    ValorCartaDealer1 = 1;
                }

                SumatoriaDealer = ValorCartaDealer1 + ValorCartaDealer2 + ValorCartaDealer3 + ValorCartaDealer4;
                salir = 1;
            }
        }


    }

    public void Pedir1()
    {
        Listas listas = new Listas();
        ListaRandom = new List<int>();

        salir = 0;
        while (salir == 0)
        {
            alazarUsuario3 = rnd.Next(0, 51);

            if (ListaRandom.Contains(alazarUsuario3))
            { }
            else
            {
                ListaRandom.Add(alazarUsuario3);
                Cartas cartas5 = listas.consultar(alazarUsuario3);
                CartaUsuario3 = cartas5.NAME;
                ValorCartaUsuario3 = cartas5.NUMBER;

                SumatoriaUsuario = ValorCartaUsuario1 + ValorCartaUsuario2 + ValorCartaUsuario3 + ValorCartaUsuario4;
                salir = 1;


            }
        }

        if (SumatoriaUsuario > 21)
        {
            if (ValorCartaUsuario1 == 11)
            {
                ValorCartaUsuario1 = 1;
            }
            else
            {
                if (ValorCartaUsuario2 == 11)
                {
                    ValorCartaUsuario2 = 1;
                }
                else
                {
                    if (ValorCartaUsuario3 == 11)
                    {
                        ValorCartaUsuario3 = 1;
                    }
                }
            }
            SumatoriaUsuario = ValorCartaUsuario1 + ValorCartaUsuario2 + ValorCartaUsuario3 + ValorCartaUsuario4;
        }

    }

    public void Pedir2()
    {

        Listas listas = new Listas();
        ListaRandom = new List<int>();


        if (SumatoriaUsuario < 21)
        {
            salir = 0;
            while (salir == 0)
            {
                alazarUsuario4 = rnd.Next(0, 51);

                if (ListaRandom.Contains(alazarUsuario4))
                { }
                else
                {
                    ListaRandom.Add(alazarUsuario4);
                    Cartas cartas6 = listas.consultar(alazarUsuario4);
                    CartaUsuario4 = cartas6.NAME;
                    ValorCartaUsuario4 = cartas6.NUMBER;

                    SumatoriaUsuario = ValorCartaUsuario1 + ValorCartaUsuario2 + ValorCartaUsuario3 + ValorCartaUsuario4;

                    salir = 1;


                }
            }

            if (SumatoriaUsuario > 21)
            {
                if (ValorCartaUsuario1 == 11)
                {
                    ValorCartaUsuario1 = 1;
                }
                else
                {
                    if (ValorCartaUsuario2 == 11)
                    {
                        ValorCartaUsuario2 = 1;
                    }
                    else
                    {
                        if (ValorCartaUsuario3 == 11)
                        {
                            ValorCartaUsuario3 = 1;
                        }
                        else
                        {
                            if (ValorCartaUsuario4 == 11)
                            {
                                ValorCartaUsuario4 = 1;
                            }
                        }
                    }
                }
                SumatoriaUsuario = ValorCartaUsuario1 + ValorCartaUsuario2 + ValorCartaUsuario3 + ValorCartaUsuario4;

            }
        }



    }

    public void JugadaDealer()
    {

        Listas listas = new Listas();
        ListaRandom = new List<int>();

        if (SumatoriaDealer < 17)
        {
            salir = 0;
            while (salir == 0)
            {
                alazarDealer3 = rnd.Next(0, 51);

                if (ListaRandom.Contains(alazarDealer3))
                { }
                else
                {
                    ListaRandom.Add(alazarDealer3);

                    Cartas cartas7 = listas.consultar(alazarDealer3);

                    CartaDealer3 = cartas7.NAME;
                    ValorCartaDealer3 = cartas7.NUMBER;
                    salir = 1;
                    SumatoriaDealer = ValorCartaDealer1 + ValorCartaDealer2 + ValorCartaDealer3 + ValorCartaDealer4;

                }
            }
        }

        if (SumatoriaDealer > 21)
        {
            if (ValorCartaDealer1 == 11)
            {
                ValorCartaDealer1 = 1;
            }
            else
            {
                if (ValorCartaDealer2 == 11)
                {
                    ValorCartaDealer2 = 1;
                }
                else
                {
                    if (ValorCartaDealer3 == 11)
                    {
                        ValorCartaDealer3 = 1;
                    }
                }
            }
            SumatoriaDealer = ValorCartaDealer1 + ValorCartaDealer2 + ValorCartaDealer3 + ValorCartaDealer4;

        }

        if (SumatoriaDealer < 17)
        {
            salir = 0;
            while (salir == 0)
            {
                alazarDealer4 = rnd.Next(0, 51);

                if (ListaRandom.Contains(alazarDealer4))
                { }
                else
                {
                    ListaRandom.Add(alazarDealer4);

                    Cartas cartas8 = listas.consultar(alazarDealer4);

                    CartaDealer4 = cartas8.NAME;
                    ValorCartaDealer4 = cartas8.NUMBER;

                    salir = 1;
                    SumatoriaDealer = ValorCartaDealer1 + ValorCartaDealer2 + ValorCartaDealer3 + ValorCartaDealer4;

                }
            }
        }

        if (SumatoriaDealer > 21)
        {
            if (ValorCartaDealer1 == 11)
            {
                ValorCartaDealer1 = 1;
            }
            else
            {
                if (ValorCartaDealer2 == 11)
                {
                    ValorCartaDealer2 = 1;
                }
                else
                {
                    if (ValorCartaDealer3 == 11)
                    {
                        ValorCartaDealer3 = 1;
                    }
                    else
                    {
                        if (ValorCartaDealer4 == 11)
                        {
                            ValorCartaDealer4 = 1;
                        }
                    }
                }
            }
            SumatoriaDealer = ValorCartaDealer1 + ValorCartaDealer2 + ValorCartaDealer3 + ValorCartaDealer4;

        }
    }
}
