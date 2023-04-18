using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01_Herencia.Biblioteca
{
  internal class Equipo
  {
    private short _cantidadDeJugadores;
    private List<Jugador> _jugadores;
    private string _nombre;

    public short CantidadDeJugadores
    {
      get => _cantidadDeJugadores;
      set => _cantidadDeJugadores = value >= 0 ? value : (short)0;
    }

    public List<Jugador> Jugadores
    {
      get => _jugadores;
      set => _jugadores = value;
    }

    public string Nombre
    {
      get => _nombre;
      set => _nombre = value != null ? value : "";
    }

    private Equipo()
    {
      Jugadores = new List<Jugador>();
    }

    public Equipo(short cantidad, string nombre) : this()
    {
      if (nombre != null)
      {
        this.Nombre = nombre;
      }
      this.CantidadDeJugadores = cantidad;

    }

    public static bool operator +(Equipo e, Jugador j)
    {
      bool flag = false;
      bool flag2 = false;
      int cantidadJugadores = (int)e.CantidadDeJugadores;
      if (e.Jugadores != null)
      {
        foreach (Jugador jug in e.Jugadores)
        {
          if (j == jug)
          {
            flag = true;
          }
        }
        if (flag == false & e.Jugadores.Count < cantidadJugadores)
        {
          e.Jugadores.Add(j);
          flag2 = true;
        }
      }
      return flag2;
    }

   /* public void MostrarJugadores()
    {
      Console.WriteLine($"La nomina del equipo {Nombre}: \n");
      foreach (Jugador jug in Jugadores)
      {
        Console.WriteLine(jug.Mostrar());
      }
      Console.WriteLine("****************************************");
    }*/


  }
}
