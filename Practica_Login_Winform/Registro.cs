using Practica_Login_Winform.Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Login_Winform
{
  public partial class Registro : Form
  {
    public Registro()
    {
      InitializeComponent();
    }

    private void Registro_Load(object sender, EventArgs e)
    {
      this.IsMdiContainer = true;

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void boton_Registrar_Click(object sender, EventArgs e)
    {
      string nombre = textBox1.Text;
      string contraseña = textBox2.Text;
      string contraseña2 = textBox3.Text;
      Usuario usuarioUno;
      if (Validador.ValidarString(nombre) & Validador.ValidarString(contraseña) & Validador.ValidarString(contraseña2))
      {
        usuarioUno = new Usuario(nombre, contraseña);
        if (usuarioUno is not null & contraseña == contraseña2)
        {
          MessageBox.Show($"Hola nuevo usuario: {usuarioUno.ToString()} ");
          this.Close();
          Form1 form1 = new Form1();
          form1.Show();
        }
        else if (contraseña != contraseña2 && usuarioUno is not null)
        {
          MessageBox.Show("Las contraseñas deben coincidir");
        }

        else if (usuarioUno is not null && contraseña == contraseña2)
        {
          MessageBox.Show("Ingrese un usuario valido");
        }

      
      }
      else
      {
        MessageBox.Show("Ingrese todos los datos para el registro");
      }
    }
  }
}
