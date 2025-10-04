using FoggyInabaConfig.Library.Config.Sections;

namespace FoggyInaba_Config_Adjuster.Views.Pages.Categories;

internal class Category_Field : CategoryView
{
    public Category_Field(ISection[] sections)
        : base("Field", sections.Where(x => x.Category == SectionCategory.Field).ToArray())
    {
    }
}
