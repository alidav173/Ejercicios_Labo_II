using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C02_Herencia.Biblioteca
{
  internal class VehiculoDeCarrera
  {
    private short _cantidadCombustible;
    private bool _enCompetencia;
    private string _escuderia;
    private short _numero;
    private short _vueltasRestantes;

    public short CantidadCombustible { get => _cantidadCombustible; set => _cantidadCombustible = value; }
    public bool EnCompetencia { get => _enCompetencia; set => _enCompetencia = value; }
    public string Escuderia { get => _escuderia; set => _escuderia = value; }
    public short Numero { get => _numero; set => _numero = value; }
    public short VueltasRestantes { get => _vueltasRestantes; set => _vueltasRestantes = value; }

    public VehiculoDeCarrera(short numero, string escuderia)
    {
      Numero = numero;
      Escuderia = escuderia;
      EnCompetencia = false;
      CantidadCombustible = 0;
      VueltasRestantes = 0;
    }

    public virtual string MostrarDatos()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append($"Numero: {Numero}, Escuderia: {Escuderia},");

      return sb.ToString();

    }
  }
}
