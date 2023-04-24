using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C02_Herencia.Biblioteca
{
  internal class AutoF1: VehiculoDeCarrera
  {
    private short _caballosDeFuerza;

    public short CaballosDeFuerza { get => _caballosDeFuerza; set => _caballosDeFuerza = value; }

    public AutoF1(short numero, string escuderia) : base(numero, escuderia)
    {

    }

    public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
    {
      CaballosDeFuerza = caballosDeFuerza;
    }

    public override string MostrarDatos()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(base.MostrarDatos());
      sb.Append($" Caballos de fuerza: {CaballosDeFuerza}");
      return sb.ToString();
    }

    public static bool operator ==(AutoF1 auto1, AutoF1 auto2)
    {
      return auto1.Numero == auto2.Numero & auto1.Escuderia == auto2.Escuderia & auto1.CaballosDeFuerza == auto2.CaballosDeFuerza;
    }
    public static bool operator !=(AutoF1 auto1, AutoF1 auto2)
    {
      return !(auto1 == auto2);
    }

  }
}
