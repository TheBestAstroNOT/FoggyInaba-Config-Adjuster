using FoggyInaba_Config_Adjuster.ViewModels.Components;
using FoggyInaba_Config_Adjuster.ViewModels.Windows;
using FoggyInaba_Config_Adjuster.Views.Windows;
using FoggyInabaConfig.Library.Config.Sections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace FoggyInaba_Config_Adjuster.Views.Components;

/// <summary>
/// Interaction logic for OptionView.xaml
/// </summary>
public partial class OptionView : UserControl
{
    public OptionView()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        if (this.DataContext is OptionViewModel optionViewModel)
        {
            var previewWindow = new PreviewWindow()
            {
                DataContext = new PreviewWindowViewModel(optionViewModel.Option),
            };

            previewWindow.ShowDialog();
        }
    }
}
