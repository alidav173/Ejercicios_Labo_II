using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_104
{
  internal class Calculadora
  {
    static public string Calcular(double numeroUno, double numeroDos, string operador)
    {
      double resultado;
      string resultadoOperaciones="";

      switch (operador)
      {
        case "+":
          resultado = numeroUno + numeroDos;
          resultadoOperaciones = resultado.ToString("0.00");
          break;
        case "-":
          resultado = numeroUno - numeroDos;
          resultadoOperaciones = resultado.ToString("0.00");
          break;
        case "*":
          resultado = numeroUno * numeroDos;
          resultadoOperaciones = resultado.ToString("0.00");
          break;
        case "/":
          bool validacion = Validar(numeroDos);
          if (validacion)
          {
            resultado = numeroUno / numeroDos;
            resultadoOperaciones = resultado.ToString("0.00");
          }
          else
          {
            resultadoOperaciones = "No se puede dividir por 0";
          }
          break;

      }

      return resultadoOperaciones;
    }

    static private bool Validar(double numeroDos)
    {
      bool validar = false;
      if (numeroDos != 0)
      {
        validar = true;
      }

      return validar;
    }
  }
}
