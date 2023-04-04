using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_102
{
  internal class Ingreso
  {
    static public string IngresoPorTeclado(string mensaje)
    {
      Console.WriteLine(mensaje);
      string cadena = null;
      string cadena1 = Console.ReadLine();
      if (cadena1 != null)
      {
        cadena = cadena1;
      }
      return cadena;
    }
  }
}
