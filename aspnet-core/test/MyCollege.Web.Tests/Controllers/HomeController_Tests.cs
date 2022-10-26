using System.Threading.Tasks;
using MyCollege.Models.TokenAuth;
using MyCollege.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyCollege.Web.Tests.Controllers
{
    public class HomeController_Tests: MyCollegeWebTestBase
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