using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Listas
{
    public Listas()
    { }

    public static List<Cartas> ListaCartas;

    public void agregar()
    {

        if (ListaCartas == null)
        {
            ListaCartas = new List<Cartas>();

            ListaCartas.Add(new Cartas("~/Cartas/PicaA.png", 11));
            ListaCartas.Add(new Cartas("~/Cartas/Pica2.png", 2));
            ListaCartas.Add(new Cartas("~/Cartas/Pica3.png", 3));
            ListaCartas.Add(new Cartas("~/Cartas/Pica4.png", 4));
            ListaCartas.Add(new Cartas("~/Cartas/Pica5.png", 5));
            ListaCartas.Add(new Cartas("~/Cartas/Pica6.png", 6));
            ListaCartas.Add(new Cartas("~/Cartas/Pica7.png", 7));
            ListaCartas.Add(new Cartas("~/Cartas/Pica8.png", 8));
            ListaCartas.Add(new Cartas("~/Cartas/Pica9.png", 9));
            ListaCartas.Add(new Cartas("~/Cartas/Pica10.png", 10));
            ListaCartas.Add(new Cartas("~/Cartas/PicaJ.png", 10));
            ListaCartas.Add(new Cartas("~/Cartas/PicaQ.png", 10));
            ListaCartas.Add(new Cartas("~/Cartas/PicaK.png", 10));

            ListaCartas.Add(new Cartas("~/Cartas/CorazonA.png", 11));
            ListaCartas.Add(new Cartas("~/Cartas/Corazon2.png", 2));
            ListaCartas.Add(new Cartas("~/Cartas/Corazon3.png", 3));
            ListaCartas.Add(new Cartas("~/Cartas/Corazon4.png", 4));
            ListaCartas.Add(new Cartas("~/Cartas/Corazon5.png", 5));
            ListaCartas.Add(new Cartas("~/Cartas/Corazon6.png", 6));
            ListaCartas.Add(new Cartas("~/Cartas/Corazon7.png", 7));
            ListaCartas.Add(new Cartas("~/Cartas/Corazon8.png", 8));
            ListaCartas.Add(new Cartas("~/Cartas/Corazon9.png", 9));
            ListaCartas.Add(new Cartas("~/Cartas/Corazon10.png", 10));
            ListaCartas.Add(new Cartas("~/Cartas/CorazonJ.png", 10));
            ListaCartas.Add(new Cartas("~/Cartas/CorazonQ.png", 10));
            ListaCartas.Add(new Cartas("~/Cartas/CorazonK.png", 10));

            ListaCartas.Add(new Cartas("~/Cartas/DiamanteA.png", 11));
            ListaCartas.Add(new Cartas("~/Cartas/Diamante2.png", 2));
            ListaCartas.Add(new Cartas("~/Cartas/Diamante3.png", 3));
            ListaCartas.Add(new Cartas("~/Cartas/Diamante4.png", 4));
            ListaCartas.Add(new Cartas("~/Cartas/Diamante5.png", 5));
            ListaCartas.Add(new Cartas("~/Cartas/Diamante6.png", 6));
            ListaCartas.Add(new Cartas("~/Cartas/Diamante7.png", 7));
            ListaCartas.Add(new Cartas("~/Cartas/Diamante8.png", 8));
            ListaCartas.Add(new Cartas("~/Cartas/Diamante9.png", 9));
            ListaCartas.Add(new Cartas("~/Cartas/Diamante10.png", 10));
            ListaCartas.Add(new Cartas("~/Cartas/DiamanteJ.png", 10));
            ListaCartas.Add(new Cartas("~/Cartas/DiamanteQ.png", 10));
            ListaCartas.Add(new Cartas("~/Cartas/DiamanteK.png", 10));

            ListaCartas.Add(new Cartas("~/Cartas/TrebolA.png", 11));
            ListaCartas.Add(new Cartas("~/Cartas/Trebol2.png", 2));
            ListaCartas.Add(new Cartas("~/Cartas/Trebol3.png", 3));
            ListaCartas.Add(new Cartas("~/Cartas/Trebol4.png", 4));
            ListaCartas.Add(new Cartas("~/Cartas/Trebol5.png", 5));
            ListaCartas.Add(new Cartas("~/Cartas/Trebol6.png", 6));
            ListaCartas.Add(new Cartas("~/Cartas/Trebol7.png", 7));
            ListaCartas.Add(new Cartas("~/Cartas/Trebol8.png", 8));
            ListaCartas.Add(new Cartas("~/Cartas/Trebol9.png", 9));
            ListaCartas.Add(new Cartas("~/Cartas/Trebol10.png", 10));
            ListaCartas.Add(new Cartas("~/Cartas/TrebolJ.png", 10));
            ListaCartas.Add(new Cartas("~/Cartas/TrebolQ.png", 10));
            ListaCartas.Add(new Cartas("~/Cartas/TrebolK.png", 10));
        }

    }

    public Cartas consultar(int numero)
    {
        for (int i = 0; i < ListaCartas.Count; i++)
        {
            Cartas cartas = ListaCartas[i];

            if (i == numero)
            {
                return cartas;

            }
        }
        return null;
    }

    public void eliminar(int numero)
    {
        for (int i = 0; i < ListaCartas.Count; i++)
        {
            Cartas cartas = ListaCartas[i];

            if (i == numero)
            {
                ListaCartas.Remove(cartas);

            }
        }

    }


}