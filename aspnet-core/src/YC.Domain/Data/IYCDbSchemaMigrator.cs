using System.Threading.Tasks;

namespace YC.Data
{
    public interface IYCDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
