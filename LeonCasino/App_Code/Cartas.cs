using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>

public class Cartas
{


    public Cartas(String name, int number)
    {
        this.NAME = name;
        this.NUMBER = number;

    }

    private String name;
    private int number;


    public string NAME
    {
        get { return name; }
        set { name = value; }
    }
    public int NUMBER
    {
        get { return number; }
        set { number = value; }
    }
}