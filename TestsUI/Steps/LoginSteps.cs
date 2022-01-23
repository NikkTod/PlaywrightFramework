using PlaywrightFramework.Base;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestsUI.Pages.Login;

namespace TestsUI.Steps
{
    [Binding]

    class LoginSteps : PlaywrightDriver
    {
        LoginPage loginPage = new();

        [Given(@"I navigate to application")]
        public async Task GivenINavigateToApplication()
        {
            await loginPage.OpenURL();
        }

        [Given(@"I enter (.*) and (.*)")]
        public async Task GivenIEnterAnd(string userName, string password)
        {
            await loginPage.FillUserName(userName);
            await loginPage.FillPassword(password);
        }

        [Given(@"I click login")]
        public async Task GivenIClickLogin()
        {
            await loginPage.ClickLoginButton();
        }

        [Then(@"I should see user logged in to the application")]
        public async Task ThenIShouldSeeUserLoggedInToTheApplication()
        {
            await Page.ScreenshotAsync(new() { Path = "screenshot.png" });
        }

    }
}
