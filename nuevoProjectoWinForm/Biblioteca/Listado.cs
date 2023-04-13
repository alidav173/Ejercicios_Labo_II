using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevoProjectoWinForm.Biblioteca
{
  internal class Listado
  {
    private List<Persona> _listadoP;

    public List<Persona> ListadoP
    {
      get => _listadoP;
      set => _listadoP = value;
    }

    public Listado()
    {
      ListadoP = new List<Persona>();
    }

    public bool AgregarPersona(Persona persona)
    {
      bool result = false;
      if(persona != null)
      {
        ListadoP.Add(persona);
        result = true;

      }
      return result;
    }

    public string MostrarListado(List<Persona> listado)
    {
      StringBuilder sb = new StringBuilder();
      string cadena;

      foreach(Persona persona in listado)
      {
        sb.Append("Nombre: " + persona.Nombre.ToString());
        sb.Append(" Legajo :" + persona.Legajo.ToString());
        sb.AppendLine("");
      }

      cadena = sb.ToString();
      
      
      return cadena;
    }
}
  }

