using System.Threading.Tasks;
using ClothingShope.Models.TokenAuth;
using ClothingShope.Web.Controllers;
using Shouldly;
using Xunit;

namespace ClothingShope.Web.Tests.Controllers
{
    public class HomeController_Tests: ClothingShopeWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}