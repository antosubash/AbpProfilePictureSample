using ProfilePictureSample.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ProfilePictureSample
{
    [DependsOn(
        typeof(ProfilePictureSampleEntityFrameworkCoreTestModule)
        )]
    public class ProfilePictureSampleDomainTestModule : AbpModule
    {

    }
}