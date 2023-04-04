using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_104
{
  internal class Salida
  {
    static public void MostrarResultado(string operador, string resultado)
    {
      string operacion="";
      switch (operador)
      {
        case "+":
          operacion = "suma";
          break;
        case "-":
          operacion = "resta";
          break;
        case "*":
          operacion = "multiplicacion";
          break;
        case "/":
          operacion = "division";
          break;
      }

      Console.WriteLine($"El resultado de la {operacion} es: {resultado}");
    }
  }





   

}
