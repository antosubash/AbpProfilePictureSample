using ProfilePictureSample.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ProfilePictureSample.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ProfilePictureSamplePageModel : AbpPageModel
    {
        protected ProfilePictureSamplePageModel()
        {
            LocalizationResourceType = typeof(ProfilePictureSampleResource);
        }
    }
}