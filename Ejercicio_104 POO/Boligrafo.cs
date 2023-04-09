using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_104_POO
{
  internal class Boligrafo
  {
    const short cantidadMaximaTinta = 100;
    private ConsoleColor _color;
    private short _tinta;


    public ConsoleColor Color { get; set; }

    public short Tinta
    {
      get => _tinta;
      set => _tinta = value <= cantidadMaximaTinta ? value: cantidadMaximaTinta;
    }



    public Boligrafo(short tinta, ConsoleColor color)
    {
      this.Tinta = tinta;
      this.Color = color;
    }

    private void SetTinta(short tinta)
    {
 
      if(tinta >= 0)
      {
        Tinta = tinta;
      }
        
    }

    public void Recargar()
    {
      Tinta = cantidadMaximaTinta;
    }

    public bool Pintar(short gasto, out string dibujo)
    {
      bool bandera = false;
      int diferencia = 0;
      StringBuilder sb = new StringBuilder("",50);

      if(Tinta > 0)
      {
        diferencia = Tinta - gasto;
        if (diferencia > 0)
        {
          for (int i = 1; i < gasto + 1; i++)
          {
            sb.Append("*");
          }
          SetTinta((short)diferencia);

        }

        else if (diferencia <= 0)
        {
          for (int j = 1; j < Tinta + 1; j++)
          {
            sb.Append("*");
          }
     
          SetTinta(0);
        }
        bandera = true;
      }
     
      else if(Tinta == 0 | gasto == 0)
      {
        sb.Append("");
      }
      Console.ForegroundColor = Color;
      dibujo = sb.ToString();

      return bandera;
    }


  }
}
 
