using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace Tools.Mvvm
{
    public abstract class OptecApp : Application, IOptecApp
    {
        public IServiceProvider ServiceProvider { get; }
        public IConfiguration Configuration { get; }

        protected OptecApp()
        {
            IServiceCollection services = new ServiceCollection();
            ConfigureServices(services);

            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            services.AddSingleton(Configuration);
            ServiceProvider = services.BuildServiceProvider();
        }

        protected abstract void ConfigureServices(IServiceCollection services);
    }
}
