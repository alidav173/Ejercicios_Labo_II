namespace Practica_Login_Winform
{
  partial class Login
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
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.boton_Login = new System.Windows.Forms.Button();
            this.label_usuario = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(104, 76);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(121, 23);
            this.textBoxUsuario.TabIndex = 0;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(104, 126);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(121, 23);
            this.textBoxContraseña.TabIndex = 1;
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBoxContraseña_TextChanged);
            // 
            // boton_Login
            // 
            this.boton_Login.Location = new System.Drawing.Point(128, 185);
            this.boton_Login.Name = "boton_Login";
            this.boton_Login.Size = new System.Drawing.Size(75, 23);
            this.boton_Login.TabIndex = 2;
            this.boton_Login.Text = "Login";
            this.boton_Login.UseVisualStyleBackColor = true;
            this.boton_Login.Click += new System.EventHandler(this.boton_Login_Click);
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Location = new System.Drawing.Point(107, 57);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(47, 15);
            this.label_usuario.TabIndex = 3;
            this.label_usuario.Text = "Usuario";
            this.label_usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(107, 108);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(67, 15);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Contraseña";
            this.label_password.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 244);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.boton_Login);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox textBoxUsuario;
    private TextBox textBoxContraseña;
    private Button boton_Login;
    private Label label_usuario;
    private Label label_password;
  }
}