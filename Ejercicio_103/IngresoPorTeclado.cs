using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_103
{
  internal class IngresoPorTeclado
  {
    static public string IngresarPorTeclado(string mensaje)
    {
      string cadena = null;
      string cadena1;
      Console.WriteLine(mensaje);
      cadena1 = Console.ReadLine();
      if(cadena1 != null)
      {
        cadena = cadena1;
      }
      return cadena;
    }
  }
}
