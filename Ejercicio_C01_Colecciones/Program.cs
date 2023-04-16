namespace Ejercicio_C01_Colecciones
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Equipo equipo1 = new Equipo(4, "Central Lugano");

      Jugador jugador1 = new Jugador(95501570, "Ali Ansidey");
      Jugador jugador2 = new Jugador(95501570, "Karina BAA");
      Jugador jugador3 = new Jugador(22501879, "Karina Ashford");
      Jugador jugador4 = new Jugador(95501870, "Pepe Grillo");
      Jugador jugador5 = new Jugador(11570058, "Lionel Messi");
      Jugador jugador6 = new Jugador(8874855, "Eze Baeer");

      Console.WriteLine(equipo1 + jugador1);
      Console.WriteLine(equipo1 + jugador2);
      Console.WriteLine(equipo1 + jugador3);
      Console.WriteLine(equipo1 + jugador4);
      Console.WriteLine(equipo1 + jugador5);
      Console.WriteLine(equipo1 + jugador6);
      Console.WriteLine("\n");
      equipo1.MostrarJugadores();

      jugador1.PartidosJugados = 100;
      jugador1.TotalGoles = 50;

      equipo1.MostrarJugadores();
    }
  }
}
