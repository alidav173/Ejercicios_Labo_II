using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_102_WindowsForms.Biblioteca
{
  internal class Ingresante
  {
    private string[] _cursos;
    private string _direccion;
    private int _edad;
    private string _genero;
    private string _nombre;
    private string _pais;

    public string[] Cursos
    {
      get => _cursos;
      set => _cursos = value;
    }

    public string Direccion
    {
      get
      { return _direccion; }

      set => _direccion = value;
    }

    public int Edad
    {
      get
      { return _edad; }

      set => _edad = value > 0 & value <= 100 ? value : -1;
    }

    public string Genero
    {
      get => _genero;
      set => _genero = value;
    }

    public String Nombre
    {
      get => _nombre;
      set => _nombre = value;
    }

    public String Pais
    {
      get => _pais;
      set => _pais = value;
    }

    public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
    {

      Nombre = nombre;
      Direccion = direccion;
      Genero = genero;
      Pais = pais;
      Cursos = cursos;
      Edad = edad;

    }

    public string Mostrar()
    {
      string cadena;
      StringBuilder sb = new StringBuilder();
      string cursos = MostrarCursos();
      sb.AppendLine("Nombre: " + Nombre);
      sb.AppendLine("Dirección: " + Direccion);
      sb.AppendLine("Genero: " + Genero );
      sb.AppendLine("País: " + Pais);
      sb.AppendLine("Edad: " + Edad);
      sb.Append("Cursos: " + cursos);
      cadena = sb.ToString();
      return cadena;
    }

    private string MostrarCursos()
    {
      string cadena;
      StringBuilder sb = new StringBuilder();
      for (int i = 0; i < Cursos.Length; i++)
      {
        sb.AppendLine(Cursos[i]);
      }
      cadena = sb.ToString();
      return cadena;
    }


  }
}
