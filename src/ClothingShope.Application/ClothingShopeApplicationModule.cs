using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ClothingShope.Authorization;

namespace ClothingShope
{
    [DependsOn(
        typeof(ClothingShopeCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ClothingShopeApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ClothingShopeAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ClothingShopeApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
