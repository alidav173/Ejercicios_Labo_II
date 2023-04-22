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
  public partial class Login : Form
  {
    public Login()
    {
      InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

    private void Login_Load(object sender, EventArgs e)
    {

    }

    private void boton_Login_Click(object sender, EventArgs e)
    {
      string nombre = textBoxUsuario.Text;
      string contraseña = textBoxContraseña.Text;
      Usuario usuarioUno;
      if (Validador.ValidarString(nombre) & Validador.ValidarString(contraseña))
      {
        usuarioUno = new Usuario(nombre, contraseña);
        if (Validador.ValidarUsuario(usuarioUno))
        {
          MessageBox.Show($"Bienvenido {usuarioUno.ToString()} ");
          this.Hide();
          Form1 form1 = new Form1();
          form1.Show();
        }
        else
        {
          MessageBox.Show("Usuario no registrado");
        }

      }
      else
      {
        MessageBox.Show("Ingrese un usuario o contraseña validos");
      }

    }

    private void textBoxContraseña_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBoxUsuario_TextChanged(object sender, EventArgs e)
    {

    }

  }
}
