using Abp.Application.Services;
using MyCollege.MultiTenancy.Dto;

namespace MyCollege.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

