using System;
using System.Drawing;

namespace Ejercicio_101_Herencia
{
  internal class Program
  {
    static void Main(string[] args)
    {
      VehiculoTerrestre vehiculoNuevo = new VehiculoTerrestre(3, 0, Color.Colores.Rojo);
      Console.WriteLine(vehiculoNuevo.ToString());
      Console.WriteLine("");

      Automovil autoNuevo = new Automovil(4,3,Color.Colores.Azul,5,5);
      Console.WriteLine(autoNuevo.ToString());

      Moto motoNueva = new Moto(2,0,Color.Colores.Gris,250);
      Console.WriteLine(motoNueva.ToString());

      Camion camionNuevo = new Camion(6, 2, Color.Colores.Negro, 8, 4500);
      Console.WriteLine(camionNuevo.ToString());
    }
  }
}
