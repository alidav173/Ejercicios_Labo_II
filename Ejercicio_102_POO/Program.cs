/*
Alí Ansidey DIV_E
Ejercicio 102 POO
Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

Deberá tener los atributos:

    nombre
    fechaDeNacimiento
    dni

Deberá tener un constructor que inicialice todos los atributos.

Construir los siguientes métodos para la clase:

    Setter y getter para cada uno de los atributos.
    CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
    Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
    EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.

    Instanciar 3 objetos de tipo Persona en el método Main.
    Mostrar quiénes son mayores de edad y quiénes no.



*/
namespace Ejercicio_102_POO
{
  internal class Program
  {
    static void Main(string[] args)
    {
      DateTime fechaNacUno = new DateTime(1987, 4, 13);
      Persona personaUno = new Persona("Ali Ansidey", fechaNacUno, 100000002);
      Persona.Mostrar(personaUno);
      DateTime fechaNacDos = new DateTime(2015, 4, 6);
      Persona personaDos = new Persona("Juana Azcuy", fechaNacDos, 11);
      Persona.Mostrar(personaDos);
      DateTime fechaNacTres = new DateTime(1000, 12, 25);
      Persona personaTres = new Persona("Jesus", fechaNacTres, 1);
      Persona.Mostrar(personaTres);



    }
  }
}
