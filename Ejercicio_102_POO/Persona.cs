using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_102_POO
{
 
  internal class Persona
  {
    string nombre { get; set; }
    DateTime FechaNac { get; set;}
    int _dni;

    public int Dni
    {
      get => _dni;
      set => _dni = value > 0 & value < 100000000  ? value : 0;

    }

    public Persona(string nombre, DateTime fechaNac, int dni)
    {
      this.nombre = nombre;
      this.FechaNac = fechaNac;
      this.Dni = dni;
    }

    private static int CalcularEdad(DateTime fechaNac)
    {
      double dias = 0;
      int edad = 0;
      DateTime fechaActual = DateTime.Now;
      dias = fechaActual.ToOADate() - fechaNac.ToOADate();
      if(dias > 0)
      {
        edad = (int)dias / 360;
      }

      return edad;
    }

    public static void Mostrar(Persona persona)
    {
      string nombre = persona.nombre;
      int edad = CalcularEdad(persona.FechaNac);
      int dniPersona = persona.Dni;
      string cadena;
      cadena = EsMayorDeEdad(edad);

      StringBuilder sb = new StringBuilder($"Los datos de la persona son nombre: {nombre}, edad: {edad} años, y dni:{dniPersona}. ",200);
      sb.AppendLine(cadena);
      Console.WriteLine(sb);
    }

    private static string EsMayorDeEdad(int edad)
    {
      string mensaje= "Es menor";
      if (edad >= 18)
      {
        mensaje = "Es mayor de edad";
      }

      return mensaje;
    }


  }



 
}
