using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_A01_POO
{
  internal class Conductor
  {
    private string _nombre;
    private int[] _kmPorDia;

    public string Nombre
    {
      get => _nombre;
      set => _nombre = value != "" ? value : "Conductor";
    }

    public int[] KmPorDia{ get; set;}

    public Conductor(string nombre, int[] kmPorDiaCond)
    {
      Nombre = nombre;
      KmPorDia = kmPorDiaCond;
    }
  }
}
