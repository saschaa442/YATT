using System.Diagnostics;
using Yatt.Cli.Shared;

namespace Yatt.Cli.Features.Config;

internal sealed class ConfigCommand : IConfigCommand
{
    public void Edit()
    {
        new Process
        {
            StartInfo = new ProcessStartInfo(DefaultConfigurationLocation.ConfigurationFilePath)
                { UseShellExecute = true }
        }.Start();
    }

    public void Show()
    {
        throw new NotImplementedException();
    }
}