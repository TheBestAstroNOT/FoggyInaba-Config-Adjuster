using FoggyInabaConfig.Library.Config.Models;

namespace FoggyInabaConfig.Library.Config;

public class AppContext
{
    public string AppDir { get; } = AppDomain.CurrentDomain.BaseDirectory;

    public required string ReloadedDir { get; init; }

    public required string ModDir { get; init; }

    public required SavableFile<FoggyInabaModConfig> FoggyInabaConfig { get; init; }

    public required string FoggyInabaModVersion { get; init; }

    public required SavableFile<ReloadedAppConfig> ReloadedAppConfig { get; init; }
}
