namespace Practica_Login_Winform
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.IsMdiContainer = true;
    }


    private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
    
    }

    private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
    {

    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void registroToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Registro registro = new Registro();
      registro.Show();
      this.Close();
    }

    private void loginToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Login login = new Login();
      login.Show();
    }
  }
}
