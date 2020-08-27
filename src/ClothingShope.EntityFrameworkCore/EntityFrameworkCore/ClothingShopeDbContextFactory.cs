using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ClothingShope.Configuration;
using ClothingShope.Web;

namespace ClothingShope.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ClothingShopeDbContextFactory : IDesignTimeDbContextFactory<ClothingShopeDbContext>
    {
        public ClothingShopeDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ClothingShopeDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ClothingShopeDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ClothingShopeConsts.ConnectionStringName));

            return new ClothingShopeDbContext(builder.Options);
        }
    }
}
