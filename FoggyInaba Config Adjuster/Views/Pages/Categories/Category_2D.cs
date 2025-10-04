using FoggyInabaConfig.Library.Config.Sections;

namespace FoggyInaba_Config_Adjuster.Views.Pages.Categories;

public class Category_2D : CategoryView
{
    public Category_2D(ISection[] sections)
        : base("2D", sections.Where(x => x.Category == SectionCategory.TwoD).ToArray())
    {
    }
}
