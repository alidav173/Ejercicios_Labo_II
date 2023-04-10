using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_101_Sobrecarga
{
  internal class Sumador
  {
    private int _cantidadSumas;

    public int CantidadSumas
    {
      get => _cantidadSumas;
      set => _cantidadSumas = value;
    }

    public Sumador(int cantidadSumas)
    {
      CantidadSumas = cantidadSumas;
    }

    public Sumador() : this(0)
    {
    }

    public long Sumar(long a, long b)
    {
      long resultado;
      CantidadSumas += 1;
      return resultado = a + b;
    }

    public string Sumar(string a, string b)
    {
      string cadena;
      CantidadSumas += 1;
      return cadena = a + b;
    }

    public static explicit operator int(Sumador s)
    {
      return s.CantidadSumas;
    }

    public static long operator +(Sumador s1, Sumador s2)
      {
      return s1.CantidadSumas + s2.CantidadSumas;
      }

    public static bool operator |(Sumador s1, Sumador s2)
    {
      return s1.CantidadSumas == s2.CantidadSumas;
    }


  }
}
