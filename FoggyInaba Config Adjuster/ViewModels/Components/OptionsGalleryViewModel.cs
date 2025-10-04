using FoggyInabaConfig.Library.Common;
using FoggyInabaConfig.Library.Config.Options;

namespace FoggyInaba_Config_Adjuster.ViewModels.Components;

public class OptionsGalleryViewModel
{
    public OptionsGalleryViewModel(IEnumerable<ModOption> options)
    {
        this.Options = options.Where(x =>  CompareVersion(Constants.FOGGYINABA_MOD_VER, x.MinVersion)).Select(x => new OptionViewModel(x)).ToArray();
    }

    public OptionViewModel[] Options { get; }

    private bool CompareVersion(string latestVersion, string? currentVersion)
    {
        if(currentVersion == null)
        {
            return true;
        }
        else
        {
            Version latest = new Version(latestVersion.TrimStart('v'));
            Version current = new Version(currentVersion.TrimStart('v'));
            return latest >= current;
        }
    }
}
