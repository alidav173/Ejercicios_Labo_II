using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_105
{
  internal class Validar
  {
    static public bool ValidarSiEsNumero(string cadena)
    {
      bool validacion = false;
      int numeroAux;
      validacion = int.TryParse(cadena, out numeroAux);
      return validacion;
    }
  }
}
