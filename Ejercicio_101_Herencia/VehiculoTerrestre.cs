using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_101_Herencia
{
  internal class VehiculoTerrestre
  {
    private short _cantidadRuedas;
    private short _cantidadPuertas;
    private Color.Colores _color;

    public short CantidadRuedas { get => _cantidadRuedas; set => _cantidadRuedas = value >0 ? value: (short)0; }
    public short CantidadPuertas { get => _cantidadPuertas; set => _cantidadPuertas = value >= 0 ? value : (short)0;}
    public Color.Colores Color { get => _color; set => _color = value; }

    public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Color.Colores color)
    {
      CantidadRuedas = cantidadRuedas;
      CantidadPuertas = cantidadPuertas;
      Color = color;
    }

    public override string ToString()
    {
      return "CantidadRuedas: " + CantidadRuedas + " Cantidad Puertas: " + CantidadPuertas + " Color: " + Color;
    }

  }
}
