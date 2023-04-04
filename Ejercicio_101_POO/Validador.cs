using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_101_POO
{
  internal class Validador
  {
    static public double ValidarNumero(string cadena)
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

    static public string ValidarRespuestaOperacion()
    {
      string cadena;
      cadena = Ingreso.IngresarPorTeclado("Elija una opcion: [A - Ingresar dinero / B - Retirar efectivo]");
      cadena = cadena.ToUpper();
      while(cadena != "A" & cadena != "B")
      {
        cadena = Ingreso.IngresarPorTeclado("Elija una opcion: [A - Ingresar dinero / B - Retirar efectivo]");
        cadena = cadena.ToUpper();
      }

      return cadena;
    }
  }
}
