using Ejercicio_C01_Herencia.Biblioteca;

namespace Ejercicio_C01_Herencia
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Equipo equipo1 = new Equipo(4, "Central Lugano");
      DirectorTecnico dt1 = new DirectorTecnico("Marcelo Gallardo", new DateTime(1980, 4, 30));
      DirectorTecnico dt2 = new DirectorTecnico("Marcelo Bielsa", new DateTime(1960, 12, 31));
      DirectorTecnico dt3 = new DirectorTecnico("Marcelo Gallardo", new DateTime(1980, 4, 30));


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

      Console.WriteLine(jugador1.Mostrar());
      Console.WriteLine(jugador2.Mostrar());
      Console.WriteLine(jugador3.Mostrar());
      Console.WriteLine(jugador4.Mostrar());
      Console.WriteLine(jugador5.Mostrar());
      Console.WriteLine(jugador6.Mostrar());

      Console.WriteLine(dt1 == dt2);
      Console.WriteLine(dt1 == dt3);

      Console.WriteLine(dt1.Mostrar());
      Console.WriteLine(dt2.Mostrar());
      Console.WriteLine(dt3.Mostrar());



    }
  }
}
