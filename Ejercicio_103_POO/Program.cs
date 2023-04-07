namespace Ejercicio_103_POO
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Estudiante estudianteRandom = new Estudiante();
      Estudiante estudianteUno = new Estudiante("Ali", "Ansidey", "1000");
      estudianteUno.SetNotaPrimerParcial(3);
      estudianteUno.SetNotaSegundoParcial(4);
      estudianteUno.random = estudianteRandom.random;
      Estudiante estudianteDos = new Estudiante("Juan", "Perez", "1002");
      estudianteDos.SetNotaPrimerParcial(7);
      estudianteDos.SetNotaSegundoParcial(8);
      estudianteDos.random = estudianteRandom.random;
      Estudiante estudianteTres = new Estudiante("Pedro", "Lopez", "1004");
      estudianteTres.SetNotaPrimerParcial(6);
      estudianteTres.SetNotaSegundoParcial(9);
      estudianteTres.random = estudianteRandom.random;

      estudianteUno.Mostrar();
      estudianteDos.Mostrar();
      estudianteTres.Mostrar();

    }
  }
}
