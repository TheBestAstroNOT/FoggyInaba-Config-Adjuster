using FoggyInaba_Config_Adjuster.ViewModels.Pages;
using FoggyInabaConfig.Library.Config.Sections;
using System.Windows.Controls;

namespace FoggyInaba_Config_Adjuster.Views.Pages.Categories;

/// <summary>
/// Interaction logic for CategoryView.xaml
/// </summary>
public partial class CategoryView : UserControl
{
    public CategoryView(string name, ISection[] sections)
    {
        InitializeComponent();
        this.DataContext = new CategoryViewModel(name, sections);
    }
}
