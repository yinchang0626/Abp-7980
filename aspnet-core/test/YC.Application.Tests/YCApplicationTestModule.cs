using Volo.Abp.Modularity;

namespace YC
{
    [DependsOn(
        typeof(YCApplicationModule),
        typeof(YCDomainTestModule)
        )]
    public class YCApplicationTestModule : AbpModule
    {

    }
}