using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.Metrics;

namespace WinFormsBlazorDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
            blazorWebViewDeleteAllFiles.HostPage = "wwwroot\\index.html";
            blazorWebViewDeleteAllFiles.Services = services.BuildServiceProvider();
            blazorWebViewDeleteAllFiles.RootComponents.Add<DeleteAllFiles>("#app");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}