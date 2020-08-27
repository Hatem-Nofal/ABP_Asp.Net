using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ClothingShope.EntityFrameworkCore;
using ClothingShope.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ClothingShope.Web.Tests
{
    [DependsOn(
        typeof(ClothingShopeWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ClothingShopeWebTestModule : AbpModule
    {
        public ClothingShopeWebTestModule(ClothingShopeEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ClothingShopeWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ClothingShopeWebMvcModule).Assembly);
        }
    }
}