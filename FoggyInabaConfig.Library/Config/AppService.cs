using CommunityToolkit.Mvvm.ComponentModel;
using FoggyInabaConfig.Library.Common;
using FoggyInabaConfig.Library.Config.Models;
using FoggyInabaConfig.Library.Utils;

namespace FoggyInabaConfig.Library.Config;

public class AppService
{
    private AppContext? appContext;
    private readonly SavableFile<AppData> appData;

    public AppService()
    {
        var appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        this.AppDataDir = Path.Join(appDataDir, "FemcConfigAdjuster");
        Directory.CreateDirectory(this.AppDataDir);

        var appDataFile = Path.Join(this.AppDataDir, "femc.json");
        this.appData = new(appDataFile);

        try
        {
            this.AutoInit();
        }
        catch (Exception) { }
    }

    public string AppDataDir { get; }

    public AppContext GetContext()
        => this.appContext ?? throw new Exception("App context not set.");

    public void Initialize(string reloadedDir)
    {
        //VERY IMPORTANT PLEASE UPDATE EVERY TIME TO MATCH LATEST FEMC MOD VERSION

        this.appData.Settings.ReloadedDir = reloadedDir;
        if (reloadedDir is null)
            throw new Exception("Reloaded Directory not found");
        var appConfigFile = Path.Join(reloadedDir, "Apps", "p4g.exe", "AppConfig.json");
        if (!File.Exists(appConfigFile))
        {
            throw new Exception("Failed to find Reloaded app config.");
        }

        var appConfig = new SavableFile<ReloadedAppConfig>(appConfigFile);
        var reloadedModsDir = Path.Join(reloadedDir, "Mods");

        // Verify FEMC mod install dir.
        // Manually search for FEMC DLL since folder name isn't constant.
        string? foggyInabaDir = null;
        foreach (var dir in Directory.EnumerateDirectories(reloadedModsDir))
        {
            var foggyInabaDll = Path.Join(dir, Constants.FOGGYINABA_MOD_ID+".dll");
            if (File.Exists(foggyInabaDll))
            {
                foggyInabaDir = dir;
                break;
            }
        }

        // Find FEMC mod config file.
        var reloadedConfigsDir = Path.Join(reloadedDir, "User", "Mods");
        string? foggyInabaConfigFile = null;
        string? foggyInabaModConfigFile = null;
        foreach (var configDir in Directory.EnumerateDirectories(reloadedConfigsDir))
        {
            Console.WriteLine(configDir);
            var userConfigFile = Path.Join(configDir, "ModUserConfig.json");
            var userConfig = File.Exists(userConfigFile) ? JsonUtils.DeserializeFile<ReloadedModUserConfig>(userConfigFile) : null;

            if (userConfig is not null)
            {
                if(userConfig.ModId == Constants.FOGGYINABA_MOD_ID)
                {
                    foggyInabaConfigFile = Path.Join(configDir, "Config.json");
                    foggyInabaModConfigFile = Path.Join(reloadedModsDir, Constants.FOGGYINABA_MOD_ID, "ModConfig.json");
                    break;
                }
            }
        }

        if (foggyInabaConfigFile == null || File.Exists(foggyInabaConfigFile) == false)
        {
            throw new FoggyInabaNotFound();
        }

        string foggyInabaModVersionStatus = "NotExecError";
        string? foggyInabaModVersion = null;
        //Check mod version.
        if (File.Exists(foggyInabaModConfigFile))
        {
            foggyInabaModVersion = JsonUtils.DeserializeFile<ModInfo>(foggyInabaModConfigFile).ModVersion;
            if (foggyInabaModVersion == Constants.FOGGYINABA_MOD_VER)
            {
                foggyInabaModVersionStatus = "SUPPORTED";
            }
            else
            {
                foggyInabaModVersionStatus = "UNSUPPORTED";
            }
        }
        else
        {
            foggyInabaModVersionStatus = "404FILENOTFOUND";
        }

        // Setup mod context.
        this.appContext = new()
        {
            ReloadedDir = reloadedDir,
            ModDir = foggyInabaDir,
            ReloadedAppConfig = appConfig,
            FemcConfig = Directory.Exists(foggyInabaDir) ? new(foggyInabaConfigFile) : null,
            FoggyInabaModVersion = foggyInabaModVersionStatus,
        };
    }

    // Automatically initialize by fetching Reloaded path from
    // ENV var.
    private void AutoInit()
    {
        if (this.appData.Settings.ReloadedDir != null)
        {
            this.Initialize(this.appData.Settings.ReloadedDir);
        }

        else if (Environment.GetEnvironmentVariable("RELOADEDIIMODS") is string reloadedModsDir)
        {
            var reloadedDir = Path.GetDirectoryName(reloadedModsDir)!;
            this.Initialize(reloadedDir);
        }
    }
}

public class FoggyInabaNotFound : Exception
{
    public FoggyInabaNotFound() : base("Failed to find FEMC config file. Please launch the game once with the mod enabled.")
    {
    }
}

public partial class AppData : ObservableObject
{
    [ObservableProperty]
    public string? reloadedDir;
}

public class ModInfo
{
    public string ModVersion { get; set; }
}