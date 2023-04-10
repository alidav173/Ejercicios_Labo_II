/*
Ejercicio 101 - Sobrecarga
Crear un proyecto de tipo biblioteca de clases y agregar la clase Sumador.

*/
using System.Runtime.CompilerServices;

namespace Ejercicio_101_Sobrecarga
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Ejercicio 101 - Sobrecarga");

      Sumador sumador = new Sumador();
      Sumador sumador2 = new Sumador(2);
      int entero = (int)sumador;
      int entero2 = (int)sumador2;

      if(sumador | sumador2)
      {
        Console.WriteLine("Son iguales");
      }
      else
      {
        Console.WriteLine("Son distintos");
      }

      int cantidad = entero + entero2;
      Console.WriteLine($"La cantidad de sumas es: {cantidad}");

    }
  }
}
