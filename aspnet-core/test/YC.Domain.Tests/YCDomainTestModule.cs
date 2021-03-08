using YC.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace YC
{
    [DependsOn(
        typeof(YCEntityFrameworkCoreTestModule)
        )]
    public class YCDomainTestModule : AbpModule
    {

    }
}