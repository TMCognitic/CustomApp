using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using Tools.Mvvm;

namespace CustomApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : OptecApp
    {
        protected override void ConfigureServices(IServiceCollection services)
        {
            
        }

        public App()
        {
            Console.WriteLine(Configuration["Test"]);
            Console.WriteLine(ServiceProvider.GetService<IConfiguration>());
        }
    }

}
