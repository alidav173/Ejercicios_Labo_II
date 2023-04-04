/*
 * Alí Ansidey DIV-E
 * Ejercicio 102
 * Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje 
 * "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y
FALSE si se ingresó cualquier otro valor. */




namespace Ejercicio_102
{
  internal class Program
  {
    static void Main(string[] args)
    {
     bool respuesta = false;
      string cadena;
      int numero, suma;
      var numeros = new List<int>();
      do
      {
        cadena = Ingreso.IngresoPorTeclado("Ingrese un numero: ");
        numero = Validador.ValidarSiEsNumero(cadena);
        numeros.Add(numero);
        respuesta =  Validador.ValidarRespuesta("Desea continuar: [S/N]");
      } while (respuesta == true);

      suma = Numeros.SumarNumeros(numeros);
      Console.WriteLine($"La suma de los numeros ingresados es: {suma}");

    }
  }
}
