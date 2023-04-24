using Ejercicio_C02_Herencia.Biblioteca;

namespace Ejercicio_C02_Herencia
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Competencia competenciaUno = new Competencia(10, 3,Tipo.TipoCompetencia.F1);
      AutoF1 autoUno = new AutoF1(1, "Ferrari",450);
      AutoF1 autoDos = new AutoF1(1, "McLaren",480);
      AutoF1 autoTres = new AutoF1(13, "Mercedes",500);
      AutoF1 autoCuatro = new AutoF1(13, "Honda",420);

      Console.WriteLine(competenciaUno + autoUno);
      Console.WriteLine(competenciaUno + autoDos);
      Console.WriteLine(competenciaUno + autoTres);
      Console.WriteLine(competenciaUno + autoCuatro);

      Console.WriteLine(competenciaUno.MostrarDatos());

      Console.WriteLine(competenciaUno - autoUno);
      Console.WriteLine(competenciaUno + autoCuatro);

      Console.WriteLine(competenciaUno.MostrarDatos());


      Competencia competenciaDos = new Competencia(10, 3, Tipo.TipoCompetencia.MotoCross);
      MotoCross motoUno = new MotoCross(1, "Ducati",650);
      MotoCross motoDos = new MotoCross(1, "Honda", 1000);
      MotoCross motoTres = new MotoCross(1, "Kawasaki", 900);


      Console.WriteLine(competenciaDos + motoUno);
      Console.WriteLine(competenciaDos + motoDos);
      Console.WriteLine(competenciaDos + motoTres);


      Console.WriteLine(competenciaDos.MostrarDatos());





    }
  }
}
