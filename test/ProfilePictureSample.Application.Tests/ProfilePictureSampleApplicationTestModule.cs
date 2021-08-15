using Volo.Abp.Modularity;

namespace ProfilePictureSample
{
    [DependsOn(
        typeof(ProfilePictureSampleApplicationModule),
        typeof(ProfilePictureSampleDomainTestModule)
        )]
    public class ProfilePictureSampleApplicationTestModule : AbpModule
    {

    }
}