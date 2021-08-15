using ProfilePictureSample.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ProfilePictureSample.Permissions
{
    public class ProfilePictureSamplePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ProfilePictureSamplePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ProfilePictureSamplePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ProfilePictureSampleResource>(name);
        }
    }
}
