using FoggyInabaConfig.Library.Config.Sections;

namespace FoggyInaba_Config_Adjuster.Views.Pages.Categories;

public class Category_ENVINABA : CategoryView
{
    public Category_ENVINABA(ISection[] sections)
        : base("ENV - Inaba", sections.Where(x => x.Category == SectionCategory.ENVINABA).ToArray())
    {
    }
}
