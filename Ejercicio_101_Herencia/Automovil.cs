using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_101_Herencia
{
  internal class Automovil: VehiculoTerrestre
  {
    private short _cantidadMarchas;
    private int _cantidadPasajeros;

    public short CantidadMarchas { get => _cantidadMarchas; set => _cantidadMarchas = value > 0 ? value: (short)1; }
    public int CantidadPasajeros { get => _cantidadPasajeros; set => _cantidadPasajeros = value > 0 ? value: 0; }

    public Automovil(short cantidadRuedas, short cantidadPuertas, Color.Colores color, short cantidadMarchas, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, color)
    {
      CantidadMarchas = cantidadMarchas;
      CantidadPasajeros = cantidadPasajeros;
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(base.ToString());
      sb.Append($" CantidadMarchas: {CantidadMarchas}");
      sb.Append($" CantidadPasajeros: {CantidadPasajeros}");
      sb.AppendLine("");
      return sb.ToString();
    }
  }
}
