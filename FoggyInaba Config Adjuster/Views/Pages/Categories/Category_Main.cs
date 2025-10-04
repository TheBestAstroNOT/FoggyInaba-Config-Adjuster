using FoggyInabaConfig.Library.Config.Sections;

namespace FoggyInaba_Config_Adjuster.Views.Pages.Categories;

public class Category_Main : CategoryView
{
    public Category_Main(ISection[] sections)
        : base(FoggyInabaConfig.Localisation.LocalisationResources.Resources.Home, sections.Where(x => x.Category == SectionCategory.MainPage).ToArray())
    {
    }
}
