using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_101_Herencia
{
  internal class Moto: VehiculoTerrestre
  {
    private short _cilindrada;

    public short Cilindrada { get => _cilindrada; set => _cilindrada = value > 0 ? value: (short)0; }

    public Moto(short cantidadRuedas, short cantidadPuertas, Color.Colores color, short cilindrada) : base(cantidadRuedas,0, color)
    {
      Cilindrada = cilindrada;

    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(base.ToString());
      sb.Append($"Cilindrada: {Cilindrada} cc");
      sb.AppendLine("");
      return sb.ToString();
    }
  }
}
