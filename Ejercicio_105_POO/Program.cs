/*
 * Ali Ansidey, DIV-E
Ejercicio 105_POO Prueba de Geometria

*/
namespace Geometria
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Ejercicio 105_POO");

      Punto puntoUno = new Punto(1, 1);
      Punto puntoDos = new Punto(5, 4);
      Rectangulo rectanguloUno = new Rectangulo(puntoUno, puntoDos);
      MostrarRectangulo(rectanguloUno);

      Punto puntoTres = new Punto(0, -1);
      Punto puntoCuatro = new Punto(8, 5);
      Rectangulo rectanguloDos = new Rectangulo(puntoTres, puntoCuatro);
      MostrarRectangulo(rectanguloDos);
    }

    static void MostrarRectangulo(Rectangulo rectanguloUno)
    {
      Console.WriteLine("\n");
      Console.WriteLine($"El vertice1 del rectangulo es({rectanguloUno.Vertice1.X},{rectanguloUno.Vertice1.Y})");
      Console.WriteLine($"El vertice3 del rectangulo es({rectanguloUno.Vertice3.X},{rectanguloUno.Vertice3.Y})");
      Console.WriteLine($"El area del rectangulo es: {rectanguloUno.Area}");
      Console.WriteLine($"El perimetro del rectangulo es: {rectanguloUno.Perimetro}");
   
    }
  }
}
