using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_102
{
  internal class Numeros
  {
    static public int SumarNumeros(List<int> listaNumeros)
    {
      int suma = 0;
      if(listaNumeros != null)
      {
        foreach(int numero in listaNumeros)
        {
          suma = suma + numero;
        }
      }

      return suma;
    }
  }
}
