using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ProfilePictureSample.Data
{
    /* This is used if database provider does't define
     * IProfilePictureSampleDbSchemaMigrator implementation.
     */
    public class NullProfilePictureSampleDbSchemaMigrator : IProfilePictureSampleDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}