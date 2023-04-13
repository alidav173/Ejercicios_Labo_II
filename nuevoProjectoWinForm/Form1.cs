using nuevoProjectoWinForm.Biblioteca;
using System.Text;

namespace nuevoProjectoWinForm
{
  public partial class Form1 : Form
  {
    Listado listado = new Listado();
    public Form1()
    {
      InitializeComponent();

    }

    private void CerrarFormulario()
    {
      this.Close();
    }


    private void lbl_titulo_Click(object sender, EventArgs e)
    {
      
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string nombre = textBox1.Text;
      string legajo = textBox2.Text;
      int legajo2;
      int.TryParse(legajo,out legajo2);

    
      var personaNueva = new Persona(nombre,legajo2);
      listado.AgregarPersona(personaNueva);

      textBox1.Clear();
      textBox2.Clear();
  
      //StringBuilder sb = new StringBuilder();
      //sb.Append($"{personaNueva.Nombre} {personaNueva.Legajo}");
      //lbl_titulo.Text = sb.ToString();


     // CerrarFormulario();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      CerrarFormulario();
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
     
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
      textBox3.Text = listado.MostrarListado(listado.ListadoP);
    }
  }
}
