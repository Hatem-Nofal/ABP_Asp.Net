using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ClothingShope.Authorization.Roles;
using ClothingShope.Authorization.Users;
using ClothingShope.MultiTenancy;
using ClothingShope.Items;
using ClothingShope.ItemsCategories;

namespace ClothingShope.EntityFrameworkCore
{
    public class ClothingShopeDbContext : AbpZeroDbContext<Tenant, Role, User, ClothingShopeDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public ClothingShopeDbContext(DbContextOptions<ClothingShopeDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<itemCategory> ItemsCategories { get; set; }

        public virtual DbSet<Item> Items { get; set; }

    }
}
