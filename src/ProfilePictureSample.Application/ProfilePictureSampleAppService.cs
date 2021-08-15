using System;
using System.Collections.Generic;
using System.Text;
using ProfilePictureSample.Localization;
using Volo.Abp.Application.Services;

namespace ProfilePictureSample
{
    /* Inherit your application services from this class.
     */
    public abstract class ProfilePictureSampleAppService : ApplicationService
    {
        protected ProfilePictureSampleAppService()
        {
            LocalizationResource = typeof(ProfilePictureSampleResource);
        }
    }
}
