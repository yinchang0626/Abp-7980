using Volo.Abp.Settings;

namespace YC.Settings
{
    public class YCSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(YCSettings.MySetting1));
        }
    }
}
