using System.Threading.Tasks;
using MyCollege.Configuration.Dto;

namespace MyCollege.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
