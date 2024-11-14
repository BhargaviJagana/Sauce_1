// This partial class contains actions for the LoginPage
public partial class LoginPage {
    public void EnterUsername(string username) {
        _driver.FindElement(UsernameField).SendKeys(username);
    }

    public void EnterPassword(string password) {
        _driver.FindElement(PasswordField).SendKeys(password);
    }

    public void ClickLoginButton() {
        _driver.FindElement(LoginButton).Click();
    }
}