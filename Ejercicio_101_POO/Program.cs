namespace Ejercicio_101_POO
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string titular, cadena,operacion;
      double cantidad;
      Console.WriteLine("Bienvenido al Banco BBCA!");
      titular = Ingreso.IngresarPorTeclado("Ingrese el nombre del titular");
      cadena = Ingreso.IngresarPorTeclado("Ingrese el monto inicial de la cuenta");
      cantidad = Validador.ValidarNumero(cadena);
      Cuenta cuentaUno = new Cuenta(titular, cantidad);
      cuentaUno.Mostrar();
      operacion =  Validador.ValidarRespuestaOperacion();
      if(operacion == "A")
      {
        cadena = Ingreso.IngresarPorTeclado("Ingrese el monto a depositar");
        cantidad = Validador.ValidarNumero(cadena);
        cuentaUno.Ingresar(cantidad);
      }
      else if(operacion == "B")
      {
        cadena = Ingreso.IngresarPorTeclado("Ingrese el monto a retirar");
        cantidad = Validador.ValidarNumero(cadena);
        cuentaUno.Retirar(cantidad);
      }
      cuentaUno.Mostrar();
    }
  }
}
