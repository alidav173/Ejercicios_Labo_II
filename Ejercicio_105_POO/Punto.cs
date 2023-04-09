using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
  internal class Punto
  {
    private int _x;
    private int _y;

    public int X {
      get=> _x;
    }

    public int Y {
      get => _y;
    }

    public Punto(int x, int y)
    {
      _x = x;
      _y = y;
    }



  }
}
