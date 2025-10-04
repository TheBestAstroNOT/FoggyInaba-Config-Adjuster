using FoggyInabaConfig.Library.Config.Sections;
using FoggyInabaConfig.Localisation.LocalisationResources;

namespace FoggyInaba_Config_Adjuster.Views.Pages.Categories;

public class Category_Audio : CategoryView
{
    public Category_Audio(ISection[] sections)
        : base(FoggyInabaConfig.Localisation.LocalisationResources.Resources.Audio, sections.Where(x => x.Category == SectionCategory.Audio).ToArray())
    {
    }
}
