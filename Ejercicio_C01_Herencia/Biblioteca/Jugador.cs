using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01_Herencia.Biblioteca
{
  internal class Jugador : Persona
  {
    private int _partidosJugados;
    private float _promedioGoles;
    private int _totalGoles;


    public int PartidosJugados
    {
      get => _partidosJugados;
      set => _partidosJugados = value;
    }

    public float PromedioGoles
    {
      get => GetPromedioGoles(TotalGoles, PartidosJugados);
      set => _promedioGoles = value;
    }

    public int TotalGoles
    {
      get => _totalGoles;
      set => _totalGoles = value;
    }


    public Jugador(int dni, string nombre) :base(dni, nombre)
    {

    }

    public Jugador(int dni, string nombre, int cantidadGoles, int totalPartidos): this(dni, nombre)
    {
      TotalGoles = cantidadGoles;
      PartidosJugados = totalPartidos;

    }

    private float GetPromedioGoles(int totalGoles, int partidosJugados)
    {
      float promedio = 0;
      if (partidosJugados != 0)
      {
        promedio = (float)totalGoles / partidosJugados;
      }

      return promedio;
    }

    public override string Mostrar()
    {
      string cadena;
      StringBuilder sb = new StringBuilder();
      sb.Append(base.Mostrar());
      sb.Append($" Total partidos: {PartidosJugados}");
      sb.Append($" Total de goles: {TotalGoles}");
      sb.Append($" Promedio: {PromedioGoles} goles por partido.");
      return cadena = sb.ToString();
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
