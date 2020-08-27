using System.Threading.Tasks;
using Abp.Application.Services;
using ClothingShope.Sessions.Dto;

namespace ClothingShope.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
