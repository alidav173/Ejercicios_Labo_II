using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01_Colecciones
{
  internal class Jugador
  {
    private int _dni;
    private string _nombre;
    private int _partidosJugados;
    private float _promedioGoles;
    private int _totalGoles;

    public int Dni
    {
      get => _dni;
      set => _dni = value;
    }

    public string Nombre
    { get => _nombre;
      set => _nombre = value;
    }

    public int PartidosJugados
    {
      get => _partidosJugados;
      set => _partidosJugados = value;
    }

    public float PromedioGoles
    {
      get =>  GetPromedioGoles(TotalGoles,PartidosJugados);
      set => _promedioGoles = value;
    }

    public int TotalGoles
    {
      get => _totalGoles;
      set => _totalGoles = value;
    }


    private Jugador()
    {
      PartidosJugados = 0;
      TotalGoles = 0;
      PromedioGoles = 0;
    }

    public Jugador(int dni, string nombre) : this()
    {
      if (Validador.ValidarCadena(nombre))
      {
        this.Nombre = nombre;
      }
      this.Dni = dni;
    }

    public Jugador(int dni, string nombre, int cantidadGoles, int totalPartidos)
    {
      Jugador jugador = new Jugador(dni, nombre);
      TotalGoles = cantidadGoles;
      PartidosJugados = totalPartidos;

    }

    private float GetPromedioGoles(int totalGoles, int partidosJugados)
    {
      float promedio = 0;
      if (partidosJugados != 0) {
        promedio = (float) totalGoles / partidosJugados;
      }

      return promedio;
    }

    public string MostrarJugador()
    {
      string cadena;
      StringBuilder sb = new StringBuilder();
      sb.AppendLine($"Nombre: {Nombre}");
      sb.AppendLine($"DNI: {Dni}");
      sb.AppendLine($"Total partidos: {PartidosJugados}");
      sb.AppendLine($"Total de goles: {TotalGoles}");
      sb.AppendLine($"Promedio: {PromedioGoles} goles por partido");
      cadena = sb.ToString();
      return cadena;
    }

    public static bool operator ==(Jugador j1, Jugador j2)
      {
      return j1.Dni == j2.Dni;
      }

    public static bool operator !=(Jugador j1, Jugador j2)
    {
      return !(j1 == j2);
    }


  }

 
}

