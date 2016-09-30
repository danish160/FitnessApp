using System.Threading.Tasks;
using Abp.Application.Services;
using FitnessApp.Roles.Dto;

namespace FitnessApp.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
