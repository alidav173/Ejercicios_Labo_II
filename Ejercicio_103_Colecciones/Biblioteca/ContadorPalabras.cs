using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicio_103_Colecciones.Biblioteca
{
  internal class ContadorPalabras
  {
    private Dictionary<string, int> _dicccionario = new Dictionary<string, int>();


    public Dictionary<string, int> Diccionario
    {
      get => _dicccionario;
      set => _dicccionario = value;
    }

    public ContadorPalabras(string text)
    {
      
      string[] palabras = SepararTexto(text);

      foreach (string palabra in palabras)
      {
        if (palabra != null & palabra !="")
        {

          if (Diccionario.ContainsKey(palabra))
          {
            int contador = 0;
            Diccionario.TryGetValue(palabra,out contador);
            Diccionario[palabra] = contador+1;

          }
          else
          {
            Diccionario.Add(palabra,1);
          }

        }

      }

    }

    private string[] SepararTexto(string texto)
    {
      string[] palabras = { };
      char[] delimitadores = { ' ', ',', '.', ':', '\t','\n'};
      if (texto != null)
      {
        palabras = texto.Split(delimitadores);
      }

      return palabras;
    }

    public string MostrarDiccionario(int cantidadTop)
    {
      StringBuilder sb = new StringBuilder();
      var diccionario = Diccionario.Skip(0).Take(cantidadTop).ToDictionary(pair => pair.Key, pair => pair.Value);
      string cadena = "";
      sb.AppendLine($"Top {cantidadTop} de palabras: ");
        foreach (KeyValuePair<string, int> ele in diccionario)
        {
          sb.AppendLine($" Palabra: {ele.Key}, Cantidad: {ele.Value}");
        
        }
      
      cadena = sb.ToString();

      return cadena;
    }

    public string MostrarTopResultados(int cantidadTop)
    {
      Diccionario = Diccionario.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
     return MostrarDiccionario(cantidadTop);
    }


  }
}
