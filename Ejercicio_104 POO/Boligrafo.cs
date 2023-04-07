using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_104_POO
{
  internal class Boligrafo
  {
    private short cantidadMaximaTinta;
    private ConsoleColor color;
    private short tinta;

    public Boligrafo(short tinta, ConsoleColor color)
    {
      this.tinta = tinta;
      this.color = color;
    }
  }
}
 
