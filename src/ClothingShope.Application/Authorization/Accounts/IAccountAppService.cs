using System.Threading.Tasks;
using Abp.Application.Services;
using ClothingShope.Authorization.Accounts.Dto;

namespace ClothingShope.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
