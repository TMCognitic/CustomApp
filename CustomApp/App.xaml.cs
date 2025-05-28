using BStorm.Tools.Encryptions.Cryptography.Symmetric;
using CustomApp.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Text.Json;
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
            string? cypher = Configuration["Config"];

            if (string.IsNullOrWhiteSpace(cypher))
            {
                MessageBox.Show("No Config Detected");
                Current.Shutdown();
            }

            byte[] vector = Res.vector;
            byte[] key = Res.key;

            AesEncryption aesEncryption = new AesEncryption(key, vector);
            string config = aesEncryption.Decrypt(cypher!);

            Config _config = JsonSerializer.Deserialize<Config>(config, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true })!;


            Console.WriteLine(cypher);
            Console.WriteLine(config);
            Console.WriteLine(_config.Option1);
            Console.WriteLine(_config.Option2);
            
        }
    }

}
