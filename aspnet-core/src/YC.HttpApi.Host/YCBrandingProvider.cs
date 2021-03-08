using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace YC
{
    [Dependency(ReplaceServices = true)]
    public class YCBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "YC";
    }
}
