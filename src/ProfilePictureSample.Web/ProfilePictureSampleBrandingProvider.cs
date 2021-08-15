using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ProfilePictureSample.Web
{
    [Dependency(ReplaceServices = true)]
    public class ProfilePictureSampleBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ProfilePictureSample";
    }
}
