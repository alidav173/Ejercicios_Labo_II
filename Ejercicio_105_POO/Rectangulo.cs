using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
  internal class Rectangulo
  {
    private float _area;
    private float _perimetro;
    private Punto _vertice1;
    private Punto _vertice2;
    private Punto _vertice3;
    private Punto _vertice4;

    public Punto Vertice1
    {
      get => _vertice1;
      set => _vertice1 = value;
    }

    public Punto Vertice3
    {
      get => _vertice3;
      set => _vertice3 = value;
    }

    public Punto Vertice2
    {
      get => _vertice2;
      set => _vertice2 = value;
    }

    public Punto Vertice4
    {
      get => _vertice4;
      set => _vertice4 = value;
    }

    public Rectangulo(Punto vertice1, Punto vertice3)
    {
      if(vertice1 != null & vertice3 != null)
      {
        Vertice1 = vertice1;
        Vertice3 = vertice3;
        Punto vertice2 = new Punto(Vertice3.X, Vertice1.Y);
        Vertice2 = vertice2;
        Punto vertice4 = new Punto(Vertice1.X, Vertice3.Y);
        Vertice4 = vertice4;
      }
    }


    public float Area
    {
      get
      {
        return _area = Math.Abs(Vertice3.X - Vertice1.X) * Math.Abs(Vertice3.Y - Vertice1.Y);
      }

    }

    public float Perimetro
    {
      get
      {
       return _perimetro = Area / 2;
      }
    }

  
}
}
