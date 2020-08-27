using Abp.Application.Services;
using ClothingShope.MultiTenancy.Dto;

namespace ClothingShope.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

