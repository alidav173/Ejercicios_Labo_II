/*
 * Alí Ansidey, DIV-E
 * Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

public string ConvertirDecimalABinario(int numeroEntero) {}

El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

public int ConvertirBinarioADecimal(int numeroEntero) {}



*/

namespace Ejercicio_103
{
  internal class Program
  {
    static void Main(string[] args)
    {
      
      string cadena, tipoConversion;
      int numero;
      string numeroBinario;
      int numeroDecimal;

      tipoConversion = IngresoPorTeclado.IngresarPorTeclado("Ingrese el tipo de Conversion [A - Binario a Decimal / B - Decimal" +
        " a Binario]");
      tipoConversion = tipoConversion.ToUpper();

      while(tipoConversion != "A" & tipoConversion != "B")
      {
        tipoConversion = IngresoPorTeclado.IngresarPorTeclado("Ingrese el tipo de Conversion [A - Binario a Decimal / B - Decimal" +
        " a Binario]");
        tipoConversion = tipoConversion.ToUpper();
      }

      cadena = IngresoPorTeclado.IngresarPorTeclado("Ingrese el numero a convertir");
      numero = Validar.ValidarSiEsNumero(cadena);

      if (tipoConversion == "A")
      {
        numeroDecimal = Conversor.ConvertirBinarioADecimal(numero);
        Console.WriteLine($"El numero {numero} en sistema decimal es: {numeroDecimal}");
      }
      else if (tipoConversion == "B"){
        numeroBinario = Conversor.ConvertirDecimalABinario(numero);
        Console.WriteLine($"El numero {numero} en sistema binario es: {numeroBinario}");
      }

    }
  }
}
