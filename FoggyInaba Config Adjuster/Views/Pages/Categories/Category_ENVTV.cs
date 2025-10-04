using FoggyInabaConfig.Library.Config.Sections;
using FoggyInabaConfig.Localisation.LocalisationResources;

namespace FoggyInaba_Config_Adjuster.Views.Pages.Categories;

public class Category_ENVTV : CategoryView
{
    public Category_ENVTV(ISection[] sections)
        : base("ENV - TV World", sections.Where(x => x.Category == SectionCategory.ENVTV).ToArray())
    {
    }
}
