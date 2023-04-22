using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Login_Winform.Biblioteca
{
  internal class Validador
  {
    public static bool ValidarString(string cadena)
    {
      bool flag = true;
      if (String.IsNullOrEmpty(cadena)) {
        flag =  false;
      }
      return flag;
    }

    public static bool ValidarUsuario(Usuario usuarioUno)
    {
      bool flag = false;
      foreach (Usuario userUno in Hardcodeo.ListarUsuarios())
      {
        if (userUno == usuarioUno)
        {
          flag = true;
          break;
        }
      }
      return flag;
    }
  }
}
