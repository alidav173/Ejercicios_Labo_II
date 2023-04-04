using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_102
{
  internal class Validador
  {
    static public bool ValidarRespuesta(string mensaje)
    {
      bool respuesta = false;
      Console.WriteLine(mensaje);
      string cadena = Console.ReadLine();
      cadena = cadena.ToUpper();
      while(cadena != "S" & cadena != "N")
      {
        Console.WriteLine(mensaje);
         cadena = Console.ReadLine();
        cadena = cadena.ToUpper();
      }
      if(cadena == "S")
      {
        respuesta = true;
      }

      return respuesta;
    }

    static public int ValidarSiEsNumero(string cadena)
    {
      bool validacion = false;
      int numeroAux;
      int numero = 0;
      validacion = int.TryParse(cadena, out numeroAux);
      if(validacion == true)
      {
        numero = numeroAux;
      }
      return numero;
    }

  
  }
}
