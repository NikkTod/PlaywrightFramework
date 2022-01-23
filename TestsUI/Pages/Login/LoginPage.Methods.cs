using PlaywrightFramework.Base;
using System.Threading.Tasks;

namespace TestsUI.Pages.Login
{
    public partial class LoginPage : PlaywrightDriver
    {
        public override string PagePath => string.Empty;

        public async Task FillUserName(string userName) => await Page.FillAsync(UserNameField, userName);

        public async Task FillPassword(string password) => await Page.FillAsync(PasswordField, password);

        public async Task ClickLoginButton() => await Page.ClickAsync(LoginButton);

        public async Task LoginSuccessfully(string userName, string password)
        {
            await FillUserName(userName);
            await FillPassword(password);
            await ClickLoginButton();
        }
    }
}
