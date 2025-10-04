using FoggyInabaConfig.Library.Config.Options;

namespace FoggyInabaConfig.Library.Config.Sections;

public interface ISection
{
    string Name { get; }

    SectionCategory Category { get; }

    public string Description { get; }

    ModOption[] Options { get; }
}
