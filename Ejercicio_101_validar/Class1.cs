using System;

public class Validador
{
  static public bool Validar(int valor, int min, int max)
  {
    bool bandera = false;
    if (valor >= min || valor <= max)
    {
      bandera = true;
    }
    return bandera;
  }
}
