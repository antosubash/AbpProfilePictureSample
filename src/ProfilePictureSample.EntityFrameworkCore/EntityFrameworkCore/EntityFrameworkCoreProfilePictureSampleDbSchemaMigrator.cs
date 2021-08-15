using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProfilePictureSample.Data;
using Volo.Abp.DependencyInjection;

namespace ProfilePictureSample.EntityFrameworkCore
{
    public class EntityFrameworkCoreProfilePictureSampleDbSchemaMigrator
        : IProfilePictureSampleDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreProfilePictureSampleDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ProfilePictureSampleDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ProfilePictureSampleDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
