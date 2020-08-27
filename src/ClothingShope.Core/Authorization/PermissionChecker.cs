using Abp.Authorization;
using ClothingShope.Authorization.Roles;
using ClothingShope.Authorization.Users;

namespace ClothingShope.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
