using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_103
{
  internal class Validar
  {
    static public int ValidarSiEsNumero(string cadena)
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
