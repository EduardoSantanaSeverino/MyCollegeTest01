using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyCollege.Configuration.Dto;

namespace MyCollege.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyCollegeAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
