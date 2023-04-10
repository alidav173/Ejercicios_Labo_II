namespace Ejercicio_A01_POO
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Ejercicio A01 - Sistema Autonavegacion");

      int[] listaHorasConductorUno = { 1, 2, 3, 4, 14, 0, 0};
      Conductor conductorUno = new Conductor("Jorge Emilio", listaHorasConductorUno);

      int[] listaHorasConductorDos = { 2,4, 6, 8, 10, 0, 0};
      Conductor conductorDos = new Conductor("Juan Carrillo", listaHorasConductorDos);

      int[] listaHorasConductorTres = { 2,8,0,0, 10, 12,12};
      Conductor conductorTres = new Conductor("Pepe Grillo", listaHorasConductorTres);

      Conductor[] listaConductores = {conductorUno, conductorDos, conductorTres};

      Empresa empresaNueva = new Empresa("DOTA", listaConductores);


      string conductor;

      Console.WriteLine($"La empresa {empresaNueva.Nombre} ofrece la lista de premios esta semana:\n");

      conductor = empresaNueva.CalcularConductorMasKm(listaConductores);
      Console.WriteLine($"El conductor con mas horas esta semana fue: {conductor}");

      conductor = empresaNueva.CalcularConductorMasKmDiaCualquiera(listaConductores,3);
      Console.WriteLine($"El conductor con mas horas el dia 3 fue: {conductor}");

      conductor = empresaNueva.CalcularConductorMasKmDiaCualquiera(listaConductores,5);
      Console.WriteLine($"El conductor con mas horas el dia 5 fue: {conductor}");
    }
  }
}
