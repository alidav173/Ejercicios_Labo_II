using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_102_WindowsForms
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();

    }

    public void MostrarMensaje(string cadena)
    {
      textBox1.Text = cadena;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Form2_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
  }
}
