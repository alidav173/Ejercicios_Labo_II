using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevoProjectoWinForm.Biblioteca
{
  internal class Persona
  {
    private string _nombre;
    private int _legajo;


    public string Nombre
    {
      get => _nombre;
      set => _nombre = value;
    }

    public int Legajo
    {
      get => _legajo;
      set=> _legajo = value;
    }


    public Persona(string nombre, int legajo)
    {
      Nombre = nombre;
      Legajo = legajo;
    }
  }


}
