using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C02_Herencia.Biblioteca
{
  internal class MotoCross: VehiculoDeCarrera
  {
    private short _cilindrada;

    public short Cilindrada { get => _cilindrada; set => _cilindrada = value; }

    public MotoCross(short numero, string escuderia) : base(numero, escuderia)
    {

    }

    public MotoCross(short numero, string escuderia, short cilindrada):base(numero, escuderia)
    {
      Cilindrada = cilindrada;
    }

    public override string MostrarDatos()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(base.MostrarDatos());
      sb.Append($" Cilindrada: {Cilindrada}.");
      return sb.ToString();
    }

    public static bool operator ==(MotoCross moto1, MotoCross moto2)
    {
      return moto1.Numero == moto2.Numero & moto1.Escuderia == moto2.Escuderia & moto1.Cilindrada == moto2.Cilindrada;
    }
    public static bool operator !=(MotoCross moto1, MotoCross moto2)
    {
      return !(moto1 == moto2);
    }
  }
}
