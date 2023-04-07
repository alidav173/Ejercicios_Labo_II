using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_102_POO
{
  internal class Validador
  {
    static public int ValidarNumero(string cadena)
    {
      bool validacion = false;
      int numeroAux;
      int numero = 0;
      validacion = int.TryParse(cadena, out numeroAux);
      if (validacion == true)
      {
        numero = numeroAux;
      }
      return numero;
    }
  }
}
