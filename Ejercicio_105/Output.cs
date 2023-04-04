using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_105
{
  internal class Output
  {
    static public void MostrarTabla(string cadena)
    {
  
      bool esNumero;
      string numero;
      esNumero = Validar.ValidarSiEsNumero(cadena);

      if(esNumero == false)
      {
        Console.WriteLine("Ingrese un numero valido");
      }
      else
      {

      }
    }
  }
}
