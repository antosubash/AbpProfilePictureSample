using Volo.Abp.Settings;

namespace ProfilePictureSample.Settings
{
    public class ProfilePictureSampleSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ProfilePictureSampleSettings.MySetting1));
        }
    }
}
