namespace Yatt.Cli.Shared;

internal static class DefaultConfigurationLocation
{
    internal const string ConfigurationFileName = "yatt.json";
    internal static readonly string ConfigurationFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),".yatt", "config.json");
}