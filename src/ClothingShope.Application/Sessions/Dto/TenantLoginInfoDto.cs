using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ClothingShope.MultiTenancy;

namespace ClothingShope.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
