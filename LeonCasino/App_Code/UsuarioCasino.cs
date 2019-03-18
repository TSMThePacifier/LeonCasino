using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UsuarioCasino
/// </summary>
public class UsuarioCasino
{

    public static String User;
    public static Double Monto;
    private String userName, email, password, firstName,
                  lastName, day, month, year, gender, country, mobile;
    private Double dineros;

    public static List<UsuarioCasino> ListaUsuario;

    public UsuarioCasino(String userName, String email, String password, String firstName,
       String lastName, String day, String month, String year, String gender, String country, String mobile, Double dineros)
    {
        this.UserName = userName; this.Email = email; this.Password = password;
        this.FirstName = firstName; this.LastName = lastName; this.Day = day; this.Month = month; this.Year = year;
        this.Gender = gender; this.Country = country; this.Mobile = mobile; this.Dineros = dineros;

    }

    public UsuarioCasino() { }

    public string UserName { get { return userName; } set { userName = value; } }
    public string Email { get { return email; } set { email = value; } }
    public string Password { get { return password; } set { password = value; } }
    public string FirstName { get { return firstName; } set { firstName = value; } }
    public string LastName { get { return lastName; } set { lastName = value; } }
    public string Day { get { return day; } set { day = value; } }
    public string Month { get { return month; } set { month = value; } }
    public string Year { get { return year; } set { year = value; } }
    public string Gender { get { return gender; } set { gender = value; } }
    public string Country { get { return country; } set { country = value; } }
    public string Mobile { get { return mobile; } set { mobile = value; } }
    public Double Dineros { get { return dineros; } set { dineros = value; } }

    public void AgregarUsuario(String userName, String email, String password, String firstName,
       String lastName, String day, String month, String year, String gender, String country, String mobile, Double dineros)
    {
        UsuarioCasino usuario = new UsuarioCasino(userName, email, password, firstName,
        lastName, day, month, year, gender, country, mobile, dineros);

        if (ListaUsuario == null)
        {
            ListaUsuario = new List<UsuarioCasino>();
            ListaUsuario.Add(usuario);
        }
        else { ListaUsuario.Add(usuario); }
    }

    public UsuarioCasino ConsultarUsuario(String nombre)
    {
        if (ListaUsuario == null)
        {
            return null;
        }
        for (int i = 0; i < ListaUsuario.Count; i++)
        {
            UsuarioCasino usuario = ListaUsuario[i];
            if (usuario.UserName.Equals(nombre))
            {
                return usuario;
            }
        }
        return null;
    }

    public void ModificarContra(String nombreUsuario, String password)
    {
        for (int i = 0; i < ListaUsuario.Count; i++)
        {
            UsuarioCasino usuario = ListaUsuario[i];
            if (usuario.UserName.Equals(nombreUsuario))
            {
                usuario.Password = password;
            }
        }
    }


    public void AgregarDinero(String nombreUsuario, Double dineros)
    {
        for (int i = 0; i < ListaUsuario.Count; i++)
        {
            UsuarioCasino usuario = ListaUsuario[i];
            if (usuario.UserName.Equals(nombreUsuario))
            {
                usuario.Dineros += dineros;
                Monto = usuario.Dineros;
            }
        }
    }

    public void RestarDinero(String nombreUsuario, Double dineros)
    {
        for (int i = 0; i < ListaUsuario.Count; i++)
        {
            UsuarioCasino usuario = ListaUsuario[i];
            if (usuario.UserName.Equals(nombreUsuario))
            {
                if (usuario.Dineros > dineros)
                {
                    usuario.Dineros -= dineros;
                    Monto = usuario.Dineros;
                }
            }
        }
    }

    public void SumarDinero(String nombreUsuario, Double dineros)
    {
        for (int i = 0; i < ListaUsuario.Count; i++)
        {
            UsuarioCasino usuario = ListaUsuario[i];
            if (usuario.UserName.Equals(nombreUsuario))
            {
                usuario.Dineros += dineros;
                Monto = usuario.Dineros;
            }
        }
    }

    public Double CuantoDinero(String nombreUsuario)
    {
        for (int i = 0; i < ListaUsuario.Count; i++)
        {
            UsuarioCasino usuario = ListaUsuario[i];
            if (usuario.UserName.Equals(nombreUsuario))
            {
                return usuario.dineros;
            }
        }
        return 0;
    }
    public String CambiarNombre(String nombre, String nuevoNombre)
    {
        for (int i = 0; i < ListaUsuario.Count; i++)
        {
            UsuarioCasino usuario = ListaUsuario[i];
            if (usuario.UserName.Equals(nombre))
            {
                usuario.userName = nuevoNombre;
                User = usuario.userName;

            }
        }
        return null;
    }

    public void eliminarusuario(String nombre)
    {
        for (int i = 0; i < ListaUsuario.Count; i++)
        {
            UsuarioCasino usuario = ListaUsuario[i];
            if (usuario.UserName.Equals(nombre))
            {
                ListaUsuario.Remove(usuario);
                User = "";
            }
        }
    }


}