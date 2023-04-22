namespace Practica_Login_Winform
{
  partial class Registro
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.et_Nombre = new System.Windows.Forms.Label();
            this.et_Contraseña = new System.Windows.Forms.Label();
            this.et_Contraseña_2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.boton_Registrar = new System.Windows.Forms.Button();
            this.boton_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Ingrese su usuario";
            this.textBox1.Size = new System.Drawing.Size(130, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(55, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Ingrese su contraseña";
            this.textBox2.Size = new System.Drawing.Size(130, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // et_Nombre
            // 
            this.et_Nombre.AutoSize = true;
            this.et_Nombre.Location = new System.Drawing.Point(60, 20);
            this.et_Nombre.Name = "et_Nombre";
            this.et_Nombre.Size = new System.Drawing.Size(47, 15);
            this.et_Nombre.TabIndex = 2;
            this.et_Nombre.Text = "Usuario";
            this.et_Nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // et_Contraseña
            // 
            this.et_Contraseña.AutoSize = true;
            this.et_Contraseña.Location = new System.Drawing.Point(60, 79);
            this.et_Contraseña.Name = "et_Contraseña";
            this.et_Contraseña.Size = new System.Drawing.Size(67, 15);
            this.et_Contraseña.TabIndex = 3;
            this.et_Contraseña.Text = "Contraseña";
            this.et_Contraseña.Click += new System.EventHandler(this.label2_Click);
            // 
            // et_Contraseña_2
            // 
            this.et_Contraseña_2.AutoSize = true;
            this.et_Contraseña_2.Location = new System.Drawing.Point(60, 139);
            this.et_Contraseña_2.Name = "et_Contraseña_2";
            this.et_Contraseña_2.Size = new System.Drawing.Size(63, 15);
            this.et_Contraseña_2.TabIndex = 5;
            this.et_Contraseña_2.Text = "Contaseña";
            this.et_Contraseña_2.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(55, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Reingrese su contraseña";
            this.textBox3.Size = new System.Drawing.Size(130, 23);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // boton_Registrar
            // 
            this.boton_Registrar.Location = new System.Drawing.Point(32, 224);
            this.boton_Registrar.Name = "boton_Registrar";
            this.boton_Registrar.Size = new System.Drawing.Size(75, 23);
            this.boton_Registrar.TabIndex = 6;
            this.boton_Registrar.Text = "Registrar";
            this.boton_Registrar.UseVisualStyleBackColor = true;
            this.boton_Registrar.Click += new System.EventHandler(this.boton_Registrar_Click);
            // 
            // boton_Cancelar
            // 
            this.boton_Cancelar.Location = new System.Drawing.Point(149, 224);
            this.boton_Cancelar.Name = "boton_Cancelar";
            this.boton_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.boton_Cancelar.TabIndex = 7;
            this.boton_Cancelar.Text = "Cancelar";
            this.boton_Cancelar.UseVisualStyleBackColor = true;
            this.boton_Cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 282);
            this.Controls.Add(this.boton_Cancelar);
            this.Controls.Add(this.boton_Registrar);
            this.Controls.Add(this.et_Contraseña_2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.et_Contraseña);
            this.Controls.Add(this.et_Nombre);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox textBox1;
    private TextBox textBox2;
    private Label et_Nombre;
    private Label et_Contraseña;
    private Label et_Contraseña_2;
    private TextBox textBox3;
    private Button boton_Registrar;
    private Button boton_Cancelar;
  }
}