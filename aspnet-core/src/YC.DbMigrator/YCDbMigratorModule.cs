using YC.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace YC.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(YCEntityFrameworkCoreDbMigrationsModule),
        typeof(YCApplicationContractsModule)
        )]
    public class YCDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
