using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Yatt.Cli.Shared;

namespace Yatt.Cli;

internal class Program
{
    public static void Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();
    }

    private static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((_, config) =>
            {
                config.AddJsonFile(DefaultConfigurationLocation.ConfigurationFilePath, optional: true, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                services.Configure<Configuration>(context.Configuration);
            });
}