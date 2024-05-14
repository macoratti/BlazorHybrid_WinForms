namespace WinformsBlazorHybrid;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnContador_Click(object sender, EventArgs e)
    {
        Form3 form3 = new Form3();
        form3.Show();
    }

    private void btnCalculaFatorial_Click(object sender, EventArgs e)
    {
        Form2 form2 = new Form2();
        form2.Show();
    }

    private void btnEncerrar_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }    
}
