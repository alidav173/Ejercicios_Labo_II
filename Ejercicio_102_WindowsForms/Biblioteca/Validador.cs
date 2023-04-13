using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_102_WindowsForms.Biblioteca
{
  internal class Validador
  {
    public static bool ValidarCadena(string cadena)
    {
      bool flag = false;
      int numero;
      if(!String.IsNullOrEmpty(cadena) & !String.IsNullOrWhiteSpace(cadena) & !int.TryParse(cadena,out numero))
      {
        flag = true;
      }
      return flag;
    }

    
  }

 
}
