using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FitnessApp.MultiTenancy.Dto;

namespace FitnessApp.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
