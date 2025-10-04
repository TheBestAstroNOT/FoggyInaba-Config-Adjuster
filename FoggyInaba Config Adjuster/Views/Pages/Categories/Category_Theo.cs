using FoggyInabaConfig.Library.Config.Sections;

namespace FoggyInaba_Config_Adjuster.Views.Pages.Categories;


public class Category_Theo : CategoryView
{
	public Category_Theo(ISection[] sections)
		: base(FoggyInabaConfig.Localisation.LocalisationResources.Resources.Theo, sections.Where(x => x.Category == SectionCategory.Theo).ToArray())
	{
	}
}
