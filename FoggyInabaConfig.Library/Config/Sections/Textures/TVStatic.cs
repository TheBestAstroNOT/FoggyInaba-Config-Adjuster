using FoggyInabaConfig.Library.Config.Options;

namespace FoggyInabaConfig.Library.Config.Sections;

public class TVStatic : ISection
{
    public string Name { get; } = "TV Static";

    public string Description { get; } = "TV Static Dummy Desc";

    public SectionCategory Category { get; } = SectionCategory.Textures;

    public ModOption[] Options { get; }

    public TVStatic(AppService app)
    {
        var ctx = app.GetContext();
        this.Options =
        [
            new ModOption(ctx)
            {
                InternalName = "tvstat_golden",
                Authors = [Author.Ely],
                Enable = (ctx) => ctx.FoggyInabaConfig.Settings.StaticENV = Models.FoggyInabaModConfig.TexTypeA.Stock,
                IsEnabledFunc = (ctx) => ctx.FoggyInabaConfig.Settings.StaticENV == Models.FoggyInabaModConfig.TexTypeA.Stock,
            },
            new ModOption(ctx)
            {
                InternalName = "tvstat_restore",
                Authors = [Author.Fernando],
                Enable = (ctx) => ctx.FoggyInabaConfig.Settings.StaticENV = Models.FoggyInabaModConfig.TexTypeA.P4,
                IsEnabledFunc = (ctx) => ctx.FoggyInabaConfig.Settings.StaticENV == Models.FoggyInabaModConfig.TexTypeA.P4,
            }
        ];
    }
}
