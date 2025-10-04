using FoggyInabaConfig.Library.Config.Sections;

namespace FoggyInaba_Config_Adjuster.Views.Pages.Categories;

public class Category_Textures : CategoryView
{
    public Category_Textures(ISection[] sections)
        : base("Textures", sections.Where(x => x.Category == SectionCategory.Textures).ToArray())
    {
    }
}
