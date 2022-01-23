namespace TestsUI.Pages.Login
{
    public partial class LoginPage
    {
        string UserNameField => "input[data-test='username']";

        string PasswordField => "input[data-test='password']";

        string LoginButton => "input[data-test='login-button']";
    }
}