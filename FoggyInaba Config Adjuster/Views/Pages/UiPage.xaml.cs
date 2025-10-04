using FoggyInaba_Config_Adjuster.ViewModels.Pages;
using FoggyInabaConfig.Library.Config;
using System.Windows.Controls;

namespace FoggyInaba_Config_Adjuster.Views.Pages;

/// <summary>
/// Interaction logic for UiPage.xaml
/// </summary>
public partial class UiPage : UserControl
{
    public UiPage(UiPageViewModel vm)
    {
        InitializeComponent();
        this.DataContext = vm;
    }
}
