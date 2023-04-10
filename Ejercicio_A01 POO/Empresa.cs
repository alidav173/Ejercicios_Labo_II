using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Ejercicio_A01_POO
{

  internal class Empresa
  {
    private string _nombre;
    private Conductor[] _conductores;

    public string Nombre
      {
      get => _nombre;
      set { _nombre = value !="" ? value:"Empresa"; }
      }

    public Conductor[] Conductores
    {
      get => _conductores;
      set
      {
        _conductores = value;
      }
    }

    public Empresa(string nombreEmpresa, Conductor[] listaConductores)
    {
      Nombre = nombreEmpresa;
      Conductores = listaConductores;
    }

    public string CalcularConductorMasKm(Conductor[] listaConductores)
    {
      string conductoMasKm="None";
      int sumaKm = 0;
      int maxKm = 0;

      foreach(Conductor conductorAux in listaConductores)
      {

        sumaKm=  conductorAux.KmPorDia.Sum();
        
        if(sumaKm > maxKm)
        {
          maxKm = sumaKm;
          conductoMasKm = conductorAux.Nombre;
        }
      }
      return conductoMasKm;

    }


    public string CalcularConductorMasKmDiaCualquiera(Conductor[] listaConductores, int dia)
    {
      string conductoMasKm = "None";
      int diaSemana = dia - 1;
      int kmDiaCualquiera = 0;
      int maxKm = 0;

      foreach (Conductor conductorAux in listaConductores)
      {

        kmDiaCualquiera = conductorAux.KmPorDia[diaSemana];

        if (kmDiaCualquiera > maxKm)
        {
          maxKm = kmDiaCualquiera;
          conductoMasKm = conductorAux.Nombre;
        }
      }
      return conductoMasKm;

    }


  }

}
