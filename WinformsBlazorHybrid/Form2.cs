using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using RazorLibrary;

namespace WinformsBlazorHybrid;

public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();
        var services = new ServiceCollection();
        services.AddWindowsFormsBlazorWebView();
        blazorWebView1.HostPage = "wwwroot\\index.html";
        blazorWebView1.Services = services.BuildServiceProvider();
        blazorWebView1.RootComponents.Add<Fatorial>("#app");
    }

    private void btnRetornar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
