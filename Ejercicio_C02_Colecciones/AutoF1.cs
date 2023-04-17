using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C02_Colecciones
{
  internal class AutoF1
  {
    private short _cantidadCombustible;
    private bool _enCompetencia;
    private string _escuderia;
    private short _numero;
    private short _vueltasRestantes;

    public short CantidadCombustible
    {
      get => _cantidadCombustible;
      set => _cantidadCombustible = value;
    }

    public bool EnCompetencia
    {
      get => _enCompetencia;
      set => _enCompetencia = value;
    }

    public string Escuderia
    {
      get => _escuderia;
      set => _escuderia = value;
    }

    public short Numero
    {
      get => _numero;
      set => _numero = value;
    }

    public short VueltasRestantes
    {
      get => _vueltasRestantes;
      set => _vueltasRestantes = value;
    }


    public AutoF1(short numero, string escuderia) 
    {
      if (escuderia != null)
      {
        Escuderia = escuderia;
      }
      this.Numero = numero;
      CantidadCombustible = 0;
      VueltasRestantes = 0;
      EnCompetencia = false;
    }

    public string MostrarDatos()
    {
      string cadena;
      StringBuilder sb = new StringBuilder();
      sb.AppendLine($"Numero: {Numero}");
      sb.AppendLine($"Escuderia: {Escuderia}");
      sb.AppendLine($"Cantidad de Combustible: {CantidadCombustible}");
      sb.AppendLine($"Vueltas restantes: {VueltasRestantes}");
      sb.AppendLine($"Esta en competencia: {EnCompetencia}");
      cadena = sb.ToString();

      return cadena;
    }
    public static bool operator ==(AutoF1 auto1, AutoF1 auto2)
    {
      return auto1.Numero == auto2.Numero & auto1.Escuderia == auto2.Escuderia;
    }
    public static bool operator !=(AutoF1 auto1, AutoF1 auto2)
    {
      return !(auto1 == auto2);
    }
  }
}
