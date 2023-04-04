
using System;
using System.Globalization;

namespace Ejercicio_101_validar
{
  internal class Program
  {
 
    static void Main(string[] args)
    {
      int tope = 10;
      int max = 100;
      int min = -100;
      int numero;

      var numeros = new List<int>
      {

      };
  
      bool bandera = false;
      for (int i = 0; i < tope; i++)
      {
        numero = IngresoPorTeclado("Ingrese un numero: ");
        bandera = Validador.Validar(numero, min, max);
        while (bandera == false)
        {
          numero = IngresoPorTeclado("Reingrese un numero: ");
          bandera = Validador.Validar(numero, min, max);
        }
        numeros.Add(numero);
      }

      MostrarValoresNumeros(numeros);
    }


     static int IngresoPorTeclado(string mensaje)
    {
      int numero = -1000;
      Console.WriteLine(mensaje);
      string numeroSolicitado = Console.ReadLine();
      int numeroAux;
      bool bandera = int.TryParse(numeroSolicitado, out numeroAux);
      if (bandera == true)
      {
        numero = numeroAux;
      }
      return numero;
    }

    static int ObtenerMayorNumero(List<int> numeros)
    {
      //int numeroMayor = array.Max();
      int numeroMayor = numeros.Max();
      return numeroMayor;
    }

    static int ObtenerMenorNumero(List<int> numeros)
    {
      //int numeroMenor = array.Min();
      int numeroMenor = numeros.Min();
      return numeroMenor;
    }

    static double ObtenerPromedio(List<int> numeros)
    {
      //double promedio = array.Average();
      double promedio = numeros.Average();
      return promedio;
    }

    static void MostrarValoresNumeros(List<int> numeros)
    {

      int mayorNumero = ObtenerMayorNumero(numeros);

      int menorNumero = ObtenerMenorNumero(numeros);

      double promedio = ObtenerPromedio(numeros);

      Console.WriteLine($"El mayor de los numeros es: {mayorNumero}");
      Console.WriteLine($"El menor de los numeros es: {menorNumero}");
      Console.WriteLine($"El promedio de los numeros es: {promedio}");
    }    

  }

  public class Validador
  {
    static public bool Validar(int valor, int min, int max)
    {
      bool bandera = false;
      if (valor >= min & valor <= max)
      {
        bandera = true;
      }
      return bandera;
    }
  }
}
