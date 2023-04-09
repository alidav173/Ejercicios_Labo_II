/*
 * Alí Ansidey, DIV-E
 * Ejercicio 104
 * En un proyecto de biblioteca de clases, crear la clase Boligrafo a partir del siguiente diagrama:
*/
namespace Ejercicio_104_POO
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string salida;
      
      Boligrafo boligrafoUno = new Boligrafo(100, ConsoleColor.Blue);
      Boligrafo boligrafoDos = new Boligrafo(50, ConsoleColor.Red);


      boligrafoUno.Pintar(100,out salida);
      Console.WriteLine(salida);
      
      boligrafoDos.Pintar(50, out salida);
      Console.WriteLine(salida);
      
      boligrafoUno.Pintar(5, out salida);
      Console.WriteLine(salida);
      
      boligrafoDos.Pintar(10, out salida);
      Console.Write(salida);

      boligrafoUno.Recargar();

      boligrafoUno.Pintar(50, out salida);
      Console.WriteLine(salida);

      boligrafoDos.Recargar();

      boligrafoDos.Pintar(100, out salida);
      Console.WriteLine(salida);

      boligrafoUno.Pintar(50, out salida);
      Console.WriteLine(salida);


    }
  }
}
