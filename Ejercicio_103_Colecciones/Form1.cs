using Ejercicio_103_Colecciones.Biblioteca;

namespace Ejercicio_103_Colecciones
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {
     
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string text = richTextBox1.Text;
      ContadorPalabras cPalabras = new ContadorPalabras(text);
      MessageBox.Show(cPalabras.MostrarTopResultados(3));

      
    }
  }
}
