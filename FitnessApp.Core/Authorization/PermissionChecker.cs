using Abp.Authorization;
using FitnessApp.Authorization.Roles;
using FitnessApp.MultiTenancy;
using FitnessApp.Users;

namespace FitnessApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
