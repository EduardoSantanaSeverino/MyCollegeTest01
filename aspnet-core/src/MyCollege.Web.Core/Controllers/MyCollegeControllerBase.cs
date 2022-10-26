using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyCollege.Controllers
{
    public abstract class MyCollegeControllerBase: AbpController
    {
        protected MyCollegeControllerBase()
        {
            LocalizationSourceName = MyCollegeConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
