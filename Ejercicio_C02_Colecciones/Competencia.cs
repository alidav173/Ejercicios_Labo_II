using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C02_Colecciones
{
  internal class Competencia
  {
    private short _cantidadCompetidores;
    private short _cantidadVueltas;
    private List<AutoF1> _competidores;

    public short CantidadCompetidores
    {
      get => _cantidadCompetidores;
      set => _cantidadCompetidores = value;
    }

    public short CantidadVueltas
    {
      get => _cantidadVueltas;
      set => _cantidadVueltas = value;
    }

    public List<AutoF1> Competidores
    {
      get => _competidores;
      set => _competidores = value;
    }

    private Competencia()
    {
      Competidores = new List<AutoF1>();
    }

    public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
    {
      this.CantidadVueltas = cantidadVueltas;
      this.CantidadCompetidores = cantidadCompetidores;
    }

    public string MostrarDatos()
    {
      string cadena;
      StringBuilder sb = new StringBuilder();
      sb.AppendLine($"La compentencia tiene {CantidadCompetidores} competidores  y {CantidadVueltas} vueltas");
      sb.AppendLine("\n");
      sb.AppendLine("Listado de competidores:");
        foreach (AutoF1 auto in Competidores)
        {
          sb.AppendLine(auto.MostrarDatos());
        }
      cadena = sb.ToString();
      return cadena;
    }

    public static bool operator -(Competencia c, AutoF1 a)
    {
      bool flag = false;
        c.Competidores.Remove(a);
        flag = true;
      
      return flag;
    }

    public static bool operator +(Competencia c, AutoF1 a)
    {
      bool flag = false;
      Random cantidadCombustible = new Random();
      if (c.Competidores.Count < c.CantidadCompetidores & c != a)
      {
        c.Competidores.Add(a);
        a.EnCompetencia = true;
        a.VueltasRestantes = c.CantidadVueltas;
        a.CantidadCombustible = (short)cantidadCombustible.Next(15, 100);
        flag = true;
      }
      return flag;
    }

    public static bool operator ==(Competencia c, AutoF1 a)
    {
      bool flag = false;
        foreach (AutoF1 auto in c.Competidores)
        {
          if (a == auto)
          {
            flag = true;
            break;
           
          }
        }
      
      return flag;
    }

    public static bool operator !=(Competencia c, AutoF1 a)
    {
      bool flag = true;
      foreach (AutoF1 auto in c.Competidores)
      {
        if (auto == a)
        {
          flag = false;
          break;
        }
      }
      return flag;
    }
  }
}

