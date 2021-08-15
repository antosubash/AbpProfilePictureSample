using ProfilePictureSample.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProfilePictureSample.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ProfilePictureSampleController : AbpController
    {
        protected ProfilePictureSampleController()
        {
            LocalizationResource = typeof(ProfilePictureSampleResource);
        }
    }
}