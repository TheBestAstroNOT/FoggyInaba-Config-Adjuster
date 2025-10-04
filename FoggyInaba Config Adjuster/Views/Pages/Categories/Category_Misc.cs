using FoggyInabaConfig.Library.Config.Sections;

namespace FoggyInaba_Config_Adjuster.Views.Pages.Categories;

internal class Category_Misc : CategoryView
{
    public Category_Misc(ISection[] sections)
        : base(/*FoggyInabaConfig.Localisation.LocalisationResources.Resources.Misc*/"Misc", sections.Where(x => x.Category == SectionCategory.Misc).ToArray())
    {
    }
}
