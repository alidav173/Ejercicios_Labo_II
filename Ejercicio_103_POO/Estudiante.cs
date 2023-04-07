using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_103_POO
{
  internal class Estudiante
  {
    string _apellido;
    public string Apellido {
      get => _apellido;
      set => _apellido = value != "" ? value : "Ninguno";
    }
      
    string _legajo;
    public string Legajo
    {
      get => _legajo;
      set => _legajo = value != "" ? value : "Ninguno";
    }

    string _nombre;

    public string Nombre
    {
      get => _nombre;
      set => _nombre = value != "" ? value : "Ninguno";
    }

    int notaPrimerParcial { get; set;}
    int notaSegundoPacial { get; set;}
   public Random random { get; set; }

      public  Estudiante()
    {
      random = new Random();
     
    }

    public Estudiante(string nombre, string apellido, string legajo)
    {
      Nombre = nombre;
      Apellido = apellido;
      Legajo = legajo;
    
    }

    public void SetNotaPrimerParcial(int nota)
    { 
      if(nota >0 & nota < 10)
      {
        this.notaPrimerParcial = nota;
      }
      
    }

    public void SetNotaSegundoParcial(int nota)
    {
      if (nota > 0 & nota < 10)
      {
        this.notaSegundoPacial = nota;
      }

    }

    private float CalcularPromedio()
    {
      float promedio;
      promedio = (this.notaPrimerParcial + this.notaSegundoPacial)/2;

        return promedio;
    }

    public double CalcularNotafinal()
    {
      double notaFinal = -1;
      if(this.notaPrimerParcial >= 4 & this.notaSegundoPacial >= 4)
      {
        notaFinal = random.Next(6, 10);

      }

      return notaFinal;
    }

    public void Mostrar()
    {

      string nombre = Nombre;
      string apellido = Apellido;
      string legajo = Legajo;
      int notaPrimerP = notaPrimerParcial;
      int notaSegundoP = notaSegundoPacial;
      float promedio = CalcularPromedio();
      double notaFinal = CalcularNotafinal();

      StringBuilder sb = new StringBuilder($"El estudiante {nombre} {apellido}, con legajo {legajo}, " +
        $"tiene como notas, primer parcial {notaPrimerP} y segundo parcial {notaSegundoP}", 250);
      if (notaFinal != -1)
      {
        sb.AppendLine($", y nota final {notaFinal}");
      }
      else
      {
        sb.AppendLine("Y se encuentra desaprobado.");
      }
   

      Console.WriteLine(sb);
    }

  }
}
