using System.Threading.Tasks;
using Abp.Application.Services;
using MyCollege.Authorization.Accounts.Dto;

namespace MyCollege.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
