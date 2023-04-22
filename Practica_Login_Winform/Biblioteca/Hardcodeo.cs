using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Login_Winform.Biblioteca
{
  internal class Hardcodeo
  {

   
    public static List<Usuario> ListarUsuarios()
    {
      List<Usuario> usuarios = new List<Usuario>();
      Usuario usuarioUno = new Usuario("alidav","12345");
      usuarios.Add(usuarioUno);
      Usuario usuarioDos = new Usuario("pepe", "00000");
      usuarios.Add(usuarioDos);
      Usuario usuarioTres = new Usuario("Don Gato", "11111");
      usuarios.Add(usuarioTres);

      return usuarios;
    }

  }
}
