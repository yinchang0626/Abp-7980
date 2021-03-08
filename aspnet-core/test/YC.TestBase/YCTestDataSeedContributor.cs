using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace YC
{
    public class YCTestDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        public Task SeedAsync(DataSeedContext context)
        {
            /* Seed additional test data... */

            return Task.CompletedTask;
        }
    }
}