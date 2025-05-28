using BStorm.Tools.Encryptions.Cryptography.Symmetric;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using Tools.Mvvm;

using Res = CustomApp.Properties.Resources;

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
            string? config = Configuration["Config"];

            if (string.IsNullOrWhiteSpace(config))
            {
                MessageBox.Show("No Config Detected");
                Current.Shutdown();
            }

            byte[] vector = Res.vector;
            byte[] key = Res.key;

            AesEncryption aesEncryption = new AesEncryption(key, vector);

            Console.WriteLine(aesEncryption.Decrypt(config!));
            Console.WriteLine(ServiceProvider.GetService<IConfiguration>());
        }
    }

}
