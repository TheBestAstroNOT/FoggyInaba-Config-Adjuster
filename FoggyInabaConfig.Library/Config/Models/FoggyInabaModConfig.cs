using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FoggyInabaConfig.Library.Config.Models;

/// <summary>
/// Should match Config.cs from FEMC mod:
/// https://github.com/MadMax1960/Femc-Reloaded-Project/blob/main/code/p3rpc.femc/p3rpc.femc/Config.cs
/// </summary>
public partial class FoggyInabaModConfig : ObservableObject
{
    public enum ENVTypeA
{
    [Display(Name = "P4 Fog Restoration")]
    P4,
    [Display(Name = "Stock P4G")]
    Stock,
}

public enum TexTypeA
{
    [Display(Name = "P4 Fog Restoration")]
    P4,
    [Display(Name = "Stock P4G")]
    Stock,
}

// ===============================
// Misc
// ===============================

[Category("Misc")]
[Display(Order = 0)]
[Description("If enabled, causes additional information that may be useful for debugging to be logged.")]
[DefaultValue(false)]
[ObservableProperty]
private bool debugEnabled = false;

// ===============================
// Texture Selection
// ===============================

[Category("Texture Selection")]
[Display(Order = 1)]
[Description("Select whether to apply P4-style TV static or not.\n\nP4: Uses the P4-style TV static.\nStock: Uses the stock P4G TV static. Select this if using No TV Static 64.")]
[DefaultValue(TexTypeA.P4)]
[ObservableProperty]
private TexTypeA staticENV = TexTypeA.P4;

[Category("Texture Selection")]
[Display(Order = 2)]
[Description("Select whether to apply P4-style fog or use the more \"stringy\" fog texture from P4G.\n\nP4: Uses the P4-style fog.\nStock: Uses the stock P4G fog.")]
[DefaultValue(TexTypeA.P4)]
[ObservableProperty]
private TexTypeA fogENV = TexTypeA.P4;

// ===============================
// ENV Selection - Inaba
// ===============================

[Category("ENV Selection - Inaba")]
[Display(Order = 3)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA townMapENV = ENVTypeA.P4;

[Category("ENV Selection - Inaba")]
[Display(Order = 4)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA yasogamiENV = ENVTypeA.P4;

[Category("ENV Selection - Inaba")]
[Display(Order = 5)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA dojimaENV = ENVTypeA.P4;

[Category("ENV Selection - Inaba")]
[Display(Order = 6)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA shoppingDistrictENV = ENVTypeA.P4;

[Category("ENV Selection - Inaba")]
[Display(Order = 7)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA samegawaENV = ENVTypeA.P4;

[Category("ENV Selection - Inaba")]
[Display(Order = 8)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA junesENV = ENVTypeA.P4;

[Category("ENV Selection - Inaba")]
[Display(Order = 9)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA okinaENV = ENVTypeA.P4;

[Category("ENV Selection - Inaba")]
[Display(Order = 10)]
[Description("Select what visuals to use for areas like the hospital, police station, etc.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA miscENV = ENVTypeA.P4;

// ===============================
// ENV Selection - TV World
// ===============================

[Category("ENV Selection - TV World")]
[Display(Order = 11)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA velvetENV = ENVTypeA.P4;

[Category("ENV Selection - TV World")]
[Display(Order = 12)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA entranceENV = ENVTypeA.P4;

[Category("ENV Selection - TV World")]
[Display(Order = 13)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA bedroomENV = ENVTypeA.P4;

// ===============================
// ENV Selection - Dungeons
// ===============================

[Category("ENV Selection - Dungeons")]
[Display(Order = 14)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA dreamENV = ENVTypeA.P4;

[Category("ENV Selection - Dungeons")]
[Display(Order = 15)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA twistedENV = ENVTypeA.P4;

[Category("ENV Selection - Dungeons")]
[Display(Order = 16)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA konishiENV = ENVTypeA.P4;

[Category("ENV Selection - Dungeons")]
[Display(Order = 17)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA castleENV = ENVTypeA.P4;

[Category("ENV Selection - Dungeons")]
[Display(Order = 18)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA saunaENV = ENVTypeA.P4;

[Category("ENV Selection - Dungeons")]
[Display(Order = 19)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA clubENV = ENVTypeA.P4;

[Category("ENV Selection - Dungeons")]
[Display(Order = 20)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA gameENV = ENVTypeA.P4;

[Category("ENV Selection - Dungeons")]
[Display(Order = 21)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA labENV = ENVTypeA.P4;

[Category("ENV Selection - Dungeons")]
[Display(Order = 22)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA heavenENV = ENVTypeA.P4;

[Category("ENV Selection - Dungeons")]
[Display(Order = 23)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA magatsuENV = ENVTypeA.P4;

[Category("ENV Selection - Dungeons")]
[Display(Order = 24)]
[Description("Select what visuals to use for this area.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA yomotsuENV = ENVTypeA.P4;

[Category("ENV Selection - Dungeons")]
[Display(Order = 25)]
[Description("Select what visuals to use for this area.\n\nNOTE: Since the Hollow Forest is P4G exclusive, if \"P4 Visuals\" is selected, the\nvisuals will have slightly reduced contrast to fit better with the other fields in this mod.")]
[DefaultValue(ENVTypeA.P4)]
[ObservableProperty]
private ENVTypeA hollowENV = ENVTypeA.P4;

// ===============================
// Fields Imports and Other Models
// ===============================

[Category("Fields Imports and Other Models")]
[Display(Order = 26)]
[Description("Adds power line models to fields that had them in P4 but not P4G. yeah")]
[DefaultValue(true)]
[ObservableProperty]
private bool powerLinesTwitterLoves = true;

}