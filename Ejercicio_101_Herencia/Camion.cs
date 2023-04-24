using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_101_Herencia
{
  internal class Camion : VehiculoTerrestre
  {
    private short _cantidadMarchas;
    private int _pesoCarga;

    public short CantidadMarchas { get => _cantidadMarchas; set => _cantidadMarchas = value > 0 ? value:(short) 1; }
    public int PesoCarga { get => _pesoCarga; set => _pesoCarga = value > 0 ? value: 0; }

    public Camion(short cantidadRuedas, short cantidadPuertas, Color.Colores color, short cantidadMarchas, int pesoCarga): base(cantidadRuedas, cantidadPuertas, color)
    {
      CantidadMarchas = cantidadMarchas;
      PesoCarga = pesoCarga;
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(base.ToString());
      sb.Append($" CantidadMarchas: {CantidadMarchas}");
      sb.Append($" PesoCarga: {PesoCarga}kg");
      sb.AppendLine("");
      return sb.ToString();
    }
  }
}
