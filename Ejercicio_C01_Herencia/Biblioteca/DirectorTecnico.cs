using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01_Herencia.Biblioteca
{
  internal class DirectorTecnico : Persona
  {
    private DateTime _fechaNacimiento;

    public DateTime FechaNacimiento
    {
      get => _fechaNacimiento;
      set => _fechaNacimiento = value;
    }

    public DirectorTecnico(string nombre) : base(nombre)
    {

    }

    public DirectorTecnico(string nombre, DateTime fechaNacimiento):this(nombre)
    {
      FechaNacimiento = fechaNacimiento;
    }

    public override string Mostrar()
    {
      string cadena;
      StringBuilder sb = new StringBuilder();
      sb.Append(base.Mostrar());
      sb.Append($" Fecha de nacimiento: {FechaNacimiento.ToString()}");
      return cadena = sb.ToString();
    }

    public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
    {
      return dt1.Nombre == dt2.Nombre & dt1.FechaNacimiento == dt2.FechaNacimiento;
    }

    public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
    {
      return !(dt1 == dt2);
    }

  }
}
