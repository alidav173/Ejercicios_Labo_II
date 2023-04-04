using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_101_POO
{
  internal class Cuenta
  {
    public string titular;
    public double cantidad;

    public Cuenta(string titular, double cantidad)
    {
      this.titular = titular;
      this.cantidad = cantidad;
    }

    public string GetTitular()
    {
      return this.titular;
    }

    public double GetCantidad()
    {
      return this.cantidad;
    }

    private double SetCantidad(double monto)
    {
      return this.cantidad +=monto;
    }

    public void Mostrar()
    {
      string titular = GetTitular();
      double cantidad = GetCantidad();
      StringBuilder sb = new StringBuilder($"El nombre del titular es {titular} y tiene depositado {cantidad} pesos: ",100);
      Console.WriteLine(sb);
    }

    public double Ingresar(double monto)
    {
      double retorno = GetCantidad();
      if (monto > 0)
      {
        retorno = SetCantidad(monto);
      }
      return retorno;
    }

    public double Retirar(double monto)
    {
      double cantidad = GetCantidad();
      if(monto >0 && cantidad > 0)
      {
        cantidad -= monto;
        SetCantidad(cantidad);
      }
      return cantidad;
    }
  }
}
