using FoggyInabaConfig.Library.Config.Sections;

namespace FoggyInaba_Config_Adjuster.Views.Pages.Categories;

internal class Category_UI : CategoryView
{
    public Category_UI(ISection[] sections)
        : base(FoggyInabaConfig.Localisation.LocalisationResources.Resources.UI, sections.Where(x => x.Category == SectionCategory.UI).ToArray())
    {
    }
}
