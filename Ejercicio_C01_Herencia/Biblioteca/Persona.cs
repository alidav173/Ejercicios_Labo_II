using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01_Herencia.Biblioteca
{
   internal class Persona
  {
    private long _dni;
    private string _nombre;

    public long Dni
    {
      get { return _dni; }
      set { _dni = value; }
    }

    public string Nombre
    {
      get { return _nombre; }
      set { _nombre = value; }
    }

    public Persona(string nombre)
    {
      Nombre = nombre;

    }

    public Persona(long dni, string nombre) :this(nombre)
    {
      Dni = dni;
    }

    public virtual string Mostrar()
    {
      string cadena;
      StringBuilder sb = new StringBuilder();
      sb.Append($"Nombre:{Nombre}, Dni: {Dni}");
      return cadena = sb.ToString();
    }
  }
}
