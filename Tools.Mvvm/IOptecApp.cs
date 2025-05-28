using Microsoft.Extensions.Configuration;

namespace Tools.Mvvm
{
    public interface IOptecApp
    {
        IConfiguration Configuration { get; }
        IServiceProvider ServiceProvider { get; }
    }
}