using Ejercicio_102_WindowsForms.Biblioteca;

namespace Ejercicio_102_WindowsForms
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void groupBox2_Enter(object sender, EventArgs e)
    {

    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      string nombre = "";
      string direccion = "";
      if (Validador.ValidarCadena(textBox1.Text))
      {
        nombre = textBox1.Text;
      }

      if (Validador.ValidarCadena(textBox1.Text))
      {
        direccion = textBox2.Text;
      }

      string pais = listBox1.SelectedItem.ToString();

      int edad = (int)numericUpDown1.Value;

      string genero = RadioButtonSeleccionado();

      string[] array = CheckBoxSeleccionado();

      Ingresante ingresanteUno = new Ingresante(nombre, direccion, genero, pais, array,edad);

      string infoIngresante = ingresanteUno.Mostrar();

      Form2 f2 = new Form2();
      f2.Show();
      f2.MostrarMensaje(infoIngresante);
    }


    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private string RadioButtonSeleccionado()
    {
      string cadena = "";
      for (int i = 0; i < groupBox2.Controls.Count; i++)
      {
        if (((RadioButton)groupBox2.Controls[i]).Checked)
          cadena = ((RadioButton)groupBox2.Controls[i]).Text;
      }
      return cadena;
    }

    private string[] CheckBoxSeleccionado()
    {
      string[] array = {"","",""};
      string cadena="";
      int j = 0;
      for (int i = 0; i < groupBox3.Controls.Count; i++)
      {
        if (((CheckBox)groupBox3.Controls[i]).Checked)
          cadena = ((CheckBox)groupBox3.Controls[i]).Text;
            array[j] = cadena;
        j++;
      }
      return array;
    }
  }
}

