using System.Xml.Linq;

namespace ejercicio_101
{
  /*Ingresar 5 numeros por consola, guardandolas en una variable escalar.
   * Luego calcular y mostrar: el valor maximo, el valor minimo y el promedio */
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] array = new int[5];
      for(int i = 0; i <5;i++)
      {
        array[i] = PedirNumero("Ingrese el numero");
      }

      int mayorNumero = ObtenerMayorNumero(array);

      Console.WriteLine($"El mayor numero es: {mayorNumero}");

      int menorNumero = ObtenerMenorNumero(array);

      Console.WriteLine($"El menor numero es: {menorNumero}");

      double promedio = ObtenerPromedio(array);

      Console.WriteLine($"El promedio de los numeros es: {promedio}");

    }

    static int PedirNumero(string mensaje)
    {
      string numeroSolicitado;
      Console.WriteLine(mensaje);
      numeroSolicitado = Console.ReadLine();
      int numero = Int32.Parse(numeroSolicitado);
      return numero;
    }

    /*static void VerArray(int[] array)
    {
      foreach(int element in array)
      //for(int i = 0; i < 5; i++)
      {
        Console.WriteLine($"{element}");
      }
    }*/

    static int ObtenerMayorNumero(int[] array)
    { 
      int numeroMayor = array.Max();
      return numeroMayor;
    }

    static int ObtenerMenorNumero(int[] array)
    {
      int numeroMenor = array.Min();
      return numeroMenor;
    }

    static double ObtenerPromedio(int[] array)
    {
      double promedio = array.Average();
      return promedio;
    }
  }
}
