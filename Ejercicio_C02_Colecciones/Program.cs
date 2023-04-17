/*
Ejercicio C02 - Enciendan los motores
Crear un proyecto de biblioteca de clases que contenga las clases Competencia y AutoF1.

*/
namespace Ejercicio_C02_Colecciones
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Competencia competenciaUno = new Competencia(10,3);
      AutoF1 autoUno = new AutoF1(1,"Ferrari");
      AutoF1 autoDos = new AutoF1(1, "McLaren");
      AutoF1 autoTres = new AutoF1(13, "Mercedes");
      AutoF1 autoCuatro = new AutoF1(13, "Honda");

      Console.WriteLine(competenciaUno + autoUno);
      Console.WriteLine(competenciaUno + autoDos);
      Console.WriteLine(competenciaUno + autoTres);
      Console.WriteLine(competenciaUno + autoCuatro);

      Console.WriteLine(competenciaUno.MostrarDatos());

      Console.WriteLine(competenciaUno - autoUno);
      Console.WriteLine(competenciaUno + autoCuatro);

      Console.WriteLine(competenciaUno.MostrarDatos());


    }
  }
}
