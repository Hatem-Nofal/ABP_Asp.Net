using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ClothingShope.Controllers
{
    public abstract class ClothingShopeControllerBase: AbpController
    {
        protected ClothingShopeControllerBase()
        {
            LocalizationSourceName = ClothingShopeConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
