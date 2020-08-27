using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ClothingShope.EntityFrameworkCore
{
    public static class ClothingShopeDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ClothingShopeDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ClothingShopeDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
