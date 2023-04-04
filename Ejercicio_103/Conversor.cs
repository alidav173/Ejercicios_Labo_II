using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_103
{
  internal class Conversor
  {
    static public string ConvertirDecimalABinario(int numeroEntero)
    {
      string cadena = "0";
      int resto;

      while (numeroEntero > 0)
      {
        resto = numeroEntero % 2;
        numeroEntero /= 2;
        cadena = resto.ToString() + cadena;
      }

      return cadena;
    }

   static public int ConvertirBinarioADecimal(int numeroEntero)
    {
      string cadenaNumero = numeroEntero.ToString();
      char[] arrayChar = cadenaNumero.ToCharArray();
      Array.Reverse(arrayChar);

      int numero = 0;
      int valorBase = 1;

      foreach (char c in arrayChar)
      {
        if (c == '1')
        {
          numero += valorBase;
        }
        valorBase *= 2;
      }

      return numero;
    }
  }
}
