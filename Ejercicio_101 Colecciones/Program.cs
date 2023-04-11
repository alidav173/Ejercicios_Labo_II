using System.Linq;

namespace Ejercicio_101_Colecciones
{
  internal class Program
  {
    static void Main(string[] args)
    {
 
      List<int> list = new List<int>();
      Random random = new Random();
      for (int i = 0; i < 20; i++)
      {
        list.Add(random.Next(-100,100));
      }

      //mostrar los numeros
      foreach(int value in list)
      {
        Console.WriteLine($"Numero,{value}");
      }

      
      list.Sort();
      list.Reverse();

      //Mostrar los positivos ordenados decreciente

      Console.WriteLine("\n");
      Console.WriteLine("Ordenados decreciente");
      foreach (int value in list)
      {
        if(value > 0)
        {
          Console.WriteLine($"Numero,{value}");
        }
       
      }


      //Mostrar los negativos en orden creciente

      Console.WriteLine("\n");
      Console.WriteLine("Ordenados Creciente");
      foreach (int value in list)
      {
        if (value < 0)
        {
          Console.WriteLine($"Numero,{value}");
        }

      }

    }
  }
}
