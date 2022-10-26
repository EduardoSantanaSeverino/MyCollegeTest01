using Abp.Authorization;
using MyCollege.Authorization.Roles;
using MyCollege.Authorization.Users;

namespace MyCollege.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
