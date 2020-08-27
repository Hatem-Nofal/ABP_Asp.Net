using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ClothingShope.Configuration;

namespace ClothingShope.Web.Host.Startup
{
    [DependsOn(
       typeof(ClothingShopeWebCoreModule))]
    public class ClothingShopeWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ClothingShopeWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ClothingShopeWebHostModule).GetAssembly());
        }
    }
}
