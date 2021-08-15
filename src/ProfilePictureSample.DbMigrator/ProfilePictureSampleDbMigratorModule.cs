using ProfilePictureSample.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ProfilePictureSample.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ProfilePictureSampleEntityFrameworkCoreModule),
        typeof(ProfilePictureSampleApplicationContractsModule)
        )]
    public class ProfilePictureSampleDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
