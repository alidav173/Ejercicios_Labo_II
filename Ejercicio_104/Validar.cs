using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_104
{
  internal class Validar
  {
    static public double ValidarSiEsNumero(string cadena)
    {
      bool validacion = false;
      double numeroAux;
      double numero = 0;
      validacion = double.TryParse(cadena, out numeroAux);
      if (validacion == true)
      {
        numero = numeroAux;
      }
      return numero;
    }

    static public string ValidarOperador(string operador)
    {
      string operadorValidado = operador;
      while(operadorValidado != "+" & operadorValidado != "-" & operadorValidado != "*" & operadorValidado != "/")
      {
        operadorValidado =  Input.IngresarPorTeclado("Reingrese la operacion[ + sumar | - restar | * multiplicar | / dividir]:");
      }

      return operadorValidado;
    }
  }
}
