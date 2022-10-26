using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCollege.EntityFrameworkCore;
using MyCollege.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MyCollege.Web.Tests
{
    [DependsOn(
        typeof(MyCollegeWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MyCollegeWebTestModule : AbpModule
    {
        public MyCollegeWebTestModule(MyCollegeEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyCollegeWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyCollegeWebMvcModule).Assembly);
        }
    }
}