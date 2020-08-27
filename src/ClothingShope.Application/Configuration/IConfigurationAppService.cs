using System.Threading.Tasks;
using ClothingShope.Configuration.Dto;

namespace ClothingShope.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
