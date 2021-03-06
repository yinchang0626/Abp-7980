using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace YC.EntityFrameworkCore
{
    [DependsOn(
        typeof(YCEntityFrameworkCoreModule)
        )]
    public class YCEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<YCMigrationsDbContext>();
        }
    }
}
