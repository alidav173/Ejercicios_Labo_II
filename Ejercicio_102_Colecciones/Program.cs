/*
Ejercicio 102- Numeros locos 2
Ali Ansidey div-e
*/
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace Ejercicio_102_Colecciones
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<int> list = new List<int>();
      Stack<int> pila = new Stack<int>();
      Queue<int> cola = new Queue<int>();
      Random random = new Random();

      for (int i = 0; i < 20; i++)
      {
        list.Add(random.Next(-100, 100));
        pila.Push(random.Next(-100, 100));
        cola.Enqueue(random.Next(-100, 100));

      }
      Mostrar(list,"lista");
      Mostrar(pila,"pila");
      Mostrar(cola,"cola");

      Console.WriteLine($"Valores positivos decrecientes en la lista :");
      MostrarPositivosDecrecientes(list);
      Console.WriteLine($"Valores positivos decrecientes en la Pila :");
      MostrarPositivosDecrecientes(pila);
      Console.WriteLine($"Valores positivos decrecientes en la Cola :");
      MostrarPositivosDecrecientes(cola);

      Console.WriteLine($"Valores negativos crecientes en la lista :");
      MostrarNegativosCrecientes(list);
      Console.WriteLine($"Valores negativos crecientes en la pila :");
      MostrarNegativosCrecientes(pila);
      Console.WriteLine($"Valores negativos crecientes en la cola :");
      MostrarNegativosCrecientes(cola);

    }

   public static void Mostrar(List<int> lista, string tipo)
    {
        Console.WriteLine($"Valores en la {tipo}: ");
        foreach (int valor in lista)
        {
          Console.WriteLine($"{valor}");
        }
        Console.WriteLine("\n");
    }

    public static void Mostrar(Stack<int> lista, string tipo)
    {
      Console.WriteLine($"Valores en la {tipo}: ");
      foreach (int valor in lista)
      {
        Console.WriteLine($"{valor}");
      }
      Console.WriteLine("\n");
    }

    public static void Mostrar(Queue<int> lista, string tipo)
    {
      Console.WriteLine($"Valores en la {tipo}: ");
      foreach (int valor in lista)
      {
        Console.WriteLine($"{valor}");
      }
      Console.WriteLine("\n");
    }


    public static void MostrarPositivosDecrecientes(List<int> lista)
    {
      

      lista.Sort();
      lista.Reverse();

      foreach (int valor in lista)
      {
        if(valor > 0)
        {
          Console.WriteLine($"{valor}");
        }
      }
      Console.WriteLine("\n");
    }

    public static void MostrarPositivosDecrecientes(Stack<int> stack)
    {
      List<int> lista1 = new List<int>();

      foreach (int valor in stack)
      {
        if (valor > 0)
        {
          lista1.Add(valor);
        }
      }
      MostrarPositivosDecrecientes(lista1);
    }

    public static void MostrarPositivosDecrecientes(Queue<int> cola)
    {
      List<int> lista1 = new List<int>();

      foreach (int valor in cola)
      {
        if (valor > 0)
        {
          lista1.Add(valor);
        }
      }
      MostrarPositivosDecrecientes(lista1);
    }

    public static void MostrarNegativosCrecientes(List<int> lista)
    {

      lista.Sort();

      foreach (int valor in lista)
      {
        if (valor < 0)
        {
          Console.WriteLine($"{valor}");
        }
      }
      Console.WriteLine("\n");
    }

    public static void MostrarNegativosCrecientes(Stack<int> pila)
    {

      List<int> lista1 = new List<int>();

      foreach (int valor in pila)
      {
        if (valor < 0)
        {
          lista1.Add(valor);
        }
      }
      MostrarNegativosCrecientes(lista1);

    }

    public static void MostrarNegativosCrecientes(Queue<int> cola)
    {

      List<int> lista1 = new List<int>();

      foreach (int valor in cola)
      {
        if (valor < 0)
        {
          lista1.Add(valor);
        }
      }
      MostrarNegativosCrecientes(lista1);

    }


  }
}
