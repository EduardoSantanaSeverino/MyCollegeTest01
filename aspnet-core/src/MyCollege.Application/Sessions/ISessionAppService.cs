using System.Threading.Tasks;
using Abp.Application.Services;
using MyCollege.Sessions.Dto;

namespace MyCollege.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
