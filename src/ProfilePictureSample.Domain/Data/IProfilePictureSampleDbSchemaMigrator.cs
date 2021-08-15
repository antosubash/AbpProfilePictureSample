using System.Threading.Tasks;

namespace ProfilePictureSample.Data
{
    public interface IProfilePictureSampleDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
