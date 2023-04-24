using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C02_Herencia.Biblioteca
{
  internal class Competencia
  {
    private short _cantidadCompetidores;
    private short _cantidadVueltas;
    private List<VehiculoDeCarrera> _competidores;
    private Tipo.TipoCompetencia _tipoCompetencia;

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

    public List<VehiculoDeCarrera> Competidores
    {
      get => _competidores;
      set => _competidores = value;
    }
    public Tipo.TipoCompetencia TipoCompetencia { get => _tipoCompetencia; set => _tipoCompetencia = value; }

    private Competencia()
    {
      Competidores = new List<VehiculoDeCarrera>();
    }

    public Competencia(short cantidadVueltas, short cantidadCompetidores, Tipo.TipoCompetencia tipo) : this()
    {
      this.CantidadVueltas = cantidadVueltas;
      this.CantidadCompetidores = cantidadCompetidores;
      this.TipoCompetencia = tipo;
    }

    public string MostrarDatos()
    {
      string cadena;
      StringBuilder sb = new StringBuilder();
      sb.AppendLine($"La compentencia es del tipo {TipoCompetencia}, tiene {CantidadCompetidores} competidores  y {CantidadVueltas} vueltas");
      sb.AppendLine("\n");
      sb.AppendLine("Listado de competidores:");
      foreach (VehiculoDeCarrera vehiculo in Competidores)
      {
        sb.AppendLine(vehiculo.MostrarDatos());
      }
      cadena = sb.ToString();
      return cadena;
    }

    public static bool operator -(Competencia c, VehiculoDeCarrera a)
    {
      bool flag = false;
      c.Competidores.Remove(a);
      flag = true;

      return flag;
    }

    public static bool operator +(Competencia c, VehiculoDeCarrera a)
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

    public static bool operator ==(Competencia c, VehiculoDeCarrera a)
    {
      bool flag = false;
      foreach (VehiculoDeCarrera auto in c.Competidores)
      {
        if (a == auto)
        {
          flag = true;
          break;

        }
      }

      return flag;
    }

    public static bool operator !=(Competencia c, VehiculoDeCarrera a)
    {
      bool flag = true;
      foreach (VehiculoDeCarrera auto in c.Competidores)
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
