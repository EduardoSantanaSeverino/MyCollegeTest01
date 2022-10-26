using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCollege.Authorization;

namespace MyCollege
{
    [DependsOn(
        typeof(MyCollegeCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyCollegeApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyCollegeAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyCollegeApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
