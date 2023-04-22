using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Login_Winform.Biblioteca
{
  internal class Usuario
  {
    private string _nombreUsuario;
    private string _contraseña;

    public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
    public string Contraseña { get => _contraseña; set => _contraseña = value; }

    public Usuario(string nombre, string contraseña)
    {
      NombreUsuario = nombre;
      Contraseña = contraseña;

    }

    public override string ToString()
    {
      return "Nombre " + NombreUsuario;
    }

    public static bool operator ==(Usuario u1, Usuario u2)
      {
      return u1.NombreUsuario == u2.NombreUsuario & u1.Contraseña == u2.Contraseña;
      }

    public static bool operator !=(Usuario u1, Usuario u2)
    {
      return !(u1 == u2);
    }

  }

}
