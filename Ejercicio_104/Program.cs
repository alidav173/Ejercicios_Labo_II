/* Ali Ansidey. DIV-E
Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,
multiplicación y división).

Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y
la operación matemática. El método devolverá el resultado de la operación.

Validar (privado): Recibirá como parámetro el segundo operando.
Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
Este método devolverá true si el operando es distinto de cero.

Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar
(ingresando el caracter +, -, * o /).

El usuario decidirá cuándo finalizar el programa.
*/
namespace Ejercicio_104
{
  internal class Program
  {
    static void Main(string[] args)
    {
      double numeroUno, numeroDos;
      string cadena, resultado, operador;
      Console.WriteLine("***** Bienvenido a la calculadora *****");
      cadena = Input.IngresarPorTeclado("Ingrese el primer numero: ");
      numeroUno = Validar.ValidarSiEsNumero(cadena);
      cadena = Input.IngresarPorTeclado("Ingrese el segundo numero: ");
      numeroDos = Validar.ValidarSiEsNumero(cadena);
      operador = Input.IngresarPorTeclado("Ingrese la operacion[ + sumar | - restar | * multiplicar" +
        "| / dividir]: ");
      operador = Validar.ValidarOperador(operador);
      resultado = Calculadora.Calcular(numeroUno, numeroDos, operador);
      Salida.MostrarResultado(operador, resultado);

    }
  }
}
